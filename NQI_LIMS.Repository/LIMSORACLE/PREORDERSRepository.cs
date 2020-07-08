using NQI_LIMS.IRepository;
//using NQI_LIMS.IRepository.LIMSORACLE;
using NQI_LIMS.IRepository.UnitOfWork;
using NQI_LIMS.Model.Models;
//using NQI_LIMS.Model.Models.LIMSORACLE;
using NQI_LIMS.Repository.Base;

namespace NQI_LIMS.Repository
{
	/// <summary>
	/// PREORDERSRepository
	/// </summary>
    public class PREORDERSRepository : BaseRepository<PREORDERS>, IPREORDERSRepository
    {
        public PREORDERSRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}