using NQI_LIMS.IRepository.Base;
//using NQI_LIMS.Model.Models.localhost;
using NQI_LIMS.Model.Models;
namespace NQI_LIMS.IRepository
{
	/// <summary>
	/// IPM_CARYRepository
	/// </summary>	
    public interface IPM_CARYRepository : IBaseRepository<PM_CARY>
    {
        /// <summary>
        /// 根据受检单位编号 获得 受检单位信息
        /// </summary>
        /// <param name="caryCode">受检单位信息</param>
        PM_CARY GetPmCaryByCode(string iCaryCode);
    }
}