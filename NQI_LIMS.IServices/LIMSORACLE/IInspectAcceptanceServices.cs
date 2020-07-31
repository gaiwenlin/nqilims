using NQI_LIMS.IServices.BASE;
using NQI_LIMS.Model.Models;
using NQI_LIMS.Model.ViewModels;

namespace NQI_LIMS.IServices
{
    public interface IInspectAcceptanceServices
    {
        bool SaveInspectAcceptance(int iUserId,InputInsepectAcceptanceModel model);
    }
}
