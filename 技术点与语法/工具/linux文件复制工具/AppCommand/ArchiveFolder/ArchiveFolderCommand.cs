using linux文件复制工具.AppCommand.RsyncToQb;
using linux文件复制工具.BaseTool.Config;
using linux文件复制工具.BaseTool.LogHlper;
using Spectre.Console.Cli;

namespace linux文件复制工具.AppCommand.ArchiveFolder
{
    public partial class ArchiveFolderCommand : Command<ArchiveFolderSetting>
    {
        public override int Execute(CommandContext context, ArchiveFolderSetting settings)
        {
            //读取配置
            AppSettings appSettings = ConfigHelper.GetConfig();

            //执行
            LogHelper.WriteLog($"【ArchiveFolder】当前执行时间:{DateTime.Now:yyyy-MM-dd HH:mm:ss}");
            new ArchiveFolderRunner(appSettings, settings)
                .Run();

            LogHelper.CloseLog();
            return 1;
        }
    }
}