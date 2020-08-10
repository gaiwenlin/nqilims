using NQI_LIMS.Common.LogHelper;
using NQI_LIMS.IRepository;
//using NQI_LIMS.IRepository.LIMSORACLE;
using NQI_LIMS.IRepository.UnitOfWork;
using NQI_LIMS.Model.Models;
//using NQI_LIMS.Model.Models.LIMSORACLE;
using NQI_LIMS.Repository.Base;

namespace NQI_LIMS.Repository
{
	/// <summary>
	/// DEPARTMENTSRepository
	/// </summary>
    public class DEPARTMENTSRepository : BaseRepository<DEPARTMENTS>, IDEPARTMENTSRepository
    {
        public DEPARTMENTSRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
          
        }

        /// <summary>
        /// 20200803 By Gavin
        /// 获得部门表
        /// </summary>
        /// <param name="dept"></param>
        /// <returns></returns>
        public DEPARTMENTS GetDepartmentsByCode(string dept)
        {
            try
            {
                return this.Db.Queryable<DEPARTMENTS>().Where(t => t.DEPT == dept).First();
            }
            catch (System.Exception ex)
            {
                SerilogServer.WriteErrorLog("GetSupervisePlanByCode", ex.Message, ex);
                throw ex;
            }
        }
    }
}