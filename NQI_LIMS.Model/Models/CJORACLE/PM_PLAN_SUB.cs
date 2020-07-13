using System;
using System.Linq;
using System.Text;
using SqlSugar;


namespace NQI_LIMS.Model
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("PM_PLAN_SUB", "CJORACLE")]
    public class PM_PLAN_SUB
    {
        public PM_PLAN_SUB()
        {
        }
        /// <summary>
        /// ID
        /// </summary>
        [SugarColumn(IsNullable = false, IsPrimaryKey = true, IsIdentity = true)]
        public int ID { get; set; }
        /// <summary>
        /// 单据编号
        /// </summary>
        public string BILL_CODE { get; set; }
        /// <summary>
        /// 任务编号
        /// </summary>
        public string PLAN_CODE { get; set; }
        /// <summary>
        /// 抽检批次号
        /// </summary>
        public string LOT_NUM { get; set; }
        /// <summary>
        /// 任务类型 
        /// 08：省级监督抽查；
        /// 09：省级专项监督抽查；
        /// 10：省级联动监督抽查；
        /// 11：省级产品质量风险监测
        /// </summary>
        public string TASK_KIND { get; set; }
        /// <summary>
        /// 手机端选择的执行类型：
        /// 1，正常抽样；
        /// 2，拒绝抽样；
        /// 3，无法抽样；
        /// 4，成品油抽样；
        /// 5，市场抽样；
        /// 6，其他来源；
        /// </summary>
        public string CHECK_STATE { get; set; }

        /// <summary>
        /// 检测组编号
        /// </summary>
        public int GRUOP_ID_TEMP { get; set; }

        /// <summary>
        /// 受检单位编号
        /// </summary>
        public int CARY_ID { get; set; }
        /// <summary>
        /// 生产单位编号
        /// </summary>
        public int PRO_ID { get; set; }
        /// <summary>
        /// 受检产品编号
        /// </summary>
        public int GOODS_ID { get; set; }
        /// <summary>
        /// 受检产品规格型号
        /// </summary>
        public string GOODS_SCALE { get; set; }
        /// <summary>
        /// 受检产品生产日期
        /// </summary>
        public string GOODS_PRO_TIME_TEMP { get; set; }
        /// <summary>
        /// 受检产品生产批号
        /// </summary>
        public string GOODS_PRO_LOT { get; set; }
        /// <summary>
        /// 受检产品抽样数量
        /// </summary>
        public string GOODS_CHECK_NUM { get; set; }
        /// <summary>
        /// 受检产品备样量
        /// </summary>
        public string GOODS_COPY_NUM { get; set; }
        /// <summary>
        /// 受检产品备样封存地点
        /// </summary>
        public string GOODS_COPY_LOCAL { get; set; }
        /// <summary>
        /// 受检产品抽样基数
        /// </summary>
        public string GOODS_BASE_NUM { get; set; }
        /// <summary>
        /// 受检产品抽样日期
        /// </summary>
        public string GOODS_CHECK_TIME { get; set; }
        /// <summary>
        /// 受检产品抽样地点
        /// </summary>
        public string GOODS_CHECK_LOCAL { get; set; }
        /// <summary>
        /// 受检产品封样状态
        /// </summary>
        public string GOODS_SEAL_STATE { get; set; }
        /// <summary>
        /// 受检产品是否合格代销
        /// </summary>
        public string GOODS_CAN_SALE { get; set; }
        /// <summary>
        /// 所抽产品上年销售额
        /// </summary>
        public string LAST_YEAR_SALE { get; set; }
        /// <summary>
        /// 抽样单位编号
        /// </summary>
        public int EXEC_ID { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string REMARKS { get; set; }
        /// <summary>
        /// 生成时间
        /// </summary>
        public DateTime CREATEDATE { get; set; }
        /// <summary>
        /// 受检产品抽样批量
        /// </summary>
        public string GOODS_CHECK_LOT { get; set; }
        /// <summary>
        /// 抽检任务状态
        /// 0:抽样人员待上传  
        /// 1:抽样人员已上传 
        /// 2:抽样信息上传照片未上传
        /// 3:抽样信息上传照片已上传 
        /// 4:已提交（提交省公司）
        /// 5:提交审批 
        /// 6:审批通过 
        /// 7:驳回 
        /// 9:删除
        /// </summary>
        public string STATE { get; set; }
        /// <summary>
        /// 图片附件group_id（PC端的产品信息截图对应APP端所有打包截图）
        /// </summary>
        public string IMG_GROUP_ID { get; set; }
        /// <summary>
        /// 视频附件group_id
        /// </summary>
        public string VID_GROUP_ID { get; set; }
        /// <summary>
        /// 受检产品寄送样地点
        /// </summary>
        public string GOODS_SEND_LOCAL { get; set; }
        /// <summary>
        /// 受检产品寄送样截止日期
        /// </summary>
        public string GOODS_SEND_TIME { get; set; }
        /// <summary>
        /// 抽检方式 
        /// 1:现场抽样
        /// 2:市场买样
        /// 3：电商买样 
        /// 4：其他来源
        /// </summary>
        public string CHECK_TYPE { get; set; }
        /// <summary>
        /// 受检产品监管类别
        /// </summary>
        public string GOODS_CHECK_LEVEL { get; set; }
        /// <summary>
        /// 受检产品证书编号
        /// </summary>
        public string GOODS_CERT_CODE { get; set; }
        /// <summary>
        /// 受检产品名称
        /// </summary>
        public string GOODS_NAME { get; set; }
        /// <summary>
        /// 受检产品商标
        /// </summary>
        public string GOODS_BRAND { get; set; }
        /// <summary>
        /// 受检产品是否出口
        /// </summary>
        public string GOODS_EXPORT { get; set; }
        /// <summary>
        /// 受检产品执行标准
        /// </summary>
        public string GOODS_STANDARD { get; set; }
        /// <summary>
        /// 受检产品等级
        /// </summary>
        public string GOODS_LEVEL { get; set; }
        /// <summary>
        /// 采样环节
        /// </summary>
        public string SAMPLE_STEP { get; set; }
        /// <summary>
        /// 采样环节其他说明
        /// </summary>
        public string SAMPLE_STEP_OTHER { get; set; }
        /// <summary>
        /// 电商平台编号
        /// </summary>
        public int EC_ID { get; set; }
        /// <summary>
        /// 发票号
        /// </summary>
        public string INVOICE_CODE { get; set; }
        /// <summary>
        /// 开票单位
        /// </summary>
        public string INVOICE_UNIT { get; set; }
        /// <summary>
        /// 销售单价(元)
        /// </summary>
        public string SALE_PRICE { get; set; }
        /// <summary>
        ///明示质量承诺 
        /// </summary>
        public string QUALITY_PROMISE { get; set; }
        /// <summary>
        /// 承检机构
        /// </summary>
        public string CHECK_COMP { get; set; }
        /// <summary>
        /// 填报人id
        /// </summary>
        public string FILL_USER_ID { get; set; }
        /// <summary>
        /// 拒检事实认定
        /// </summary>
        public string REFUSE_DESCRIPTION { get; set; }
        /// <summary>
        /// 未抽样原因（其他）
        /// </summary>
        public string NON_FOUND_EXPLANATION { get; set; }
        /// <summary>
        /// 未抽样原因
        /// </summary>
        public string NON_FOUND_CODE { get; set; }
        /// <summary>
        /// 抽样单编号
        /// </summary>
        public string CHECK_CODE { get; set; }
        /// <summary>
        /// 快递单号
        /// </summary>
        public string DELIVERY_ID { get; set; }
        /// <summary>
        /// 未抽样执行人
        /// </summary>
        public string NON_FOUND_CHECK_PERSON { get; set; }
        /// <summary>
        /// 未抽样企业名称
        /// </summary>
        public string NON_FOUND_COMPANY_NAME { get; set; }
        /// <summary>
        /// 流程ID
        /// </summary>
        public string PROCESS_ID { get; set; }
        /// <summary>
        /// 流程附件
        /// </summary>
        public string PROCESS_FILES { get; set; }
        /// <summary>
        /// 发起修改流程责任认定方
        /// </summary>
        public string RES_VALUE { get; set; }
        /// <summary>
        /// 发起修改流程责任认定说明
        /// </summary>
        public string RES_DES { get; set; }
        /// <summary>
        /// 检验报告快递公司
        /// </summary>
        public string DEL_COMP_SHEET { get; set; }
        /// <summary>
        /// 检验报告快递单号
        /// </summary>
        public string DELIVERY_ID_SHEET { get; set; }
        /// <summary>
        /// 样品快递公司
        /// </summary>
        public string DEL_COMP_SAMPLE { get; set; }
        /// <summary>
        /// 受检产品限用日期
        /// </summary>
        public string GOODS_PRO_LIMIT { get; set; }
        /// <summary>
        /// 检测组编号
        /// </summary>
        public string GRUOP_ID { get; set; }
        /// <summary>
        /// 受检产品生产日期
        /// </summary>
        public string GOODS_PRO_TIME { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string PRO_BRAND_BUILDING { get; set; }
        /// <summary>
        /// 产品分类代码
        /// </summary>
        public string PRO_CLASS_CODE { get; set; }
        /// <summary>
        /// 防护及保存要求
        /// </summary>
        public string GOODS_PROTECTION_REQ { get; set; }
        /// <summary>
        /// 销售单价
        /// </summary>
        public string GOODS_UNIT_PRICE { get; set; }
        /// <summary>
        /// 销售地区
        /// </summary>
        public string GOODS_SALE_AREA { get; set; }
        /// <summary>
        /// 销售方式
        /// </summary>
        public string GOODS_SALE_MODE { get; set; }
        /// <summary>
        /// 是否委托加工
        /// </summary>
        public string GOODS_MAN_CONSIGNMENT { get; set; }
        /// <summary>
        /// 委托加工企业名称
        /// </summary>
        public string GOODS_CONSIGN_ENTERPRISE { get; set; }
        /// <summary>
        /// 是否需要退样
        /// </summary>
        public string GOODS_NEEDS_RETREAT { get; set; }
        /// <summary>
        /// 退样方式
        /// </summary>
        public string GOODS_RETREAT_MODE { get; set; }
        /// <summary>
        /// 快递签收状态 1：未签收；2：已签收；3：已发出
        /// </summary>
        public string DELIVERY_RECEIPT_STATE { get; set; }
        /// <summary>
        /// 快递截图附件
        /// </summary>
        public string IMG_DELIVERY_GROUP_ID { get; set; }
        /// <summary>
        /// 样品状态
        /// </summary>
        public string GOODS_STATE { get; set; }
        /// <summary>
        /// 备样封样状态
        /// </summary>
        public string GOODS_COPY_STATE { get; set; }
        /// <summary>
        /// 截图附件1（PC端订单或交易记录等销售信息截图）
        /// </summary>
        public string IMG_101_GROUP_ID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string IMG_102_GROUP_ID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string IMG_103_GROUP_ID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string IMG_104_GROUP_ID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string IMG_105_GROUP_ID { get; set; }
        /// <summary>
        /// 生产企业名称
        /// </summary>
        public string MANUFACTURER { get; set; }
        /// <summary>
        /// 商品网址链接（含商品唯一识别号）
        /// </summary>
        public string LINKS_WEB_SITES { get; set; }
        /// <summary>
        /// 商品订单编码
        /// </summary>
        public string ONLINE_ORDER_CODE { get; set; }
        /// <summary>
        /// 生产企业名称编号（取方案系统生产企业名称编号）
        /// </summary>
        public string MANUFACTURER_ID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string IMG_106_GROUP_ID { get; set; }
        /// <summary>
        /// 是否加入清净剂
        /// </summary>
        public string OIL_IS_DETERGENT { get; set; }
        /// <summary>
        /// 最近一批油品进罐日期
        /// </summary>
        public string OIL_INTAKE_DATE { get; set; }
        /// <summary>
        /// 前罐内余量
        /// </summary>
        public string OIL_LAST_ALLOWANCE { get; set; }
        /// <summary>
        /// 抽样地点
        /// </summary>
        public string OIL_SAMPLING_SITE { get; set; }
        /// <summary>
        /// 上年出库量
        /// </summary>
        public string OIL_LASTYEAR_QUANTITY { get; set; }
        /// <summary>
        /// 受检单位总罐容量
        /// </summary>
        public string OIL_TOTAL_CAPACITY { get; set; }
        /// <summary>
        /// 使用单位ID
        /// </summary>
        public int USE_COMPANY_ID { get; set; }
        /// <summary>
        /// 实体店分类
        /// </summary>
        public string CARY_CLASSIFICATION { get; set; }
        /// <summary>
        /// 产品进货/库存数
        /// </summary>
        public string PRO_JH_KC { get; set; }
        /// <summary>
        /// 统一信用代码
        /// </summary>
        public string UNIFIED_CREDIT_CODE { get; set; }
        /// <summary>
        /// 发货地
        /// </summary>
        public string PLACE_OF_DELIVERY { get; set; }
        /// <summary>
        /// 发货地（省编码）
        /// </summary>
        public string PLACE_OF_DELIVERY_PROVINCE { get; set; }
        /// <summary>
        /// 发货地（市编码）
        /// </summary>
        public string PLACE_OF_DELIVERY_CITY { get; set; }
        /// <summary>
        /// 其他来源单位编码
        /// </summary>
        public int OTHER_ID { get; set; }
        /// <summary>
        /// 批次数据同步状态
        /// </summary>
        public string PM_TB_STATE { get; set; }
        /// <summary>
        /// 确认书打印日期
        /// </summary>
        public string DATE_OF_PRINTING { get; set; }
        /// <summary>
        /// 生产企业抽样摘要
        /// </summary>
        public string PRO_ABSTRACT { get; set; }

        //public string RN { get; set; }
    }
}