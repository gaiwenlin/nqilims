using NQI_LIMS.IRepository.Base;
//using NQI_LIMS.Model.Models.LIMSORACLE;
using NQI_LIMS.Model.Models;
namespace NQI_LIMS.IRepository
{
	/// <summary>
	/// IADD_SUPERVISEPLANRepository
	/// </summary>	
    public interface IADD_SUPERVISEPLANRepository : IBaseRepository<ADD_SUPERVISEPLAN>
    {
        /// <summary>
        /// 查找LIMS的任务
        /// </summary>
        /// <param name="iPlanCode">计划编号</param>
        /// <returns></returns>
        ADD_SUPERVISEPLAN GetSupervisePlanByCode(string code);


    }
}