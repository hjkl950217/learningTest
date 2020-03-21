using System.IO;

namespace System
{
    public static class StreamExtension
    {
        /// <summary>
        /// 将MemoryStream 转换为 byte数组
        /// </summary>
        /// <param name="memoryStream"></param>
        /// <returns></returns>
        public static byte[] SaveAsByte(this MemoryStream memoryStream)
        {
            if (memoryStream == null) return System.Array.Empty<byte>();

            byte[] byteArray;
            using (memoryStream)
            {
                byteArray = memoryStream.ToArray();
            }
            return byteArray;
        }
    }
}