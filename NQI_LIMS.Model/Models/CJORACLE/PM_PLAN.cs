using System;
using System.Linq;
using System.Text;
using SqlSugar;


namespace NQI_LIMS.Model
{
    ///<summary>
    ///PM_PLAN 任务表
    ///</summary>
    [SugarTable("PM_PLAN", "CJORACLE")]
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

        /// <summary>
        /// 任务编号
        /// </summary>
        public string PLAN_CODE { get; set; }

        /// <summary>
        /// 承检机构编码
        /// </summary>
        public string CHECK_COMP { get; set; }

        /// <summary>
        /// 检测产品
        /// </summary>
        public string CHECK_GOODS { get; set; }

        /// <summary>
        /// 工作内容
        /// </summary>
        public string CONTENTS { get; set; }

        /// <summary>
        /// 任务状态(1.未下达 2.已下达 3.已领取 4.已完成 0.已撤回 5.已上传)
        /// </summary>
        public string PLAN_STATE { get; set; }

        /// <summary>
        /// 任务类型（已作废）
        /// </summary>
        public string CHECK_KIND { get; set; }

        /// <summary>
        /// 结果通知日期
        /// </summary>
        public string NOTICE_TIME { get; set; }
        /// <summary>
        /// 检测有效日期
        /// </summary>
        public string EFFECT_TIME { get; set; }
        /// <summary>
        /// 单据入库编号
        /// </summary>
        public int BILL_STORE_ID { get; set; }
        /// <summary>
        /// 起始号码
        /// </summary>
        public string START_NUM { get; set; }
        /// <summary>
        /// 终止号码
        /// </summary>
        public string END_NUM { get; set; }
        /// <summary>
        /// 检测批次
        /// </summary>
        public string CHECK_LOT { get; set; }
        /// <summary>
        /// 制定人
        /// </summary>
        public string FILL_USER_ID { get; set; }
        /// <summary>
        /// 抽检方式
        /// </summary>
        public string CHECK_TYPE { get; set; }
        /// <summary>
        /// 生成时间
        /// </summary>
        public string CREATEDATE { get; set; }
        /// <summary>
        /// 任务来源
        /// </summary>
        public string TASK_SOURCE { get; set; }
        /// <summary>
        /// 实施季度
        /// </summary>
        public string TASK_SEASON { get; set; }
        /// <summary>
        /// 电商买样批次数
        /// </summary>
        public int ECO_BUY_NUM { get; set; }
        /// <summary>
        /// 生产企业抽样批次数
        /// </summary>
        public int PRO_CHECK_NUM { get; set; }
        /// <summary>
        /// 市场买样批次数
        /// </summary>
        public int STORE_BUY_NUM { get; set; }
        /// <summary>
        /// 要求完成日期
        /// </summary>
        public string FINISH_TIME { get; set; }
        /// <summary>
        /// 实施年度
        /// </summary>
        public string TASK_YEAR { get; set; }
        /// <summary>
        /// 附件
        /// </summary>
        public string ATTACHMENT_FILES { get; set; }
        /// <summary>
        /// 流水号码
        /// </summary>
        public int ORDER_CODE { get; set; }
        /// <summary>
        /// 任务类型-生产企业抽样
        /// 1-省级监督抽查；
        /// 2-产品质量风险监测；
        /// 3-省级联动监督抽查；
        /// 4-省级专项监督抽查；
        /// 5-国家联动监督抽查；
        /// 6-省级监督抽查（产品质量风险监测）;
        /// 7-联动监督抽查和其他；
        /// 08-01：定期监督抽查;
        /// 09-02：省级专项监督抽查;
        /// 10-03：省级联动监督抽查
        /// </summary>
        public string CHECK_KIND_PRO { get; set; }
        /// <summary>
        /// 任务类型-电商买样
        /// 1-省级监督抽查；
        /// 2-产品质量风险监测；
        /// 3-省级联动监督抽查；
        /// 4-省级专项监督抽查；
        /// 5-国家联动监督抽查；
        /// 6-省级监督抽查（产品质量风险监测）;
        /// 7-联动监督抽查和其他；
        /// 08-01：定期监督抽查;
        /// 09-02：省级专项监督抽查;
        /// 10-03：省级联动监督抽查
        /// </summary>
        public string CHECK_KIND_ECO { get; set; }
        /// <summary>
        /// 任务类型-市场买样
        /// 1-省级监督抽查；
        /// 2-产品质量风险监测；
        /// 3-省级联动监督抽查；
        /// 4-省级专项监督抽查；
        /// 5-国家联动监督抽查；
        /// 6-省级监督抽查（产品质量风险监测）;
        /// 7-联动监督抽查和其他；
        /// 08-01：定期监督抽查;
        /// 09-02：省级专项监督抽查;
        /// 10-03：省级联动监督抽查
        /// </summary>
        public string CHECK_KIND_STORE { get; set; }
        /// <summary>
        /// 分配的检测部门编号
        /// </summary>
        public string CHECK_DEPTS { get; set; }
        /// <summary>
        /// 任务开始日期
        /// </summary>
        public string TASK_START_TIME { get; set; }
        /// <summary>
        /// 任务下达日期
        /// </summary>
        public string ALLOC_TIME { get; set; }
        /// <summary>
        /// 产品分类代码
        /// </summary>
        public string PRO_CLASS_CODE { get; set; }
        /// <summary>
        /// 产品大类ID
        /// </summary>
        public int CPDL_ID { get; set; }
        /// <summary>
        /// 产品大类名称
        /// </summary>
        public string QT_CPDL_NAME { get; set; }
        /// <summary>
        /// 产品名称
        /// </summary>
        public string CPMC_NAME { get; set; }
        /// <summary>
        /// 其他来源批次数
        /// </summary>
        public int OTHER_NUM { get; set; }
        /// <summary>
        /// 产品分类(名称)
        /// </summary>
        public string CPLB_NAME { get; set; }
        /// <summary>
        /// 类型：1：抽查并检验；2：抽查；3检验
        /// </summary>
        public string TYPE { get; set; }
        /// <summary>
        /// 抽查机构名称
        /// </summary>
        public string CCJG_NAME { get; set; }
        /// <summary>
        /// 类型：01：工业品，02：消费品
        /// </summary>
        public string PLAN_INFO_SYN_TYPE { get; set; }

        public string UUID { get; set; }

        // public int RN { get; set; }
    }
}