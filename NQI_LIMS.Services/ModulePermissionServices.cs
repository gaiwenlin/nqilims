using NQI_LIMS.Services.BASE;
using NQI_LIMS.Model.Models;
using NQI_LIMS.IRepository;
using NQI_LIMS.IServices;

namespace NQI_LIMS.Services
{	
	/// <summary>
	/// ModulePermissionServices
	/// </summary>	
	public class ModulePermissionServices : BaseServices<ModulePermission>, IModulePermissionServices
    {
	
        IModulePermissionRepository _dal;
        public ModulePermissionServices(IModulePermissionRepository dal)
        {
            this._dal = dal;
            base.BaseDal = dal;
        }
       
    }
}
