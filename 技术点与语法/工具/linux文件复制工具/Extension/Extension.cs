namespace FileCopy
{
    internal static class FileInfoExtension
    {
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
        /// 获取随机后的文件名，带后缀
        /// </summary>
        /// <param name="fileInfo"></param>
        /// <returns></returns>
        public static string GetRandomName(this FileInfo fileInfo)
        {
            return $"{fileInfo.Name}_{DateTime.Now.Ticks % 10000}{fileInfo.Extension}";
        }

        /// <summary>
        /// 获取随机后的文件名，不带后缀
        /// </summary>
        /// <param name="fileInfo"></param>
        /// <returns></returns>
        public static string GetRandomFileName(this FileInfo fileInfo)
        {
            return $"{fileInfo.GetFileName()}_{DateTime.Now.Ticks % 10000} {fileInfo.Extension}";
        }
    }
}