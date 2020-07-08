using NQI_LIMS.IRepository;
//using NQI_LIMS.IRepository.LIMSORACLE;
using NQI_LIMS.IRepository.UnitOfWork;
using NQI_LIMS.Model.Models;
//using NQI_LIMS.Model.Models.LIMSORACLE;
using NQI_LIMS.Repository.Base;

namespace NQI_LIMS.Repository
{
	/// <summary>
	/// ADD_SUPERVISEPLANRepository
	/// </summary>
    public class ADD_SUPERVISEPLANRepository : BaseRepository<ADD_SUPERVISEPLAN>, IADD_SUPERVISEPLANRepository
    {
        public ADD_SUPERVISEPLANRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}