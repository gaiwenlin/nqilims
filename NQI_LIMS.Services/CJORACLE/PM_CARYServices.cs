using NQI_LIMS.IRepository;
using NQI_LIMS.IServices;
using NQI_LIMS.Model.Models;
//using NQI_LIMS.IRepository.localhost;
//using NQI_LIMS.IServices.localhost;
//using NQI_LIMS.Model.Models.localhost;
using NQI_LIMS.Services.BASE;

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
    }
}