using System;
using System.Linq;
using System.Text;
using SqlSugar;


namespace NQI_LIMS.Model
{
    ///<summary>
    ///生产企业信息
    ///</summary>
    [SugarTable("PM_PRODUCE_UNIT", "CJORACLE")]
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
        /// <summary>
        /// 生产单位编码
        /// </summary>
        public string PRO_CODE { get; set; }
        /// <summary>
        /// 生产单位名称
        /// </summary>
        public string PRO_NAME { get; set; }
        /// <summary>
        /// 生产单位所属地
        /// </summary>
        public string PRO_OWNERSHIP { get; set; }
        /// <summary>
        /// 生产单位地址
        /// </summary>
        public string PRO_ADDR { get; set; }
        /// <summary>
        /// 生产单位邮编
        /// </summary>
        public string PRO_ZIP_CODE { get; set; }
        /// <summary>
        /// 生产单位法人代表
        /// </summary>
        public string PRO_PRESENT { get; set; }
        /// <summary>
        /// 生产单位联系人
        /// </summary>
        public string PRO_LINKMAN { get; set; }
        /// <summary>
        /// 生产单位联系电话
        /// </summary>
        public string PRO_TEL { get; set; }
        /// <summary>
        /// 生产单位手机
        /// </summary>
        public string PRO_PHONE { get; set; }
        /// <summary>
        /// 生产单位营业执照(统一社会信用代码)
        /// </summary>
        public string PRO_BUS_LICENCE { get; set; }
        /// <summary>
        /// 生产单位机构代码
        /// </summary>
        public string PRO_ORGAN_CODE { get; set; }
        /// <summary>
        /// 生产单位企业规模
        /// </summary>
        public string PRO_SACLE { get; set; }
        /// <summary>
        /// 经济类型内资
        /// </summary>
        public string ECO_INSIDE { get; set; }
        /// <summary>
        /// 生产单位质量认证体系
        /// </summary>
        public string PRO_QUALITY_PASS { get; set; }
        /// <summary>
        /// 经济类型港澳台
        /// </summary>
        public string ECO_HMT { get; set; }
        /// <summary>
        /// 经济类型外资
        /// </summary>
        public string ECO_OUTSIDE { get; set; }
        /// <summary>
        /// 经济类型个体
        /// </summary>
        public string ECO_SINGLE { get; set; }
        /// <summary>
        /// 生产单位证书编码
        /// </summary>
        public string PRO_CERT_CODE { get; set; }
        /// <summary>
        /// 生产单位企业规模类型
        /// </summary>
        public string PRO_SACLE_TYPE { get; set; }
        /// <summary>
        /// 组织机构代码
        /// </summary>
        public string PRO_ORG_CODE { get; set; }
        /// <summary>
        /// 机构名称
        /// </summary>
        public string PRO_ORG_NAME { get; set; }
        /// <summary>
        /// 企业信用代码
        /// </summary>
        public string PRO_CREDIT_CODE { get; set; }
        /// <summary>
        /// 是否为规模以上企业
        /// </summary>
        public string PRO_IS_SCALE { get; set; }
        /// <summary>
        /// 品牌建设
        /// </summary>
        public string PRO_BRAND_BUILDING { get; set; }
        /// <summary>
        /// 产品分类代码
        /// </summary>
        public string PRO_CLASS_CODE { get; set; }
        /// <summary>
        /// 生产单位所属地（省编码）
        /// </summary>
        public string PRO_PROVINCE { get; set; }
        /// <summary>
        ///生产单位所属地（市编码） 
        /// </summary>
        public string PRO_CITY { get; set; }
        /// <summary>
        /// 生产单位所属地（区/县编码）
        /// </summary>
        public string PRO_COUNTY { get; set; }
        /// <summary>
        /// 产品分类名称
        /// </summary>
        public string PRO_CPMC_NAME { get; set; }

       // public string RN { get; set; }
    }
}