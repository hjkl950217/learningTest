namespace linux文件复制工具
{
    public static class MLCopy
    {
        public static void Run(AppSettings settings, DateTime runDateTime)
        {
             DataSetHelper.GenerateDataset(settings, runDateTime);
        }
    }
}