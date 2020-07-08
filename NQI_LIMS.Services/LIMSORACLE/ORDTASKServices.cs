using NQI_LIMS.IRepository;
using NQI_LIMS.IServices;
using NQI_LIMS.Model.Models;
//using NQI_LIMS.IRepository.LIMSORACLE;
//using NQI_LIMS.IServices.LIMSORACLE;
//using NQI_LIMS.Model.Models.LIMSORACLE;
using NQI_LIMS.Services.BASE;

namespace NQI_LIMS.Services
{
    public partial class ORDTASKServices : BaseServices<ORDTASK>, IORDTASKServices
    {
        private readonly IORDTASKRepository _dal;
        public ORDTASKServices(IORDTASKRepository dal)
        {
            this._dal = dal;
            base.BaseDal = dal;
        }
    }
}