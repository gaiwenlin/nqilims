using NQI_LIMS.Repository.Base;
using NQI_LIMS.Model.Models;
using NQI_LIMS.IRepository;
using NQI_LIMS.IRepository.UnitOfWork;

namespace NQI_LIMS.Repository
{
    /// <summary>
    /// ModuleRepository
    /// </summary>	
    public class ModuleRepository : BaseRepository<Modules>, IModuleRepository
    {
        public ModuleRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
