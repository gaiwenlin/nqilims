using NQI_LIMS.IRepository;
using NQI_LIMS.IServices;
using NQI_LIMS.Model;
using NQI_LIMS.Services.BASE;

namespace NQI_LIMS.Services.localhost
{
    public partial class PM_EC_PLATFORMServices : BaseServices<PM_EC_PLATFORM>, IPM_EC_PLATFORMServices
    {
        private readonly IPM_EC_PLATFORMRepository _dal;
        public PM_EC_PLATFORMServices(IPM_EC_PLATFORMRepository dal)
        {
            this._dal = dal;
            base.BaseDal = dal;
        }
    }
}