using System;
using System.Linq;
using System.Text;
using SqlSugar;


namespace NQI_LIMS.Model
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable( "PM_PLAN", "CJORACLE")]
    public class PM_PLAN
    {
        public PM_PLAN()
        {
        }
        /// <summary>
        /// ID
        /// </summary>
        [SugarColumn(IsNullable = false, IsPrimaryKey = true, IsIdentity = true)]
        public int ID { get; set; }

        public string PLAN_CODE { get; set; }

           public string CHECK_COMP { get; set; }

           public string CHECK_GOODS { get; set; }

           public string CONTENTS { get; set; }

           public string PLAN_STATE { get; set; }

           public string CHECK_KIND { get; set; }

           public string NOTICE_TIME { get; set; }

           public string EFFECT_TIME { get; set; }

           public int BILL_STORE_ID { get; set; }

           public string START_NUM { get; set; }

           public string END_NUM { get; set; }

           public string CHECK_LOT { get; set; }

           public string FILL_USER_ID { get; set; }

           public string CHECK_TYPE { get; set; }

           public string CREATEDATE { get; set; }
  
           public string TASK_SOURCE { get; set; }

           public string TASK_SEASON { get; set; }

           public int ECO_BUY_NUM { get; set; }

           public int PRO_CHECK_NUM { get; set; }

           public int STORE_BUY_NUM { get; set; }

           public string FINISH_TIME { get; set; }

           public string TASK_YEAR { get; set; }

           public string ATTACHMENT_FILES { get; set; }

           public int ORDER_CODE { get; set; }

           public string CHECK_KIND_PRO { get; set; }

           public string CHECK_KIND_ECO { get; set; }

           public string CHECK_KIND_STORE { get; set; }

           public string CHECK_DEPTS { get; set; }

           public string TASK_START_TIME { get; set; }

           public string ALLOC_TIME { get; set; }

           public string PRO_CLASS_CODE { get; set; }

           public int CPDL_ID { get; set; }

           public string QT_CPDL_NAME { get; set; }

           public string CPMC_NAME { get; set; }

           public int OTHER_NUM { get; set; }

           public string CPLB_NAME { get; set; }

           public string TYPE { get; set; }

           public string CCJG_NAME { get; set; }

           public string PLAN_INFO_SYN_TYPE { get; set; }

           public string UUID { get; set; }

          // public int RN { get; set; }
    }
}