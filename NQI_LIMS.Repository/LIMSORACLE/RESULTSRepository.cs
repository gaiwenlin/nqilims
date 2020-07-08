using NQI_LIMS.IRepository;
//using NQI_LIMS.IRepository.LIMSORACLE;
using NQI_LIMS.IRepository.UnitOfWork;
using NQI_LIMS.Model.Models;
//using NQI_LIMS.Model.Models.LIMSORACLE;
using NQI_LIMS.Repository.Base;

namespace NQI_LIMS.Repository
{
	/// <summary>
	/// RESULTSRepository
	/// </summary>
    public class RESULTSRepository : BaseRepository<RESULTS>, IRESULTSRepository
    {
        public RESULTSRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}