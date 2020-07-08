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

           public string OTHER_CODE { get; set; }

           public string OTHER_NAME { get; set; }

           public string OTHER_PRESENT { get; set; }

           public string OTHER_ADDR { get; set; }

           public string OTHER_ZIP_CODE { get; set; }

           public string OTHER_LINKMAN { get; set; }

           public string OTHER_TEL { get; set; }

           public string OTHER_UNIFIED_SOCIAL_CREDIT { get; set; }

           public string RN { get; set; }
    }
}