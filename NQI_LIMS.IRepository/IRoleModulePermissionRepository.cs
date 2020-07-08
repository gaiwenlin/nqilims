using NQI_LIMS.IRepository.Base;
using NQI_LIMS.Model.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NQI_LIMS.IRepository
{
    /// <summary>
    /// IRoleModulePermissionRepository
    /// </summary>	
    public interface IRoleModulePermissionRepository : IBaseRepository<RoleModulePermission>//类名
    {
        Task<List<TestMuchTableResult>> QueryMuchTable();
        Task<List<RoleModulePermission>> RoleModuleMaps();
        Task<List<RoleModulePermission>> GetRMPMaps();
    }
}
