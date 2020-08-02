using NQI_LIMS.Common.LogHelper;
using NQI_LIMS.IRepository;
using NQI_LIMS.IRepository.UnitOfWork;
using NQI_LIMS.Model;
using NQI_LIMS.Repository.Base;
using System;

namespace NQI_LIMS.Repository.localhost
{
    /// <summary>
    /// PM_PLANRepository 任务表
    /// </summary>
    public class PM_PLANRepository : BaseRepository<PM_PLAN>, IPM_PLANRepository
    {
        public PM_PLANRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {

        }

        /// <summary>
        /// 根据任务编号获得任务实体
        /// </summary>
        /// <param name="iCode">任务编号</param>
        /// <returns></returns>
        public PM_PLAN GetPmPlanByCode(string iPalnCode)
        {
            try
            {
                return this.Db.Queryable<PM_PLAN>().Where(t => t.PLAN_CODE == iPalnCode).First();
            }
            catch (Exception ex)
            {
                SerilogServer.WriteErrorLog("GetPmPlanByCode", ex.Message, ex);
                throw ex;
            }
        }
    }
}