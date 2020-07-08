using NQI_LIMS.IServices.BASE;
using NQI_LIMS.Model.Models;
using System.Threading.Tasks;

namespace NQI_LIMS.IServices
{	
	/// <summary>
	/// UserRoleServices
	/// </summary>	
    public interface IUserRoleServices :IBaseServices<UserRole>
	{

        Task<UserRole> SaveUserRole(int uid, int rid);
        Task<int> GetRoleIdByUid(int uid);
    }
}

