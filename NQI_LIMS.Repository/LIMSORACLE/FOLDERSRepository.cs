using NQI_LIMS.IRepository;
//using NQI_LIMS.IRepository.LIMSORACLE;
using NQI_LIMS.IRepository.UnitOfWork;
using NQI_LIMS.Model.Models;
//using NQI_LIMS.Model.Models.LIMSORACLE;
using NQI_LIMS.Repository.Base;

namespace NQI_LIMS.Repository
{
	/// <summary>
	/// FOLDERSRepository
	/// </summary>
    public class FOLDERSRepository : BaseRepository<FOLDERS>, IFOLDERSRepository
    {
        public FOLDERSRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}