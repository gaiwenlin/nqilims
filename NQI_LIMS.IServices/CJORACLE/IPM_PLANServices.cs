using Newtonsoft.Json.Linq;
using NQI_LIMS.IServices.BASE;
using NQI_LIMS.Model;

namespace NQI_LIMS.IServices
{	
	/// <summary>
	/// IPM_PLANServices
	/// </summary>	
    public interface IPM_PLANServices :IBaseServices<PM_PLAN>
	{
		JObject GetPmPlanByCode(string iPalnCodeNum);

	}
}