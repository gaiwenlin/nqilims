using System;
using System.Linq;
using System.Text;
using SqlSugar;


namespace NQI_LIMS.Model.Models
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable( "RESULTS", "LIMSORACLE")]
    public class RESULTS
    {
        public RESULTS()
        {
        }
        
           public decimal ORIGREC { get; set; }

           public string AI { get; set; }

           public string ANALTYPE { get; set; }

           [SugarColumn(IsPrimaryKey=true)]
           public string ANALYTE { get; set; }

           public string CALCFLAG { get; set; }

           public decimal? CUPNO { get; set; }

           public DateTime? DATEENTER { get; set; }

           public string FINAL { get; set; }

           public string FIRSTUSER { get; set; }

           public string FOLDERNO { get; set; }

           public decimal? NOREP { get; set; }

           public string NUMRES { get; set; }

           [SugarColumn(IsPrimaryKey=true)]
           public string ORDNO { get; set; }

           public string ORIGSTS { get; set; }

           public string PICTURE { get; set; }

           [SugarColumn(IsPrimaryKey=true)]
           public decimal REP { get; set; }

           public string REPLABEL { get; set; }

           public double? RESULTASNUMERIC { get; set; }

           public decimal? RETESTNO { get; set; }

           public string RN1 { get; set; }

           public string RN10 { get; set; }

           public string RN4 { get; set; }

           public string RN2 { get; set; }

           public string RN3 { get; set; }

           public string RN5 { get; set; }

           public string RN6 { get; set; }

           public string RN7 { get; set; }

           public string RN8 { get; set; }

           public string RN9 { get; set; }

           public decimal? RUNNO { get; set; }

           public string S { get; set; }

           public decimal? SORTER { get; set; }

           public long? SPECNO { get; set; }

           public string STD_VALUE { get; set; }

           [SugarColumn(IsPrimaryKey=true)]
           public decimal TESTCODE { get; set; }

           public string TESTNO { get; set; }

           public string UNITS { get; set; }

           public string SINONYM { get; set; }

           public decimal? SPTESTSORTER { get; set; }

           public string CALCNAME { get; set; }

           public string BYPASS_ELN { get; set; }

           public decimal? REPLACED_BY { get; set; }

           [SugarColumn(IsPrimaryKey=true)]
           public string METHOD { get; set; }

           public string DEPT { get; set; }

           public string EQTYPE { get; set; }

           public long? DRAWNO { get; set; }

           public string SINONYM_ENG { get; set; }

           public string HIGHA { get; set; }

           public string LOWA { get; set; }

           public string HIGHB { get; set; }

           public string LOWB { get; set; }

           public string CHARLIMITS { get; set; }

           public string PASS_TEXT { get; set; }

           public string SHORTCODE { get; set; }

           public string CASNO { get; set; }

           public string ECNO { get; set; }

           public string LOW { get; set; }

           public string HIGH { get; set; }

           public string RN15 { get; set; }

           public string RN14 { get; set; }

           public string RN13 { get; set; }

           public string RN12 { get; set; }

           public string RN11 { get; set; }

           public string DISPLAYFLAG { get; set; }

           public string BALANCEFLAG { get; set; }

           public string USECLIENTVALUE { get; set; }

           public string USRNAM { get; set; }

           public string LOGTIME { get; set; }

           public string LOGDATE { get; set; }

           public string SPEC_COMMENTS { get; set; }

           public string DUP { get; set; }

           public string REPORTUNITS { get; set; }

           public string REPORTLOW { get; set; }

           public string BLANKNUMRES { get; set; }

           public string MATCODE { get; set; }

           public string DIVISIONCODE { get; set; }

           public string REJECTSTS { get; set; }

           public string SDISP { get; set; }

           public string SA { get; set; }

           public string SADISP { get; set; }

           public string SERVGRP { get; set; }

           public decimal? SP_CODE { get; set; }

           public decimal? TESTSORTER { get; set; }

           public string ANALYTEVISIBLE { get; set; }

           public string EQID { get; set; }

           public string LOW_S { get; set; }

           public string TESTTYPE { get; set; }

           public string PRECANCEL_STATUS { get; set; }

           public string PRECANCEL_DISPSTS { get; set; }

           public string METHODCODE { get; set; }

           public string METHODNAME { get; set; }

           public string TESTCOMMENTS { get; set; }

           public string CAPTION { get; set; }

           public string LOW_UNIT { get; set; }

           public string QLIMIT { get; set; }

           public string IMPORTANCECLASSIFIC { get; set; }

           public string COMMENTS { get; set; }

           public string ISGENERATE { get; set; }

           public string ADDFY3 { get; set; }
    }
}