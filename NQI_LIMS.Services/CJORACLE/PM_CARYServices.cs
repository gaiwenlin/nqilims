using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NQI_LIMS.Common;
using NQI_LIMS.Common.LogHelper;
using NQI_LIMS.IRepository;
using NQI_LIMS.IServices;
using NQI_LIMS.Model.Models;
//using NQI_LIMS.IRepository.localhost;
//using NQI_LIMS.IServices.localhost;
//using NQI_LIMS.Model.Models.localhost;
using NQI_LIMS.Services.BASE;
using System;

namespace NQI_LIMS.Services
{
    public partial class PM_CARYServices : BaseServices<PM_CARY>, IPM_CARYServices
    {
        private readonly IPM_CARYRepository _dal;
        public PM_CARYServices(IPM_CARYRepository dal)
        {
            this._dal = dal;
            base.BaseDal = dal;
        }

        public JObject GetPmCaryByCode(string iCaryCode)
        {
            try
            {
                #region 参数检测
                iCaryCode.NotAllowNullOrEmpty("受检单位编码");
                #endregion

                var PmCaryInfo = _dal.GetPmCaryByCode(iCaryCode);
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
                SerilogServer.WriteErrorLog("GetPmCaryByCode", ex.Message, ex);
                throw ex;
            }
        }
    }
}