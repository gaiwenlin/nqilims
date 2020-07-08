using NQI_LIMS.IRepository;
using NQI_LIMS.IRepository.UnitOfWork;
using NQI_LIMS.Model;
using NQI_LIMS.Repository.Base;

namespace NQI_LIMS.Repository.localhost
{
	/// <summary>
	/// PM_PRODUCE_UNITRepository
	/// </summary>
    public class PM_PRODUCE_UNITRepository : BaseRepository<PM_PRODUCE_UNIT>, IPM_PRODUCE_UNITRepository
    {
        public PM_PRODUCE_UNITRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}