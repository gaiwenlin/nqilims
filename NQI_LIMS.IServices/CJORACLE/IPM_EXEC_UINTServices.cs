using Newtonsoft.Json.Linq;
using NQI_LIMS.IServices.BASE;
using NQI_LIMS.Model;

namespace NQI_LIMS.IServices
{	
	/// <summary>
	/// IPM_EXEC_UINTServices
	/// </summary>	
    public interface IPM_EXEC_UINTServices :IBaseServices<PM_EXEC_UINT>
	{
		JObject GetPmExecUnitByCode(string iExecCode);

	}
}