using NQI_LIMS.IRepository.Base;
using NQI_LIMS.Model;

namespace NQI_LIMS.IRepository
{
	/// <summary>
	/// IPM_PLANRepository
	/// </summary>	
    public interface IPM_PLANRepository : IBaseRepository<PM_PLAN>
    {
        PM_PLAN GetPmPlanByCode(string iPalnCode);
    }
}