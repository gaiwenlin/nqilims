using NQI_LIMS.IRepository.Base;
using NQI_LIMS.Model;

namespace NQI_LIMS.IRepository
{
	/// <summary>
	/// IPM_PRODUCE_UNITRepository
	/// </summary>	
    public interface IPM_PRODUCE_UNITRepository : IBaseRepository<PM_PRODUCE_UNIT>
    {
        /// <summary>
        /// 根据生产单位编码ID 获得生产企业信息
        /// </summary>
        /// <param name="iProCode">生产单位编码</param>
        /// <returns></returns>
        PM_PRODUCE_UNIT GetPmProduceUnitByCode(string iProCode);
    }
}