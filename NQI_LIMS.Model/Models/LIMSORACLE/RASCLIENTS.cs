using System;
using System.Linq;
using System.Text;
using SqlSugar;


namespace NQI_LIMS.Model.Models
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable( "RASCLIENTS", "LIMSORACLE")]
    public class RASCLIENTS
    {
        public RASCLIENTS()
        {
        }
        
           public decimal ORIGREC { get; set; }

           public string ORIGSTS { get; set; }

           public string ADRESS_A { get; set; }

           public string CATEGORY { get; set; }

           public string CITY { get; set; }

           public string COMPNAME { get; set; }

           public string COUNTRY { get; set; }

           public string COUNTY { get; set; }

           public string DEFAULTCONTACT { get; set; }

           public string EXTERNALCLIENTID { get; set; }

           public string HL7_ID { get; set; }

           public string POB { get; set; }

           public string PRIMARYFAX { get; set; }

           public string PRIMARYPHONE { get; set; }

           [SugarColumn(IsPrimaryKey=true)]
           public string RASCLIENTID { get; set; }

           public string STATE { get; set; }

           public string UDPARAM0 { get; set; }

           public string UDPARAM1 { get; set; }

           public string UDPARAM2 { get; set; }

           public string UDPARAM3 { get; set; }

           public string UDPARAM4 { get; set; }

           public string URL { get; set; }

           public string VMDPATH { get; set; }

           public string ZIP { get; set; }

           public string OWNER { get; set; }

           public string ADDRESS_ENG { get; set; }

           public string COMPNAME_ENG { get; set; }

           public string SHORTNAME { get; set; }

           public string ADRESS { get; set; }

           public string PHONE { get; set; }

           public string FAX { get; set; }

           public string PRODUCTS { get; set; }

           public string TRADE { get; set; }

           public decimal? NUMEMPLOYEES { get; set; }

           public string COMPCHARACTER { get; set; }

           public string AUTHENTICATION { get; set; }

           public string ITSCLIENTS { get; set; }

           public string SCOPES { get; set; }

           public string SUBSCOPES { get; set; }

           public string EMPLOYEENUM { get; set; }

           public string CERTIFICATION { get; set; }

           public string IMPORTANTINFO { get; set; }

           public string MAINCUSTOMS { get; set; }

           public string COMMENTS { get; set; }

           public string ADDEDBY { get; set; }

           public DateTime? ADDDATE { get; set; }

           public string REGION { get; set; }

           public string BUYER { get; set; }

           public string ROUTE { get; set; }

           public string GROUPCLIENTID { get; set; }

           public string GROUPCOMPNAME { get; set; }

           public string STARDOC_ID { get; set; }

           public string ISHIDE { get; set; }

           public string AGREEMENTCUSTOM { get; set; }

           public string PASSWORD { get; set; }

           public string LOGINNAME { get; set; }

           public decimal? EXTRAPAYDAY { get; set; }

           public DateTime? BIRTHDAY { get; set; }

           public string CLIENTROLE { get; set; }

           public string CLIENTRELATION { get; set; }

           public string FATHERGROUP { get; set; }

           public string ISSHAREREPORT { get; set; }

           public string ISGETREPORTFROMMYLIMS { get; set; }

           public string SPELL { get; set; }

           public string SERVGRP { get; set; }

           public string AREA { get; set; }

           public string YYZZ { get; set; }

           public string JJDM { get; set; }

           public string DISCOUNTTYPE { get; set; }

           public string SIGN { get; set; }

           public string BELONGPEOPLE { get; set; }

           public string BELONGSERVGRP { get; set; }

           public string REGESTERADDRESS { get; set; }

           public string ACTUALADDRESS { get; set; }

           public string IMPLEVEL { get; set; }

           public string SENDTYPE { get; set; }

           public string SALEAREA { get; set; }

           public string PRODUCTTYPT { get; set; }

           public string PAYTYPE { get; set; }

           public string COMPANYTYPE { get; set; }

           public string STATUS { get; set; }

           public string DISUSEREASON { get; set; }

           public string PARENTID { get; set; }

           public string ISPROTOCOL { get; set; }

           public string DISCOUNTSTATUS { get; set; }

           public string DISCOUNTDISSTATUS { get; set; }

           public string TASKREMARK { get; set; }

           public double? ADDPRINTFEE { get; set; }

           public string UNUALFEETYPE { get; set; }

           public double? COPYREPORTFEE { get; set; }

           public string COMPANYENG { get; set; }

           public string REMAINTIME { get; set; }

           public string CANCELEDBY { get; set; }

           public DateTime? CANCELEDDATE { get; set; }

           public string UPDATENAMEHISTORY { get; set; }

           public string SENDSMS1 { get; set; }

           public string SENDSMS2 { get; set; }

           public string SENDSMS3 { get; set; }

           public string ISHAVECONTACT { get; set; }

           public string ADDRESS { get; set; }

           public string SAPCLIENTID { get; set; }

           public string BSNAME { get; set; }

           public double? DISCOUNT { get; set; }

           public string INVOICE_TYPE { get; set; }

           public string INVOICE_TITLE { get; set; }

           public string INVOICE_TAXNO { get; set; }

           public string INVOICE_ADDRESS { get; set; }

           public string INVOICE_PHONE { get; set; }

           public string INVOICE_BANK { get; set; }

           public string INVOICE_BANKACCOUNT { get; set; }

           public string E_MAIL { get; set; }

           public string CREDITLEVEL { get; set; }

           public string ENTRUSTCOMP_MAIL { get; set; }

           public string CLIENTNAME { get; set; }

           public string CLIENTTYPE { get; set; }

           public string RASCLIENTNO { get; set; }

           public string BILLCODE { get; set; }

           public string BALANCE { get; set; }

           public string RECEIPTTYPE { get; set; }

           public double? ACCOUNT_PERIOD { get; set; }

           public string BUSS_CONTACT { get; set; }

           public string BUSS_CONTACTFULL { get; set; }

           public string BUSS_MGR_CONTACT { get; set; }

           public string BUSS_MGR_FULL { get; set; }

           public string INVOICE_COMPANY { get; set; }

           public string PROVINCE { get; set; }

           public string LEGALPERSON { get; set; }

           public string CONTACTPERSON { get; set; }

           public string DEPT { get; set; }

           public string EMAIL { get; set; }

           public string COMPANYNAME { get; set; }

           public string ACCOUNTNAME { get; set; }

           public string TAXCODE { get; set; }

           public string DESPOINAME { get; set; }

           public string ATEL { get; set; }

           public string AADRESS { get; set; }

           public string SCOMPNAME { get; set; }

           public string SCOMPNAME_ENG { get; set; }

           public string SLEGALPERSON { get; set; }

           public string SADRESS { get; set; }

           public string ADDFIRSTLEVEL { get; set; }

           public string ADDSECONDLEVEL { get; set; }

           public string ADDTHIREDLEVEL { get; set; }

           public string SZIP { get; set; }

           public string SCONTACTPERSON { get; set; }

           public string STEL { get; set; }

           public string LICENSE { get; set; }

           public string INSTITUTIONCODE { get; set; }

           public string COMPSCOPE { get; set; }

           public string COMPSCOPEVALUE { get; set; }

           public string ECONOMICTYPE { get; set; }

           public string SACCOUNTNAME { get; set; }

           public string STAXCODE { get; set; }

           public string SDESPOITNAME { get; set; }

           public string SPHONE { get; set; }

           public string QADRESS { get; set; }

           public string ISPUBLIC { get; set; }

           public string STARLIMSDEPT { get; set; }

           public string SACCOUNT { get; set; }

           public DateTime? UPDATE_DATE { get; set; }

           public string OTHERCOMMENTS { get; set; }

           public string ADRESS_ENG { get; set; }

           public string CONTACTPERSON_ENG { get; set; }

           public string ISDISCARD { get; set; }

           public string SALER { get; set; }

           public string ACCOUNT { get; set; }

           public string DISPSTATUS { get; set; }

           public string REJECTSTATUS { get; set; }

           public string INSTITUTIONNAME { get; set; }

           public string PHONE2 { get; set; }

           public string INVOICEUNIT { get; set; }

           public string INVOICETYPE { get; set; }

           public string UNITTAXNO { get; set; }

           public string UNITACCOUNTNO { get; set; }

           public string ACCOUNTHEADER { get; set; }

           public string UNITACCOUNTHEADER { get; set; }

           public string BANKINFORMATION { get; set; }

           public string CELLPHONENUMBER { get; set; }

           public string ZIPCODE { get; set; }

           public string CLIENTLIMIT { get; set; }

           public string DEPTLIST { get; set; }
    }
}