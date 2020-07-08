using System;
using System.Linq;
using System.Text;
using SqlSugar;


namespace NQI_LIMS.Model.Models
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable( "DIVISIONS", "LIMSORACLE")]
    public class DIVISIONS
    {
        public DIVISIONS()
        {
        }
        
           public decimal ORIGREC { get; set; }

           public string ORIGSTS { get; set; }

           [SugarColumn(IsPrimaryKey=true)]
           public string DIVISIONCODE { get; set; }

           public string DIVISIONNAME { get; set; }

           public string STATUS { get; set; }

           public string IDENTIFIER { get; set; }

           public string LIMSCODE { get; set; }

           public string WEBSERVICEURL { get; set; }

           public string DIVOSIONSHORTNAME { get; set; }

           public string ALLOTTYPE { get; set; }

           public string ISSPECIALTYDIV { get; set; }
    }
}