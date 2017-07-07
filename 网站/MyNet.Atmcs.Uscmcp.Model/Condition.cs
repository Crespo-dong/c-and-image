using System;

namespace MyNet.Atmcs.Uscmcp.Model
{
    [Serializable]
    /// <summary>
    /// ��ѯʵ��
    /// </summary>
    public class Condition
    {
        private string startTime = "";

        /// <summary>
        /// ���ٶ�
        /// </summary>
        public string Dsd
        {
            get;
            set;
        }

        private string zdmb = "0";

        public string Zdmb
        {
            get { return zdmb; }
            set { zdmb = value; }
        }

        /// <summary>
        /// ���ٶ�
        /// </summary>
        public string Gsd
        {
            get;
            set;
        }

        /// <summary>
        /// �̳���
        /// </summary>
        public string Dcc
        {
            get;
            set;
        }

        /// <summary>
        /// ������
        /// </summary>
        public string Ccc
        {
            get;
            set;
        }

        /// <summary>
        /// ��ʼʱ��
        /// </summary>
        public string StartTime
        {
            get { return startTime; }
            set { startTime = value; }
        }

        private string endTime = "";

        /// <summary>
        ///����ʱ��
        /// </summary>
        public string EndTime
        {
            get { return endTime; }
            set { endTime = value; }
        }

        private string hphm = "";

        /// <summary>
        /// ���ƺ���
        /// </summary>
        public string Hphm
        {
            get { return hphm; }
            set { hphm = value; }
        }

        private string sqjc = "";

        /// <summary>
        ///ʡ�����
        /// </summary>
        public string Sqjc
        {
            get { return sqjc; }
            set { sqjc = value; }
        }

        private string hpzl = "";

        /// <summary>
        ///��������
        /// </summary>
        public string Hpzl
        {
            get { return hpzl; }
            set { hpzl = value; }
        }

        private string hpys = "";

        /// <summary>
        ///������ɫ
        /// </summary>
        public string Hpys
        {
            get { return hpys; }
            set { hpys = value; }
        }

        private string sjly = "";

        /// <summary>
        ///������Դ
        /// </summary>
        public string Sjly
        {
            get { return sjly; }
            set { sjly = value; }
        }

        private string cllx = "";

        /// <summary>
        ///�������
        /// </summary>
        public string Cllx
        {
            get { return cllx; }
            set { cllx = value; }
        }

        private string clpp = "";

        /// <summary>
        ///����Ʒ��
        /// </summary>
        public string Clpp
        {
            get { return clpp; }
            set { clpp = value; }
        }

        private string clppText;

        /// <summary>
        /// ����Ʒ�Ƶ��ı�
        /// </summary>
        public string ClppText
        {
            get { return clppText; }
            set { clppText = value; }
        }

        private string clzpp = "";

        /// <summary>
        ///������Ʒ��
        /// </summary>
        public string Clzpp
        {
            get { return clzpp; }
            set { clzpp = value; }
        }

        private string clzppText;

        /// <summary>
        /// ������Ʒ���ı�
        /// </summary>
        public string ClzppText
        {
            get { return clzppText; }
            set { clzppText = value; }
        }

        private string csys = "";

        /// <summary>
        ///������ɫ
        /// </summary>
        public string Csys
        {
            get { return csys; }
            set { csys = value; }
        }

        private string cjjg = "";

        /// <summary>
        ///��������
        /// </summary>
        public string Cjjg
        {
            get { return cjjg; }
            set { cjjg = value; }
        }

        private string xssd = "";

        /// <summary>
        ///��ʻ�ٶ�
        /// </summary>
        public string Xssd
        {
            get { return xssd; }
            set { xssd = value; }
        }

        private string kkid = "";

        /// <summary>
        /// ������
        /// </summary>
        public string Kkid
        {
            get { return kkid; }
            set { kkid = value; }
        }

        private string kkidms = "";

        /// <summary>
        /// ��������
        /// </summary>
        public string Kkidms
        {
            get { return kkidms; }
            set { kkidms = value; }
        }

        private string xsfx = "";

        /// <summary>
        ///��ʻ����
        /// </summary>
        public string Xsfx
        {
            get { return xsfx; }
            set { xsfx = value; }
        }

        private string xscd = "";

        /// <summary>
        ///��ʻ����
        /// </summary>
        public string Xscd
        {
            get { return xscd; }
            set { xscd = value; }
        }

        private bool njb = false;

        /// <summary>
        /// ����  �� true  û��false
        /// </summary>
        public bool Njb
        {
            get { return njb; }
            set { njb = value; }
        }

        private bool zjh = false;

        /// <summary>
        /// ֽ���  �� true  û��false
        /// </summary>
        public bool Zjh
        {
            get { return zjh; }
            set { zjh = value; }
        }

        private bool zyb = false;

        /// <summary>
        /// ������  �� true  û��false
        /// </summary>
        public bool Zyb
        {
            get { return zyb; }
            set { zyb = value; }
        }

        private bool dz = false;

        /// <summary>
        /// ��׹  �� true  û��false
        /// </summary>
        public bool Dz
        {
            get { return dz; }
            set { dz = value; }
        }

        private bool bj = false;

        /// <summary>
        /// �ڼ�  �� true  û��false
        /// </summary>
        public bool Bj
        {
            get { return bj; }
            set { bj = value; }
        }

        private bool zjsaqd = false;

        /// <summary>
        /// ����ʻ��ȫ��  �� true  û��false
        /// </summary>
        public bool Zjsaqd
        {
            get { return zjsaqd; }
            set { zjsaqd = value; }
        }

        private bool fjsaqd = false;

        /// <summary>
        /// ����ʻ��ȫ��  �� true  û��false
        /// </summary>
        public bool Fjsaqd
        {
            get { return fjsaqd; }
            set { fjsaqd = value; }
        }

        private string queryMode;

        /// <summary>
        /// ��ѯģʽ 0 ģ����ѯ  1 ��ȷ��ѯ
        /// </summary>
        public string QueryMode
        {
            get { return queryMode; }
            set { queryMode = value; }
        }

        //��������ֶ��Ǹ��ӿ��м���־�õ�
        private string userName;

        /// <summary>
        /// �û����ƣ����磺���������ĸ��ˣ�
        /// </summary>
        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        private string userIp;

        /// <summary>
        /// �û���ǰ����IP�����磺192.168.1.123 (һ��Ϊ�������е�IP)��
        /// </summary>
        public string UserIp
        {
            get { return userIp; }
            set { userIp = value; }
        }

        private string userCode;

        /// <summary>
        /// �û���ţ����磺000001 ��
        /// </summary>
        public string UserCode
        {
            get { return userCode; }
            set { userCode = value; }
        }

        private string dyzgnmkbh;

        /// <summary>
        /// ����ģ���ţ����磺010501 ��
        /// </summary>
        public string Dyzgnmkbh
        {
            get { return dyzgnmkbh; }
            set { dyzgnmkbh = value; }
        }

        private string dyzgnmkmc;

        /// <summary>
        /// ����ģ�����ƣ����磺�ۺϲ�ѯ ��
        /// </summary>
        public string Dyzgnmkmc
        {
            get { return dyzgnmkmc; }
            set { dyzgnmkmc = value; }
        }
    }
}