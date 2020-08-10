using Newtonsoft.Json.Linq;
using NQI_LIMS.IServices.BASE;
//using NQI_LIMS.Model.Models.LIMSORACLE;
using NQI_LIMS.Model.Models ;
namespace NQI_LIMS.IServices
{	
	/// <summary>
	/// IRASCLIENTSServices
	/// </summary>	
    public interface IRASCLIENTSServices :IBaseServices<RASCLIENTS>
	{
		/// <summary>
		/// ���ݿͻ���Ų�ѯ
		/// </summary>
		/// <param name="clientName"></param>
		/// <returns></returns>
		JObject GetRaseClientsByName(string clientName);


	}
}