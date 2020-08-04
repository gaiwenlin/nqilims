using NQI_LIMS.IRepository.Base;
//using NQI_LIMS.Model.Models.localhost;
using NQI_LIMS.Model.Models;
namespace NQI_LIMS.IRepository
{
	/// <summary>
	/// IPM_CARYRepository
	/// </summary>	
    public interface IPM_CARYRepository : IBaseRepository<PM_CARY>
    {
        /// <summary>
        /// �����ܼ쵥λ��� ��� �ܼ쵥λ��Ϣ
        /// </summary>
        /// <param name="caryCode">�ܼ쵥λ��Ϣ</param>
        PM_CARY GetPmCaryByCode(string iCaryCode);
    }
}