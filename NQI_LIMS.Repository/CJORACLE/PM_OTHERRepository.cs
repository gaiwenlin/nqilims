using NQI_LIMS.IRepository;
using NQI_LIMS.IRepository.UnitOfWork;
using NQI_LIMS.Model;
using NQI_LIMS.Repository.Base;

namespace NQI_LIMS.Repository.localhost
{
	/// <summary>
	/// PM_OTHERRepository
	/// </summary>
    public class PM_OTHERRepository : BaseRepository<PM_OTHER>, IPM_OTHERRepository
    {
        public PM_OTHERRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}