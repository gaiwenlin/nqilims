using NQI_LIMS.IRepository;
using NQI_LIMS.IRepository.UnitOfWork;
using NQI_LIMS.Model;
using NQI_LIMS.Repository.Base;

namespace NQI_LIMS.Repository.localhost
{
	/// <summary>
	/// PM_PLANRepository
	/// </summary>
    public class PM_PLANRepository : BaseRepository<PM_PLAN>, IPM_PLANRepository
    {
        public PM_PLANRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}