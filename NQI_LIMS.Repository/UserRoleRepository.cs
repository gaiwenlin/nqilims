using NQI_LIMS.FrameWork.IRepository;
using NQI_LIMS.Repository.Base;
using NQI_LIMS.Model.Models;
using NQI_LIMS.IRepository.UnitOfWork;

namespace NQI_LIMS.Repository
{
    /// <summary>
    /// UserRoleRepository
    /// </summary>	
    public class UserRoleRepository : BaseRepository<UserRole>, IUserRoleRepository
    {
        public UserRoleRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
