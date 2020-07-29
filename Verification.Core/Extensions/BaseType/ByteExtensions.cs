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
            encoding = encoding ?? Encoding.UTF8;
            return source.BaseConvertOrDefalut(string.Empty, encoding.GetString);
        }
    }
}