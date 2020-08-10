using NQI_LIMS.IRepository.Base;
//using NQI_LIMS.Model.Models.LIMSORACLE;
using NQI_LIMS.Model.Models;
namespace NQI_LIMS.IRepository
{
	/// <summary>
	/// IRASCLIENTSRepository
	/// </summary>	
    public interface IRASCLIENTSRepository : IBaseRepository<RASCLIENTS>
    {
        /// <summary>
        /// ���ݿͻ������ҿͻ�
        /// </summary>
        /// <param name="clientName"></param>
        /// <returns></returns>
        RASCLIENTS GetRaseClientsByName(string clientName);

        /// <summary>
        /// �������
        /// </summary>
        /// <returns></returns>
        string GetMaxClientCode();

    }
}