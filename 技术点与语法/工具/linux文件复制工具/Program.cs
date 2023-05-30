using linux文件复制工具.Config;

namespace linux文件复制工具
{
    public class Program
    {
        public const string separatorMsg = "==============================";

        // 发布命令
        // dotnet publish -c Release -r linux-x64 --self-contained -p:PublishReadyToRun=true -p:PublishSingleFile=true

        public static async Task Main(string[] args)
        {
#if DEBUG
            Environment.SetEnvironmentVariable("IsDebug", "1");

#endif

            //读取配置
            AppSettings settings = ConfigHelper.GetConfig();
            DateTime timeLimit = settings.TimeLimit ?? DateTime.MinValue;

            //执行
            DateTime runDateTime = DateTime.Now;//定义当前时间
            LogHelper.PreLogWriter(runDateTime); //创建日志文件
            LogHelper.WriteLog(Program.separatorMsg); //输出分割符
            LogHelper.WriteLog($"当前最新复制时间:{timeLimit:yyyy-MM-dd HH:mm:ss}");

            await MLCopy.RunAsync(settings, runDateTime);

            //结束
            LogHelper.WriteLog(Program.separatorMsg); //输出分割符
            LogHelper.CloseLog();
        }
    }
}