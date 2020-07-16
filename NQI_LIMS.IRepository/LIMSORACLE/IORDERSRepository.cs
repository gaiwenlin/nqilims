using NQI_LIMS.IRepository.Base;
//using NQI_LIMS.Model.Models.LIMSORACLE;
using NQI_LIMS.Model.Models;
namespace NQI_LIMS.IRepository
{
	/// <summary>
	/// IORDERSRepository
	/// </summary>	
    public interface IORDERSRepository : IBaseRepository<ORDERS>
    {
        int SaveOrders(ORDERS model);

        ORDERS GetOrdersByNo(string iOrdNo);
    }
}