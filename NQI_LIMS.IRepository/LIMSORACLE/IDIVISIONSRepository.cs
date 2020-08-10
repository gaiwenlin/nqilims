using NQI_LIMS.IRepository.Base;
//using NQI_LIMS.Model.Models.LIMSORACLE;
using NQI_LIMS.Model.Models;
namespace NQI_LIMS.IRepository
{
	/// <summary>
	/// IDIVISIONSRepository
	/// </summary>	
    public interface IDIVISIONSRepository : IBaseRepository<DIVISIONS>
    {
        /// <summary>
        /// 获得中心
        /// </summary>
        /// <param name="Divisioncode"></param>
        /// <returns></returns>
        DIVISIONS GetDivisionsByCode(string Divisioncode);
    }
}