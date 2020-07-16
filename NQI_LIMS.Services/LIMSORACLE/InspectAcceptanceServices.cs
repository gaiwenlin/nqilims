using NQI_LIMS.Common.LogHelper;
using NQI_LIMS.IRepository;
using NQI_LIMS.IRepository.UnitOfWork;
using NQI_LIMS.IServices;
using NQI_LIMS.Model.Models;
using NQI_LIMS.Model.ViewModels;
using NQI_LIMS.Services.BASE;
using System;

namespace NQI_LIMS.Services
{
   public class InspectAcceptanceServices : BaseServices<FOLDERS>, IInspectAcceptanceServices
    {
        private readonly IORDERSRepository _OrderDal;
        private readonly IFOLDERSRepository _FoldersDal;
        private readonly IPREORDERSRepository _PreOrdersDal;
        private readonly IUnitOfWork _UnitOfWork;
        public InspectAcceptanceServices(IORDERSRepository orderDal, IFOLDERSRepository foldersDal, IPREORDERSRepository preOrdersDal,IUnitOfWork unitOfWork)
        {
            this._OrderDal = orderDal;
            this._FoldersDal = foldersDal;
            this._PreOrdersDal = preOrdersDal;
            this._UnitOfWork = unitOfWork;
            base.BaseDal = foldersDal;
        }

        public bool SaveInspectAcceptance(InputInsepectAcceptanceModel model)
        {
            try
            {

                #region 参数检测
                #endregion

                _UnitOfWork.BeginTran();
                #region 受理单
                FOLDERS folders = new FOLDERS();
                folders.FOLDERNO = this.CreateFolderNo();//生成规则  
                //是否判断是否已经存在
                _FoldersDal.SaveFolders(folders);
                #endregion

                #region 样品单
                PREORDERS preoders = new PREORDERS();
                preoders.PREORDNO =this.CreatPreOrderNo();
                preoders.FOLDERNO = folders.FOLDERNO;
                _PreOrdersDal.SavePreOrders(preoders);
                #endregion

                #region 子样单
                ORDERS orders = new ORDERS();
                orders.ORDNO = this.CreatOrderNo();
                orders.FOLDERNO = folders.FOLDERNO;
                orders.PREORDNO = preoders.PREORDNO;
                _OrderDal.SaveOrders(orders);
                #endregion
                _UnitOfWork.CommitTran();
                return true;
            }
            catch (Exception ex)
            {
                _UnitOfWork.RollbackTran();
                SerilogServer.WriteErrorLog("SaveInspectAcceptance", ex.Message, ex);
                throw ex;
            }
        }

        public string CreateFolderNo()
        {
            string mFolderNo = string.Empty;
            mFolderNo = "20" + "";//不明白规则
            var IsExist = _FoldersDal.GeyFolderByNo(mFolderNo)!=null?true:false;
            if (IsExist)
            {
                CreateFolderNo();
            }
            return mFolderNo;
        }

        public string CreatPreOrderNo()
        {
            string mPreOrderNo = string.Empty;
            mPreOrderNo = "20" + "";//不明白规则
            var IsExist = _PreOrdersDal.GetPreOrdersByNo(mPreOrderNo) != null ? true : false;
            if (IsExist)
            {
                CreateFolderNo();
            }
            return mPreOrderNo;

        }

        public string CreatOrderNo()
        {
            string mOrderNo = string.Empty;
            mOrderNo = "20" + "";//不明白规则
            var IsExist = _OrderDal.GetOrdersByNo(mOrderNo) != null ? true : false;
            if (IsExist)
            {
                CreateFolderNo();
            }
            return mOrderNo;
        }
    }
}
