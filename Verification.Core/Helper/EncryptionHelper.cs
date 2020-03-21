using System;
using System.Security.Cryptography;
using System.Text;
using NETCore.Encrypt;
using NETCore.Encrypt.Internal;
using Verification.Core.ConstAndEnum;

namespace Verification.Core.Helper
{
    /// <summary>
    /// 加密解密帮助类
    /// </summary>
    public static class EncryptionHelper
    {
        //span 参考 https://www.cnblogs.com/maxzhang1985/p/6875622.html

        #region 密钥与加密向量

        /// <summary>
        /// RSA 公钥
        /// </summary>
        private const string RSAPublicKey = "abc";

        /// <summary>
        /// RSA 私钥
        /// </summary>
        private const string RSAPrivateKey = "abc";

        /// <summary>
        /// AES 加密种子
        /// </summary>
        private const string AESSecretKey = "123";

        /// <summary>
        /// AES 加密向量
        /// </summary>
        private const string AESEncryptionVector = "123";

        #endregion 密钥与加密向量

        #region 密钥计算方法

        /// <summary>
        /// 获得可用的AES密钥
        /// </summary>
        /// <param name="aesSecretKey"> AES 加密种子</param>
        /// <returns>密钥</returns>
        private static string GetAESLegalKey(string? aesSecretKey = null)
        {
            string sTemp = aesSecretKey ?? AESSecretKey;

            AESKey ase = EncryptProvider.CreateAesKey();
            int keyLength = ase.Key.Length;
            if (sTemp.Length > keyLength)
            {
                sTemp = sTemp.Substring(0, keyLength);
            }
            else if (sTemp.Length < keyLength)
            {
                sTemp = sTemp.PadRight(keyLength, ' ');//在右侧填充空字符
            }

            return sTemp;
        }

        /// <summary>
        /// 获得可用的AES初始向量
        /// </summary>
        ///<param name="aesEncryptionVector"> AES 加密向量</param>
        /// <returns>初试向量IV</returns>
        private static string GetAESLegalVector(string? aesEncryptionVector = null)
        {
            var sTemp = aesEncryptionVector ?? AESEncryptionVector;

            var ase = EncryptProvider.CreateAesKey();
            var bytTemp = ase.IV;
            var ivLength = bytTemp.Length;

            if (sTemp.Length > ivLength)
            {
                sTemp = sTemp.Substring(0, ivLength);
            }
            else if (sTemp.Length < ivLength)
            {
                sTemp = sTemp.PadRight(ivLength, ' ');//在右侧填充空字符
            }

            return sTemp;
        }

        #endregion 密钥计算方法

        #region 公开加密与解密方法

        #region RSA

        /// <summary>
        /// RSA加密
        /// </summary>
        /// <param name="content"> </param>
        /// <param name="rsaPublicKey"> RSA公钥</param>
        /// <returns> </returns>
        public static string EncryptRSA(string content, string? rsaPublicKey = null)
        {
            var rsa = EncryptProvider.RSAFromString(rsaKey: rsaPublicKey ?? RSAPublicKey);
            var bytes = Encoding.Unicode.GetBytes(content);
            var encryptedBytes = rsa.Encrypt(bytes, RSAEncryptionPadding.Pkcs1);
            return System.Convert.ToBase64String(encryptedBytes, 0, encryptedBytes.Length);
        }

        /// <summary>
        /// RSA解密
        /// </summary>
        /// <param name="content"></param>
        /// <param name="rsaPrivateKey">RSA私钥</param>
        /// <returns></returns>
        public static string DecryptRSA(string content, string? rsaPrivateKey = null)
        {
            var rsa = EncryptProvider.RSAFromString(rsaPrivateKey ?? RSAPrivateKey);
            var bytes = System.Convert.FromBase64String(content);
            var decryptedBytes = rsa.Decrypt(bytes, RSAEncryptionPadding.Pkcs1);
            return Encoding.Unicode.GetString(decryptedBytes);
        }

        #endregion RSA

        #region AES

        /// <summary>
        ///
        /// </summary>
        /// <param name="source"></param>
        /// <param name="aesSecretKey"> AES 加密种子</param>
        /// <param name="aesEncryptionVector"> AES 加密向量</param>
        /// <returns></returns>
        public static string EncryptAES(string source, string? aesSecretKey = null, string? aesEncryptionVector = null)
        {
            var key = GetAESLegalKey(aesSecretKey);
            var iv = GetAESLegalVector(aesEncryptionVector);
            var encryptedBytes = EncryptProvider.AESEncrypt(source, key, iv);
            return encryptedBytes;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="source"></param>
        /// <param name="aesSecretKey"> AES 加密种子</param>
        /// <param name="aesEncryptionVector"> AES 加密向量</param>
        /// <returns></returns>
        public static string DecryptAES(string source, string? aesSecretKey = null, string? aesEncryptionVector = null)
        {
            var key = GetAESLegalKey(aesSecretKey);
            var iv = GetAESLegalVector(aesEncryptionVector);
            var encryptedBytes = EncryptProvider.AESDecrypt(source, key, iv);
            return encryptedBytes;
        }

        #endregion AES

        #region MD5

        /// <summary>
        /// 对输入值做MD5计算
        /// </summary>
        /// <param name="source">要处理的字符串</param>
        /// <param name="is32">是否是32位长度。传递false时返回16位长度</param>
        /// <returns></returns>
        public static string EncryptMD5(string source, bool is32 = true)
        {
            if (source.IsNullOrEmpty() == true) return string.Empty;

            if (is32 == true)
            {
                return EncryptProvider.Md5(source);
            }
            else
            {
                return EncryptProvider.Md5(source, MD5Length.L16);
            }
        }

        #endregion MD5

        #region Fence-栅栏加密

        /// <summary>
        /// 栅栏加密
        /// </summary>
        /// <param name="source">要加密的字符串</param>
        /// <param name="rows">加密的层数</param>
        /// <returns>
        /// 加密后的字符串，若<paramref name="source"/>为空，则返回<see cref="string.Empty"/>
        /// </returns>
        public static string EncryptFence(string source, int rows)
        {
            if (string.IsNullOrEmpty(source)) return string.Empty;
            return ProcessFence(source, rows, isEncrypt: true);
        }

        /// <summary>
        /// 栅栏解密
        /// </summary>
        /// <param name="source">要加密的字符串</param>
        /// <param name="rows">解密的层数，需要和加密的层数相等</param>
        /// <returns>
        /// 解密后的字符串，若<paramref name="source"/>为空，则返回<see cref="string.Empty"/>
        /// </returns>
        public static string DecryptFence(string source, int rows)
        {
            if (string.IsNullOrEmpty(source)) return string.Empty;
            return ProcessFence(source, rows, isEncrypt: false);
        }

        /// <summary>
        /// 栅栏加密解密的处理方法
        /// </summary>
        /// <param name="message">要处理的信息</param>
        /// <param name="rows">层数</param>
        /// <param name="isEncrypt">传递true代表加密。false代表解密</param>
        /// <returns></returns>
        private static string ProcessFence(string message, int rows, bool isEncrypt = true)
        {
            int columns = (int)Math.Ceiling((double)message.Length / (double)rows);
            char[,] matrix = FillArray(message, rows, columns, isEncrypt);
            StringBuilder result = new StringBuilder();

            foreach (char c in matrix)
            {
                if (c == '*') continue;
                result.Append(c);
            }

            return result.ToString();
        }

        /// <summary>
        /// 栅栏加密解密中的具体算法
        /// </summary>
        /// <param name="message">要处理的信息</param>
        /// <param name="rowsCount">层数,也可以说是层数</param>
        /// <param name="columnsCount">列数</param>
        /// <param name="isEncrypt">传递true代表加密。false代表解密</param>
        /// <returns></returns>
        private static char[,] FillArray(
            string message,
            int rowsCount,
            int columnsCount,
            bool isEncrypt)
        {
            int charPosition = 0;//代表处理的指针，指向message的字符，一个一个处理
            int height, width;
            char[,] matrix;

            //初始化数据
            if (isEncrypt == true)
            {
                height = rowsCount;
                width = columnsCount;
                matrix = new char[rowsCount, columnsCount];
            }
            else
            {
                width = rowsCount;
                height = columnsCount;
                matrix = new char[columnsCount, rowsCount];
            }

            //开始计算
            for (int w = 0 ; w < width ; w++)
            {
                for (int h = 0 ; h < height ; h++)
                {
                    if (charPosition < message.Length)
                    {
                        matrix[h, w] = message[charPosition];
                    }
                    else
                    {
                        matrix[h, w] = '*';
                    }

                    charPosition++;
                }
            }

            return matrix;
        }

        #endregion Fence-栅栏加密

        #endregion 公开加密与解密方法

        #region 其它方法

        /// <summary>
        /// 获取混淆key的方法
        /// </summary>
        /// <param name="confuseNum">需要生成key的数量</param>
        /// <param name="keyLength">混淆key的长度</param>
        /// <param name="customWords">自定义的生成字,默认:O o 0</param>
        /// <returns>生成的混淆key字符串数组</returns>
        public static string[] GetConfuseKey(int confuseNum = 3, int keyLength = 12, char[] customWords = null)
        {
            //可以使用span再次提高下性能
            char[] words = customWords ?? new char[] { 'O', 'o', '0' };//混淆字符
            char[] tempKey = new char[keyLength];//存放一次处理出的key名
            Random random = new Random();//随机变量
            string[] result = new string[confuseNum];//key集合

            for (int num = 0 ; num < result.Length ; num++)//key的数量
            {
                for (int length = 0 ; length < tempKey.Length ; length++)//循环处理单个key的名字
                {
                    tempKey[length] = words[random.Next(0, words.Length)];
                }
                result[num] = new string(tempKey);
            }

            return result;
        }

        /// <summary>
        /// 获取一个新的GUID字符串
        /// </summary>
        /// <param name="foramatEnum">用于格式化枚举</param>
        /// <param name="isUpper">是否转成大写</param>
        /// <returns></returns>
        public static string GetNewGuidString(
            GuidForamatEnum foramatEnum = GuidForamatEnum.D,
            bool isUpper = false)
        {
            return isUpper
                ? Guid.NewGuid().ToString(foramatEnum.GetForamatString()).ToUpper()
                : Guid.NewGuid().ToString(foramatEnum.GetForamatString());
        }

        #endregion 其它方法
    }
}