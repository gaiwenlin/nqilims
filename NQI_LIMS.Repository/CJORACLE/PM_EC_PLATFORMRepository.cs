using NQI_LIMS.IRepository;
using NQI_LIMS.IRepository.UnitOfWork;
using NQI_LIMS.Model;
using NQI_LIMS.Repository.Base;

namespace NQI_LIMS.Repository.localhost
{
	/// <summary>
	/// PM_EC_PLATFORMRepository
	/// </summary>
    public class PM_EC_PLATFORMRepository : BaseRepository<PM_EC_PLATFORM>, IPM_EC_PLATFORMRepository
    {
        public PM_EC_PLATFORMRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

    
    }//class
}//namespace