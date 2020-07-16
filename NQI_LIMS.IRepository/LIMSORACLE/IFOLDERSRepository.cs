using NQI_LIMS.IRepository.Base;
//using NQI_LIMS.Model.Models.LIMSORACLE;
using NQI_LIMS.Model.Models;
namespace NQI_LIMS.IRepository
{
	/// <summary>
	/// IFOLDERSRepository
	/// </summary>	
    public interface IFOLDERSRepository : IBaseRepository<FOLDERS>
    {
        int SaveFolders(FOLDERS model);

        FOLDERS GeyFolderByNo(string iFolderNo);
    }
}