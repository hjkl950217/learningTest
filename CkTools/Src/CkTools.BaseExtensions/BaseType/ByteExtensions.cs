using System.Text;

namespace System
{
    public static class ByteExtensions
    {
        /// <summary>
        /// 将byte[] 转换为<see cref="string"/>
        /// </summary>
        /// <param name="source"></param>
        /// <param name="encoding"></param>
        /// <returns></returns>
        public static string ToStr(this byte[] source, Encoding? encoding = null)
        {
            encoding ??= Encoding.UTF8;
            return source.BaseConvertOrDefalut(encoding.GetString, string.Empty);
        }

        #region BytesToHexstring

        /// <summary>
        /// Byte[]数组转16进制字符串
        /// </summary>
        /// <param name="array">需要求Hex值的数组</param>
        /// <param name="separator">分隔符</param>
        /// <param name="uppercase">是否转为大写</param>
        /// <returns>字节数组的16进制表示</returns>
        public static string BytesToHexstring(
            this byte[] array,
            ReadOnlySpan<char> separator,
            bool uppercase = true)
        {
            if (array.IsNullOrEmpty())
            {
                return string.Empty;
            }

            string format = uppercase ? "X2" : "x2";
            StringBuilder stringBuilder = new StringBuilder();

            foreach (byte item in array)
            {
                stringBuilder.Append(item.ToString(format));
                stringBuilder.Append(separator);
            }
            stringBuilder.Remove(stringBuilder.Length - separator.Length, separator.Length);//移除最后多加的分隔符

            return stringBuilder.ToString();
        }

        /// <summary>
        /// Byte[]数组转16进制字符串,无分隔符
        /// </summary>
        /// <param name="array">需要求Hex值的数组</param>
        /// <param name="uppercase">是否转为大写</param>
        /// <returns>字节数组的16进制表示</returns>
        public static string BytesToHexstring(
            this byte[] array,
            bool uppercase = true)
        {
            return ByteExtensions.BytesToHexstring(array, ReadOnlySpan<char>.Empty, uppercase);
        }

        /// <summary>
        /// Byte[]数组转16进制字符串,以" "分隔
        /// </summary>
        /// <param name="array">需要求Hex值的数组</param>
        /// <param name="uppercase">是否转为大写</param>
        /// <returns>字节数组的16进制表示</returns>
        public static string BytesToHexstringWithSeparator(
            this byte[] array,
            bool uppercase = true)
        {
            return ByteExtensions.BytesToHexstring(array, " ".AsSpan(), uppercase);
        }

        #endregion BytesToHexstring



    }
}