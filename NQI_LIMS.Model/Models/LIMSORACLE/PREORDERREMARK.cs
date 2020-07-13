using System;
using System.Linq;
using System.Text;
using SqlSugar;


namespace NQI_LIMS.Model.Models
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable( "PREORDERREMARK", "LIMSORACLE")]
    public class PREORDERREMARK
    {
        public PREORDERREMARK()
        {
        }
        
           public decimal ORIGREC { get; set; }

           public string ORIGSTS { get; set; }

           public string RESINMATERIAL { get; set; }

           public string COLOURANT { get; set; }

           public string PERFORMANCE { get; set; }

           public string FOODTYPE { get; set; }

           public string EXPECTEDCONDITIONS { get; set; }

           public string CHEMICALTEST { get; set; }

           public string EXPECTEDTIME { get; set; }

           public string EXPECTEDTEMPERATURE { get; set; }

           public string SV { get; set; }

           public string REMARK { get; set; }

           [SugarColumn(IsPrimaryKey=true)]
           public string PREORDNO { get; set; }

           public DateTime? CREATEDATE { get; set; }

           public string CERATEBY { get; set; }
    }
}