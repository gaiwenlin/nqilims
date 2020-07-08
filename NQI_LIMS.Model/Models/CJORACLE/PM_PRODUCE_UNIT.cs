using System;
using System.Linq;
using System.Text;
using SqlSugar;


namespace NQI_LIMS.Model
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable( "PM_PRODUCE_UNIT", "CJORACLE")]
    public class PM_PRODUCE_UNIT
    {
        public PM_PRODUCE_UNIT()
        {
        }

        /// <summary>
        /// ID
        /// </summary>
        [SugarColumn(IsNullable = false, IsPrimaryKey = true, IsIdentity = true)]
        public int ID { get; set; }

           public string PRO_CODE { get; set; }

           public string PRO_NAME { get; set; }

           public string PRO_OWNERSHIP { get; set; }

           public string PRO_ADDR { get; set; }

           public string PRO_ZIP_CODE { get; set; }

           public string PRO_PRESENT { get; set; }

           public string PRO_LINKMAN { get; set; }

           public string PRO_TEL { get; set; }

           public string PRO_PHONE { get; set; }

           public string PRO_BUS_LICENCE { get; set; }

           public string PRO_ORGAN_CODE { get; set; }

           public string PRO_SACLE { get; set; }

           public string ECO_INSIDE { get; set; }

           public string PRO_QUALITY_PASS { get; set; }

           public string ECO_HMT { get; set; }

           public string ECO_OUTSIDE { get; set; }

           public string ECO_SINGLE { get; set; }

           public string PRO_CERT_CODE { get; set; }

           public string PRO_SACLE_TYPE { get; set; }

           public string PRO_ORG_CODE { get; set; }

           public string PRO_ORG_NAME { get; set; }

           public string PRO_CREDIT_CODE { get; set; }

           public string PRO_IS_SCALE { get; set; }

           public string PRO_BRAND_BUILDING { get; set; }

           public string PRO_CLASS_CODE { get; set; }

           public string PRO_PROVINCE { get; set; }

           public string PRO_CITY { get; set; }

           public string PRO_COUNTY { get; set; }

           public string PRO_CPMC_NAME { get; set; }

           public string RN { get; set; }
    }
}