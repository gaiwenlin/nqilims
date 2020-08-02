using System;
using System.Linq;
using System.Text;
using SqlSugar;


namespace NQI_LIMS.Model
{
    ///<summary>
    ///������Ϣ
    ///</summary>
    [SugarTable( "PM_EC_PLATFORM", "CJORACLE")]
    public class PM_EC_PLATFORM
    {
        public PM_EC_PLATFORM()
        {
        }
        /// <summary>
        /// ����id
        /// </summary>
        [SugarColumn(IsNullable = false, IsPrimaryKey = true, IsIdentity = true)]
        public int EC_ID { get; set; }
        /// <summary>
        /// ��������
        /// </summary>
        public string ONLINE_STORE_NAME { get; set; }
        /// <summary>
        /// ����ͨѶ��ַ
        /// </summary>
        public string ONLINE_STORE_ADDR { get; set; }
        /// <summary>
        /// ����Ӫҵע����
        /// </summary>
        public string ONLINE_STORE_POLL_CODE { get; set; }
        /// <summary>
        /// ������ϵ��ʽ
        /// </summary>
        public string ONLINE_STORE_CONTACT { get; set; }
        /// <summary>
        /// ������ַ����
        /// </summary>
        public string ONLINE_STORE_LINK { get; set; }
        /// <summary>
        /// ����ƽ̨����
        /// </summary>
        public string EC_PLATFORM_NAME { get; set; }
        /// <summary>
        /// 
        /// </summary>
           public string EC_PLATFORM_LINK { get; set; }
        /// <summary>
        /// 
        /// </summary>
           public string ONLINE_ORDER_CODE { get; set; }
        /// <summary>
        /// ��Ʒ��ַ���ӣ�����ƷΨһʶ��ţ�
        /// </summary>
        public string LINKS_WEB_SITES { get; set; }
        /// <summary>
        /// ����������
        /// </summary>
        public string ONLINE_OWNERSHIP { get; set; }
        /// <summary>
        /// ƽ̨������
        /// </summary>
        public string EC_PLATFORM_OWNERSHIP { get; set; }
        /// <summary>
        /// ƽ̨�����أ�ʡ���룩
        /// </summary>
        public string EC_PLATFORM_PROVINCE { get; set; }
        /// <summary>
        /// ƽ̨�����أ��б��룩
        /// </summary>
        public string EC_PLATFORM_CITY { get; set; }
        /// <summary>
        /// ƽ̨�����أ���/�ر��룩
        /// </summary>
        public string EC_PLATFORM_COUNTY { get; set; }
        /// <summary>
        /// ���������أ�ʡ���룩
        /// </summary>
        public string ONLINE_PROVINCE { get; set; }
        /// <summary>
        /// ���������أ��б��룩
        /// </summary>
        public string ONLINE_CITY { get; set; }
        /// <summary>
        /// ���������أ���/�ر��룩
        /// </summary>
        public string ONLINE_COUNTY { get; set; }
        /// <summary>
        /// ��������
        /// </summary>
        public string ONLINE_TYPE { get; set; }

         //  public string RN { get; set; }
    }
}