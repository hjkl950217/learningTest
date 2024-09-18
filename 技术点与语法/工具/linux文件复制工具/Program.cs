using linux文件复制工具.AppCommand;
using linux文件复制工具.ArchiveFile;
using linux文件复制工具.BaseTool.LogHlper;
using Spectre.Console.Cli;

namespace linux文件复制工具
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
            //args = new[] { "pack", "--db-type=MySql", "-i=intput", "-o=output", "-h=192.168.1.241", "-u=eform", "-p=1qaz2WSX1qaz2WSX", "--port=30001", "" };
            //args = new[] { "pack", "--db-type=Dm", "-i=intput", "-o=output", "-h=192.168.1.241", "-u=eform", "-p=1qaz2WSX1qaz2WSX", "--port=30001", "" };

            CommandApp app = new();

            ConfigureCommandApp(app);

            //结束
            LogHelper.WriteLog(Program.separatorMsg); //输出分割符
            LogHelper.CloseLog();

            return app.Run(args);
        }

        private static void ConfigureCommandApp(CommandApp app)
        {
            app.Configure(config =>
            {
                #region 配置示例

                //  config.AddExample(new[] { "archiveFile", "--db=MySql", "-i=intput", "-o=output", "-h=127.0.0.1", "-u=test", "-p=pwd", "--port=3306", "--connOther='abc=123;a=1'" });
                config.AddExample(new[] { "archiveFile" });
                config.AddExample(new[] { "pack", });

                #endregion 配置示例

                #region 配置命令

                config.AddCommand<ArchiveFileCommand>("archiveFile")
                    .WithAlias("packing")
                    .WithDescription("打包,执行SQL脚本文件，将结果转换为csv中间数据");

                //config.AddCommand<InitCommand>("init")
                //    //.WithAlias("Init")
                //    .WithDescription("初始化数据，将中间数据更新到数据库中");

                //config.AddCommand<ShowEnvCommand>("showEnv")
                //    .WithDescription("显示环境变量");

                #endregion 配置命令

                config.SetHelpProvider(new CustomHelpProvider(config.Settings));
                config.PropagateExceptions();
                config.ValidateExamples();
            });
        }
    }
}