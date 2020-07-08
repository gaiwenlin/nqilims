using NQI_LIMS.IRepository;
//using NQI_LIMS.IRepository.LIMSORACLE;
using NQI_LIMS.IRepository.UnitOfWork;
using NQI_LIMS.Model.Models;
//using NQI_LIMS.Model.Models.LIMSORACLE;
using NQI_LIMS.Repository.Base;

namespace NQI_LIMS.Repository
{
	/// <summary>
	/// RASCLIENTSRepository
	/// </summary>
    public class RASCLIENTSRepository : BaseRepository<RASCLIENTS>, IRASCLIENTSRepository
    {
        public RASCLIENTSRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}