using System;
using System.Linq;
using System.Text;
using SqlSugar;


namespace NQI_LIMS.Model
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable( "PM_OTHER", "CJORACLE")]
    public class PM_OTHER
    {
        public PM_OTHER()
        {
        }
        /// <summary>
        /// ID
        /// </summary>
        [SugarColumn(IsNullable = false, IsPrimaryKey = true, IsIdentity = true)]
        public int ID { get; set; }
        /// <summary>
        /// ������Դ��λ����
        /// </summary>
        public string OTHER_CODE { get; set; }
        /// <summary>
        /// ������Դ��λ����
        /// </summary>
        public string OTHER_NAME { get; set; }
        /// <summary>
        /// ������Դ��λ���˴���
        /// </summary>
        public string OTHER_PRESENT { get; set; }
        /// <summary>
        /// ������Դ��λͨ�ŵ�ַ
        /// </summary>
        public string OTHER_ADDR { get; set; }
        /// <summary>
        /// ������Դ��λ�ʱ�
        /// </summary>
        public string OTHER_ZIP_CODE { get; set; }
        /// <summary>
        /// ������Դ��λ��ϵ��
        /// </summary>
        public string OTHER_LINKMAN { get; set; }
        /// <summary>
        /// ������Դ��λ��ϵ�绰
        /// </summary>
        public string OTHER_TEL { get; set; }
        /// <summary>
        /// ͳһ������ô��루Ӫҵִ��ע��ţ�
        /// </summary>
        public string OTHER_UNIFIED_SOCIAL_CREDIT { get; set; }
        /// <summary>
        /// 
        /// </summary>
          // public string RN { get; set; }
    }
}