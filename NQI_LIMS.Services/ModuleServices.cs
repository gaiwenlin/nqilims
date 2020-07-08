using NQI_LIMS.Services.BASE;
using NQI_LIMS.Model.Models;
using NQI_LIMS.IRepository;
using NQI_LIMS.IServices;

namespace NQI_LIMS.Services
{	
	/// <summary>
	/// ModuleServices
	/// </summary>	
	public class ModuleServices : BaseServices<Modules>, IModuleServices
    {
	
        IModuleRepository _dal;
        public ModuleServices(IModuleRepository dal)
        {
            this._dal = dal;
            base.BaseDal = dal;
        }
       
    }
}
