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
	/// ORDERSRepository
	/// </summary>
    public class ORDERSRepository : BaseRepository<ORDERS>, IORDERSRepository
    {
        public ORDERSRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public ORDERS GetOrdersByNo(string iOrdNo)
        {
            try
            {
                return this.Db.Queryable<ORDERS>().Where(t => t.ORDNO == iOrdNo).First();
            }
            catch (Exception ex)
            {
                SerilogServer.WriteErrorLog("GetOrdersByNo", ex.Message, ex);
                throw ex;
            }
        }

        public int SaveOrders(ORDERS model)
        {
            try
            {
                var insert = this.Db.Insertable(model);
                int mResult = insert.ExecuteReturnIdentity();
                return mResult;
            }
            catch (Exception ex)
            {
                SerilogServer.WriteErrorLog("SaveOrders", ex.Message, ex);
                throw ex;
            }
        }
    }
}