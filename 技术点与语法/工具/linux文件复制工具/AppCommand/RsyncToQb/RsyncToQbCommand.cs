using linux文件复制工具.BaseTool.Config;
using linux文件复制工具.BaseTool.LogHlper;
using Spectre.Console.Cli;

namespace linux文件复制工具.AppCommand.RsyncToQb
{
    public partial class RsyncToQbCommand : Command<RsyncToQbSetting>
    {
        public override int Execute(CommandContext context, RsyncToQbSetting settings)
        {
            //读取配置
            AppSettings appSettings = ConfigHelper.GetConfig();
            DateTime timeLimit = appSettings.TimeLimit ?? DateTime.MinValue;

            //执行
            DateTime runDateTime = DateTime.Now;//定义当前时间
            LogHelper.PreLogWriter(runDateTime); //创建日志文件
            LogHelper.WriteLog(Program.separatorMsg); //输出分割符
            LogHelper.WriteLog($"【RsyncToQb】当前最新执行时间:{timeLimit:yyyy-MM-dd HH:mm:ss}");

            //执行
            new RsyncToQbRunner(appSettings, settings)
                .Run();

            return 1;
        }
    }
}