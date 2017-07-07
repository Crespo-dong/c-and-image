using System.Text;

namespace MyNet.Atmcs.Uscmcp.Bll
{
    public class Cryptography
    {
        /// <summary>
        /// @����: fengd
        /// @�汾�ţ�1.0
        /// @����˵����������Ϊ1��20���ַ����ַ�������
        /// @������String originString:�������ַ���
        /// @���أ�String �ַ��������ܺ��64λ�ַ���
        /// @�������ڣ�2007-10-12
        /// @�޸��ߣ�zhaobin
        /// @�޸����ڣ�2008-02-07
        /// </summary>
        public static string Encrypt(string originString)
        {
            StringBuilder encryptedArray = new StringBuilder();
            sbyte[] originByteArray = Common.ToSByteArray(Common.ToByteArray(originString));
            int arrayLen = originByteArray.Length;
            int index = 0;
            for (int i = 0; i < arrayLen; i++)
            {
                sbyte temp = originByteArray[i];
                int encryptingKey = randomNum(65, 90);
                if ((temp + encryptingKey - 33) < 91)
                {
                    encryptedArray.Append((char)(temp + encryptingKey - 33));
                    encryptedArray.Append((char)randomNum(65, 70));
                }
                else if ((temp + encryptingKey - 59) < 91)
                {
                    encryptedArray.Append((char)(temp + encryptingKey - 59));
                    encryptedArray.Append((char)randomNum(71, 75));
                }
                else if ((temp + encryptingKey - 85) < 91)
                {
                    encryptedArray.Append((char)(temp + encryptingKey - 85));
                    encryptedArray.Append((char)randomNum(76, 80));
                }
                else if ((temp + encryptingKey - 111) < 91)
                {
                    encryptedArray.Append((char)(temp + encryptingKey - 111));
                    encryptedArray.Append((char)randomNum(81, 85));
                }
                else if ((temp + encryptingKey - 137) < 91)
                {
                    encryptedArray.Append((char)(temp + encryptingKey - 137));
                    encryptedArray.Append((char)randomNum(86, 90));
                }
                encryptedArray.Append((char)(encryptingKey));
                //UPGRADE_TODO: Method 'java.lang.Integer.parseInt' ��ת��Ϊ���в�ͬ��Ϊ�� 'System.Convert.ToInt32'��. 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="jlca1073"'
                temp &= (sbyte)System.Convert.ToInt32("7F", 16);
                index = 3 * (i + 1);
            }
            for (int i = index; i < 62; i++)
            {
                int randomKey = randomNum(65, 90);
                encryptedArray.Append((char)(randomKey));
            }
            if ((index + 65) < 91)
            {
                encryptedArray.Append((char)(index + 65));
                encryptedArray.Append((char)randomNum(65, 73));
            }
            else if ((index + 65) < 117)
            {
                encryptedArray.Append((char)(index + 39));
                encryptedArray.Append((char)randomNum(74, 82));
            }
            else if ((index + 65) < 143)
            {
                encryptedArray.Append((char)(index + 13));
                encryptedArray.Append((char)randomNum(83, 90));
            }
            return (encryptedArray.ToString());
        }

        /// <summary>
        /// @����: fengd
        /// @�汾�ţ�1.0
        /// @����˵�������ַ�������
        /// @������String encryptedString:64λ���Ĵ������ַ���
        /// @���أ�String �ַ��������ܺ���ַ���
        /// @�������ڣ�2007-10-12
        /// @�޸��ߣ�zhaobin
        /// @�޸����ڣ�2008-02-07
        /// </summary>
        public static string Decrypt(string encryptedString)
        {
            sbyte[] fullString = Common.ToSByteArray(Common.ToByteArray(encryptedString));
            int trueEncStringLen = 0;
            if (fullString[63] > 64 && fullString[63] < 74)
            {
                trueEncStringLen = fullString[62] - 65;
            }
            else if (fullString[63] > 73 && fullString[63] < 83)
            {
                trueEncStringLen = fullString[62] - 39;
            }
            else if (fullString[63] > 82 && fullString[63] < 91)
            {
                trueEncStringLen = fullString[62] - 13;
            }
            StringBuilder originString = new StringBuilder();
            for (int i = 0; i < trueEncStringLen; )
            {
                int originer = 0;
                int replacer = fullString[i];
                int ranEle = fullString[i + 2];
                if (fullString[i + 1] > 64 && fullString[i + 1] < 71)
                {
                    originer = replacer - ranEle + 33;
                    originString.Append((char)originer);
                }
                else if (fullString[i + 1] > 70 && fullString[i + 1] < 76)
                {
                    originer = replacer - ranEle + 59;
                    originString.Append((char)originer);
                }
                else if (fullString[i + 1] > 75 && fullString[i + 1] < 81)
                {
                    originer = replacer - ranEle + 85;
                    originString.Append((char)originer);
                }
                else if (fullString[i + 1] > 80 && fullString[i + 1] < 86)
                {
                    originer = replacer - ranEle + 111;
                    originString.Append((char)originer);
                }
                else if (fullString[i + 1] > 85 && fullString[i + 1] < 91)
                {
                    originer = replacer - ranEle + 137;
                    originString.Append((char)originer);
                }
                i = i + 3;
            }
            return (originString.ToString());
        }

        /// <summary>
        /// @����: fengd
        /// @�汾�ţ�1.0
        /// @����˵�����õ����Ʒ�Χ�ڵ�һ���������
        /// @������int min ����Сֵ || int max �����ֵ
        /// @���أ�int ����ֵ ��λ�ڱ������ڵ�һ����������
        /// @�������ڣ�2007-10-12
        /// @�޸��ߣ�zhaobin
        /// @�޸����ڣ�2008-02-07
        /// </summary>
        public static int randomNum(int min, int max)
        {
            if (min >= max)
            {
                return 0;
            }
            else
            {
                int range = max - min;
                //UPGRADE_WARNING: �� C# �У�����ת�����ܲ�������Ľ����. 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="jlca1042"'
                int result = (int)(range * (Common.Random.NextDouble()) + min);
                return result;
            }
        }


      


    }
}