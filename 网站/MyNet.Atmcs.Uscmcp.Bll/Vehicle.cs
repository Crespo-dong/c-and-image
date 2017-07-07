using System;
using System.Collections;
using System.Xml;
using MyNet.Common.Log;
using XmlReadWrite;
using MyNet.Atmcs.Uscmcp.Model;

namespace MyNet.Atmcs.Uscmcp.Bll
{
    /// <summary>
    /// ���ݹܶ�ȡ
    /// </summary>
    public class Vehicle
    {
        private OtherQueryService.OtherQueryInfo service = new OtherQueryService.OtherQueryInfo();
        private XmlRead xmlRead = new XmlRead();

        /// <summary>
        /// ��ʼ��
        /// </summary>
        /// <param name="url"></param>
        public Vehicle(string url)
        {
            service.Url = url;
        }

        /// <summary>
        /// ��ȡ���ݹ���Ϣ
        /// </summary>
        /// <param name="hpzl"></param>
        /// <param name="hphm"></param>
        /// <returns></returns>
        public VehicleInfo GetVehicleInfo(string hpzl, string hphm)
        {
            VehicleInfo vehinfo = new VehicleInfo();
            XmlDocument doc = new XmlDocument();
            string xmlbody = "<?xml version='1.0' encoding='GBK'?>";
            xmlbody = xmlbody + "<root>";
            xmlbody = xmlbody + "<QueryCondition>";
            xmlbody = xmlbody + "<hpzl>" + hpzl + "</hpzl>";
            xmlbody = xmlbody + "<hphm>" + hphm + "</hphm>";
            xmlbody = xmlbody + "</QueryCondition>";
            xmlbody = xmlbody + "</root>";
            string xmlReturn = "";
            try
            {
                 xmlReturn = service.QueryObjectOut("01C21", xmlbody);
                //xmlReturn = GetTestXml();
            }
            catch (Exception)
            {
                ILog.WriteErrorLog(xmlReturn);
                return null;
            }
            doc = new XmlDocument();
            doc.LoadXml(xmlReturn);
            if (string.IsNullOrEmpty(GetSingleValueByXPath(doc, "root/body")))
            {
                ILog.WriteErrorLog(xmlReturn);
                return null;
            }
            if (!string.IsNullOrEmpty(xmlReturn))
            {
                Hashtable ht = xmlRead.XmltoHashtable(xmlReturn, "veh");
                if (ht.Count > 2)
                {
                    try
                    {
                        vehinfo.Hphm = hphm;
                        vehinfo.Hpzl = hpzl;
                        vehinfo.Clpp1 = ht["clpp1"].ToString();
                        vehinfo.Clxh = ht["clxh"].ToString();
                        vehinfo.Clsbdh = ht["clsbdh"].ToString();
                        vehinfo.Fdjh = ht["fdjh"].ToString();
                        try
                        {
                            vehinfo.Csys = GetCsys(ht["csys"].ToString());
                        }
                        catch
                        {
                            vehinfo.Csys = ht["csys"].ToString();
                        }
                        vehinfo.Csysbh = ht["csys"].ToString();
                        vehinfo.Syr = ht["syr"].ToString();
                        vehinfo.Ccdjrq = ht["ccdjrq"].ToString();
                        string qzbfqz = ht["qzbfqz"].ToString();
                        if (!string.IsNullOrEmpty(qzbfqz))
                        {
                            vehinfo.Qzbfqz = qzbfqz.Substring(0, qzbfqz.Length - 2);
                        }
                        string yxqz = ht["yxqz"].ToString();
                        if (!string.IsNullOrEmpty(yxqz))
                        {
                            vehinfo.Yxqz = yxqz.Substring(0, yxqz.Length - 2);
                            vehinfo.Jyyxqz = yxqz.Substring(0, yxqz.Length - 2);
                        }
                        vehinfo.Fzjg = ht["fzjg"].ToString();
                        vehinfo.Yzbm1 = ht["yzbm1"].ToString();
                        vehinfo.Lxdh = ht["sjhm"].ToString();
                        vehinfo.Fzjg = ht["fzjg"].ToString();
                        vehinfo.Zsxxdz = ht["zzxxdz"].ToString();
                        vehinfo.Xzqh = ht["xzqh"].ToString();
                        try
                        {
                            vehinfo.Cllx = GetCllx(ht["cllx"].ToString());
                        }
                        catch
                        {
                            vehinfo.Cllx = ht["cllx"].ToString();
                        }

                        vehinfo.Cllxbh = ht["cllx"].ToString();

                        // �����޸Ľ���
                        try
                        {
                            vehinfo.Zt = GetZt(ht["zt"].ToString());
                        }
                        catch
                        {
                            vehinfo.Zt = ht["zt"].ToString();
                        }
                        vehinfo.Ztbh = ht["zt"].ToString();
                        vehinfo.Sfzmhm = ht["sfzmhm"].ToString();

                        vehinfo.Dabh = ht["dabh"].ToString();
                        if (!string.IsNullOrEmpty(ht["syxz"].ToString()))
                        {
                            vehinfo.Syxz = ht["syxz"].ToString();
                            vehinfo.Syxzms = GetSyxz(ht["syxz"].ToString());
                        }
                        return vehinfo;
                    }
                    catch (Exception ex)
                    {
                        ILog.WriteErrorLog(ex.Message);
                        return null;
                    }
                }
            }
            return null;
        }

        /// <summary>
        /// ת��������ɫ
        /// </summary>
        /// <param name="cpys"></param>
        /// <returns></returns>
        public string GetCsys(string cpys)
        {
            switch (cpys)
            {
                case "A":
                    return "��ɫ";

                case "B":
                    return "��ɫ";

                case "C":
                    return "��ɫ";

                case "D":
                    return "��ɫ";

                case "E":
                    return "��ɫ";

                case "F":
                    return "��ɫ";

                case "G":
                    return "��ɫ";

                case "H":
                    return "��ɫ";

                case "I":
                    return "��ɫ";

                case "J":
                    return "��ɫ";

                default:
                    return "����";
            }
        }

        /// <summary>
        ///ת����������
        /// </summary>
        /// <param name="cllx"></param>
        /// <returns></returns>
        public string GetCllx(string cllx)
        {
            switch (cllx)
            {
                case "K11": return "������ͨ�ͳ�";
                case "K12": return "����˫��ͳ�";
                case "K13": return "�������̿ͳ�";
                case "K14": return "���ͽ½ӿͳ�";
                case "K15": return "����ԽҰ�ͳ�";
                case "K21": return "������ͨ�ͳ�";
                case "K22": return "����˫��ͳ�";
                case "K23": return "�������̿ͳ�";
                case "K24": return "���ͽ½ӿͳ�";
                case "K25": return "����ԽҰ�ͳ�";
                case "K31": return "С����ͨ�ͳ�";
                case "K32": return "С��ԽҰ�ͳ�";
                case "K33": return "�γ�";
                case "K41": return "΢����ͨ�ͳ�";
                case "K42": return "΢��ԽҰ�ͳ�";
                case "K43": return "΢�ͽγ�";
                case "H11": return "������ͨ����";
                case "H12": return "������ʽ����";
                case "H13": return "���ͷ�ջ���";
                case "H14": return "���͹�ʽ����";
                case "H15": return "����ƽ�����";
                case "H16": return "���ͼ�װ�ᳵ";
                case "H17": return "������ж����";
                case "H18": return "��������ṹ����";
                case "H21": return "������ͨ����";
                case "H22": return "������ʽ����";
                case "H23": return "���ͷ�ջ���";
                case "H24": return "���͹�ʽ����";
                case "H25": return "����ƽ�����";
                case "H26": return "���ͼ�װ�ᳵ";
                case "H27": return "������ж����";
                case "H28": return "��������ṹ����";
                case "H31": return "������ͨ����";
                case "H32": return "������ʽ����";
                case "H33": return "���ͷ�ջ���";
                case "H34": return "���͹�ʽ����";
                case "H35": return "����ƽ�����";
                case "H37": return "������ж����";
                case "H38": return "��������ṹ����";
                case "H41": return "΢����ͨ����";
                case "H42": return "΢����ʽ����";
                case "H43": return "΢�ͷ�ջ���";
                case "H44": return "΢�͹�ʽ����";
                case "H45": return "΢����ж����";
                case "H46": return "΢������ṹ����";
                case "H51": return "������ͨ����";
                case "H52": return "������ʽ����";
                case "H53": return "���ٹ�ʽ����";
                case "H54": return "������ж����";
                case "Q11": return "���Ͱ��ǣ����";
                case "Q21": return "���Ͱ��ǣ����";
                case "Q31": return "���Ͱ��ǣ����";
                case "Z": return "ר����ҵ��";
                case "Z11": return "����ר����ҵ��";
                case "Z21": return "����ר����ҵ��";
                case "Z31": return "С��ר����ҵ��";
                case "Z41": return "΢��ר����ҵ��";
                case "Z51": return "����ר����ҵ��";
                case "Z71": return "����ר����ҵ��";
                case "D11": return "�޹�糵";
                case "D12": return "�й�糵";
                case "M11": return "��ͨ������Ħ�г�";
                case "M12": return "���������Ħ�г�";
                case "M13": return "�������ؿ�Ħ�г�";
                case "M14": return "�������ػ�Ħ�г�";
                case "M15": return "������Ħ�г�";
                case "M21": return "��ͨ����Ħ�г�";
                case "M22": return "������Ħ�г�";
                case "N11": return "��������";
                case "T11": return "������ʽ������";
                case "T21": return "С����ʽ������";
                case "T22": return "�ַ�������";
                case "T23": return "�ַ����������";
                case "J11": return "��ʽװ�ػ�е";
                case "J12": return "��ʽ�ھ��е";
                case "J13": return "��ʽƽ�ػ�е";
                case "G11": return "������ͨȫ�ҳ�";
                case "G12": return "������ʽȫ�ҳ�";
                case "G13": return "���͹�ʽȫ�ҳ�";
                case "G14": return "����ƽ��ȫ�ҳ�";
                case "G15": return "���ͼ�װ��ȫ�ҳ�";
                case "G16": return "������жȫ�ҳ�";
                case "G21": return "������ͨȫ�ҳ�";
                case "G22": return "������ʽȫ�ҳ�";
                case "G23": return "���͹�ʽȫ�ҳ�";
                case "G24": return "����ƽ��ȫ�ҳ�";
                case "G25": return "���ͼ�װ��ȫ�ҳ�";
                case "G26": return "������жȫ�ҳ�";
                case "G31": return "������ͨȫ�ҳ�";
                case "G32": return "������ʽȫ�ҳ�";
                case "G33": return "���͹�ʽȫ�ҳ�";
                case "G34": return "����ƽ��ȫ�ҳ�";
                case "G35": return "������жȫ�ҳ�";
                case "B11": return "������ͨ��ҳ�";
                case "B12": return "������ʽ��ҳ�";
                case "B13": return "���͹�ʽ��ҳ�";
                case "B14": return "����ƽ���ҳ�";
                case "B15": return "���ͼ�װ���ҳ�";
                case "B16": return "������ж��ҳ�";
                case "B17": return "��������ṹ��ҳ�";
                case "B21": return "������ͨ��ҳ�";
                case "B22": return "������ʽ��ҳ�";
                case "B23": return "���͹�ʽ��ҳ�";
                case "B24": return "����ƽ���ҳ�";
                case "B25": return "���ͼ�װ���ҳ�";
                case "B26": return "������ж��ҳ�";
                case "B27": return "��������ṹ��ҳ�";
                case "B31": return "������ͨ��ҳ�";
                case "B32": return "������ʽ��ҳ�";
                case "B33": return "���͹�ʽ��ҳ�";
                case "B34": return "����ƽ���ҳ�";
                case "B35": return "������ж��ҳ�";
                case "X99": return "����";
                default: return "����";
            }
        }

        /// <summary>
        ///ת������״̬
        /// </summary>
        /// <param name="zt"></param>
        /// <returns></returns>
        public string GetZt(string zt)
        {
            switch (zt)
            {
                case "A": return "����";
                case "B": return "ת��";
                case "C": return "������";
                case "D": return "ͣʻ";
                case "E": return "ע��";
                case "G": return "Υ��δ����";
                case "H": return "���ؼ��";
                case "I": return "�¹�δ����";
                case "J": return "���ɳ�";
                case "K": return "���";
                case "L": return "�ݿ�";
                case "M": return "ǿ��ע��";
                case "N": return "�¹�����";
                case "O": return "����";
                case "Z": return "����";
                default: return "����";
            }
        }

        //������� ʹ������
        /// <summary>
        /// ת��ʹ������
        /// </summary>
        /// <param name="syxz"></param>
        /// <returns></returns>
        public string GetSyxz(string syxz)
        {
            switch (syxz)
            {
                case "A":
                    return "��Ӫ��";

                case "B":
                    return "��·����";

                case "C":
                    return "��������";

                case "D":
                    return "�������";

                case "E":
                    return "���ο���";

                case "F":
                    return "����";

                case "G":
                    return "����";

                case "H":
                    return "����";

                case "I":
                    return "����";

                case "J":
                    return "�Ȼ�";

                case "K":
                    return "���̾���";

                case "L":
                    return "Ӫת��";

                case "M":
                    return "����ת��";

                case "N":
                    return "����";

                case "O":
                    return "�׶�У��";

                case "P":
                    return "Сѧ��У��";

                case "Q":
                    return "����У��";

                case "R":
                    return "Σ��Ʒ����";

                case "Z":
                    return "����";

                default:
                    return "����";
            }
        }

        /// <summary>
        /// ��ȡ�ڵ�ֵ
        /// </summary>
        /// <param name="xmlDocument"></param>
        /// <param name="XPath"></param>
        /// <returns></returns>
        public string GetSingleValueByXPath(XmlDocument xmlDocument, string XPath)
        {
            XmlNode node;
            try
            {
                node = xmlDocument.SelectSingleNode(XPath);
                if (node != null)
                {
                    return node.InnerText;
                }
            }
            catch
            {
            }
            return "";
        }

        private string GetTestXml()
        {
            return @"<?xml version='1.0' encoding='GBK'?>
<root>
<head>
<code>1</code>
<message>�������سɹ���</message>
<rownum>1</rownum>
</head>
<body>
<veh id='0'>
  <clsbdh>LVSHDFMC57F008832</clsbdh>
  <jyw>3279640D0E04F2DCE5E080D7F6F37579760604080B7E2624133C2934246D5659351E000D0F07020104060408027E050B7176040809045A4670405F42581F535A3330413035</jyw>
  <zsxzqh>510106</zsxzqh>
  <zxxs>1</zxxs>
  <xsrq></xsrq>
  <zzxzqh>510106</zzxzqh>
  <bzcs>0</bzcs>
  <zqyzl>0</zqyzl>
  <clpp2></clpp2>
  <clpp1>���Դ���</clpp1>
  <hlj>1515</hlj>
  <sfzmmc>A</sfzmmc>
  <zj>2640</zj>
  <ytsx>9</ytsx>
  <zt>G</zt>
  <zs>2</zs>
  <csys>B</csys>
  <fhgzrq>2009-04-27 16:01:28.0</fhgzrq>
  <yxh></yxh>
  <qpzk>0</qpzk>
  <hdfs>A</hdfs>
  <xsjg></xsjg>
  <clxh>CAF7202M</clxh>
  <gcjk>A</gcjk>
  <dybj>0</dybj>
  <gbthps>0</gbthps>
  <lxdh></lxdh>
  <jbr>����÷</jbr>
  <ccdjrq>2007-04-04 11:54:46.0</ccdjrq>
  <djrq>2009-04-27 00:00:00.0</djrq>
  <gxrq>2010-12-15 21:10:54.0</gxrq>
  <xzqh>510106</xzqh>
  <lsh>1A70404050960</lsh>
  <fdjxh>LF</fdjxh>
  <clyt>P1</clyt>
  <dzyx></dzyx>
  <fprq>2007-04-04 11:54:46.0</fprq>
  <jkpzhm></jkpzhm>
  <lts>4</lts>
  <nszmbh>6510753723</nszmbh>
  <bz></bz>
  <qlj>1530</qlj>
  <hxnbgd>0</hxnbgd>
  <yxqz>2011-04-30 00:00:00.0</yxqz>
  <fdjrq>2007-04-04 12:22:11.0</fdjrq>
  <ccrq>2007-03-19 00:00:00.0</ccrq>
  <zzcmc>�����������Դ��������޹�˾(����C4)</zzcmc>
  <xsdw></xsdw>
  <hgzbh>WDV100007035722</hgzbh>
  <zsxxdz>�ɶ��н�ţ��������·�����ţ�������Ԫ��¥������</zsxxdz>
  <bpcs>0</bpcs>
  <cwkc>4539</cwkc>
  <hdzk>5</hdzk>
  <hpzl>02</hpzl>
  <hpzk>0</hpzk>
  <pzbh1>00874003</pzbh1>
  <jkpz></jkpz>
  <djzsbh>510003867598</djzsbh>
  <pzbh2></pzbh2>
  <fdjh>062001</fdjh>
  <sqdm>510106000000</sqdm>
  <dabh></dabh>
  <hphm>AWT890</hphm>
  <syr>��ӽ÷</syr>
  <cwkk>1755</cwkk>
  <dwbh>51010000006118</dwbh>
  <ltgg>205/55 R16</ltgg>
  <zbzl>1287</zbzl>
  <xszbh></xszbh>
  <zzxxdz>�ɶ��н�ţ��������·�����ţ�������Ԫ��¥������</zzxxdz>
  <cwkg>1465</cwkg>
  <hbdbqk></hbdbqk>
  <sfzmhm>511102197902257720</sfzmhm>
  <syq>2</syq>
  <dphgzbh></dphgzbh>
  <pl>1999</pl>
  <syxz>A</syxz>
  <gl>110</gl>
  <qmbh></qmbh>
  <nszm>1</nszm>
  <hdzzl>0</hdzzl>
  <sjhm>13348846398</sjhm>
  <fzrq>2007-04-04 12:21:57.0</fzrq>
  <hmbh></hmbh>
  <hxnbkd>0</hxnbkd>
  <bxzzrq>2010-04-04 00:00:00.0</bxzzrq>
  <zdyzt></zdyzt>
  <llpz1>A</llpz1>
  <fzjg>³M</fzjg>
  <zdjzshs></zdjzshs>
  <zzg>156</zzg>
  <glbm>510100000400</glbm>
  <qzbfqz>2099-12-31 00:00:00.0</qzbfqz>
  <bdjcs>0</bdjcs>
  <llpz2></llpz2>
  <zzl>1736</zzl>
  <hxnbcd>0</hxnbcd>
  <cllx>K33</cllx>
  <clly>1</clly>
  <rlzl>A</rlzl>
  <zzz></zzz>
  <xgzl>ABMJ</xgzl>
  <yzbm1>610000</yzbm1>
  <yzbm2></yzbm2>
  <jyhgbzbh>115101122795</jyhgbzbh>
  <xh>51010007086048</xh>
  <cyry></cyry>
</veh>
</body></root>";
        }
    }
}