using NQI_LIMS.IRepository;
using NQI_LIMS.IServices;
using NQI_LIMS.Model;
using NQI_LIMS.Services.BASE;

namespace NQI_LIMS.Services.localhost
{
    public partial class PM_PRODUCE_UNITServices : BaseServices<PM_PRODUCE_UNIT>, IPM_PRODUCE_UNITServices
    {
        private readonly IPM_PRODUCE_UNITRepository _dal;
        public PM_PRODUCE_UNITServices(IPM_PRODUCE_UNITRepository dal)
        {
            this._dal = dal;
            base.BaseDal = dal;
        }
    }
}