using System;
using System.Linq;
using System.Text;
using SqlSugar;


namespace NQI_LIMS.Model.Models
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("FOLDERS", "LIMSORACLE")]
    public class FOLDERS
    {
        public FOLDERS()
        {
        }

        public decimal ORIGREC { get; set; }

        /// <summary>
        /// 部门编号
        /// </summary>
        public string DEPT { get; set; }
        /// <summary>
        /// 报告份数
        /// </summary>
        public decimal? REPORTNUM { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal? REPORTSCOPIES { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string REMARKS { get; set; }

        /// <summary>
        /// 默认为N
        /// </summary>
        public string ORIGSTS { get; set; }

        public string METADATA_GUID { get; set; }

        /// <summary>
        /// 英文状态
        /// </summary>
        public string FLDSTS { get; set; }

        /// <summary>
        /// 中文状态
        /// </summary>
        public string DISPSTS { get; set; }

        public string SAMPLECLASSFORCCC { get; set; }

        /// <summary>
        /// 受理单编号
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)]
        public string FOLDERNO { get; set; }

        public string CODEOFINSPECTIONORG { get; set; }

        public string NAMEOFINSPECTIONORG { get; set; }

        public string SAMPLINGORDERNO { get; set; }

        public string SAMPLINGCOMPANY { get; set; }

        public string SAMPLINGWAY { get; set; }

        public string PLANFORIACB { get; set; }

        public string SERIALNUMBERFORYEAR { get; set; }

        public string DETECTIONFORIACB { get; set; }

        public decimal? QUARTER { get; set; }

        public string PHONEOFMONITORINGORG { get; set; }

        public string NAMEOFMONITORINGORG { get; set; }

        public string PHONEOFSUPERVISINGORG { get; set; }

        public string NAMEOFSUPERVISINGORG { get; set; }
        /// <summary>
        /// 抽样类型
        /// </summary>
        public string DETECTIONFORSPOTCHECK { get; set; }

        /// <summary>
        /// 实验室
        /// </summary>
        public string TESTORGREGFORM { get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        public string TESTPLACE { get; set; }

        /// <summary>
        /// 测试类型 01 监督；03 委托
        /// </summary>
        public string TESTTYPE { get; set; }

        public string OBJECTIVEOFTEST { get; set; }

        public string TESTREQUIREMENT { get; set; }

        public string INSPECTIONSTATION { get; set; }

        public string WITNESS { get; set; }

        public string NAMEOFWITNESSORG { get; set; }

        public string ADDRESSOFBUILDORG { get; set; }

        public string PHONEOFBUILDORG { get; set; }

        public string CONTACTPERSONOFBUILDORG { get; set; }

        public string NAMEOFBUILDORG { get; set; }

        public string POSTCODEOFBUILDORG { get; set; }

        public string ECONOMYCLASSTYPE { get; set; }
        /// <summary>
        /// 任务编号
        /// </summary>
        public string PLANNO { get; set; }

        public string BLUEBOOKNO { get; set; }

        public decimal? YEAR { get; set; }

        public string SCALEENTERPRISES { get; set; }

        public string SAMPLINGSITE { get; set; }

        public string SALESLASTYEAR { get; set; }

        /// <summary>
        /// 任务来源
        /// </summary>
        public string TASKSOURCE { get; set; }

        public string NAMEOFDESIGNORG { get; set; }

        public string PHONEOFDESIGNORG { get; set; }

        public string APPLICATIONNOFORCCC { get; set; }


        /// <summary>
        /// 委托单位协议编号
        /// </summary>
        public string TESTTASKNOFORCCC { get; set; }

        public string CHECKUPDEPARTFORCCC { get; set; }
        /// <summary>
        /// 生产单位编号
        /// </summary>
        public string COMPANYNOOFPRODUCTIONORG { get; set; }
        /// <summary>
        /// 生产单位地址
        /// </summary>
        public string ADDRESSOFPRODUCTIONORG { get; set; }
        /// <summary>
        /// 生产单位电话
        /// </summary>
        public string PHONEOFPRODUCTIONORG { get; set; }

        public string CONTACTPERSONOFPRODUCTIONORG { get; set; }
        /// <summary>
        /// 生产单位名称
        /// </summary>
        public string NAMEOFPRODUCTIONORG { get; set; }
        /// <summary>
        /// 生产单位组织机构代码证
        /// </summary>
        public string PRODUCTIONOFBUSINESSLICENSE { get; set; }

        public string POSTCODEOFPRODUCTIONORG { get; set; }

        public string ORGCODEOFPRODUCTIONORG { get; set; }

        public string ADDRESSOFCONSTRUCTORG { get; set; }

        public string PHONEOFCONSTRUCTORG { get; set; }

        public string CONTACTPERSONOFCONSTRUCTORG { get; set; }

        public string NAMEOFCONSTRUCTORG { get; set; }

        public string NATUREOFCONSTRUCTORG { get; set; }

        public string POSTCODEOFCONSTRUCTORG { get; set; }

        public string FORMATOFHOMEPAGE { get; set; }
        /// <summary>
        /// 受检单位地址
        /// </summary>
        public string ADDRESSOFORGBETESTED { get; set; }
        /// <summary>
        /// 受检单位法人
        /// </summary>
        public string CORPORATIONOFORGBETESTED { get; set; }
        /// <summary>
        /// 受检单位电话
        /// </summary>
        public string PHONEOFORGBETESTED { get; set; }

        /// <summary>
        /// 受检单位法人
        /// </summary>
        public string CONTACTPERSONOFORGBETESTED { get; set; }

        /// <summary>
        /// 受检单位名称
        /// </summary>
        public string NAMEOFORGBETESTED { get; set; }

        public string COMPANYNOOFORGBETESTED { get; set; }

        public string NATUREOFORGBETESTED { get; set; }

        public string REGIONOFORGBETESTED { get; set; }
        /// <summary>
        /// 受检单位组织机构代码证
        /// </summary>
        public string ORGBETESTEDOFBUSINESSLICENSE { get; set; }

        public string POSTCODEOFORGBETESTED { get; set; }

        public string ORGCODEOFORGBETESTED { get; set; }

        public string NAMEOFACCEPTORG { get; set; }

        public string CODEOFACCEPTORG { get; set; }

        /// <summary>
        /// 接收人
        /// </summary>
        public string ACCEPTER { get; set; }

        /// <summary>
        /// 接收时间
        /// </summary>
        public DateTime? ACCEPTDATE { get; set; }

        public string NAMEOFSENDSAMPLEORG { get; set; }

        /// <summary>
        /// 委托单位地址
        /// </summary>
        public string ADDRESSOFENTRUSTORG { get; set; }

        /// <summary>
        /// 委托单位法人
        /// </summary>
        public string CORPORATIONOFENTRUSTORG { get; set; }
        /// <summary>
        /// 委托单位电话
        /// </summary>
        public string PHONEOFENTRUSTORG { get; set; }
        /// <summary>
        /// 委托单位联系人
        /// </summary>
        public string CONTACTPERSONOFENTRUSTORG { get; set; }
        /// <summary>
        /// 委托单位
        /// </summary>
        public string NAMEOFENTRUSTORG { get; set; }
        /// <summary>
        /// 委托单位编号
        /// </summary>
        public string COMPANYNOOFENTRUSTORG { get; set; }

        public string POSTCODEOFENTRUSTORG { get; set; }

        public string ORGCODEOFENTRUSTORG { get; set; }
        /// <summary>
        /// 委托人
        /// </summary>
        public string CONSIGNOR { get; set; }

        public DateTime? ENTRUSTDATE { get; set; }

        public string AGREEMENTNO { get; set; }

        public string SAMPLECOMINGWAY { get; set; }
        /// <summary>
        /// 送样，抽样
        /// </summary>
        public string SAMPLESOURCEREGFORM { get; set; }

        public decimal? MONTH { get; set; }

        public string MAKEDOCUMENTSFORCCC { get; set; }

        public string NAMEOFMANUFACTURERORG { get; set; }

        public string ADDRESSOFMANUFACTURERORG { get; set; }

        public string PHONEOFMANUFACTURERORG { get; set; }

        public string CONTACTPERSONOFMANUFACTURERORG { get; set; }

        public string POSTCODEOFMANUFACTURERORG { get; set; }

        public decimal? TESTCOSTS { get; set; }

        public DateTime? CREATETIME { get; set; }

        public string INPUTUSER { get; set; }

        public string SOURCE { get; set; }

        /// <summary>
        /// 主检部们
        /// </summary>
        public string DIVISIONCODE { get; set; }

        public string SAMPLINGTYPE { get; set; }

        public string COMPETENTAUTHORITYOFORGBETEST { get; set; }

        public string LEGALREPRESENTATIVEOFPRODU { get; set; }

        public string PRODUCTIONUNITADMINISTRATIVE { get; set; }

        public string COMPETENTAUTHORITYOFCONST { get; set; }

        public string PAYSTS { get; set; }

        public DateTime? LOGDATE { get; set; }

        public string RUNFOLDER { get; set; }

        public string JUDGE_STS { get; set; }

        public string CRMCODE { get; set; }

        /// <summary>
        /// 付款方式
        /// </summary>
        public string PAYMENT { get; set; }

        public string INSPECTNAME { get; set; }

        public string ENTRUSTEDUNITROVINCE { get; set; }

        public string ENTRUSTEDUNITCITY { get; set; }

        public string ENTRUSTEDUNITAREA { get; set; }

        public string PRODUCTIONUNITCONTACTER { get; set; }

        public string PRODUCTIONUNITROVINCE { get; set; }

        public string PRODUCTIONUNITCITY { get; set; }

        public string PRODUCTIONUNITAREA { get; set; }

        public string CARYUNITPROVINCE { get; set; }

        public string CARYUNITCITY { get; set; }

        public string CARYUNITAREA { get; set; }

        public string OILGASRECOVERYUNITINSTALL { get; set; }

        public string OILGASRECOVERYUNITOPERAT { get; set; }

        public string TANKCAPACITY { get; set; }

        public string GASOLINEVOLUME { get; set; }

        public string LAANDLOCOORDINATE { get; set; }

        public string SUPERVISIONUNITNAME { get; set; }

        public string SUPERVISIONUNITADDRESS { get; set; }

        public string SUPERVISIONUNITCONTACTER { get; set; }

        public string SUPERVISIONUNITCODE { get; set; }

        public string SUPERVISIONUNITNUMBER { get; set; }

        public string SUPERVISIONUNITZIPCODE { get; set; }

        public string PROJECTTYPE { get; set; }

        public string MAKERPROVINCE { get; set; }

        public string MAKERCITY { get; set; }

        public string MAKERAREA { get; set; }

        public string PRODUCERUNIFIEDCODE { get; set; }

        public string PRODUCERLEGAL { get; set; }

        public string SAMPLETEAM { get; set; }

        public string SAMPLEBASISANDNUMBER { get; set; }

        public string SAMPLEBATCH { get; set; }

        public string ISSUBCONTRACT { get; set; }

        public string SUBCONTRACTPROJECT { get; set; }

        public string SUBCONTRACTDEPT { get; set; }

        public string SAMPLINGFIELD { get; set; }

        public string FAECONOMYTYPEOFPRODUCTION { get; set; }

        public string FAXOFPRODUCTION { get; set; }

        public string FAXOFSAMPLING { get; set; }

        public string FAXOFORGBETESTED { get; set; }

        public string MANUFACTURERORGCODE { get; set; }

        public string COMMERCEINSPECTCATEGORY { get; set; }

        public string EXAMINATIONDEPT { get; set; }

        public string CARYUNITCODE { get; set; }

        public string TASKCLASS { get; set; }

        public string REGIONCLASS { get; set; }

        public string SCCONTACTER { get; set; }

        public string SCADDRESS { get; set; }

        public string SCCONTACTNUMBER { get; set; }

        public string SCPOSTCODE { get; set; }

        public string ISSUPPLIER { get; set; }

        public string ELECTRONICSEAL { get; set; }

        public string REJECTSTATUS { get; set; }

        public string CREATER { get; set; }

        public string RASCLIENTID { get; set; }

        public decimal? CONTACTID { get; set; }

        public string RECEIPTTYPE { get; set; }

        public string QUALITYISPASS { get; set; }

        public string QUALITYNO { get; set; }

        public string SALEMONEY { get; set; }

        public string EVALUATIONREQ { get; set; }

        public string WTDATATYPE { get; set; }

        public string EVALUATINGUSRNAM { get; set; }

        public string EVALUATINGNAME { get; set; }

        public DateTime? EVALUATINGDATE { get; set; }

        public string REQUIREMENTS { get; set; }

        public DateTime? REQUESTCOMPLETIONDATE { get; set; }

        public string TASKNO { get; set; }

        public string SUPERVISIONPLANNO { get; set; }

        public string SHOUJIANUNITFAX { get; set; }

        public string PRECANCEL_FLDSTS { get; set; }

        public string PRECANCEL_DISPSTS { get; set; }

        public string CHOUYANGUNITPROVINCE { get; set; }

        public string CHOUYANGUNITCITY { get; set; }

        public string CHOUYANGUNITAREA { get; set; }

        public string CHOUYANGUNITFAREN { get; set; }

        public string CHOUYANGUNITNO { get; set; }

        public string HOSTDEPT { get; set; }

        public string DIANSHANGNAME { get; set; }

        public string DIANSHANGWWW { get; set; }

        public string DIANSHANGWD { get; set; }

        public string TELPHONEOFORGBETESTED { get; set; }

        public string TELPHONEOFPRODUCTIONORG { get; set; }

        public string DOCKINGPEOPLE { get; set; }

        public string OTHERCLIENTNAME { get; set; }

        public string OTHERCLIENTCITY { get; set; }

        public string OTHERCLIENTPHONE { get; set; }

        public string OTHERCLIENTCODE { get; set; }

        public string SPECICALACCORDNO { get; set; }

        public string SETTLEMENTMETHOD { get; set; }
    }
}