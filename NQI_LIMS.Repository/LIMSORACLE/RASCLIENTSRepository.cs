using NQI_LIMS.Common.LogHelper;
using NQI_LIMS.IRepository;
//using NQI_LIMS.IRepository.LIMSORACLE;
using NQI_LIMS.IRepository.UnitOfWork;
using NQI_LIMS.Model.Models;
//using NQI_LIMS.Model.Models.LIMSORACLE;
using NQI_LIMS.Repository.Base;
using SqlSugar;

namespace NQI_LIMS.Repository
{
	/// <summary>
	/// RASCLIENTSRepository
	/// </summary>
    public class RASCLIENTSRepository : BaseRepository<RASCLIENTS>, IRASCLIENTSRepository
    {
        public RASCLIENTSRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        /// <summary>
        /// 获得最大值
        /// </summary>
        /// <returns></returns>
        public string GetMaxClientCode()
        {
            try
            {
                return this.Db.Queryable<RASCLIENTS>().Max(t => (SqlFunc.Substring(t.RASCLIENTID, 2, t.RASCLIENTID.Length - 2)));
            }
            catch (System.Exception ex)
            {
                SerilogServer.WriteErrorLog("GetMaxClientCode", ex.Message, ex);
                throw ex;
            }
        }

        /// <summary>
        /// 根据客户名查找客户
        /// </summary>
        /// <param name="clientName"></param>
        /// <returns></returns>
        public RASCLIENTS GetRaseClientsByName(string clientName)
        {
            try
            {
                return this.Db.Queryable<RASCLIENTS>().Where(t => t.COMPANYNAME == clientName).First();
            }
            catch (System.Exception ex)
            {
                SerilogServer.WriteErrorLog("GetRaseClientsByName", ex.Message, ex);
                throw ex;
            }
        }
    }
}