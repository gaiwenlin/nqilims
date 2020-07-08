using NQI_LIMS.IRepository;
//using NQI_LIMS.IRepository.localhost;
using NQI_LIMS.IRepository.UnitOfWork;
using NQI_LIMS.Model.Models;
//using NQI_LIMS.Model.Models.localhost;
using NQI_LIMS.Repository.Base;

namespace NQI_LIMS.Repository
{
	/// <summary>
	/// PM_CARYRepository
	/// </summary>
    public class PM_CARYRepository : BaseRepository<PM_CARY>, IPM_CARYRepository
    {
        public PM_CARYRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}