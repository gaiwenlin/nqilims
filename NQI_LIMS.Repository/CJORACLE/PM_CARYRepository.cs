using NQI_LIMS.Common.LogHelper;
using NQI_LIMS.IRepository;
//using NQI_LIMS.IRepository.localhost;
using NQI_LIMS.IRepository.UnitOfWork;
using NQI_LIMS.Model.Models;
//using NQI_LIMS.Model.Models.localhost;
using NQI_LIMS.Repository.Base;

namespace NQI_LIMS.Repository
{
	/// <summary>
	/// PM_CARYRepository
	/// </summary>
    public class PM_CARYRepository : BaseRepository<PM_CARY>, IPM_CARYRepository
    {
        public PM_CARYRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        /// <summary>
        /// �����ܼ쵥λ��� ��� �ܼ쵥λ��Ϣ
        /// </summary>
        /// <param name="caryCode">�ܼ쵥λ��Ϣ</param>
        public PM_CARY GetPmCaryByCode(string  iCaryCode)
        {
            try
            {
                return this.Db.Queryable<PM_CARY>().Where(t => t.CARY_CODE == iCaryCode).First();
            }
            catch (System.Exception ex)
            {
                SerilogServer.WriteErrorLog("GetPmCaryByCode", ex.Message, ex);
                throw ex;
            }
        }
    }
}