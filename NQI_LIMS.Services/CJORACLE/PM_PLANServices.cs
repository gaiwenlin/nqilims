using NQI_LIMS.IRepository;
using NQI_LIMS.IServices;
using NQI_LIMS.Model;
using NQI_LIMS.Services.BASE;

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
    }
}