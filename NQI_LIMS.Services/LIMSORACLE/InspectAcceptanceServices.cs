using NQI_LIMS.Common;
using NQI_LIMS.Common.LogHelper;
using NQI_LIMS.IRepository;
using NQI_LIMS.IRepository.UnitOfWork;
using NQI_LIMS.IServices;
using NQI_LIMS.Model.Models;
using NQI_LIMS.Model.ViewModels;
using NQI_LIMS.Services.BASE;
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
        public InspectAcceptanceServices(IORDERSRepository orderDal, IFOLDERSRepository foldersDal, IPREORDERSRepository preOrdersDal, IUnitOfWork unitOfWork)
        {
            this._OrderDal = orderDal;
            this._FoldersDal = foldersDal;
            this._PreOrdersDal = preOrdersDal;
            this._UnitOfWork = unitOfWork;
            base.BaseDal = foldersDal;
        }

        public bool SaveInspectAcceptance(InputInsepectAcceptanceModel model)
        {
            try
            {
                #region 获取用户部门信息
                #endregion

                #region 参数检测
                #endregion
                _UnitOfWork.BeginTran();
                #region 受理单
                FOLDERS folders = new FOLDERS();
                folders.FOLDERNO = this.CreateFolderNo();//生成规则 
                var IsFolderExist = _FoldersDal.GeyFolderByNo(folders.FOLDERNO) != null ? true : false;
                if (!IsFolderExist)
                {
                    _FoldersDal.SaveFolders(folders);
                }
                #endregion

                #region 样品单
                PREORDERS preoders = new PREORDERS();
                preoders.PREORDNO = this.CreatPreOrderNo("");//获取部门编号信息
                preoders.FOLDERNO = folders.FOLDERNO;
                var IsPreExist = _PreOrdersDal.GetPreOrdersByNo(preoders.PREORDNO) != null ? true : false;
                if (!IsPreExist)
                {
                    _PreOrdersDal.SavePreOrders(preoders);
                }
                #endregion

                #region 子样单
                ORDERS orders = new ORDERS();
                orders.ORDNO = string.Format("{0}-001", preoders.PREORDNO);
                orders.FOLDERNO = folders.FOLDERNO;
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
    }
}
