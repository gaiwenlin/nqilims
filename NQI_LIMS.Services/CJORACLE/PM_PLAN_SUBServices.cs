using NQI_LIMS.IRepository;
using NQI_LIMS.IServices;
using NQI_LIMS.Model;
using NQI_LIMS.Services.BASE;

namespace NQI_LIMS.Services.localhost
{
    public partial class PM_PLAN_SUBServices : BaseServices<PM_PLAN_SUB>, IPM_PLAN_SUBServices
    {
        private readonly IPM_PLAN_SUBRepository _dal;
        public PM_PLAN_SUBServices(IPM_PLAN_SUBRepository dal)
        {
            this._dal = dal;
            base.BaseDal = dal;
        }
    }
}