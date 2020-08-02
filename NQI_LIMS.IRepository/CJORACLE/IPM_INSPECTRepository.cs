using NQI_LIMS.IRepository.Base;
using NQI_LIMS.Model;
using NQI_LIMS.Model.Models;
using System.Threading.Tasks;

namespace NQI_LIMS.IRepository
{
    /// <summary>
    /// 监督抽查业务
    /// </summary>
    public interface IPM_INSPECTRepository : IBaseRepository<PM_PLAN_SUB>
    {       
        PM_PLAN_SUB GetPmPlanSubByCode(string iCode, string iNum);

        PM_PLAN GetPmPlanByCode(string iPlanCode);

        PM_CARY GetPmCaryById(int iCaryId);

        PM_PRODUCE_UNIT GetPmProduceUnitById(int iProId);

        PM_EXEC_UINT GetPmExecUintById(int iExecId);

        PM_EC_PLATFORM GetPmEcPlatFormById(int iEcId);

        /// <summary>
        /// 查找LIMS的任务
        /// </summary>
        /// <param name="iPlanCode">计划编号</param>
        /// <returns></returns>
        ADD_SUPERVISEPLAN GetSupervisePlanByCode(string code);

        /// <summary>
        /// 获得部门
        /// </summary>
        /// <param name="dept"></param>
        /// <returns></returns>
        DEPARTMENTS GetDepartmentsByCode(string dept);

        /// <summary>
        /// 获得中心
        /// </summary>
        /// <param name="Divisioncode"></param>
        /// <returns></returns>
        DIVISIONS GetDivisionsByCode(string Divisioncode);
    }
}
