    

using NQI_LIMS.IServices.BASE;
using NQI_LIMS.Model.Models;
using System.Threading.Tasks;

namespace NQI_LIMS.IServices
{	
	/// <summary>
	/// sysUserInfoServices
	/// </summary>	
    public interface ISysUserInfoServices :IBaseServices<sysUserInfo>
	{
        Task<sysUserInfo> SaveUserInfo(string loginName, string loginPwd);
        Task<string> GetUserRoleNameStr(string loginName, string loginPwd);
    }
}
