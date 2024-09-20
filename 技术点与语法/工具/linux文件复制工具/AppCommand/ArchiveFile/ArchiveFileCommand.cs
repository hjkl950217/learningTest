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
            DateTime timeLimit = appSettings.ArchiveFile.TimeLimit ?? DateTime.MinValue;

            //执行
            LogHelper.WriteLog($"【ArchiveFile】当前最新复制时间:{timeLimit:yyyy-MM-dd HH:mm:ss}");
            new ArchiveFileRunner(appSettings, settings)
                .Run();

            LogHelper.CloseLog();
            return 1;
        }
    }
}