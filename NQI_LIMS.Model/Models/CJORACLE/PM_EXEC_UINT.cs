using System;
using System.Linq;
using System.Text;
using SqlSugar;


namespace NQI_LIMS.Model
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("PM_EXEC_UINT", "CJORACLE")]
    public class PM_EXEC_UINT
    {
        public PM_EXEC_UINT()
        {

        }
        /// <summary>
        /// ID
        /// </summary>
        [SugarColumn(IsNullable = false, IsPrimaryKey = true, IsIdentity = true)]
        public int ID { get; set; }
        /// <summary>
        /// 抽样单位编码
        /// </summary>
        public string EXEC_CODE { get; set; }
        /// <summary>
        /// 抽样单位名称
        /// </summary>
        public string EXEC_NAME { get; set; }
        /// <summary>
        /// 抽样单位地址
        /// </summary>
        public string EXEC_ADDR { get; set; }
        /// <summary>
        /// 抽样单位邮编
        /// </summary>
        public string EXEC_ZIP_CODE { get; set; }
        /// <summary>
        /// 抽样单位联系人
        /// </summary>
        public string EXEC_LINKMAN { get; set; }
        /// <summary>
        /// 抽样单位联系电话
        /// </summary>
        public string EXEC_TEL { get; set; }
        /// <summary>
        /// 抽样单位传真
        /// </summary>
        public string EXEC_FAX { get; set; }
        /// <summary>
        /// 
        /// </summary>
         //  public string RN { get; set; }
    }
}