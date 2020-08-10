using System;
using System.Linq;
using System.Text;
using SqlSugar;


namespace NQI_LIMS.Model.Models
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("PREORDERS", "LIMSORACLE")]
    public class PREORDERS
    {
        public PREORDERS()
        {
        }

        public decimal ORIGREC { get; set; }

        public string ORIGSTS { get; set; }

        [SugarColumn(IsPrimaryKey = true)]
        public string PREORDNO { get; set; }

        public string FOLDERNO { get; set; }

        public string STATUS { get; set; }

        public string CCCCERTIFICATION { get; set; }

        public string SAMPLETYPEOFCCC { get; set; }

        public string STORAGELOCATIONOFPREPARE { get; set; }

        public string NUMBEROFPREPARE { get; set; }

        public string REMARKS { get; set; }

        public string PRODUCTORCOMMODITY { get; set; }

        public string PRODUCTCATEGORY { get; set; }

        public string PRODUCTID { get; set; }

        public string SAMPLETYPE { get; set; }

        public string SAMPLINGWAY { get; set; }

        public DateTime? SAMPLINGTIME { get; set; }

        public string SAMPLINGPLACE { get; set; }

        public string SAMPLINGPERSON { get; set; }

        public decimal? RESULTOFSPOTCHECK { get; set; }

        public string SAMPLINGMETHOD { get; set; }

        public string SAMPLINGRADIX { get; set; }

        public DateTime? CHECKSTHEDATEOFTERMINATION { get; set; }

        public DateTime? CHECKSSTARTDATE { get; set; }

        public string PERSONOFSEALINGSAMPLE { get; set; }

        public string DESCRIPTIONFORPACKAGE { get; set; }

        public string CHECKFORPACKAGE { get; set; }

        public decimal? SMSNOTIFICATION { get; set; }

        public string ADDRESSOFENGINEERING { get; set; }

        public string CATEGORYOFENGINEERING { get; set; }

        public string NAMEOFENGINEERING { get; set; }

        public string COSTSOFENGINEERING { get; set; }

        public string INDUSTRIALPRODUCTLICENSE { get; set; }

        public string TESTORG { get; set; }

        public decimal? TESTCOSTSFORSAMPLE { get; set; }

        public string TESTITEM { get; set; }

        public string TESTBASIS { get; set; }

        public string ENDDATEOFENGINEERING { get; set; }

        public string BEGINDATEOFENGINEERING { get; set; }

        public string TAKEREPORTMETHOD { get; set; }

        public string OTHERCERTIFICATION { get; set; }

        public string TRADEMARK { get; set; }

        public string TESTDEPARTMENT { get; set; }

        public string TESTDEPARTMENTCODE { get; set; }

        public string FOODPRODUCTIONLICENSE { get; set; }

        public string NETAREAOFENGINEERING { get; set; }

        public string REGFORMDETECTIONFORSPOTCHECK { get; set; }

        public string ADJUSTMENTPERSON { get; set; }

        public decimal? ADJUSTMENTDAYS { get; set; }

        public DateTime? RECEIVEDATE { get; set; }

        public string DESCRIPTIONFORREPORT { get; set; }

        public string STORAGEMETHOD { get; set; }

        public string TREATMENTFORSAMPLE { get; set; }

        public DateTime? ARRIVDATEFORSAMPLE { get; set; }

        public string SAMPLEGRADE { get; set; }

        public string SPECMODEL { get; set; }

        public string SAMPLEDESC { get; set; }

        public string SAMPLENAME { get; set; }

        public DateTime? STORAGEDATE { get; set; }

        public string PRODUCTIONDATE { get; set; }

        public string TOTALQUANTITY { get; set; }

        public string SAMPLESTATE { get; set; }

        public string SAMPLESTATEAFTERINSPECT { get; set; }

        public DateTime? DISCUSSCOMPLETIONDATE { get; set; }

        public DateTime? REQUIREDCOMPLETIONDATE { get; set; }

        public string TASKTYPE { get; set; }

        public string QUALITYJUDGMENT { get; set; }

        public string QUALIFICATIONSFORDEPARTMENT { get; set; }

        public decimal? ISNOTICED { get; set; }

        public string TESTERUSENAME { get; set; }

        public string TESTER { get; set; }

        public DateTime? CREATETIME { get; set; }

        public DateTime? ASSIGNDATE { get; set; }

        public string DEPT { get; set; }

        public string DIVISIONCODE { get; set; }

        public string ISRETURNSAMPLE { get; set; }

        public string ISEMERGENCY { get; set; }

        public DateTime? SAMPLEEXPIREDATE { get; set; }

        public string MAJORUSRNAM { get; set; }

        public string REJECTSTS { get; set; }

        public string PAYSTS { get; set; }

        public string DISPSTS { get; set; }

        public DateTime? LOGDATE { get; set; }

        public string SAMPLE_TEMPLATEID { get; set; }

        public string LOCATION { get; set; }

        public string ISMAKESAMPLE { get; set; }

        public decimal? MAKENUM { get; set; }

        public string CONTAINERID { get; set; }

        public string SERVGRP { get; set; }

        public string CRMCODE { get; set; }

        public string ISADD_G { get; set; }

        public string SP_NAME { get; set; }

        public string SP_CODE { get; set; }

        public string GROUPNAME { get; set; }

        public string GROUPCODE { get; set; }

        public string GDSPCODE { get; set; }

        public string SPECNO { get; set; }

        public string SAMPLEPRICE { get; set; }

        public string SPECNAME { get; set; }

        public string DRAWNO { get; set; }

        public string DRAWNAME { get; set; }

        public string JUDGE_STS { get; set; }

        public string OTHERSPECNAME { get; set; }

        public byte[] LABEL_PIC { get; set; }

        public string INVOICEISSUEMETHOD { get; set; }

        public string SAMPLINGPOSITION { get; set; }

        public string ENGMATERIALREPORTTEMPLATE { get; set; }

        public string INSPECTIONMATERIAL { get; set; }

        public string APPRAISALDATUM { get; set; }

        public string AUTHENTICATIONCELL { get; set; }

        public string SAMPLESEEDER { get; set; }

        public string PRODUCTIONSERIALNUMBER { get; set; }

        public string SAMPLESEALMODE { get; set; }

        public string SEALPART { get; set; }

        public string HEALTHFOODFUNCCATE { get; set; }

        public string HEALTHFOODAPPROVALNUM { get; set; }

        public string HEALTHFOODSHEIFLIFE { get; set; }

        public string OTHERQUALIFICATIONNUM { get; set; }

        public string CCCCERTIFICATENUM { get; set; }

        public string PURCHASEPRICE { get; set; }

        public string PURCHASEAMOUNT { get; set; }

        public string SALEUNITPRICE { get; set; }

        public string SALEAMOUNT { get; set; }

        public string OPERATORSEAT { get; set; }

        public string SAMPLESITE { get; set; }

        public string STOCKAMOUNT { get; set; }

        public string STOCKLOCATION { get; set; }

        public DateTime? FINISHSTORAGEDATE { get; set; }

        public string SAMPLETEAM { get; set; }

        public string SAMPLEPARAMETERS { get; set; }

        public string SAMPLEGENRE { get; set; }

        public string SAMPLESHAPE { get; set; }

        public string PACKAGINGCLASSIFICATION { get; set; }

        public string STORAGECONDITIONS { get; set; }

        public string PRODUCTIONTACHE { get; set; }

        public string CIRCULATIONTACHE { get; set; }

        public string RESTAURANTTACHE { get; set; }

        public string DATETYPE { get; set; }

        public string PRODUCTCERTIFICATION { get; set; }

        public string SAMPLINGPACKAGE { get; set; }

        public string TAKESAMPLINGPERSON { get; set; }

        public string SAMPLINGDATE { get; set; }

        public decimal? STORAGECONDITION { get; set; }

        public decimal? OTHERSAMPLETYPE { get; set; }

        public decimal? OTHERRESTAURANTTACHE { get; set; }

        public decimal? OTHERCIRCULATIONTACHE { get; set; }

        public decimal? STRIPNUMBERANDSUM { get; set; }

        public string NUMBEROFSAMPLES { get; set; }

        public string SAMPLELOTNUMBER { get; set; }

        public string SAMPLINGPRODUCTIMPLEMENTATION { get; set; }

        public string ACCESSORIESORDATA { get; set; }

        public string SAMPLERETENTIONTIME { get; set; }

        public string SAMPLEDELIVERYMODE { get; set; }

        public DateTime? SENDSAMPLEDELIVERYDATE { get; set; }

        public string SENDSAMPLEADDRESS { get; set; }

        public string EXPORTPRODUCTS { get; set; }

        public string SAMPLECLASS { get; set; }

        public string APPEARANCE { get; set; }

        public string REPORTRECYCLE { get; set; }

        public string CHANGESTATUS { get; set; }

        public string INSPECTPRODUCTTYPE { get; set; }

        public string INSPECTPRODUCTNAME { get; set; }

        public string CCCPREORDNO { get; set; }
        /// <summary>
        /// 抽样编号或其他编号
        /// </summary>
        public string SELFNUMBER { get; set; }

        public string PRODUCTUNIT { get; set; }

        public string SPECIALSIGN { get; set; }

        public string ELECTRONICSEAL { get; set; }

        public DateTime? FINISHDATE { get; set; }

        public string PREORDERCANCELBYUSRNAM { get; set; }

        public string PREORDERCANCELBYFULLNAME { get; set; }

        public string PRDIUCTTYPE { get; set; }

        public decimal? DISCOUNT { get; set; }

        public string INVOICENUMBER { get; set; }

        public decimal? REALPAY { get; set; }

        public string REBATE { get; set; }

        public decimal? PRINTNUM { get; set; }

        public decimal? AMOUNTRECEIVABLE { get; set; }

        public byte[] LABLEPIC { get; set; }

        public string SAMPLESTORAGESTATUS { get; set; }

        public string ZHENGSHUNO { get; set; }

        public string SAMPLENATURE { get; set; }

        public string PACKAGINGCLASS { get; set; }

        public decimal? SIGNPRICE { get; set; }

        public decimal? TOTALPRICE { get; set; }

        public string ISADD_FG { get; set; }

        public string ALLOTTYPE { get; set; }

        public decimal? PRINTBYNUMS { get; set; }

        public decimal? PRINTJYNUMS { get; set; }

        public string BYDETAILLOCATION { get; set; }

        public string ISNEEDCOVERING { get; set; }
        /// <summary>
        /// 测试周期
        /// </summary>
        public decimal? TESTPERIOD { get; set; }

        public string PRECANCEL_STATUS { get; set; }

        public string PRECANCEL_DISPSTS { get; set; }

        public string PRECANCEL_COMMENTS { get; set; }

        public string PRECANCELOFSTATUS { get; set; }

        public string PRECANCELOFDISPSTS { get; set; }

        public string BATCHNUM { get; set; }

        public string ITYEWURECORD { get; set; }

        public string JIANCETEST { get; set; }

        public string PRODUCTCODE { get; set; }

        public DateTime? SAMPLESAVEDATE { get; set; }

        public string REPORTNUM { get; set; }

        public string PREORDERSISJIAGONG { get; set; }

        public string JIAGONGUNITNAME { get; set; }

        public string BACKSAMPLETYPE { get; set; }

        public string CONSUMEAMOUNT { get; set; }

        public string REMAINAMOUNT { get; set; }

        public string REPORTRESULT { get; set; }

        public string REPORTASSE { get; set; }

        public string FIRSTLEVEL { get; set; }

        public string SECONDLEVEL { get; set; }

        public string THIRDLEVEL { get; set; }

        public string FOURTHLEVEL { get; set; }

        public DateTime? ISSUEDATE { get; set; }

        public string SAMPLEBATCH { get; set; }

        public string RECEIPTPEOPLE { get; set; }

        public string RECEIPTEMAIL { get; set; }

        public string RECEIPTPHONE { get; set; }

        public string RECEIPUNIT { get; set; }

        public string RECEITADDRESS { get; set; }

        public DateTime? YWSLRQ { get; set; }

        public DateTime? HTPSRQ { get; set; }

        public string PREMODIFY_STATUS { get; set; }

        public string PREMODIFY_DISPSTS { get; set; }

        public string FEENOTE { get; set; }

        public string ANNOTATIONIMPLEMENTATION { get; set; }

        public string HTPSUSRNAM { get; set; }

        public decimal? REALPAY2 { get; set; }

        public decimal? NOFEES { get; set; }
    }
}