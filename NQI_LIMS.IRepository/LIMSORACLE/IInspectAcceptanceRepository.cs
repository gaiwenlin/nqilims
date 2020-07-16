using NQI_LIMS.IRepository.Base;
using NQI_LIMS.Model.Models;

namespace NQI_LIMS.IRepository
{
    public interface IInspectAcceptanceRepository : IBaseRepository<FOLDERS>
    {
        string SaveFolders(FOLDERS model);
    }
}
