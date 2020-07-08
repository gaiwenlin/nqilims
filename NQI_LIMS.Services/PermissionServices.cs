using NQI_LIMS.Services.BASE;
using NQI_LIMS.Model.Models;
using NQI_LIMS.IRepository;
using NQI_LIMS.IServices;

namespace NQI_LIMS.Services
{	
	/// <summary>
	/// PermissionServices
	/// </summary>	
	public class PermissionServices : BaseServices<Permission>, IPermissionServices
    {
	
        IPermissionRepository _dal;
        public PermissionServices(IPermissionRepository dal)
        {
            this._dal = dal;
            base.BaseDal = dal;
        }
       
    }
}
