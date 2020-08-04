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
    public partial class PM_PLANServices : BaseServices<PM_PLAN>, IPM_PLANServices
    {
        private readonly IPM_PLANRepository _dal;
        public PM_PLANServices(IPM_PLANRepository dal)
        {
            this._dal = dal;
            base.BaseDal = dal;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="iCodeNum"></param>
        /// <returns></returns>
        public JObject GetPmPlanByCode(string iPalnCodeNum)
        {
            try
            {
                #region �������
                iPalnCodeNum.NotAllowNullOrEmpty("������");
                int StringLength = iPalnCodeNum.Length;
                (iPalnCodeNum.Length <= 4).ThrowException("�����Ÿ�ʽ����ȷ");
              
                #endregion

                var mPmPlanInfo = _dal.GetPmPlanByCode(iPalnCodeNum);
                if (mPmPlanInfo != null)
                {
                    return JObject.Parse(JsonConvert.SerializeObject(mPmPlanInfo));//ȫ������
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                SerilogServer.WriteErrorLog("GetPmPlanByCode", ex.Message, ex);
                throw ex;
            }
        }
    }
}