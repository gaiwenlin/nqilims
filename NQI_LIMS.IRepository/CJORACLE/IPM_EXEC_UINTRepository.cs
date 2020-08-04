using NQI_LIMS.IRepository.Base;
using NQI_LIMS.Model;

namespace NQI_LIMS.IRepository
{
	/// <summary>
	/// IPM_EXEC_UINTRepository
	/// </summary>	
    public interface IPM_EXEC_UINTRepository : IBaseRepository<PM_EXEC_UINT>
    {

        /// <summary>
        /// 根据 抽样单位编码 获得 抽样单位信息
        /// </summary>
        /// <param name="iExecCode">抽样单位编码</param>
        /// <returns></returns>
        PM_EXEC_UINT GetPmExecUnitByCode(string iExecCode);
    }
}