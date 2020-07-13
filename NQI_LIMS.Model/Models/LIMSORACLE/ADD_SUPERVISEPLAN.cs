using System;
using System.Linq;
using System.Text;
using SqlSugar;


namespace NQI_LIMS.Model.Models
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable( "ADD_SUPERVISEPLAN", "LIMSORACLE")]
    public class ADD_SUPERVISEPLAN
    {
        public ADD_SUPERVISEPLAN()
        {
        }
        
           public decimal ORIGREC { get; set; }

           public string ORIGSTS { get; set; }

           [SugarColumn(IsPrimaryKey=true)]
           public string PLANNO { get; set; }

           public string TASKSOURCE { get; set; }

           public string DETECTIONFORSPOTCHECK { get; set; }

           public string BLUEBOOKNO { get; set; }

           public string NAMEOFINSPECTIONORG { get; set; }

           public string CODEOFINSPECTIONORG { get; set; }

           public string TESTORGREGFORM { get; set; }

           public string TESTCODEORGREGFORM { get; set; }

           public string SAMPLINGCOMPANY { get; set; }

           public string SAMPLINGAREA { get; set; }

           public DateTime? CHECKSSTARTDATE { get; set; }

           public DateTime? CHECKSENDDATE { get; set; }

           public string STATUS { get; set; }

           public decimal? YEAR { get; set; }

           public decimal? QUARTER { get; set; }

           public decimal? MONTH { get; set; }

           public string SAMPLINGBASIS { get; set; }

           public string SAMPLINGRANGE { get; set; }

           public string DIVISIONCODELIST { get; set; }

           public DateTime? TESTENDDATA { get; set; }

           public string REMARK { get; set; }

           public DateTime? SCHEMEENDDATA { get; set; }

           public decimal? BATCH { get; set; }

           public string SUPERVISIONPLANNO { get; set; }

           public string SUBCONTRACTDEPT { get; set; }

           public string SUBCONTRACTPROJECT { get; set; }

           public string TASKCLASS { get; set; }

           public string PRODUCTCATEGORY { get; set; }

           public string PRODUCTCATEGORYID { get; set; }

           public string PRODUCTID { get; set; }

           public string PRODUCTNAME { get; set; }

           public string SAMPLENAME { get; set; }

           public string DIVISIONCODE { get; set; }

           public string NAMEOFORGBETESTED { get; set; }

           public string CARYUNITCODE { get; set; }

           public string MAJORDIVISIONCODE { get; set; }

           public DateTime? REQUESTDATE { get; set; }

           public decimal? ONLINEBATCH { get; set; }

           public decimal? PRODUCTIONBATCH { get; set; }

           public decimal? MARKETBATCH { get; set; }

           public decimal? USERBATCH { get; set; }

           public decimal? CATERBATCH { get; set; }

           public DateTime? SAMPLESAVEDATE { get; set; }

           public string SPECIFICREQUEST { get; set; }

           public string TASKASSIGNDEPTNAME { get; set; }
    }
}