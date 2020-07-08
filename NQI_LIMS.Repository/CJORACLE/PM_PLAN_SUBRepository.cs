using NQI_LIMS.IRepository;
using NQI_LIMS.IRepository.UnitOfWork;
using NQI_LIMS.Model;
using NQI_LIMS.Repository.Base;

namespace NQI_LIMS.Repository.localhost
{
	/// <summary>
	/// PM_PLAN_SUBRepository
	/// </summary>
    public class PM_PLAN_SUBRepository : BaseRepository<PM_PLAN_SUB>, IPM_PLAN_SUBRepository
    {
        public PM_PLAN_SUBRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}