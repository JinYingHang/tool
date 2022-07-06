using NPOI.POIFS.Crypt;
using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace WorldToSql
{



    /**
     * AES加密工具类
     */

    public class AESUtils
    {

        private static readonly string KEY_ALGORITHM = "AES";
        private static readonly string DEFAULT_CIPHER_ALGORITHM = "AES/ECB/PKCS5Padding";//"算法/模式/补码方式"
        public static byte[] GetKey(string key)
        {
#if false //JAVA
                KeyGenerator kg = null;
            try
            {
                kg = KeyGenerator.getInstance(KEY_ALGORITHM);

                //AES 要求密钥长度为 128
                /*kg.init(128, new SecureRandom(key.getBytes()));*/

                SecureRandom secureRandom = SecureRandom.getInstance("SHA1PRNG");
                secureRandom.setSeed(key.getBytes());
                kg.init(128, secureRandom);

                //生成一个密钥
                SecretKey secretKey = kg.generateKey();

                return new SecretKeySpec(secretKey.getEncoded(), KEY_ALGORITHM);// 转换为AES专用密钥
#endif
            try
            {
                byte[] keyArray = null;
                using (var sha1 = new SHA1CryptoServiceProvider())
                {
                    byte[] hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(key));
                    var rd = sha1.ComputeHash(hash);
                    keyArray = rd.Take(16).ToArray();
                }
                return keyArray;
            }
            catch (Exception ez)
            {
                Console.WriteLine(ez.ToString());
                return null;
            }
         
        }


        public static string encrypt(string content, string key)
        {
#if false //java

            Cipher cipher = Cipher.getInstance(DEFAULT_CIPHER_ALGORITHM);// 创建密码器

            byte[] byteContent = content.getBytes("utf-8");

            cipher.init(Cipher.ENCRYPT_MODE, getSecretKey(key));// 初始化为加密模式的密码器

            byte[] result = cipher.doFinal(byteContent);// 加密

            return byteToString(Base64Utils.encode(result));//通过Base64转码返回
#endif
            try
            {

                Cipher cipher = Cipher.GetInstance(DEFAULT_CIPHER_ALGORITHM);
                byte[] byteContent = Encoding.UTF8.GetBytes(content);
                SecretKeySpec skeySpec = new SecretKeySpec(GetKey(key), KEY_ALGORITHM);

                cipher.Init(Cipher.ENCRYPT_MODE, skeySpec);
                byte[] result = cipher.DoFinal(byteContent);
                return Convert.ToBase64String(result);

            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
    }

}



