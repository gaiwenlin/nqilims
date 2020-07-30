using System;
using System.Collections.Generic;
using System.Text;

namespace NQI_LIMS.Model.ViewModels
{
   public class InputInsepectAcceptanceModel
    {
        #region 任务信息
        /// <summary>
        /// 委托单位
        /// </summary>
        public string EntrustUnitName { get; set; }
        /// <summary>
        /// 委托单位地址
        /// </summary>
        public string EntrustUnitAddress { get; set; }
        /// <summary>
        /// 任务类别
        /// </summary>
        public string TaskType { get; set; }
        /// <summary>
        /// 计划编号
        /// </summary>
        public string TaskPlanNo { get; set; }
        /// <summary>
        /// 计划文件号
        /// </summary>
        public string TaskPlanFileNo { get; set; }
        /// <summary>
        /// 抽样领域
        /// </summary>
        public string SamplingArea { get; set; }
        #endregion

        #region 主检部门信息
        /// <summary>
        /// 主检部门
        /// </summary>
        public string MainCheckDepartMent { get; set; }
        /// <summary>
        /// 实验室
        /// </summary>
        public string Laboratory { get; set; }
        /// <summary>
        /// 检验单位
        /// </summary>
        public string InspectionUnit { get; set; }
        /// <summary>
        /// 检验地点
        /// </summary>
        public string InspectionAddress { get; set; }
        /// <summary>
        /// 受理单号
        /// </summary>
        public string AcceptanceNo { get; set; }
        /// <summary>
        /// 受理人
        /// </summary>
        public string AcceptanceName { get; set; }
        /// <summary>
        /// 受理时间
        /// </summary>
        public string AcceptanceDateTime { get; set; }
        #endregion

        #region 受检单位信息
        /// <summary>
        /// 受检单位名称
        /// </summary>
        public string ByCheckedUnitName { get; set; }
        /// <summary>
        /// 受检单位地址
        /// </summary>
        public string ByCheckedUnitAddress { get; set; }
        /// <summary>
        /// 受检单位编号
        /// </summary>
        public string ByCheckedUnitNo{ get; set; }
        /// <summary>
        /// 受检单位法人
        /// </summary>
        public string ByCheckedUnitLegal { get; set; }
        /// <summary>
        /// 受检单位联系人
        /// </summary>
        public string ByCheckedUnitContacts { get; set; }
        /// <summary>
        /// 受检单位邮箱
        /// </summary>
        public string ByCheckedUnitEmail { get; set; }
        /// <summary>
        /// 受检单位-区域类别
        /// </summary>
        public string ByCheckedUnitAreaType { get; set; }
        /// <summary>
        /// 受检单位-协议编号
        /// </summary>
        public string ByCheckedUnitAgreementNo { get; set; }
        /// <summary>
        /// 受检单位-营业执照统一代码
        /// </summary>
        public string ByCheckedUnitLicenseNo { get; set; }
        /// <summary>
        /// 受检单位-传真
        /// </summary>
        public string Fax { get; set; }
        /// <summary>
        /// 受检单位-联系方式
        /// </summary>
        public string ByCheckedUnitContactsPhone { get; set; }
        /// <summary>
        /// 所抽产品上年销售
        /// </summary>
        public string ByCheckedProSale { get; set; }
        /// <summary>
        /// 所抽产品上年销售数据
        /// </summary>
        public string ByCheckedProSaleNum { get; set; }
        /// <summary>
        /// 行政(省)
        /// </summary>
        public string ByCheckedUnitArea1 { get; set; }
        /// <summary>
        /// 行政(城市)
        /// </summary>
        public string ByCheckedUnitArea2 { get; set; }
        /// <summary>
        /// 行政(区)
        /// </summary>
        public string ByCheckedUnitArea3 { get; set; }
        #endregion

        #region 生产企业信息
        /// <summary>
        /// 生产单位名称
        /// </summary>
        public string ProductUnitName { get; set; }
        /// <summary>
        /// 生产单位地址
        /// </summary>
        public string ProductUnitAddress { get; set; }
        /// <summary>
        /// 生产单位编号
        /// </summary>
        public string ProductUnitNo { get; set; }
        /// <summary>
        /// 生产单位邮政编号
        /// </summary>
        public string ProductUnitPostCode { get; set; }
        /// <summary>
        /// 生产单位法人
        /// </summary>
        public string ProductUnitLegal { get; set; }
        /// <summary>
        /// 生产单位联系人
        /// </summary>
        public string ProductUnitContacts { get; set; }
        /// <summary>
        /// 生产单位联系人电话
        /// </summary>
        public string ProductUnitContactsPhone { get; set; }
        /// <summary>
        /// 生产单位企业规模
        /// </summary>
        public string ProductUnitEnterScale { get; set; }
        /// <summary>
        /// 生产单位经济规模
        /// </summary>
        public string ProductUnitMoneyScale { get; set; }
        /// <summary>
        /// 生产单位销售额
        /// </summary>
        public string ProductUnitScaleValue { get; set; }
        /// <summary>
        /// 生产单位企业人数
        /// </summary>
        public string ProductUnitPersonNum { get; set; }
        /// <summary>
        /// 生产单位行政(省)
        /// </summary>
        public string ProductUnitArea1 { get; set; }
        /// <summary>
        /// 生产单位行政(城市)
        /// </summary>
        public string ProductUnitArea2 { get; set; }
        /// <summary>
        /// 生产单位行政(区)
        /// </summary>
        public string ProductUnitArea3 { get; set; }
        /// <summary>
        /// 生产单位管理体系(0:未通过1:通过)
        /// </summary>
        public int IsManageMentCert { get; set; }
        /// <summary>
        /// 生产单位管理体系认证编号
        /// </summary>
        public int ManageMentCertNo { get; set; }
        /// <summary>
        /// 生产单位营业执照编号
        /// </summary>
        public int ProductUnitLicenseNo { get; set; }
        #endregion

        #region 抽样单位信息
        /// <summary>
        /// 抽样单位名称
        /// </summary>
        public string SamplingUnitName { get; set; }
        /// <summary>
        /// 抽样单位地址/邮箱
        /// </summary>
        public string SamplingUnitAddOrEmail { get; set; }
        /// <summary>
        /// 抽样单位联系人
        /// </summary>
        public string SamplingUnitContacts { get; set; }
        /// <summary>
        /// 抽样单位联系人电话
        /// </summary>
        public string SamplingUnitContactsPhone { get; set; }
        /// <summary>
        /// 抽样单位备注
        /// </summary>
        public string SamplingUnitMark { get; set; }
        #endregion

        #region 产品信息
        /// <summary>
        /// 主检组
        /// </summary>
        public string MainCheckGroupName { get; set; }
        /// <summary>
        /// 样品编号
        /// </summary>
        public string ProSampleNo { get; set; }
        /// <summary>
        /// 监管类别
        /// </summary>
        public string ProSuperviseType { get; set; }
        /// <summary>
        /// 证书编号
        /// </summary>
        public string ProCertNo { get; set; }
        /// <summary>
        /// 检查封样人
        /// </summary>
        public string ProCheckSealName { get; set; }
        /// <summary>
        /// 产品名称
        /// </summary>
        public string ProName { get; set; }
        /// <summary>
        /// 产品规格型号
        /// </summary>
        public string ProSpeciNo { get; set; }
        /// <summary>
        /// 产品接样人
        /// </summary>
        public string ProCheckReceiveName { get; set; }
        /// <summary>
        /// 产品生产时间/批号
        /// </summary>
        public string ProCreateAndNo { get; set; }
        /// <summary>
        /// 产品商标
        /// </summary>
        public string ProTradeMark { get; set; }
        /// <summary>
        /// 样品到达时间
        /// </summary>
        public string ProSampleReciveDateTime { get; set; }
        /// <summary>
        /// 样品数量
        /// </summary>
        public string ProSampleNum { get; set; }
        /// <summary>
        /// 产品备样数量
        /// </summary>
        public string ProSampleExtraNum { get; set; }
        /// <summary>
        /// 备样封存地点
        /// </summary>
        public string ProSampleExtraAddress { get; set; }
        /// <summary>
        /// 下达时间
        /// </summary>
        public string ProSampleOrderTime { get; set; }
        /// <summary>
        /// 要求完成时间
        /// </summary>
        public string ProSampleCompletedTime { get; set; }
        /// <summary>
        /// 样品进货/库存数量
        /// </summary>
        public string ProSampleInOrStortNum { get; set; }
        /// <summary>
        /// 样品执行标准/技术文件
        /// </summary>
        public string ProSampleStandardFile { get; set; }
        /// <summary>
        /// 产品标注等级
        /// </summary>
        public string ProSampleLevel { get; set; }
        /// <summary>
        /// 产品明示质量承诺
        /// </summary>
        public string ProSampleQuality { get; set; }
        /// <summary>
        /// 产品抽样时间
        /// </summary>
        public string ProSamplingTime{ get; set; }

        #endregion
    }
}
