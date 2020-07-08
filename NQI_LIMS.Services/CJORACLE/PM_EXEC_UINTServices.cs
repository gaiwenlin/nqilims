using NQI_LIMS.IRepository;
using NQI_LIMS.IServices;
using NQI_LIMS.Model;
using NQI_LIMS.Services.BASE;

namespace NQI_LIMS.Services.localhost
{
    public partial class PM_EXEC_UINTServices : BaseServices<PM_EXEC_UINT>, IPM_EXEC_UINTServices
    {
        private readonly IPM_EXEC_UINTRepository _dal;
        public PM_EXEC_UINTServices(IPM_EXEC_UINTRepository dal)
        {
            this._dal = dal;
            base.BaseDal = dal;
        }
    }
}