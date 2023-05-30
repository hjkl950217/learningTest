namespace linux文件复制工具
{
    public static class MLCopy
    {
        public static async Task RunAsync(AppSettings settings, DateTime runDateTime)
        {
            await DataSetHelper.GenerateDataset(settings, runDateTime);
        }
    }
}