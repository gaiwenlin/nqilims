using NQI_LIMS.IServices.BASE;
using NQI_LIMS.Model;
using NQI_LIMS.Model.Models;
using System.Threading.Tasks;

namespace NQI_LIMS.IServices
{
    public partial interface IGuestbookServices : IBaseServices<Guestbook>
    {
        Task<MessageModel<string>> TestTranInRepository();
        Task<bool> TestTranInRepositoryAOP();
    }
}
