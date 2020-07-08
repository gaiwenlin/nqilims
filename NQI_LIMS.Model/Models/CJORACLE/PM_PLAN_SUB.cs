using System;
using System.Linq;
using System.Text;
using SqlSugar;


namespace NQI_LIMS.Model
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable( "PM_PLAN_SUB", "CJORACLE")]
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

           public string BILL_CODE { get; set; }

           public string PLAN_CODE { get; set; }

           public string LOT_NUM { get; set; }

           public string TASK_KIND { get; set; }

           public string CHECK_STATE { get; set; }

           public int GRUOP_ID_TEMP { get; set; }

           public int CARY_ID { get; set; }

           public int PRO_ID { get; set; }

           public int GOODS_ID { get; set; }

           public string GOODS_SCALE { get; set; }

           public string GOODS_PRO_TIME_TEMP { get; set; }

           public string GOODS_PRO_LOT { get; set; }

           public string GOODS_CHECK_NUM { get; set; }

           public string GOODS_COPY_NUM { get; set; }

           public string GOODS_COPY_LOCAL { get; set; }

           public string GOODS_BASE_NUM { get; set; }

           public string GOODS_CHECK_TIME { get; set; }

           public string GOODS_CHECK_LOCAL { get; set; }

           public string GOODS_SEAL_STATE { get; set; }

           public string GOODS_CAN_SALE { get; set; }

           public string LAST_YEAR_SALE { get; set; }

           public int EXEC_ID { get; set; }

           public string REMARKS { get; set; }

           public DateTime CREATEDATE { get; set; }

           public string GOODS_CHECK_LOT { get; set; }

           public string STATE { get; set; }

           public string IMG_GROUP_ID { get; set; }

           public string VID_GROUP_ID { get; set; }

           public string GOODS_SEND_LOCAL { get; set; }

           public string GOODS_SEND_TIME { get; set; }

           public string CHECK_TYPE { get; set; }

           public string GOODS_CHECK_LEVEL { get; set; }

           public string GOODS_CERT_CODE { get; set; }

           public string GOODS_NAME { get; set; }

           public string GOODS_BRAND { get; set; }

           public string GOODS_EXPORT { get; set; }

           public string GOODS_STANDARD { get; set; }

           public string GOODS_LEVEL { get; set; }

           public string SAMPLE_STEP { get; set; }

           public string SAMPLE_STEP_OTHER { get; set; }

           public int EC_ID { get; set; }

           public string INVOICE_CODE { get; set; }

           public string INVOICE_UNIT { get; set; }

           public string SALE_PRICE { get; set; }

           public string QUALITY_PROMISE { get; set; }

           public string CHECK_COMP { get; set; }

           public string FILL_USER_ID { get; set; }

           public string REFUSE_DESCRIPTION { get; set; }

           public string NON_FOUND_EXPLANATION { get; set; }

           public string NON_FOUND_CODE { get; set; }

           public string CHECK_CODE { get; set; }

           public string DELIVERY_ID { get; set; }

           public string NON_FOUND_CHECK_PERSON { get; set; }

           public string NON_FOUND_COMPANY_NAME { get; set; }

           public string PROCESS_ID { get; set; }

           public string PROCESS_FILES { get; set; }

           public string RES_VALUE { get; set; }

           public string RES_DES { get; set; }

           public string DEL_COMP_SHEET { get; set; }

           public string DELIVERY_ID_SHEET { get; set; }

           public string DEL_COMP_SAMPLE { get; set; }

           public string GOODS_PRO_LIMIT { get; set; }

           public string GRUOP_ID { get; set; }

           public string GOODS_PRO_TIME { get; set; }

           public string PRO_BRAND_BUILDING { get; set; }

           public string PRO_CLASS_CODE { get; set; }

           public string GOODS_PROTECTION_REQ { get; set; }

           public string GOODS_UNIT_PRICE { get; set; }

           public string GOODS_SALE_AREA { get; set; }

           public string GOODS_SALE_MODE { get; set; }

           public string GOODS_MAN_CONSIGNMENT { get; set; }

           public string GOODS_CONSIGN_ENTERPRISE { get; set; }

           public string GOODS_NEEDS_RETREAT { get; set; }

           public string GOODS_RETREAT_MODE { get; set; }

           public string DELIVERY_RECEIPT_STATE { get; set; }

           public string IMG_DELIVERY_GROUP_ID { get; set; }

           public string GOODS_STATE { get; set; }

           public string GOODS_COPY_STATE { get; set; }

           public string IMG_101_GROUP_ID { get; set; }

           public string IMG_102_GROUP_ID { get; set; }

           public string IMG_103_GROUP_ID { get; set; }

           public string IMG_104_GROUP_ID { get; set; }

           public string IMG_105_GROUP_ID { get; set; }

           public string MANUFACTURER { get; set; }

           public string LINKS_WEB_SITES { get; set; }

           public string ONLINE_ORDER_CODE { get; set; }

           public string MANUFACTURER_ID { get; set; }

           public string IMG_106_GROUP_ID { get; set; }

           public string OIL_IS_DETERGENT { get; set; }

           public string OIL_INTAKE_DATE { get; set; }

           public string OIL_LAST_ALLOWANCE { get; set; }

           public string OIL_SAMPLING_SITE { get; set; }

           public string OIL_LASTYEAR_QUANTITY { get; set; }

           public string OIL_TOTAL_CAPACITY { get; set; }

           public int USE_COMPANY_ID { get; set; }

           public string CARY_CLASSIFICATION { get; set; }

           public string PRO_JH_KC { get; set; }

           public string UNIFIED_CREDIT_CODE { get; set; }

           public string PLACE_OF_DELIVERY { get; set; }

           public string PLACE_OF_DELIVERY_PROVINCE { get; set; }

           public string PLACE_OF_DELIVERY_CITY { get; set; }

           public int OTHER_ID { get; set; }

           public string PM_TB_STATE { get; set; }

           public string DATE_OF_PRINTING { get; set; }

           public string PRO_ABSTRACT { get; set; }

           public string RN { get; set; }
    }
}