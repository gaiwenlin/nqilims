using System;
using System.Linq;
using System.Text;
using SqlSugar;


namespace NQI_LIMS.Model
{
    ///<summary>
    ///网店信息
    ///</summary>
    [SugarTable( "PM_EC_PLATFORM", "CJORACLE")]
    public class PM_EC_PLATFORM
    {
        public PM_EC_PLATFORM()
        {
        }
        /// <summary>
        /// 自增id
        /// </summary>
        [SugarColumn(IsNullable = false, IsPrimaryKey = true, IsIdentity = true)]
        public int EC_ID { get; set; }
        /// <summary>
        /// 网店名称
        /// </summary>
        public string ONLINE_STORE_NAME { get; set; }
        /// <summary>
        /// 网店通讯地址
        /// </summary>
        public string ONLINE_STORE_ADDR { get; set; }
        /// <summary>
        /// 网店营业注册码
        /// </summary>
        public string ONLINE_STORE_POLL_CODE { get; set; }
        /// <summary>
        /// 网店联系方式
        /// </summary>
        public string ONLINE_STORE_CONTACT { get; set; }
        /// <summary>
        /// 网店网址链接
        /// </summary>
        public string ONLINE_STORE_LINK { get; set; }
        /// <summary>
        /// 电商平台名称
        /// </summary>
        public string EC_PLATFORM_NAME { get; set; }
        /// <summary>
        /// 
        /// </summary>
           public string EC_PLATFORM_LINK { get; set; }
        /// <summary>
        /// 
        /// </summary>
           public string ONLINE_ORDER_CODE { get; set; }
        /// <summary>
        /// 商品网址链接（含商品唯一识别号）
        /// </summary>
        public string LINKS_WEB_SITES { get; set; }
        /// <summary>
        /// 网店所属地
        /// </summary>
        public string ONLINE_OWNERSHIP { get; set; }
        /// <summary>
        /// 平台所属地
        /// </summary>
        public string EC_PLATFORM_OWNERSHIP { get; set; }
        /// <summary>
        /// 平台所属地（省编码）
        /// </summary>
        public string EC_PLATFORM_PROVINCE { get; set; }
        /// <summary>
        /// 平台所属地（市编码）
        /// </summary>
        public string EC_PLATFORM_CITY { get; set; }
        /// <summary>
        /// 平台所属地（区/县编码）
        /// </summary>
        public string EC_PLATFORM_COUNTY { get; set; }
        /// <summary>
        /// 网店所属地（省编码）
        /// </summary>
        public string ONLINE_PROVINCE { get; set; }
        /// <summary>
        /// 网店所属地（市编码）
        /// </summary>
        public string ONLINE_CITY { get; set; }
        /// <summary>
        /// 网店所属地（区/县编码）
        /// </summary>
        public string ONLINE_COUNTY { get; set; }
        /// <summary>
        /// 电商类型
        /// </summary>
        public string ONLINE_TYPE { get; set; }

         //  public string RN { get; set; }
    }
}