using NQI_LIMS.Common.LogHelper;
using NQI_LIMS.IRepository;
using NQI_LIMS.IRepository.UnitOfWork;
using NQI_LIMS.Model;
using NQI_LIMS.Repository.Base;

namespace NQI_LIMS.Repository.localhost
{
	/// <summary>
	/// PM_PRODUCE_UNITRepository
	/// </summary>
    public class PM_PRODUCE_UNITRepository : BaseRepository<PM_PRODUCE_UNIT>, IPM_PRODUCE_UNITRepository
    {
        public PM_PRODUCE_UNITRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        /// <summary>
        /// 根据生产单位编码ID 获得生产企业信息
        /// </summary>
        /// <param name="iProCode">生产单位编码</param>
        /// <returns></returns>
        public PM_PRODUCE_UNIT GetPmProduceUnitByCode(string iProCode)
        {
            try
            {
               return this.Db.Queryable<PM_PRODUCE_UNIT>().Where(t => t.PRO_CODE == iProCode).First();
            }
            catch (System.Exception ex)
            {
                SerilogServer.WriteErrorLog("getPmProduceUnitByCode", ex.Message, ex);
                throw ex;
            }
        }
    }
}