using NQI_LIMS.Common.LogHelper;
using NQI_LIMS.IRepository;
using NQI_LIMS.IRepository.UnitOfWork;
using NQI_LIMS.Model;
using NQI_LIMS.Repository.Base;

namespace NQI_LIMS.Repository.localhost
{
	/// <summary>
	/// PM_EXEC_UINTRepository
	/// </summary>
    public class PM_EXEC_UINTRepository : BaseRepository<PM_EXEC_UINT>, IPM_EXEC_UINTRepository
    {
        public PM_EXEC_UINTRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        /// <summary>
        /// ���� ������λ���� ��� ������λ��Ϣ
        /// </summary>
        /// <param name="iExecCode">������λ����</param>
        /// <returns></returns>
        public PM_EXEC_UINT GetPmExecUnitByCode(string iExecCode)
        {
            try
            {
                return this.Db.Queryable<PM_EXEC_UINT>().Where(t => t.EXEC_CODE == iExecCode).First();
            }
            catch (System.Exception ex)
            {
                SerilogServer.WriteErrorLog("getPmExecUnitByCode", ex.Message, ex);   
                throw ex;
            }
        }
    }//class
}//namespace