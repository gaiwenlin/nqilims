using System;
using System.Linq;
using System.Text;
using SqlSugar;


namespace NQI_LIMS.Model
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable( "PM_EXEC_UINT", "CJORACLE")]
    public class PM_EXEC_UINT
    {
        public PM_EXEC_UINT()
        {
        }
        /// <summary>
        /// ID
        /// </summary>
        [SugarColumn(IsNullable = false, IsPrimaryKey = true, IsIdentity = true)]
        public int ID { get; set; }

           public string EXEC_CODE { get; set; }

           public string EXEC_NAME { get; set; }

           public string EXEC_ADDR { get; set; }

           public string EXEC_ZIP_CODE { get; set; }

           public string EXEC_LINKMAN { get; set; }

           public string EXEC_TEL { get; set; }

           public string EXEC_FAX { get; set; }

           public string RN { get; set; }
    }
}