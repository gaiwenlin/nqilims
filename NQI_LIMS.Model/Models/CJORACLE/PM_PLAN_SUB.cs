using System;
using System.Linq;
using System.Text;
using SqlSugar;


namespace NQI_LIMS.Model
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("PM_PLAN_SUB", "CJORACLE")]
    public class PM_PLAN_SUB
    {
        public PM_PLAN_SUB()
        {
        }
        /// <summary>
        /// ID
        /// </summary>
        [SugarColumn(IsNullable = false, IsPrimaryKey = true, IsIdentity = true)]
        public int ID { get; set; }
        /// <summary>
        /// ���ݱ��
        /// </summary>
        public string BILL_CODE { get; set; }
        /// <summary>
        /// ������
        /// </summary>
        public string PLAN_CODE { get; set; }
        /// <summary>
        /// ������κ�
        /// </summary>
        public string LOT_NUM { get; set; }
        /// <summary>
        /// �������� 
        /// 08��ʡ���ල��飻
        /// 09��ʡ��ר��ල��飻
        /// 10��ʡ�������ල��飻
        /// 11��ʡ����Ʒ�������ռ��
        /// </summary>
        public string TASK_KIND { get; set; }
        /// <summary>
        /// �ֻ���ѡ���ִ�����ͣ�
        /// 1������������
        /// 2���ܾ�������
        /// 3���޷�������
        /// 4����Ʒ�ͳ�����
        /// 5���г�������
        /// 6��������Դ��
        /// </summary>
        public string CHECK_STATE { get; set; }

        /// <summary>
        /// �������
        /// </summary>
        public int GRUOP_ID_TEMP { get; set; }

        /// <summary>
        /// �ܼ쵥λ���
        /// </summary>
        public int CARY_ID { get; set; }
        /// <summary>
        /// ������λ���
        /// </summary>
        public int PRO_ID { get; set; }
        /// <summary>
        /// �ܼ��Ʒ���
        /// </summary>
        public int GOODS_ID { get; set; }
        /// <summary>
        /// �ܼ��Ʒ����ͺ�
        /// </summary>
        public string GOODS_SCALE { get; set; }
        /// <summary>
        /// �ܼ��Ʒ��������
        /// </summary>
        public string GOODS_PRO_TIME_TEMP { get; set; }
        /// <summary>
        /// �ܼ��Ʒ��������
        /// </summary>
        public string GOODS_PRO_LOT { get; set; }
        /// <summary>
        /// �ܼ��Ʒ��������
        /// </summary>
        public string GOODS_CHECK_NUM { get; set; }
        /// <summary>
        /// �ܼ��Ʒ������
        /// </summary>
        public string GOODS_COPY_NUM { get; set; }
        /// <summary>
        /// �ܼ��Ʒ�������ص�
        /// </summary>
        public string GOODS_COPY_LOCAL { get; set; }
        /// <summary>
        /// �ܼ��Ʒ��������
        /// </summary>
        public string GOODS_BASE_NUM { get; set; }
        /// <summary>
        /// �ܼ��Ʒ��������
        /// </summary>
        public string GOODS_CHECK_TIME { get; set; }
        /// <summary>
        /// �ܼ��Ʒ�����ص�
        /// </summary>
        public string GOODS_CHECK_LOCAL { get; set; }
        /// <summary>
        /// �ܼ��Ʒ����״̬
        /// </summary>
        public string GOODS_SEAL_STATE { get; set; }
        /// <summary>
        /// �ܼ��Ʒ�Ƿ�ϸ����
        /// </summary>
        public string GOODS_CAN_SALE { get; set; }
        /// <summary>
        /// �����Ʒ�������۶�
        /// </summary>
        public string LAST_YEAR_SALE { get; set; }
        /// <summary>
        /// ������λ���
        /// </summary>
        public int EXEC_ID { get; set; }
        /// <summary>
        /// ��ע
        /// </summary>
        public string REMARKS { get; set; }
        /// <summary>
        /// ����ʱ��
        /// </summary>
        public DateTime CREATEDATE { get; set; }
        /// <summary>
        /// �ܼ��Ʒ��������
        /// </summary>
        public string GOODS_CHECK_LOT { get; set; }
        /// <summary>
        /// �������״̬
        /// 0:������Ա���ϴ�  
        /// 1:������Ա���ϴ� 
        /// 2:������Ϣ�ϴ���Ƭδ�ϴ�
        /// 3:������Ϣ�ϴ���Ƭ���ϴ� 
        /// 4:���ύ���ύʡ��˾��
        /// 5:�ύ���� 
        /// 6:����ͨ�� 
        /// 7:���� 
        /// 9:ɾ��
        /// </summary>
        public string STATE { get; set; }
        /// <summary>
        /// ͼƬ����group_id��PC�˵Ĳ�Ʒ��Ϣ��ͼ��ӦAPP�����д����ͼ��
        /// </summary>
        public string IMG_GROUP_ID { get; set; }
        /// <summary>
        /// ��Ƶ����group_id
        /// </summary>
        public string VID_GROUP_ID { get; set; }
        /// <summary>
        /// �ܼ��Ʒ�������ص�
        /// </summary>
        public string GOODS_SEND_LOCAL { get; set; }
        /// <summary>
        /// �ܼ��Ʒ��������ֹ����
        /// </summary>
        public string GOODS_SEND_TIME { get; set; }
        /// <summary>
        /// ��췽ʽ 
        /// 1:�ֳ�����
        /// 2:�г�����
        /// 3���������� 
        /// 4��������Դ
        /// </summary>
        public string CHECK_TYPE { get; set; }
        /// <summary>
        /// �ܼ��Ʒ������
        /// </summary>
        public string GOODS_CHECK_LEVEL { get; set; }
        /// <summary>
        /// �ܼ��Ʒ֤����
        /// </summary>
        public string GOODS_CERT_CODE { get; set; }
        /// <summary>
        /// �ܼ��Ʒ����
        /// </summary>
        public string GOODS_NAME { get; set; }
        /// <summary>
        /// �ܼ��Ʒ�̱�
        /// </summary>
        public string GOODS_BRAND { get; set; }
        /// <summary>
        /// �ܼ��Ʒ�Ƿ����
        /// </summary>
        public string GOODS_EXPORT { get; set; }
        /// <summary>
        /// �ܼ��Ʒִ�б�׼
        /// </summary>
        public string GOODS_STANDARD { get; set; }
        /// <summary>
        /// �ܼ��Ʒ�ȼ�
        /// </summary>
        public string GOODS_LEVEL { get; set; }
        /// <summary>
        /// ��������
        /// </summary>
        public string SAMPLE_STEP { get; set; }
        /// <summary>
        /// ������������˵��
        /// </summary>
        public string SAMPLE_STEP_OTHER { get; set; }
        /// <summary>
        /// ����ƽ̨���
        /// </summary>
        public int EC_ID { get; set; }
        /// <summary>
        /// ��Ʊ��
        /// </summary>
        public string INVOICE_CODE { get; set; }
        /// <summary>
        /// ��Ʊ��λ
        /// </summary>
        public string INVOICE_UNIT { get; set; }
        /// <summary>
        /// ���۵���(Ԫ)
        /// </summary>
        public string SALE_PRICE { get; set; }
        /// <summary>
        ///��ʾ������ŵ 
        /// </summary>
        public string QUALITY_PROMISE { get; set; }
        /// <summary>
        /// �м����
        /// </summary>
        public string CHECK_COMP { get; set; }
        /// <summary>
        /// ���id
        /// </summary>
        public string FILL_USER_ID { get; set; }
        /// <summary>
        /// �ܼ���ʵ�϶�
        /// </summary>
        public string REFUSE_DESCRIPTION { get; set; }
        /// <summary>
        /// δ����ԭ��������
        /// </summary>
        public string NON_FOUND_EXPLANATION { get; set; }
        /// <summary>
        /// δ����ԭ��
        /// </summary>
        public string NON_FOUND_CODE { get; set; }
        /// <summary>
        /// ���������
        /// </summary>
        public string CHECK_CODE { get; set; }
        /// <summary>
        /// ��ݵ���
        /// </summary>
        public string DELIVERY_ID { get; set; }
        /// <summary>
        /// δ����ִ����
        /// </summary>
        public string NON_FOUND_CHECK_PERSON { get; set; }
        /// <summary>
        /// δ������ҵ����
        /// </summary>
        public string NON_FOUND_COMPANY_NAME { get; set; }
        /// <summary>
        /// ����ID
        /// </summary>
        public string PROCESS_ID { get; set; }
        /// <summary>
        /// ���̸���
        /// </summary>
        public string PROCESS_FILES { get; set; }
        /// <summary>
        /// �����޸����������϶���
        /// </summary>
        public string RES_VALUE { get; set; }
        /// <summary>
        /// �����޸����������϶�˵��
        /// </summary>
        public string RES_DES { get; set; }
        /// <summary>
        /// ���鱨���ݹ�˾
        /// </summary>
        public string DEL_COMP_SHEET { get; set; }
        /// <summary>
        /// ���鱨���ݵ���
        /// </summary>
        public string DELIVERY_ID_SHEET { get; set; }
        /// <summary>
        /// ��Ʒ��ݹ�˾
        /// </summary>
        public string DEL_COMP_SAMPLE { get; set; }
        /// <summary>
        /// �ܼ��Ʒ��������
        /// </summary>
        public string GOODS_PRO_LIMIT { get; set; }
        /// <summary>
        /// �������
        /// </summary>
        public string GRUOP_ID { get; set; }
        /// <summary>
        /// �ܼ��Ʒ��������
        /// </summary>
        public string GOODS_PRO_TIME { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string PRO_BRAND_BUILDING { get; set; }
        /// <summary>
        /// ��Ʒ�������
        /// </summary>
        public string PRO_CLASS_CODE { get; set; }
        /// <summary>
        /// ����������Ҫ��
        /// </summary>
        public string GOODS_PROTECTION_REQ { get; set; }
        /// <summary>
        /// ���۵���
        /// </summary>
        public string GOODS_UNIT_PRICE { get; set; }
        /// <summary>
        /// ���۵���
        /// </summary>
        public string GOODS_SALE_AREA { get; set; }
        /// <summary>
        /// ���۷�ʽ
        /// </summary>
        public string GOODS_SALE_MODE { get; set; }
        /// <summary>
        /// �Ƿ�ί�мӹ�
        /// </summary>
        public string GOODS_MAN_CONSIGNMENT { get; set; }
        /// <summary>
        /// ί�мӹ���ҵ����
        /// </summary>
        public string GOODS_CONSIGN_ENTERPRISE { get; set; }
        /// <summary>
        /// �Ƿ���Ҫ����
        /// </summary>
        public string GOODS_NEEDS_RETREAT { get; set; }
        /// <summary>
        /// ������ʽ
        /// </summary>
        public string GOODS_RETREAT_MODE { get; set; }
        /// <summary>
        /// ���ǩ��״̬ 1��δǩ�գ�2����ǩ�գ�3���ѷ���
        /// </summary>
        public string DELIVERY_RECEIPT_STATE { get; set; }
        /// <summary>
        /// ��ݽ�ͼ����
        /// </summary>
        public string IMG_DELIVERY_GROUP_ID { get; set; }
        /// <summary>
        /// ��Ʒ״̬
        /// </summary>
        public string GOODS_STATE { get; set; }
        /// <summary>
        /// ��������״̬
        /// </summary>
        public string GOODS_COPY_STATE { get; set; }
        /// <summary>
        /// ��ͼ����1��PC�˶������׼�¼��������Ϣ��ͼ��
        /// </summary>
        public string IMG_101_GROUP_ID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string IMG_102_GROUP_ID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string IMG_103_GROUP_ID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string IMG_104_GROUP_ID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string IMG_105_GROUP_ID { get; set; }
        /// <summary>
        /// ������ҵ����
        /// </summary>
        public string MANUFACTURER { get; set; }
        /// <summary>
        /// ��Ʒ��ַ���ӣ�����ƷΨһʶ��ţ�
        /// </summary>
        public string LINKS_WEB_SITES { get; set; }
        /// <summary>
        /// ��Ʒ��������
        /// </summary>
        public string ONLINE_ORDER_CODE { get; set; }
        /// <summary>
        /// ������ҵ���Ʊ�ţ�ȡ����ϵͳ������ҵ���Ʊ�ţ�
        /// </summary>
        public string MANUFACTURER_ID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string IMG_106_GROUP_ID { get; set; }
        /// <summary>
        /// �Ƿ�����徻��
        /// </summary>
        public string OIL_IS_DETERGENT { get; set; }
        /// <summary>
        /// ���һ����Ʒ��������
        /// </summary>
        public string OIL_INTAKE_DATE { get; set; }
        /// <summary>
        /// ǰ��������
        /// </summary>
        public string OIL_LAST_ALLOWANCE { get; set; }
        /// <summary>
        /// �����ص�
        /// </summary>
        public string OIL_SAMPLING_SITE { get; set; }
        /// <summary>
        /// ���������
        /// </summary>
        public string OIL_LASTYEAR_QUANTITY { get; set; }
        /// <summary>
        /// �ܼ쵥λ�ܹ�����
        /// </summary>
        public string OIL_TOTAL_CAPACITY { get; set; }
        /// <summary>
        /// ʹ�õ�λID
        /// </summary>
        public int USE_COMPANY_ID { get; set; }
        /// <summary>
        /// ʵ������
        /// </summary>
        public string CARY_CLASSIFICATION { get; set; }
        /// <summary>
        /// ��Ʒ����/�����
        /// </summary>
        public string PRO_JH_KC { get; set; }
        /// <summary>
        /// ͳһ���ô���
        /// </summary>
        public string UNIFIED_CREDIT_CODE { get; set; }
        /// <summary>
        /// ������
        /// </summary>
        public string PLACE_OF_DELIVERY { get; set; }
        /// <summary>
        /// �����أ�ʡ���룩
        /// </summary>
        public string PLACE_OF_DELIVERY_PROVINCE { get; set; }
        /// <summary>
        /// �����أ��б��룩
        /// </summary>
        public string PLACE_OF_DELIVERY_CITY { get; set; }
        /// <summary>
        /// ������Դ��λ����
        /// </summary>
        public int OTHER_ID { get; set; }
        /// <summary>
        /// ��������ͬ��״̬
        /// </summary>
        public string PM_TB_STATE { get; set; }
        /// <summary>
        /// ȷ�����ӡ����
        /// </summary>
        public string DATE_OF_PRINTING { get; set; }
        /// <summary>
        /// ������ҵ����ժҪ
        /// </summary>
        public string PRO_ABSTRACT { get; set; }

        //public string RN { get; set; }
    }
}