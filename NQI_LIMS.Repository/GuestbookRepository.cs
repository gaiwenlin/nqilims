using NQI_LIMS.IRepository;
using NQI_LIMS.IRepository.UnitOfWork;
using NQI_LIMS.Model.Models;
using NQI_LIMS.Repository.Base;

namespace NQI_LIMS.Repository
{
    public class GuestbookRepository : BaseRepository<Guestbook>, IGuestbookRepository
    {
        public GuestbookRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }



    }
}
