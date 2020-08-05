using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NQI_LIMS.Common;
using NQI_LIMS.Common.LogHelper;
using NQI_LIMS.IRepository;
using NQI_LIMS.IServices;
using NQI_LIMS.Model.Models;
//using NQI_LIMS.IRepository.LIMSORACLE;
//using NQI_LIMS.IServices.LIMSORACLE;
//using NQI_LIMS.Model.Models.LIMSORACLE;
using NQI_LIMS.Services.BASE;

namespace NQI_LIMS.Services
{
    public partial class RASCLIENTSServices : BaseServices<RASCLIENTS>, IRASCLIENTSServices
    {
        private readonly IRASCLIENTSRepository _dal;
        public RASCLIENTSServices(IRASCLIENTSRepository dal)
        {
            this._dal = dal;
            base.BaseDal = dal;
        }

        /// <summary>
        /// 根据客户名称查询
        /// </summary>
        /// <param name="clientName"></param>
        /// <returns></returns>
        public JObject GetRaseClientsByName(string clientName)
        {
            try
            {
                clientName.NotAllowNullOrEmpty("客户名称");

                var client = _dal.GetRaseClientsByName(clientName);
                if(client != null)
                {
                    return JObject.Parse(JsonConvert.SerializeObject(client));
                }
                else
                {
                    return null;
                }

            }
            catch (System.Exception ex)
            {
                SerilogServer.WriteErrorLog("GetRaseClientsByName", ex.Message, ex);
                throw ex;
            }
        }

        //public string GeatRasClientCode()
        //{

        //}
    }
}