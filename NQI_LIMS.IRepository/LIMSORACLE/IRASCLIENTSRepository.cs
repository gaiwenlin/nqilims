using NQI_LIMS.IRepository.Base;
//using NQI_LIMS.Model.Models.LIMSORACLE;
using NQI_LIMS.Model.Models;
namespace NQI_LIMS.IRepository
{
	/// <summary>
	/// IRASCLIENTSRepository
	/// </summary>	
    public interface IRASCLIENTSRepository : IBaseRepository<RASCLIENTS>
    {
        /// <summary>
        /// 根据客户名查找客户
        /// </summary>
        /// <param name="clientName"></param>
        /// <returns></returns>
        RASCLIENTS GetRaseClientsByName(string clientName);

        /// <summary>
        /// 获得最大的
        /// </summary>
        /// <returns></returns>
        string GetMaxClientCode();

    }
}