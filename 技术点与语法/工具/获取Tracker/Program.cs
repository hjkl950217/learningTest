using Spectre.Console.Cli;
using 工具基础核心库.BaseTool.LogHlper;
using 获取Tracker.AppCommand;
using 获取Tracker.AppCommand.Combine;

namespace 获取Tracker
{
    public class Program
    {
        public const string separatorMsg = "==============================";

        // 发布命令
        // dotnet publish -c Release -r linux-x64 --self-contained -p:PublishReadyToRun=true -p:PublishSingleFile=true

        public static int Main(string[] args)
        {
#if DEBUG
            Environment.SetEnvironmentVariable("IsDebug", "1");
#endif
            //调试代码
            //args = new[] { "combine" };
            //args = new[] { "pack", "--db-type=Dm", "-i=intput", "-o=output", "-h=192.168.1.241", "-u=eform", "-p=1qaz2WSX1qaz2WSX", "--port=30001", "" };
            LogHelper.CleanLog(); //清理日志
            LogHelper.WriteLog(Program.separatorMsg); //输出分割符

            CommandApp app = new();

            //按命令执行
            ConfigureCommandApp(app);

            return app.Run(args);
        }

        private static void ConfigureCommandApp(CommandApp app)
        {
            app.Configure(config =>
            {
                #region 配置示例

                config.AddExample(new[] { "combine" });
                // config.AddExample(new[] { "xxx","-x=1","--xx=2"});

                #endregion 配置示例

                #region 配置命令

                config.AddCommand<CombineCommand>("combine")
                    .WithAlias("c")
                    .WithDescription("合并配置中的Tracker源地址中的所有Tracker");

                //config.AddCommand<ArchiveFolderCommand>("archiveFolder")
                //    //.WithAlias("")
                //    .WithDescription("将115目录的文件复制到qb下载目录，替换掉qb文件");

                #endregion 配置命令

                config.SetHelpProvider(new CustomHelpProvider(config.Settings));
                config.PropagateExceptions();
                config.ValidateExamples();
            });
        }
    }
}