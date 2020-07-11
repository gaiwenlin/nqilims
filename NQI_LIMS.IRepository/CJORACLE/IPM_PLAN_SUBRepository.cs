using NQI_LIMS.IRepository.Base;
using NQI_LIMS.Model;
using System.Threading.Tasks;

namespace NQI_LIMS.IRepository
{
	/// <summary>
	/// IPM_PLAN_SUBRepository
	/// </summary>	
    public interface IPM_PLAN_SUBRepository : IBaseRepository<PM_PLAN_SUB>
    {
       PM_PLAN_SUB GetPmPlanSubByCode(string iCode,string iNum);

    }
}