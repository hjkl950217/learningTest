using linux文件复制工具.AppCommand.ArchiveFile;
using linux文件复制工具.BaseTool.Config;
using linux文件复制工具.BaseTool.LogHlper;
using Spectre.Console.Cli;

namespace linux文件复制工具.ArchiveFile
{
    public partial class ArchiveFileCommand : Command<ArchiveFileSetting>
    {
        public override int Execute(CommandContext context, ArchiveFileSetting settings)
        {
            //读取配置
            AppSettings appSettings = ConfigHelper.GetConfig();
            DateTime timeLimit = appSettings.TimeLimit ?? DateTime.MinValue;

            //执行
            DateTime runDateTime = DateTime.Now;//定义当前时间
            LogHelper.PreLogWriter(runDateTime); //创建日志文件
            LogHelper.WriteLog(Program.separatorMsg); //输出分割符
            LogHelper.WriteLog($"【ArchiveFileC】当前最新复制时间:{timeLimit:yyyy-MM-dd HH:mm:ss}");

            //执行
            new ArchiveFileRunner(appSettings, settings)
                .Run();

            return 1;
        }
    }
}