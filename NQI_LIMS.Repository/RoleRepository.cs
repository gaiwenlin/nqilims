using NQI_LIMS.IRepository;
using NQI_LIMS.Repository.Base;
using NQI_LIMS.Model.Models;
using NQI_LIMS.IRepository.UnitOfWork;

namespace NQI_LIMS.Repository
{
    /// <summary>
    /// RoleRepository
    /// </summary>	
    public class RoleRepository : BaseRepository<Role>, IRoleRepository
    {
        public RoleRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
