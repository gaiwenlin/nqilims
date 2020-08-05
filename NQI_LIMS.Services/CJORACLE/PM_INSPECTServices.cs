using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NQI_LIMS.Common;
using NQI_LIMS.Common.LogHelper;
using NQI_LIMS.IRepository;
using NQI_LIMS.IServices;
using NQI_LIMS.Model;
using NQI_LIMS.Model.Models;
using NQI_LIMS.Services.BASE;
using System;
using System.Threading.Tasks;

namespace NQI_LIMS.Services.localhost
{
    public partial class PM_INSPECTServices : BaseServices<PM_PLAN_SUB>, IPM_INSPECTServices
    {
        private readonly IPM_INSPECTRepository _dal;
        private readonly ISysUserInfoServices _SysUserInfoServices;
        private readonly IADD_SUPERVISEPLANRepository _AddSuperviserPlanDal;
        private readonly IDEPARTMENTSRepository _DepartmentsDal;
        private readonly IDIVISIONSRepository _DivisionsDal;
        public PM_INSPECTServices(IPM_INSPECTRepository dal, 
            ISysUserInfoServices sysUserInfoServices, 
            IADD_SUPERVISEPLANRepository addSuperviserPlanDal, 
            IDEPARTMENTSRepository departmentsDal, 
            IDIVISIONSRepository divisionsDal)
        {
            this._dal = dal;
            this._SysUserInfoServices = sysUserInfoServices;
            base.BaseDal = dal;
            this._AddSuperviserPlanDal = addSuperviserPlanDal;
            this._DepartmentsDal = departmentsDal;
            this._DivisionsDal = divisionsDal;
        }
        public JObject GetPmInsPectByCode(int iUserId, string iCodeNum)
        {
            try
            {
                #region 参数检测
                iCodeNum.NotAllowNullOrEmpty("抽查批次号");
                int StringLength = iCodeNum.Length;
                (iCodeNum.Length <= 4).ThrowException("抽查批次号格式不正确");
                string mCode = iCodeNum.Substring(0, StringLength - 4).ToUpper();
                string mNum = iCodeNum.Substring(StringLength - 4);
                #endregion

                #region 获取主表信息
                var mPmPlanSubInfo = _dal.GetPmPlanSubByCode(mCode, mNum);
                mPmPlanSubInfo.NotAllowNull("未查询到抽查任务单信息");
                #endregion

                #region 获得任务信息 ****查询NQI_LIMS********
                ADD_SUPERVISEPLAN mAddSupervisePlan = null;
                mAddSupervisePlan = _AddSuperviserPlanDal.GetSupervisePlanByCode(mCode);
                #endregion

                #region 获取用户部门信息****查询NQI_LIMS********

                var mUserInfo = _SysUserInfoServices.QueryById(iUserId).Result;//用户信息
                /*
                 20200801 没有组织架构，后期要增加，
                临时在adress字段 里面配置用户的部门信息
                格式： DEPT部门编号RY01
                 */

                DIVISIONS mDivisions = null;
                DEPARTMENTS mDepartments = null;

                mDepartments = _DepartmentsDal.GetDepartmentsByCode(mUserInfo.addr);
                mDivisions = _DivisionsDal.GetDivisionsByCode(mDepartments.PARENTDIV);
                #endregion

                #region 任务表
                PM_PLAN mPmPlanInfo = null;
                if (!string.IsNullOrEmpty(mPmPlanSubInfo.PLAN_CODE))
                {
                    mPmPlanInfo = _dal.GetPmPlanByCode(mPmPlanSubInfo.PLAN_CODE);
                }
                #endregion

                #region 受检单位信息
                PM_CARY mPmCaryInfo = null;
                if (mPmPlanSubInfo.CARY_ID > 0)
                {
                    mPmCaryInfo = _dal.GetPmCaryById(mPmPlanSubInfo.CARY_ID);
                }

                #endregion

                #region 生产企业信息
                PM_PRODUCE_UNIT mPmProduceUnit = null;
                if (mPmPlanSubInfo.PRO_ID > 0)
                {
                    mPmProduceUnit = _dal.GetPmProduceUnitById(mPmPlanSubInfo.PRO_ID);
                }
                #endregion

                #region 抽样单位信息
                PM_EXEC_UINT mPmExecUintInfo = null;
                if (mPmPlanSubInfo.EXEC_ID > 0)
                {
                    mPmExecUintInfo = _dal.GetPmExecUintById(mPmPlanSubInfo.EXEC_ID);
                }
                #endregion

                #region 网店信息
                PM_EC_PLATFORM mPmEcPlatFormInfo = null;
                if (mPmPlanSubInfo.EC_ID > 0)
                {
                    mPmEcPlatFormInfo = _dal.GetPmEcPlatFormById(mPmPlanSubInfo.EC_ID);
                }
                #endregion

                #region 组装数据
                return new JObject() {
                    {"ID",mPmPlanSubInfo.ID},
                    {"PLAN_CODE",mPmPlanSubInfo.PLAN_CODE},
                    {"LOT_NUM",mPmPlanSubInfo.LOT_NUM},
                  
                    //任务信息
                    {"SupervisePlanInfo",JObject.Parse(JsonConvert.SerializeObject(mAddSupervisePlan))},
                    //部门信息
                    {"Department", JObject.Parse(JsonConvert.SerializeObject(mDepartments))},
                    //中心信息
                    {"Division",JObject.Parse(JsonConvert.SerializeObject(mDivisions)) },

                    //抽检数据库的相关表格：
                    {"PmPlanSubInfo", JObject.Parse(JsonConvert.SerializeObject(mPmPlanSubInfo))},
                    {"PmPlanInfo",mPmPlanInfo!=null?JObject.Parse(JsonConvert.SerializeObject(mPmPlanInfo)):new JObject()},
                    {"PmCaryInfo", mPmCaryInfo!=null?JObject.Parse(JsonConvert.SerializeObject(mPmCaryInfo)):new JObject()},
                    {"PmProduceUnit",mPmProduceUnit!=null? JObject.Parse(JsonConvert.SerializeObject(mPmProduceUnit)):new JObject()},
                    {"PmExecUintInfo",mPmExecUintInfo!=null? JObject.Parse(JsonConvert.SerializeObject(mPmExecUintInfo)):new JObject()},
                    {"PmEcPlatFormInfo",mPmEcPlatFormInfo!=null? JObject.Parse(JsonConvert.SerializeObject(mPmEcPlatFormInfo)):new JObject()},
                };
                #endregion

            }
            catch (Exception ex)
            {
                SerilogServer.WriteErrorLog("GetPmInsPectByCode", ex.Message, ex);
                throw ex;
            }
        }
    }
}
