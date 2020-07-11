using NQI_LIMS.Common.LogHelper;
using NQI_LIMS.IRepository;
using NQI_LIMS.IRepository.UnitOfWork;
using NQI_LIMS.Model;
using NQI_LIMS.Repository.Base;
using System;
using System.Threading.Tasks;

namespace NQI_LIMS.Repository.localhost
{
	/// <summary>
	/// PM_PLAN_SUBRepository
	/// </summary>
    public class PM_PLAN_SUBRepository : BaseRepository<PM_PLAN_SUB>, IPM_PLAN_SUBRepository
    {
        public PM_PLAN_SUBRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {

        }
        /// <summary>
        /// 根据参数组合进行查询
        /// </summary>
        /// <param name="iCode"></param>
        /// <param name="iNum"></param>
        /// <returns></returns>
        public PM_PLAN_SUB GetPmPlanSubByCode(string iCode,string iNum)
        {
            try
            {
                return this.Db.Queryable<PM_PLAN_SUB>().Where(t => t.PLAN_CODE == iCode && t.LOT_NUM == iNum).First();
            }
            catch (Exception ex)
            {
                SerilogServer.WriteErrorLog("GetPmPlanSubByCode",ex.Message,ex);
                throw ex;
            }
        }
    }
}