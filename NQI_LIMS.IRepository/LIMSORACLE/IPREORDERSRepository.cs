using NQI_LIMS.IRepository.Base;
//using NQI_LIMS.Model.Models.LIMSORACLE;
using NQI_LIMS.Model.Models;
namespace NQI_LIMS.IRepository
{
	/// <summary>
	/// IPREORDERSRepository
	/// </summary>	
    public interface IPREORDERSRepository : IBaseRepository<PREORDERS>
    {
        int SavePreOrders(PREORDERS model);

        PREORDERS GetPreOrdersByNo(string iPreOrdNo);
        PREORDERS GetMaxPreOrders();
    }
}