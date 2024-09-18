using System.Security.Cryptography;

namespace linux文件复制工具
{
    internal static class FileInfoExtension
    {
        private static string GetMd5Hash(this string input)
        {
            using MD5 md5 = MD5.Create();
            byte[] inputBytes = System.Text.Encoding.UTF8.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);
            return BitConverter.ToString(hash).Replace("-", "");
        }

        /// <summary>
        /// 获取 文件名，不带后缀
        /// </summary>
        /// <param name="fileInfo"></param>
        /// <returns></returns>
        public static string GetFileName(this FileInfo fileInfo)
        {
            int lastEnd = fileInfo.Name.LastIndexOf('.');
            return $"{fileInfo.Name[0..lastEnd]}";
        }

        /// <summary>
        /// 获取随机后的文件名，不带后缀
        /// </summary>
        /// <param name="fileInfo"></param>
        /// <returns></returns>
        public static string GetRandomFileName(this FileInfo fileInfo)
        {
            string seed = fileInfo.FullName.GetMd5Hash()[^4..];
            return $"{fileInfo.GetFileName()}_{seed}";
        }

        /// <summary>
        /// 获取MD5后的文件名，带后缀
        /// </summary>
        /// <param name="fileInfo"></param>
        /// <remarks>用带路径的文件名计算MD5并附加到文件名中</remarks>
        /// <returns></returns>
        public static string GetMD5Name(this FileInfo fileInfo)
        {
            return $"{FileInfoExtension.GetRandomFileName(fileInfo)}{fileInfo.Extension}";
        }
    }

    internal static class DateTimeExtension
    {
        /// <summary>
        /// 获取字符串
        /// </summary>
        /// <param name="dateTime"></param>
        /// <param name="format"></param>
        /// <returns></returns>
        public static string GetString(
            this DateTime dateTime,
            string format = "yyyy-MM-dd HH:mm:ss")
        {
            return dateTime.ToString(format);
        }

        /// <summary>
        /// 获取字符串
        /// </summary>
        /// <param name="dateTime"></param>
        /// <param name="format"></param>
        /// <returns></returns>
        public static string GetString(
            this DateTime? dateTime,
            string format = "yyyy-MM-dd HH:mm:ss")
        {
            return (dateTime ?? DateTime.MinValue).ToString(format);
        }
    }
}