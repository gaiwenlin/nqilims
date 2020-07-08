using System;
using System.Linq;
using System.Text;
using SqlSugar;


namespace NQI_LIMS.Model.Models
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable( "PM_CARY", "CJORACLE")]
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

           public string CARY_CODE { get; set; }

           public string CARY_NAME { get; set; }

           public string CARY_PRESENT { get; set; }

           public string CARY_ADDR { get; set; }

           public string CARY_ZIP_CODE { get; set; }

           public string CARY_LINKMAN { get; set; }

           public string CARY_TEL { get; set; }

           public int CARY_RELATED_PRO_ID { get; set; }

           public string CARY_OWNERSHIP { get; set; }

           public string UNIFIED_SOCIAL_CREDIT_CODE { get; set; }

           public string CARY_PROVINCE { get; set; }

           public string CARY_CITY { get; set; }

           public string CARY_COUNTY { get; set; }

           public string OPERATOR_LOCATION { get; set; }

           public string RN { get; set; }
    }
}