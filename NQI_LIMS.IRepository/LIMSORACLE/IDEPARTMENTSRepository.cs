using NQI_LIMS.IRepository.Base;
//using NQI_LIMS.Model.Models.LIMSORACLE;
using NQI_LIMS.Model.Models;
namespace NQI_LIMS.IRepository
{
	/// <summary>
	/// IDEPARTMENTSRepository
	/// </summary>	
    public interface IDEPARTMENTSRepository : IBaseRepository<DEPARTMENTS>
    {
        /// <summary>
        /// ��ò���
        /// </summary>
        /// <param name="dept"></param>
        /// <returns></returns>
        DEPARTMENTS GetDepartmentsByCode(string dept);
    }
}