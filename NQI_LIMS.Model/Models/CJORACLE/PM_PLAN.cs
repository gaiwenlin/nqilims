using System;
using System.Linq;
using System.Text;
using SqlSugar;


namespace NQI_LIMS.Model
{
    ///<summary>
    ///PM_PLAN �����
    ///</summary>
    [SugarTable("PM_PLAN", "CJORACLE")]
    public class PM_PLAN
    {
        public PM_PLAN()
        {
        }
        /// <summary>
        /// ID
        /// </summary>
        [SugarColumn(IsNullable = false, IsPrimaryKey = true, IsIdentity = true)]
        public int ID { get; set; }

        /// <summary>
        /// ������
        /// </summary>
        public string PLAN_CODE { get; set; }

        /// <summary>
        /// �м��������
        /// </summary>
        public string CHECK_COMP { get; set; }

        /// <summary>
        /// ����Ʒ
        /// </summary>
        public string CHECK_GOODS { get; set; }

        /// <summary>
        /// ��������
        /// </summary>
        public string CONTENTS { get; set; }

        /// <summary>
        /// ����״̬(1.δ�´� 2.���´� 3.����ȡ 4.����� 0.�ѳ��� 5.���ϴ�)
        /// </summary>
        public string PLAN_STATE { get; set; }

        /// <summary>
        /// �������ͣ������ϣ�
        /// </summary>
        public string CHECK_KIND { get; set; }

        /// <summary>
        /// ���֪ͨ����
        /// </summary>
        public string NOTICE_TIME { get; set; }
        /// <summary>
        /// �����Ч����
        /// </summary>
        public string EFFECT_TIME { get; set; }
        /// <summary>
        /// ���������
        /// </summary>
        public int BILL_STORE_ID { get; set; }
        /// <summary>
        /// ��ʼ����
        /// </summary>
        public string START_NUM { get; set; }
        /// <summary>
        /// ��ֹ����
        /// </summary>
        public string END_NUM { get; set; }
        /// <summary>
        /// �������
        /// </summary>
        public string CHECK_LOT { get; set; }
        /// <summary>
        /// �ƶ���
        /// </summary>
        public string FILL_USER_ID { get; set; }
        /// <summary>
        /// ��췽ʽ
        /// </summary>
        public string CHECK_TYPE { get; set; }
        /// <summary>
        /// ����ʱ��
        /// </summary>
        public string CREATEDATE { get; set; }
        /// <summary>
        /// ������Դ
        /// </summary>
        public string TASK_SOURCE { get; set; }
        /// <summary>
        /// ʵʩ����
        /// </summary>
        public string TASK_SEASON { get; set; }
        /// <summary>
        /// ��������������
        /// </summary>
        public int ECO_BUY_NUM { get; set; }
        /// <summary>
        /// ������ҵ����������
        /// </summary>
        public int PRO_CHECK_NUM { get; set; }
        /// <summary>
        /// �г�����������
        /// </summary>
        public int STORE_BUY_NUM { get; set; }
        /// <summary>
        /// Ҫ���������
        /// </summary>
        public string FINISH_TIME { get; set; }
        /// <summary>
        /// ʵʩ���
        /// </summary>
        public string TASK_YEAR { get; set; }
        /// <summary>
        /// ����
        /// </summary>
        public string ATTACHMENT_FILES { get; set; }
        /// <summary>
        /// ��ˮ����
        /// </summary>
        public int ORDER_CODE { get; set; }
        /// <summary>
        /// ��������-������ҵ����
        /// 1-ʡ���ල��飻
        /// 2-��Ʒ�������ռ�⣻
        /// 3-ʡ�������ල��飻
        /// 4-ʡ��ר��ල��飻
        /// 5-���������ල��飻
        /// 6-ʡ���ල��飨��Ʒ�������ռ�⣩;
        /// 7-�����ල����������
        /// 08-01�����ڼල���;
        /// 09-02��ʡ��ר��ල���;
        /// 10-03��ʡ�������ල���
        /// </summary>
        public string CHECK_KIND_PRO { get; set; }
        /// <summary>
        /// ��������-��������
        /// 1-ʡ���ල��飻
        /// 2-��Ʒ�������ռ�⣻
        /// 3-ʡ�������ල��飻
        /// 4-ʡ��ר��ල��飻
        /// 5-���������ල��飻
        /// 6-ʡ���ල��飨��Ʒ�������ռ�⣩;
        /// 7-�����ල����������
        /// 08-01�����ڼල���;
        /// 09-02��ʡ��ר��ල���;
        /// 10-03��ʡ�������ල���
        /// </summary>
        public string CHECK_KIND_ECO { get; set; }
        /// <summary>
        /// ��������-�г�����
        /// 1-ʡ���ල��飻
        /// 2-��Ʒ�������ռ�⣻
        /// 3-ʡ�������ල��飻
        /// 4-ʡ��ר��ල��飻
        /// 5-���������ල��飻
        /// 6-ʡ���ල��飨��Ʒ�������ռ�⣩;
        /// 7-�����ල����������
        /// 08-01�����ڼල���;
        /// 09-02��ʡ��ר��ල���;
        /// 10-03��ʡ�������ල���
        /// </summary>
        public string CHECK_KIND_STORE { get; set; }
        /// <summary>
        /// ����ļ�ⲿ�ű��
        /// </summary>
        public string CHECK_DEPTS { get; set; }
        /// <summary>
        /// ����ʼ����
        /// </summary>
        public string TASK_START_TIME { get; set; }
        /// <summary>
        /// �����´�����
        /// </summary>
        public string ALLOC_TIME { get; set; }
        /// <summary>
        /// ��Ʒ�������
        /// </summary>
        public string PRO_CLASS_CODE { get; set; }
        /// <summary>
        /// ��Ʒ����ID
        /// </summary>
        public int CPDL_ID { get; set; }
        /// <summary>
        /// ��Ʒ��������
        /// </summary>
        public string QT_CPDL_NAME { get; set; }
        /// <summary>
        /// ��Ʒ����
        /// </summary>
        public string CPMC_NAME { get; set; }
        /// <summary>
        /// ������Դ������
        /// </summary>
        public int OTHER_NUM { get; set; }
        /// <summary>
        /// ��Ʒ����(����)
        /// </summary>
        public string CPLB_NAME { get; set; }
        /// <summary>
        /// ���ͣ�1����鲢���飻2����飻3����
        /// </summary>
        public string TYPE { get; set; }
        /// <summary>
        /// ����������
        /// </summary>
        public string CCJG_NAME { get; set; }
        /// <summary>
        /// ���ͣ�01����ҵƷ��02������Ʒ
        /// </summary>
        public string PLAN_INFO_SYN_TYPE { get; set; }

        public string UUID { get; set; }

        // public int RN { get; set; }
    }
}