using NQI_LIMS.IRepository;
using NQI_LIMS.IServices;
using NQI_LIMS.Model.Models;
//using NQI_LIMS.IRepository.LIMSORACLE;
//using NQI_LIMS.IServices.LIMSORACLE;
//using NQI_LIMS.Model.Models.LIMSORACLE;
using NQI_LIMS.Services.BASE;

namespace NQI_LIMS.Services
{
    public partial class DIVISIONSServices : BaseServices<DIVISIONS>, IDIVISIONSServices
    {
        private readonly IDIVISIONSRepository _dal;
        public DIVISIONSServices(IDIVISIONSRepository dal)
        {
            this._dal = dal;
            base.BaseDal = dal;
        }
    }
}