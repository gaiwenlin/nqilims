using NQI_LIMS.Common.LogHelper;
using NQI_LIMS.IRepository;
//using NQI_LIMS.IRepository.LIMSORACLE;
using NQI_LIMS.IRepository.UnitOfWork;
using NQI_LIMS.Model.Models;
//using NQI_LIMS.Model.Models.LIMSORACLE;
using NQI_LIMS.Repository.Base;
using System;
using System.Threading.Tasks;

namespace NQI_LIMS.Repository
{
	/// <summary>
	/// FOLDERSRepository
	/// </summary>
    public class FOLDERSRepository : BaseRepository<FOLDERS>, IFOLDERSRepository
    {
        public FOLDERSRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public FOLDERS GeyFolderByNo(string iFolderNo)
        {
            try
            {
                return this.Db.Queryable<FOLDERS>().Where(t => t.FOLDERNO == iFolderNo).First();
            }
            catch (Exception ex)
            {
                SerilogServer.WriteErrorLog("GeyFolderByNo", ex.Message, ex);
                throw ex;
            }
        }

        public int SaveFolders(FOLDERS model)
        {
            try
            {
                var insert = this.Db.Insertable(model);
                int mResult = insert.ExecuteReturnIdentity();
                return mResult;
            }
            catch (Exception ex)
            {
                SerilogServer.WriteErrorLog("SaveFolders", ex.Message, ex);
                throw ex;
            }
        }
    }
}