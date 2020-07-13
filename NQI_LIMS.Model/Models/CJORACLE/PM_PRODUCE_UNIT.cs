using System;
using System.Linq;
using System.Text;
using SqlSugar;


namespace NQI_LIMS.Model
{
    ///<summary>
    ///������ҵ��Ϣ
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
        /// ������λ����
        /// </summary>
        public string PRO_CODE { get; set; }
        /// <summary>
        /// ������λ����
        /// </summary>
        public string PRO_NAME { get; set; }
        /// <summary>
        /// ������λ������
        /// </summary>
        public string PRO_OWNERSHIP { get; set; }
        /// <summary>
        /// ������λ��ַ
        /// </summary>
        public string PRO_ADDR { get; set; }
        /// <summary>
        /// ������λ�ʱ�
        /// </summary>
        public string PRO_ZIP_CODE { get; set; }
        /// <summary>
        /// ������λ���˴���
        /// </summary>
        public string PRO_PRESENT { get; set; }
        /// <summary>
        /// ������λ��ϵ��
        /// </summary>
        public string PRO_LINKMAN { get; set; }
        /// <summary>
        /// ������λ��ϵ�绰
        /// </summary>
        public string PRO_TEL { get; set; }
        /// <summary>
        /// ������λ�ֻ�
        /// </summary>
        public string PRO_PHONE { get; set; }
        /// <summary>
        /// ������λӪҵִ��(ͳһ������ô���)
        /// </summary>
        public string PRO_BUS_LICENCE { get; set; }
        /// <summary>
        /// ������λ��������
        /// </summary>
        public string PRO_ORGAN_CODE { get; set; }
        /// <summary>
        /// ������λ��ҵ��ģ
        /// </summary>
        public string PRO_SACLE { get; set; }
        /// <summary>
        /// ������������
        /// </summary>
        public string ECO_INSIDE { get; set; }
        /// <summary>
        /// ������λ������֤��ϵ
        /// </summary>
        public string PRO_QUALITY_PASS { get; set; }
        /// <summary>
        /// �������͸۰�̨
        /// </summary>
        public string ECO_HMT { get; set; }
        /// <summary>
        /// ������������
        /// </summary>
        public string ECO_OUTSIDE { get; set; }
        /// <summary>
        /// �������͸���
        /// </summary>
        public string ECO_SINGLE { get; set; }
        /// <summary>
        /// ������λ֤�����
        /// </summary>
        public string PRO_CERT_CODE { get; set; }
        /// <summary>
        /// ������λ��ҵ��ģ����
        /// </summary>
        public string PRO_SACLE_TYPE { get; set; }
        /// <summary>
        /// ��֯��������
        /// </summary>
        public string PRO_ORG_CODE { get; set; }
        /// <summary>
        /// ��������
        /// </summary>
        public string PRO_ORG_NAME { get; set; }
        /// <summary>
        /// ��ҵ���ô���
        /// </summary>
        public string PRO_CREDIT_CODE { get; set; }
        /// <summary>
        /// �Ƿ�Ϊ��ģ������ҵ
        /// </summary>
        public string PRO_IS_SCALE { get; set; }
        /// <summary>
        /// Ʒ�ƽ���
        /// </summary>
        public string PRO_BRAND_BUILDING { get; set; }
        /// <summary>
        /// ��Ʒ�������
        /// </summary>
        public string PRO_CLASS_CODE { get; set; }
        /// <summary>
        /// ������λ�����أ�ʡ���룩
        /// </summary>
        public string PRO_PROVINCE { get; set; }
        /// <summary>
        ///������λ�����أ��б��룩 
        /// </summary>
        public string PRO_CITY { get; set; }
        /// <summary>
        /// ������λ�����أ���/�ر��룩
        /// </summary>
        public string PRO_COUNTY { get; set; }
        /// <summary>
        /// ��Ʒ��������
        /// </summary>
        public string PRO_CPMC_NAME { get; set; }

       // public string RN { get; set; }
    }
}