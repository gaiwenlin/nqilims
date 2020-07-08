using System;
using System.Linq;
using System.Text;
using SqlSugar;


namespace NQI_LIMS.Model
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable( "PM_EC_PLATFORM", "CJORACLE")]
    public class PM_EC_PLATFORM
    {
        public PM_EC_PLATFORM()
        {
        }
        /// <summary>
        /// ID
        /// </summary>
        [SugarColumn(IsNullable = false, IsPrimaryKey = true, IsIdentity = true)]
        public int EC_ID { get; set; }

           public string ONLINE_STORE_NAME { get; set; }

           public string ONLINE_STORE_ADDR { get; set; }

           public string ONLINE_STORE_POLL_CODE { get; set; }

           public string ONLINE_STORE_CONTACT { get; set; }

           public string ONLINE_STORE_LINK { get; set; }

           public string EC_PLATFORM_NAME { get; set; }

           public string EC_PLATFORM_LINK { get; set; }

           public string ONLINE_ORDER_CODE { get; set; }

           public string LINKS_WEB_SITES { get; set; }

           public string ONLINE_OWNERSHIP { get; set; }

           public string EC_PLATFORM_OWNERSHIP { get; set; }

           public string EC_PLATFORM_PROVINCE { get; set; }

           public string EC_PLATFORM_CITY { get; set; }

           public string EC_PLATFORM_COUNTY { get; set; }

           public string ONLINE_PROVINCE { get; set; }

           public string ONLINE_CITY { get; set; }

           public string ONLINE_COUNTY { get; set; }

           public string ONLINE_TYPE { get; set; }

           public string RN { get; set; }
    }
}