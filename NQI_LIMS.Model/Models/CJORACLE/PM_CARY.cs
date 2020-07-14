using System;
using System.Linq;
using System.Text;
using SqlSugar;


namespace NQI_LIMS.Model.Models
{
    ///<summary>
    ///�ܼ쵥λ��Ϣ
    ///</summary>
    [SugarTable("PM_CARY", "CJORACLE")]
    public class PM_CARY
    {
        public PM_CARY()
        {
        }
        /// <summary>
        /// ID
        /// </summary>
        [SugarColumn(IsNullable = false, IsPrimaryKey = true, IsIdentity = true)]
        public int ID { get; set; }
        /// <summary>
        /// �ܼ쵥λ����
        /// </summary>
        public string CARY_CODE { get; set; }
        /// <summary>
        ///�ܼ쵥λ����
        /// </summary>
        public string CARY_NAME { get; set; }
        /// <summary>
        /// �ܼ쵥λ���˴���
        /// </summary>
        public string CARY_PRESENT { get; set; }
        /// <summary>
        /// �ܼ쵥λͨ�ŵ�ַ
        /// </summary>
        public string CARY_ADDR { get; set; }
        /// <summary>
        /// �ܼ쵥λ�ʱ�
        /// </summary>
        public string CARY_ZIP_CODE { get; set; }
        /// <summary>
        /// �ܼ쵥λ��ϵ��
        /// </summary>
        public string CARY_LINKMAN { get; set; }
        /// <summary>
        /// �ܼ쵥λ��ϵ�绰
        /// </summary>
        public string CARY_TEL { get; set; }
        /// <summary>
        /// �ܼ쵥λ����������ҵ
        /// </summary>
        public int CARY_RELATED_PRO_ID { get; set; }
        /// <summary>
        /// �ܼ쵥λ������
        /// </summary>
        public string CARY_OWNERSHIP { get; set; }
        /// <summary>
        /// ͳһ������ô��루Ӫҵִ��ע��ţ�
        /// </summary>
        public string UNIFIED_SOCIAL_CREDIT_CODE { get; set; }
        /// <summary>
        /// �ܼ쵥λ�����أ�ʡ���룩
        /// </summary>
        public string CARY_PROVINCE { get; set; }
        /// <summary>
        /// �ܼ쵥λ�����أ��б��룩
        /// </summary>
        public string CARY_CITY { get; set; }
        /// <summary>
        /// �ܼ쵥λ�����أ���/�ر��룩
        /// </summary>
        public string CARY_COUNTY { get; set; }
        /// <summary>
        /// ��Ӫ�����ڵأ�1��������2���ǽ���ϲ���3������
        /// </summary>
        public string OPERATOR_LOCATION { get; set; }
        /// <summary>
        /// 
        /// </summary>
       // public string RN { get; set; }
    }
}