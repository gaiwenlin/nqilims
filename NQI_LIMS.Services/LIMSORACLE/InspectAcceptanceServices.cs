using NQI_LIMS.Common;
using NQI_LIMS.Common.HttpContextUser;
using NQI_LIMS.Common.LogHelper;
using NQI_LIMS.IRepository;
using NQI_LIMS.IRepository.UnitOfWork;
using NQI_LIMS.IServices;
using NQI_LIMS.Model.Models;
using NQI_LIMS.Model.ViewModels;
using NQI_LIMS.Services.BASE;
using StackExchange.Redis;
using System;
using System.Linq;

namespace NQI_LIMS.Services
{
    public class InspectAcceptanceServices : BaseServices<FOLDERS>, IInspectAcceptanceServices
    {
        private readonly IORDERSRepository _OrderDal;
        private readonly IFOLDERSRepository _FoldersDal;
        private readonly IPREORDERSRepository _PreOrdersDal;
        private readonly IUnitOfWork _UnitOfWork;
        private readonly ISysUserInfoServices _SysUserInfoServices;
        private readonly IRASCLIENTSRepository _RasClientsDal;
        public InspectAcceptanceServices(
            IORDERSRepository orderDal, 
            IFOLDERSRepository foldersDal, 
            IPREORDERSRepository preOrdersDal,
            IUnitOfWork unitOfWork, 
            ISysUserInfoServices sysUserInfoServices,
            IRASCLIENTSRepository rasClientsDal)
        {
            this._OrderDal = orderDal;
            this._FoldersDal = foldersDal;
            this._PreOrdersDal = preOrdersDal;
            this._UnitOfWork = unitOfWork;
            this._SysUserInfoServices = sysUserInfoServices;
            this._RasClientsDal = rasClientsDal;
            base.BaseDal = foldersDal;
        }

        public bool SaveInspectAcceptance(int iUserId,InputInsepectAcceptanceModel model)
        {
            try
            {
                model.PmPlanSubInfo.NotAllowNull("抽检信息");

                #region 获取用户信息
                var mUserInfo = _SysUserInfoServices.QueryById(iUserId).Result;//用户信息
                 #endregion

             
                _UnitOfWork.BeginTran();

                #region 查询或保存企业
                // CHECK_TYPE : 1:现场抽样(生产) 2:市场买样 3：电商买样 4：其他来源
                //生产单位
                RASCLIENTS mScdwInfor = null;
                if (model.PmPlanSubInfo.CHECK_TYPE == "1")
                {
                    mScdwInfor = this.SaveRaseClient(model.PmProduceUnit.PRO_NAME, model.PmProduceUnit.PRO_ADDR, model.PmProduceUnit.PRO_TEL, mUserInfo.uRealName, model.Department.DEPTNAME, model.PmProduceUnit.PRO_BUS_LICENCE, model.Department.DEPT);
                }
                //受检单位
                RASCLIENTS mSjdwInfor = null;
                if(model.PmPlanSubInfo.CHECK_TYPE == "2")
                {
                    mSjdwInfor = this.SaveRaseClient(model.PmCaryInfo.CARY_NAME, model.PmCaryInfo.CARY_ADDR, model.PmCaryInfo.CARY_TEL, mUserInfo.uRealName, model.Department.DEPTNAME, model.PmCaryInfo.UNIFIED_SOCIAL_CREDIT_CODE, model.Department.DEPT);
                }
                else if (model.PmPlanSubInfo.CHECK_TYPE == "3")
                {
                    //网店信息
                    mSjdwInfor = this.SaveRaseClient(model.PmEcPlatFormInfo.ONLINE_STORE_NAME, model.PmEcPlatFormInfo.ONLINE_STORE_ADDR, model.PmEcPlatFormInfo.ONLINE_STORE_CONTACT, mUserInfo.uRealName, model.Department.DEPTNAME, "", model.Department.DEPT);
                }
                #endregion

                #region 1. 受理单
                FOLDERS folders = new FOLDERS();
                folders.FOLDERNO = this.CreateFolderNo();//生成规则 
                folders.DEPT = model.Department.DEPT;
                folders.REMARKS = model.PmPlanSubInfo.REMARKS;
                folders.ORIGSTS = "N";
                folders.FLDSTS = "Draft";
                folders.DISPSTS = "新建";
                folders.SAMPLECLASSFORCCC = "3C样品种类名称";
                folders.CODEOFINSPECTIONORG = "承检机构代码";
                folders.DETECTIONFORSPOTCHECK = model.SupervisePlanInfo.TASKCLASS;
                folders.TESTORGREGFORM = model.Department.DEPTNAME;
                folders.TESTPLACE = model.Department.LOCATION;
                folders.TESTTYPE = "01";
                folders.PLANNO = model.SupervisePlanInfo.PLANNO;
                folders.TASKSOURCE = model.SupervisePlanInfo.TASKSOURCE;
                folders.TESTTASKNOFORCCC = "委托单位协议编号";
                //生产单位
                folders.COMPANYNOOFPRODUCTIONORG = mScdwInfor == null ? null : mScdwInfor.RASCLIENTID;
                folders.ADDRESSOFPRODUCTIONORG = mScdwInfor == null ? null : mScdwInfor.ADDRESS;
                folders.PHONEOFPRODUCTIONORG = mScdwInfor == null ? null : mScdwInfor.PHONE;
                folders.NAMEOFPRODUCTIONORG = mScdwInfor == null ? null : mScdwInfor.COMPNAME;
                folders.PRODUCTIONOFBUSINESSLICENSE = mScdwInfor == null ? null : mScdwInfor.STAXCODE;
                //受检单位
                folders.ADDRESSOFORGBETESTED = mSjdwInfor == null? null: mSjdwInfor.ADRESS;
                folders.PHONEOFORGBETESTED = mSjdwInfor == null ? null : mSjdwInfor.PHONE;
                folders.NAMEOFORGBETESTED = mSjdwInfor == null ? null : mSjdwInfor.COMPNAME;
                folders.ACCEPTER = mUserInfo.uRealName;
                folders.ACCEPTDATE = DateTime.Now;
                //委托单位
                folders.NAMEOFENTRUSTORG = model.SupervisePlanInfo.TASKSOURCE;
                folders.SAMPLESOURCEREGFORM = "抽样";
                folders.DIVISIONCODE = model.Division.DIVISIONCODE;
                folders.PAYSTS = "N";
                folders.LOGDATE = DateTime.Now;
                folders.ISSUBCONTRACT = "不同意";
                folders.ISSUPPLIER = "N";
                folders.CREATER = mUserInfo.uLoginName;
                folders.EVALUATIONREQ = "评价";

                var IsFolderExist = _FoldersDal.GeyFolderByNo(folders.FOLDERNO) != null ? true : false;
                if (!IsFolderExist)
                {
                    _FoldersDal.SaveFolders(folders);
                }
                else
                {
                    return false;
                }
                #endregion

                #region 2. 样品单
                PREORDERS preoders = new PREORDERS();
                preoders.PREORDNO = this.CreatPreOrderNo("");//获取部门编号信息
                preoders.FOLDERNO = folders.FOLDERNO;
                preoders.STATUS = "Draft";
                preoders.DISPSTS = "新建";
                preoders.REMARKS = model.PmPlanSubInfo.REMARKS;
                preoders.TESTCOSTSFORSAMPLE = 0;
                preoders.TAKEREPORTMETHOD = "自取";
                preoders.RECEIVEDATE = DateTime.Today;
                preoders.STORAGEMETHOD = "常温";
                preoders.TREATMENTFORSAMPLE = "销毁";
                preoders.ARRIVDATEFORSAMPLE = DateTime.Today;
                preoders.SPECMODEL = model.PmPlanSubInfo.GOODS_SCALE;
                preoders.SAMPLENAME = model.PmPlanSubInfo.GOODS_NAME;
                preoders.TOTALQUANTITY = model.PmPlanSubInfo.GOODS_CHECK_NUM;
                preoders.SAMPLESTATE = "封样完好、符合检验要求";
                preoders.REQUIREDCOMPLETIONDATE = DateTime.Today.AddDays(7);
                preoders.DEPT = model.Department.DEPT;
                preoders.DIVISIONCODE = model.Division.DIVISIONCODE;
                preoders.ISRETURNSAMPLE = "N";
                preoders.ISEMERGENCY = "0";
                preoders.PAYSTS = "未缴费";
                preoders.LOGDATE = DateTime.Now;
                preoders.ISMAKESAMPLE = "N";
                preoders.ISADD_G = "N";
                preoders.INVOICEISSUEMETHOD = "自取";
                preoders.TAKESAMPLINGPERSON = mUserInfo.uRealName;
                preoders.STORAGECONDITION = 0;
                preoders.OTHERSAMPLETYPE = 0;
                preoders.OTHERRESTAURANTTACHE = 0;
                preoders.OTHERCIRCULATIONTACHE = 0;
                preoders.STRIPNUMBERANDSUM = 0;
                preoders.SAMPLINGPRODUCTIMPLEMENTATION = "按文件要求";
                preoders.SAMPLEDELIVERYMODE = "抽样";
                preoders.REPORTRECYCLE = "Y";
                preoders.SELFNUMBER = model.PmPlanSubInfo.PLAN_CODE + model.PmPlanSubInfo.LOT_NUM;
                preoders.PRINTNUM = 0;
                preoders.ZHENGSHUNO = model.PmPlanSubInfo.GOODS_CERT_CODE;
                preoders.ISADD_FG = "N";
                preoders.ALLOTTYPE = "CP";
                preoders.PRINTBYNUMS = 0;
                preoders.PRINTJYNUMS = 1;
                preoders.ISNEEDCOVERING = "N";
                preoders.TESTPERIOD = 7;
                preoders.REALPAY2 = 0;

                var IsPreExist = _PreOrdersDal.GetPreOrdersByNo(preoders.PREORDNO) != null ? true : false;
                if (!IsPreExist)
                {
                    _PreOrdersDal.SavePreOrders(preoders);
                }
                #endregion

                #region 3. 子样单
                ORDERS orders = new ORDERS();
                orders.ORDNO = string.Format("{0}-001", preoders.PREORDNO);
                orders.ORIGSTS = "N";
                orders.STATUS = "Draft";
                orders.DISPSTS = "新建";
                orders.CREATETIME = DateTime.Now;
                orders.SAMPLENAME = model.PmPlanSubInfo.GOODS_NAME ;
                orders.DEPT = model.Department.DEPT;
                orders.DIVISIONCODE = model.Division.DIVISIONCODE;
                orders.ISMAKESAMPLE = "N";
                orders.ISPREPARE = "N";
                orders.ISCHOICE = "N";
                orders.FOLDERNO = folders.FOLDERNO;
                orders.MAJORUSRNAM = mUserInfo.uLoginName;
                orders.PREORDNO = preoders.PREORDNO;
                var IsOrderExist = _OrderDal.GetOrdersByNo(orders.ORDNO) != null ? true : false;
                if (!IsOrderExist)
                {
                    _OrderDal.SaveOrders(orders);
                }
                #endregion
              
                _UnitOfWork.CommitTran();
                return true;
            }
            catch (Exception ex)
            {
                _UnitOfWork.RollbackTran();
                SerilogServer.WriteErrorLog("SaveInspectAcceptance", ex.Message, ex);
                throw ex;
            }
        }

        #region 获取 受理单编号
        /// <summary>
        /// 获取 受理单编号
        /// </summary>
        /// <returns></returns>
        public string CreateFolderNo()
        {
            string mFolderNo = string.Empty;

            #region 获取年份
            string mYear = DateTime.Now.Year.ToString();
            string mPrefixYear = mYear.Substring(mYear.Length - 2, 2);
            #endregion

            #region 生成流水号
            var mMaxFoleder = _FoldersDal.GetMaxFolder();
            string mSerialNumString = "00001";
            if (mMaxFoleder != null)
            {
                string mLastNum = mMaxFoleder.FOLDERNO.Substring(2);
                int mSerialNum = 0;
                int.TryParse(mLastNum, out mSerialNum);
                mSerialNum++;
                mSerialNumString = mSerialNum.ToString().PadLeft(5, '0');
            }
            #endregion

            mFolderNo = mPrefixYear + mSerialNumString;
            return mFolderNo;
        }
        #endregion

        #region 获取 样品编号
        /// <summary>
        /// 获取 样品编号
        /// </summary>
        /// <param name="iDepartMentCode"></param>
        /// <returns></returns>
        public string CreatPreOrderNo(string iDepartMentCode)
        {
            iDepartMentCode.NotAllowNullOrEmpty("部门编号不能为空");
            string mPreOrderNo = string.Empty;
            string mPrefix = "NZJ";
            string mPrefixYear = DateTime.Now.Year.ToString();
            #region 生成流水号
            PREORDERS mMaxPreOrders = _PreOrdersDal.GetMaxPreOrders();
            string mSerialNumString = "00001";
            if (mMaxPreOrders != null)
            {
                string[] mPreOrders = mMaxPreOrders.PREORDNO.Split("-");
                string mLastNum = "00000";
                if (mPreOrders.Count() >= 2)
                {
                    mLastNum = mPreOrders[1];
                }
                int mSerialNum = 0;
                int.TryParse(mLastNum, out mSerialNum);
                mSerialNum++;
                mSerialNumString = mSerialNum.ToString().PadLeft(5, '0');
            }
            #endregion
            mPreOrderNo = string.Format("{0}({1}){2}-{3}", mPrefix, mPrefixYear, iDepartMentCode, mSerialNumString);
            return mPreOrderNo;
        }
        #endregion

        #region 保存客户信息
        /// <summary>
        /// 
        /// </summary>
        /// <param name="clientName"></param>
        /// <returns></returns>
        public RASCLIENTS SaveRaseClient(string clientName,string adress, string tell,string createBy,string deptName,string staxCode,string dept)
        {
            var client = _RasClientsDal.GetRaseClientsByName(clientName);
            if (client == null)
            {
                client.RASCLIENTID = _RasClientsDal.GetMaxClientCode();
                client = new RASCLIENTS();
                client.ORIGSTS = "N";
                client.CATEGORY = "非协议客户";
                client.COMPNAME = clientName;
                client.SHORTNAME = "XXXX";
                client.ADRESS = adress;
                client.PHONE = tell;
                client.ADDEDBY = createBy;
                client.ADDDATE = DateTime.Now;
                client.STATUS = "Done";
                client.DEPT = deptName;
                client.STAXCODE = staxCode;
                client.ISPUBLIC = "1";
                client.STARLIMSDEPT = dept;
                client.ISDISCARD = "N";
                client.DISPSTATUS = "完成";
                client.INSTITUTIONNAME = "南京市产品质量监督检验院";
                _RasClientsDal.Add(client);
            }
            
            return client;
        }
        #endregion
    }//class
}//namespace
