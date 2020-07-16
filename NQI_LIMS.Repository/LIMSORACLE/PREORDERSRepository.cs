using NQI_LIMS.Common.LogHelper;
using NQI_LIMS.IRepository;
//using NQI_LIMS.IRepository.LIMSORACLE;
using NQI_LIMS.IRepository.UnitOfWork;
using NQI_LIMS.Model.Models;
//using NQI_LIMS.Model.Models.LIMSORACLE;
using NQI_LIMS.Repository.Base;
using System;

namespace NQI_LIMS.Repository
{
	/// <summary>
	/// PREORDERSRepository
	/// </summary>
    public class PREORDERSRepository : BaseRepository<PREORDERS>, IPREORDERSRepository
    {
        public PREORDERSRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public PREORDERS GetPreOrdersByNo(string iPreOrdNo)
        {
            try
            {
                return this.Db.Queryable<PREORDERS>().Where(t => t.PREORDNO == iPreOrdNo).First();
            }
            catch (Exception ex)
            {
                SerilogServer.WriteErrorLog("GetPreOrdersByNo", ex.Message, ex);
                throw ex;
            }
        }

        public int SavePreOrders(PREORDERS model)
        {
            try
            {
                var insert = this.Db.Insertable(model);
                int mResult = insert.ExecuteReturnIdentity();
                return mResult;
            }
            catch (Exception ex)
            {
                SerilogServer.WriteErrorLog("SavePreOrders", ex.Message, ex);
                throw ex;
            }
        }
    }
}