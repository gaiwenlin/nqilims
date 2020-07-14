using System;
using System.Linq;
using System.Text;
using SqlSugar;


namespace NQI_LIMS.Model.Models
{
    ///<summary>
    ///受检单位信息
    ///</summary>
    [SugarTable("PM_CARY", "CJORACLE")]
    public class PM_CARY
    {
        public PM_CARY()
        {
        }
        /// <summary>
        /// ID
        /// </summary>
        [SugarColumn(IsNullable = false, IsPrimaryKey = true, IsIdentity = true)]
        public int ID { get; set; }
        /// <summary>
        /// 受检单位编码
        /// </summary>
        public string CARY_CODE { get; set; }
        /// <summary>
        ///受检单位名称
        /// </summary>
        public string CARY_NAME { get; set; }
        /// <summary>
        /// 受检单位法人代表
        /// </summary>
        public string CARY_PRESENT { get; set; }
        /// <summary>
        /// 受检单位通信地址
        /// </summary>
        public string CARY_ADDR { get; set; }
        /// <summary>
        /// 受检单位邮编
        /// </summary>
        public string CARY_ZIP_CODE { get; set; }
        /// <summary>
        /// 受检单位联系人
        /// </summary>
        public string CARY_LINKMAN { get; set; }
        /// <summary>
        /// 受检单位联系电话
        /// </summary>
        public string CARY_TEL { get; set; }
        /// <summary>
        /// 受检单位管理生产企业
        /// </summary>
        public int CARY_RELATED_PRO_ID { get; set; }
        /// <summary>
        /// 受检单位所属地
        /// </summary>
        public string CARY_OWNERSHIP { get; set; }
        /// <summary>
        /// 统一社会信用代码（营业执照注册号）
        /// </summary>
        public string UNIFIED_SOCIAL_CREDIT_CODE { get; set; }
        /// <summary>
        /// 受检单位所属地（省编码）
        /// </summary>
        public string CARY_PROVINCE { get; set; }
        /// <summary>
        /// 受检单位所属地（市编码）
        /// </summary>
        public string CARY_CITY { get; set; }
        /// <summary>
        /// 受检单位所属地（区/县编码）
        /// </summary>
        public string CARY_COUNTY { get; set; }
        /// <summary>
        /// 经营者所在地（1：城区，2：城郊结合部，3：乡镇）
        /// </summary>
        public string OPERATOR_LOCATION { get; set; }
        /// <summary>
        /// 
        /// </summary>
       // public string RN { get; set; }
    }
}