using Newtonsoft.Json.Linq;
using NQI_LIMS.IServices.BASE;
using NQI_LIMS.Model;
using System.Threading.Tasks;

namespace NQI_LIMS.IServices
{	
	/// <summary>
	/// IPM_PLAN_SUBServices
	/// </summary>	
    public interface IPM_PLAN_SUBServices :IBaseServices<PM_PLAN_SUB>
	{
		JObject GetPmPlanSubByCode(string iCodeNum);
	}
}