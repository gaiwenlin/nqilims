using NQI_LIMS.IRepository;
using NQI_LIMS.IServices;
using NQI_LIMS.Model;
using NQI_LIMS.Services.BASE;

namespace NQI_LIMS.Services.localhost
{
    public partial class PM_OTHERServices : BaseServices<PM_OTHER>, IPM_OTHERServices
    {
        private readonly IPM_OTHERRepository _dal;
        public PM_OTHERServices(IPM_OTHERRepository dal)
        {
            this._dal = dal;
            base.BaseDal = dal;
        }
    }
}