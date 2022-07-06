using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace md5_timespan
{
    public class Class1
    {
        public string GetTimeStamp()
        {
            return DateTime.Now.ToString("yyyyMMddHHmmss");
        }

        public string GetMD5Str(string plainText)
        {
#if false

            //定义一个字节数组
            byte[] secretBytes = null;
            try
            {
                // 生成一个MD5加密计算摘要
                MessageDigest md = MessageDigest.getInstance("MD5");
                //对字符串进行加密
                md.update(plainText.getBytes());
                //获得加密后的数据
                secretBytes = md.digest();
            }
            catch (NoSuchAlgorithmException e)
            {
                //throw new RuntimeException("没有md5这个算法！");
                throw new RuntimeException(SystemEnv.getHtmlLabelName(517545, userLanguage));
            }



            //将加密后的数据转换为16进制数字
            String md5code = new BigInteger(1, secretBytes).toString(16);


            // 如果生成数字未满32位，需要前面补0
            // 不能把变量放到循环条件，值改变之后会导致条件变化。如果生成30位 只能生成31位md5
            int tempIndex = 32 - md5code.length();
            for (int i = 0; i < tempIndex; i++)
            {
                md5code = "0" + md5code;
            }
            return md5code;

               //方式1
            var md5code1 = new BigInteger(1, secretBytes).ToString(16);
            int tempIndex1 = 32 - md5code1.Count();
            for (int i = 0; i < tempIndex1; i++)
            {
                md5code1 = "0" + md5code1;
            }
            //方式2
            var md5code2 = BitConverter.ToInt32(secretBytes, 0).ToString("X");
            int tempIndex2 = 32 - md5code2.Count();
            for (int i = 0; i < tempIndex2; i++)
            {
                md5code2 = "0" + md5code2;
            }
#endif
            MD5 md5 = MD5.Create();
            var secretBytes = md5.ComputeHash(Encoding.UTF8.GetBytes(plainText));
            //方式3
            var md5code3 = "";
            for (int i = 0; i < secretBytes.Length; i++)
            {
                md5code3 = md5code3 + secretBytes[i].ToString("x");
            }
            int tempIndex3 = 32 - md5code3.Count();
            for (int i = 0; i < tempIndex3; i++)
            {
                md5code3 = "0" + md5code3;
            }

            return md5code3;
        }
    }
}
