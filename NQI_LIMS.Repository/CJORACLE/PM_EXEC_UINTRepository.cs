using NQI_LIMS.IRepository;
using NQI_LIMS.IRepository.UnitOfWork;
using NQI_LIMS.Model;
using NQI_LIMS.Repository.Base;

namespace NQI_LIMS.Repository.localhost
{
	/// <summary>
	/// PM_EXEC_UINTRepository
	/// </summary>
    public class PM_EXEC_UINTRepository : BaseRepository<PM_EXEC_UINT>, IPM_EXEC_UINTRepository
    {
        public PM_EXEC_UINTRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}