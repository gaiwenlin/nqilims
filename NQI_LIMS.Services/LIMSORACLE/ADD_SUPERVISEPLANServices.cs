using NQI_LIMS.IRepository;
using NQI_LIMS.IServices;
using NQI_LIMS.Model.Models;
//using NQI_LIMS.IRepository.LIMSORACLE;
//using NQI_LIMS.IServices.LIMSORACLE;
//using NQI_LIMS.Model.Models.LIMSORACLE;
using NQI_LIMS.Services.BASE;

namespace NQI_LIMS.Services
{
    public partial class ADD_SUPERVISEPLANServices : BaseServices<ADD_SUPERVISEPLAN>, IADD_SUPERVISEPLANServices
    {
        private readonly IADD_SUPERVISEPLANRepository _dal;
        public ADD_SUPERVISEPLANServices(IADD_SUPERVISEPLANRepository dal)
        {
            this._dal = dal;
            base.BaseDal = dal;
        }
    }
}