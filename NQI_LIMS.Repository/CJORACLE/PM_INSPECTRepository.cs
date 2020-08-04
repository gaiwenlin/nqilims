using NQI_LIMS.Common.LogHelper;
using NQI_LIMS.IRepository;
using NQI_LIMS.IRepository.UnitOfWork;
using NQI_LIMS.Model;
using NQI_LIMS.Model.Models;
using NQI_LIMS.Repository.Base;
using System;
using System.Threading.Tasks;

namespace NQI_LIMS.Repository.localhost
{
   public class PM_INSPECTRepository : BaseRepository<PM_PLAN_SUB>, IPM_INSPECTRepository
    {
        public PM_INSPECTRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {

        }

        public PM_CARY GetPmCaryById(int iCaryId)
        {
            try
            {
                return this.Db.Queryable<PM_CARY>().Where(t => t.ID == iCaryId).First();
            }
            catch (Exception ex)
            {
                SerilogServer.WriteErrorLog("GetPmCary", ex.Message, ex);
                throw ex;
            }
        }

        public PM_EC_PLATFORM GetPmEcPlatFormById(int iEcId)
        {
            try
            {
                return this.Db.Queryable<PM_EC_PLATFORM>().Where(t => t.EC_ID == iEcId).First();
            }
            catch (Exception ex)
            {
                SerilogServer.WriteErrorLog("GetPmEcPlatForm", ex.Message, ex);
                throw ex;
            }
        }

        public PM_EXEC_UINT GetPmExecUintById(int iExecId)
        {
            try
            {
                return this.Db.Queryable<PM_EXEC_UINT>().Where(t => t.ID == iExecId).First();
            }
            catch (Exception ex)
            {
                SerilogServer.WriteErrorLog("GetPmCary", ex.Message, ex);
                throw ex;
            }
        }

        public PM_PLAN GetPmPlanByCode(string iPlanCode)
        {
            try
            {
                return this.Db.Queryable<PM_PLAN>().Where(t => t.PLAN_CODE == iPlanCode).First();
            }
            catch (Exception ex)
            {
                SerilogServer.WriteErrorLog("GetPmPlanByCode", ex.Message, ex);
                throw ex;
            }
        }

        public PM_PLAN_SUB GetPmPlanSubByCode(string iCode, string iNum)
        {
            try
            {
                return this.Db.Queryable<PM_PLAN_SUB>().Where(t => t.PLAN_CODE == iCode && t.LOT_NUM == iNum).First();
            }
            catch (Exception ex)
            {
                SerilogServer.WriteErrorLog("GetPmPlanSubByCode", ex.Message, ex);
                throw ex;
            }
        }

        public PM_PRODUCE_UNIT GetPmProduceUnitById(int iProId)
        {
            try
            {
                return this.Db.Queryable<PM_PRODUCE_UNIT>().Where(t => t.ID == iProId).First();
            }
            catch (Exception ex)
            {
                SerilogServer.WriteErrorLog("GetPmProduceUnit", ex.Message, ex);
                throw ex;
            }
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
                return this.Db.Queryable<ADD_SUPERVISEPLAN>().Where(t => t.PLANNO.Contains(iPlanCode)).First();
            }
            catch (Exception ex)
            {
                SerilogServer.WriteErrorLog("GetSupervisePlanByCode", ex.Message, ex);
                throw ex;
            }
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
                return this.Db.Queryable<DEPARTMENTS>().Where(t => t.DEPT== dept).First();
            }
            catch (Exception ex)
            {
                SerilogServer.WriteErrorLog("GetSupervisePlanByCode", ex.Message, ex);
                throw ex;
            }
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
                return this.Db.Queryable<DIVISIONS>().Where(t => t.DIVISIONCODE== Divisioncode).First();
            }
            catch (Exception ex)
            {
                SerilogServer.WriteErrorLog("GetSupervisePlanByCode", ex.Message, ex);
                throw ex;
            }
        }

    }
}
