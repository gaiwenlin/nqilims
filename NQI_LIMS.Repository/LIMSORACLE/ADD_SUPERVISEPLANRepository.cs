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
	/// ADD_SUPERVISEPLANRepository
	/// </summary>
    public class ADD_SUPERVISEPLANRepository : BaseRepository<ADD_SUPERVISEPLAN>, IADD_SUPERVISEPLANRepository
    {
        public ADD_SUPERVISEPLANRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        /// <summary>
        /// 20200803 By Gavin
        /// 查找LIMS的任务
        /// </summary>
        /// <param name="iPlanCode">计划编号</param>
        /// <returns></returns>
        public ADD_SUPERVISEPLAN GetSupervisePlanByCode(string iPlanCode)
        {
            try
            {
                return this.Db.Queryable<ADD_SUPERVISEPLAN>().Where(t => t.SAMPLINGBASIS.Contains(iPlanCode)).First();
            }
            catch (System.Exception ex)
            {
                SerilogServer.WriteErrorLog("GetSupervisePlanByCode", ex.Message, ex);
                throw ex;
            }
        }
    }
}