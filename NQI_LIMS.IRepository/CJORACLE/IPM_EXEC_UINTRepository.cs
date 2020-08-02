using NQI_LIMS.IRepository.Base;
using NQI_LIMS.Model;

namespace NQI_LIMS.IRepository
{
	/// <summary>
	/// IPM_EXEC_UINTRepository
	/// </summary>	
    public interface IPM_EXEC_UINTRepository : IBaseRepository<PM_EXEC_UINT>
    {

        /// <summary>
        /// ���� ������λ���� ��� ������λ��Ϣ
        /// </summary>
        /// <param name="iExecCode">������λ����</param>
        /// <returns></returns>
        PM_EXEC_UINT GetPmExecUnitByCode(string iExecCode);
    }
}