using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NQI_LIMS.Common;
using NQI_LIMS.Common.LogHelper;
using NQI_LIMS.IRepository;
using NQI_LIMS.IServices;
using NQI_LIMS.Model;
using NQI_LIMS.Services.BASE;
using System;
using System.Threading.Tasks;

namespace NQI_LIMS.Services.localhost
{
    public partial class PM_PLAN_SUBServices : BaseServices<PM_PLAN_SUB>, IPM_PLAN_SUBServices
    {
        private readonly IPM_PLAN_SUBRepository _dal;
        public PM_PLAN_SUBServices(IPM_PLAN_SUBRepository dal)
        {
            this._dal = dal;
            base.BaseDal = dal;
        }

        public JObject GetPmPlanSubByCode(string iCodeNum)
        {
            try
            {
                #region 参数检测
                iCodeNum.NotAllowNullOrEmpty("抽查批次号");
                int StringLength = iCodeNum.Length;
                (iCodeNum.Length <= 4).ThrowException("抽查批次号格式不正确");
                string mCode = iCodeNum.Substring(0, StringLength-4).ToUpper();
                string mNum = iCodeNum.Substring(StringLength - 4);
                #endregion

                var mPmPlanSubInfo =  _dal.GetPmPlanSubByCode(mCode,mNum);                 
                if (mPmPlanSubInfo != null)
                {
                    var result = new JObject() {
                    {"ID",mPmPlanSubInfo.ID},
                    {"PLAN_CODE",mPmPlanSubInfo.PLAN_CODE},
                    {"LOT_NUM",mPmPlanSubInfo.LOT_NUM}
                     };
                    //return result;//自定义返回
                    return JObject.Parse(JsonConvert.SerializeObject(mPmPlanSubInfo));//全部返回
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                SerilogServer.WriteErrorLog("GetPmPlanSubByCode", ex.Message, ex);
                throw ex;
            }
        }
    }
}