using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NQI_LIMS.Common;
using NQI_LIMS.Common.LogHelper;
using NQI_LIMS.IRepository;
using NQI_LIMS.IServices;
using NQI_LIMS.Model;
using NQI_LIMS.Services.BASE;
using System;

namespace NQI_LIMS.Services.localhost
{
    public partial class PM_EXEC_UINTServices : BaseServices<PM_EXEC_UINT>, IPM_EXEC_UINTServices
    {
        private readonly IPM_EXEC_UINTRepository _dal;
        public PM_EXEC_UINTServices(IPM_EXEC_UINTRepository dal)
        {
            this._dal = dal;
            base.BaseDal = dal;
        }



        public JObject GetPmExecUnitByCode(string iExecCode)
        {
            try
            {
                #region 参数检测
                iExecCode.NotAllowNullOrEmpty("抽样单位编码");
                #endregion

                var PmCaryInfo = _dal.GetPmExecUnitByCode(iExecCode);
                if (PmCaryInfo != null)
                {
                    //return result;//自定义返回
                    return JObject.Parse(JsonConvert.SerializeObject(PmCaryInfo));//全部返回
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                SerilogServer.WriteErrorLog("GetPmExecUnitByCode", ex.Message, ex);
                throw ex;
            }
        }
    }
}