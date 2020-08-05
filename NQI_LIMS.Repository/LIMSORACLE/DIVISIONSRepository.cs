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
	/// DIVISIONSRepository
	/// </summary>
    public class DIVISIONSRepository : BaseRepository<DIVISIONS>, IDIVISIONSRepository
    {
        public DIVISIONSRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        /// <summary>
        /// 20200803 By Gavin
        /// 获得中心
        /// </summary>
        /// <param name="Divisioncode"></param>
        /// <returns></returns>
        public DIVISIONS GetDivisionsByCode(string Divisioncode)
        {
            try
            {
                return this.Db.Queryable<DIVISIONS>().Where(t => t.DIVISIONCODE == Divisioncode).First();
            }
            catch (System.Exception ex)
            {
                SerilogServer.WriteErrorLog("GetSupervisePlanByCode", ex.Message, ex);
                throw ex;
            }
        }
    }
}