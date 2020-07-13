using System;
using System.Linq;
using System.Text;
using SqlSugar;


namespace NQI_LIMS.Model.Models
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable( "PREORDTASK", "LIMSORACLE")]
    public class PREORDTASK
    {
        public PREORDTASK()
        {
        }
        
           public decimal ORIGREC { get; set; }

           public string ORIGSTS { get; set; }

           public DateTime? ANALYSISDUEDATE { get; set; }

           public decimal? CUPNO { get; set; }

           public string DEPT { get; set; }

           [SugarColumn(IsPrimaryKey=true)]
           public decimal DRAWNO { get; set; }

           public string EQID { get; set; }

           public string EQTYPE { get; set; }

           public string FIRSTTESTINPROFILE { get; set; }

           public string FOLDERNO { get; set; }

           public string OUTSOURCEORDNO { get; set; }

           public string PAREANTORDNO { get; set; }

           public double? PRICE { get; set; }

           public string QCTYPE { get; set; }

           public decimal? REP { get; set; }

           public decimal? RETESTNO { get; set; }

           public decimal? RUNNO { get; set; }

           public string SERVGRP { get; set; }

           [SugarColumn(IsPrimaryKey=true)]
           public decimal SP_CODE { get; set; }

           public decimal? SPECNO { get; set; }

           [SugarColumn(IsPrimaryKey=true)]
           public decimal TESTCODE { get; set; }

           public string TESTNO { get; set; }

           public decimal? TRIGGEREDBYTEST { get; set; }

           public decimal? TRIGSORTER { get; set; }

           public string TS { get; set; }

           public string TSA { get; set; }

           public string TSADISP { get; set; }

           public string USRNAM { get; set; }

           public DateTime? WORKDUEBY { get; set; }

           public string WARNINGFLAG { get; set; }

           public decimal? SPTESTSORTER { get; set; }

           [SugarColumn(IsPrimaryKey=true)]
           public string METHOD { get; set; }

           public string TSDISP { get; set; }

           public string RETESTFLAG { get; set; }

           public string COMMENTS { get; set; }

           public decimal? REPLACED_BY { get; set; }

           public string NEEDRUN { get; set; }

           public string SUBCONTRACT_FLAG { get; set; }

           public string OUTSIDE_SUBCONTRACT_FLAG { get; set; }

           public string OUTSIDE_SUBCONTRACT_LAB { get; set; }

           public decimal? SPTESTSOTER { get; set; }

           public string ANALYZEDTIME { get; set; }

           public string FROM_ORDNO { get; set; }

           public string FROM_FOLDERNO { get; set; }

           public string FROM_TYPE { get; set; }

           public string CLIENTAPPOINT { get; set; }

           public string REJECTS { get; set; }

           public decimal? QCSHORTORDNO { get; set; }

           public string REANALYSIS { get; set; }

           public string RESPONSIABLE { get; set; }

           public string ALLEQID { get; set; }

           public double? PAUSEPERIOD { get; set; }

           public string TESTNO_ENG { get; set; }

           public string REPORT_REMARK { get; set; }

           public string JUDGE_STS { get; set; }

           public string REFUSEFLAG { get; set; }

           public string DIVISIONCODE { get; set; }

           public string MAJORUSRNAM { get; set; }

           public string TESTERUSRNAM { get; set; }

           [SugarColumn(IsPrimaryKey=true)]
           public string PREORDNO { get; set; }

           public string OUTSIDE_MAJORUSRNAM { get; set; }

           public string ALLOTTYPE { get; set; }

           public string LABITEM { get; set; }

           public string TESTTYPE { get; set; }

           public string PRECANCEL_STATUS { get; set; }

           public string PRECANCEL_DISPSTS { get; set; }

           public string METHODCODE { get; set; }

           public string METHODNAME { get; set; }

           public string TESTCOMMENTS { get; set; }

           public string PROGNAME { get; set; }

           public string SP_NAME { get; set; }

           public string CONDITIONS { get; set; }

           public decimal? UNITNO { get; set; }
    }
}