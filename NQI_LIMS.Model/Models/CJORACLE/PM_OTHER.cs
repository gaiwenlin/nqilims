using System;
using System.Linq;
using System.Text;
using SqlSugar;


namespace NQI_LIMS.Model
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable( "PM_OTHER", "CJORACLE")]
    public class PM_OTHER
    {
        public PM_OTHER()
        {
        }
        /// <summary>
        /// ID
        /// </summary>
        [SugarColumn(IsNullable = false, IsPrimaryKey = true, IsIdentity = true)]
        public int ID { get; set; }
        /// <summary>
        /// 其他来源单位编码
        /// </summary>
        public string OTHER_CODE { get; set; }
        /// <summary>
        /// 其他来源单位名称
        /// </summary>
        public string OTHER_NAME { get; set; }
        /// <summary>
        /// 其他来源单位法人代表
        /// </summary>
        public string OTHER_PRESENT { get; set; }
        /// <summary>
        /// 其他来源单位通信地址
        /// </summary>
        public string OTHER_ADDR { get; set; }
        /// <summary>
        /// 其他来源单位邮编
        /// </summary>
        public string OTHER_ZIP_CODE { get; set; }
        /// <summary>
        /// 其他来源单位联系人
        /// </summary>
        public string OTHER_LINKMAN { get; set; }
        /// <summary>
        /// 其他来源单位联系电话
        /// </summary>
        public string OTHER_TEL { get; set; }
        /// <summary>
        /// 统一社会信用代码（营业执照注册号）
        /// </summary>
        public string OTHER_UNIFIED_SOCIAL_CREDIT { get; set; }
        /// <summary>
        /// 
        /// </summary>
          // public string RN { get; set; }
    }
}