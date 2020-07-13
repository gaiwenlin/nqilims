using System;
using System.Linq;
using System.Text;
using SqlSugar;


namespace NQI_LIMS.Model.Models
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable( "ORDERS", "LIMSORACLE")]
    public class ORDERS
    {
        public ORDERS()
        {
        }
        
           public decimal ORIGREC { get; set; }

           public string FOLDERNO { get; set; }

           [SugarColumn(IsPrimaryKey=true)]
           public string ORDNO { get; set; }

           public string ORIGSTS { get; set; }

           public string STATUS { get; set; }

           public string DISPSTS { get; set; }

           public DateTime? CREATETIME { get; set; }

           public string SAMPLENAME { get; set; }

           public string SAMPLEDESC { get; set; }

           public string SPECMODEL { get; set; }

           public string SAMPLEGRADE { get; set; }

           public string SAMPLESTATE { get; set; }

           public string STORAGEMETHOD { get; set; }

           public string DEPT { get; set; }

           public string DIVISIONCODE { get; set; }

           public string ISMAKESAMPLE { get; set; }

           public string ISPREPARE { get; set; }

           public string ISCHOICE { get; set; }

           public string LOCATION { get; set; }

           public string PREORDNO { get; set; }

           public string MAJORUSRNAM { get; set; }

           public byte[] LABLEPIC { get; set; }

           public long? DRAWNO { get; set; }

           public string QC_TYPE { get; set; }

           public string JUDGE_STS { get; set; }

           public decimal? SP_CODE { get; set; }

           public string STDNO { get; set; }

           public string FROM_FOLDERNO { get; set; }

           public string QS_NO { get; set; }

           public string SAMPLE_TEMPLATEID { get; set; }

           public DateTime? SAMPLE_TESTED_DATE { get; set; }

           public DateTime? SAMPLE_RECEIVE_DATE { get; set; }

           public string SAMPLE_BARCODE { get; set; }

           public string SAMPLE_GRADE { get; set; }

           public string SAMPLE_GRADE_ENG { get; set; }

           public string MODEL_NO { get; set; }

           public string MODEL_NO_ENG { get; set; }

           public string LOT_NO { get; set; }

           public string LOT_NO_ENG { get; set; }

           public DateTime? PRODUCTION_DATE { get; set; }

           public string PRODUCTION_DATE_ENG { get; set; }

           public string SAMPLE_BRAND { get; set; }

           public string SAMPLE_BRAND_ENG { get; set; }

           public string SAMPLE_STATUS { get; set; }

           public string SAMPLE_STATUS_ENG { get; set; }

           public string SAMPLE_NAME_ENG { get; set; }

           public DateTime? LOGDATE { get; set; }

           public string COMMENTS { get; set; }

           public string SAMPLE_SPECIFICATION { get; set; }

           public string SAMPLE_UNIT { get; set; }

           public decimal? SAMPLE_COUNT { get; set; }

           public string SAMPLE_DESC { get; set; }

           public string SAMPLE_NAME { get; set; }

           public decimal? TEST_GROUP { get; set; }

           public string PRECANCEL_STATUS { get; set; }

           public string PRECANCEL_DISPSTS { get; set; }
    }
}