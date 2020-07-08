using System;
using System.Linq;
using System.Text;
using SqlSugar;


namespace NQI_LIMS.Model.Models
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable( "DEPARTMENTS", "LIMSORACLE")]
    public class DEPARTMENTS
    {
        public DEPARTMENTS()
        {
        }
        
           public decimal ORIGREC { get; set; }

           [SugarColumn(IsPrimaryKey=true)]
           public string DEPT { get; set; }

           public string DEPTCODE { get; set; }

           public string MANAGER { get; set; }

           public string ORIGSTS { get; set; }

           public string RASCLIENTID { get; set; }

           public string SHARESDB { get; set; }

           public string ADDRESS { get; set; }

           public string COUNTRYCODE { get; set; }

           public string STATECODE { get; set; }

           public string ZIP { get; set; }

           public string PHONE { get; set; }

           public string FAX { get; set; }

           public decimal? CITY_CODE { get; set; }

           public string DEFAULTCOUNTRY { get; set; }

           public string DEPT_ENG { get; set; }

           public string DIVISIONCODE { get; set; }

           public string STATUS { get; set; }

           public string DEPTNAME { get; set; }

           public string DEPTNAME_ENG { get; set; }

           public string ADDRESS_ENG { get; set; }

           public string SKIP_REPORT_APPROVE2 { get; set; }

           public string PERFORATION_SIGN_NO { get; set; }

           public string PERFORATION_SIGN_NO_NOT_COPY { get; set; }

           public string LOCATION { get; set; }

           public decimal? CALENDAR_ORIGREC { get; set; }

           public string IDENTIFIER { get; set; }

           public string PARENTDIV { get; set; }

           public decimal? WORKLOAD { get; set; }

           public string PHOTOSIZE { get; set; }

           public string DEFAULTSAMPLE { get; set; }

           public string SKIPAPPROVESTEP { get; set; }

           public string ALLOTTYPE { get; set; }

           public string INSPECTORBLANK { get; set; }

           public string ADDPAGENUMBER { get; set; }
    }
}