using System.Text;
using 工具基础核心库.AppCommand;
using 工具基础核心库.BaseTool.Executer;
using 工具基础核心库.BaseTool.Extension;
using 工具基础核心库.BaseTool.LogHlper;

namespace 获取Tracker.AppCommand.Combine
{
    public class CombineRunner : BaseRunner
    {
        private readonly AppSettings appSettings;
        private string[] trackerSourceUrlList = Array.Empty<string>();

        public CombineRunner(AppSettings appSettings, CombineSetting combineSetting)
        {
            this.appSettings = appSettings;

            this.actionExecuter
               .MayEndPipe(
                    this.检测QT文件是否存在,
                    () => LogHelper.WriteLog("qt配置文件不存在，退出任务", LogTypeEnum.Error))
               .Pipe(this.获取所有Tracker源地址)
               .MayEndPipe(
                    this.检测是否获取到Tracker地址,
                    () => LogHelper.WriteLog("未获取到Tracker地址，退出任务", LogTypeEnum.Error))
               .Pipe(this.设置QT配置文件)
               ;
        }

        protected override void InternalRun()
        {
            this.actionExecuter.Execute();
        }

        private bool 检测QT文件是否存在()
        {
            return File.Exists(this.appSettings.QtConfigFilePath);
        }

        private void 获取所有Tracker源地址()
        {
            string[] trackerSourceUrlList = this.appSettings.TrackerSourceUrlList;

            // 用于存储所有行的列表
            List<string> allLines = new();

            // 使用HttpClient发送请求
            using HttpClient client = new();
            client.Timeout = TimeSpan.FromSeconds(15);

            Parallel.ForEach(trackerSourceUrlList, url =>
            {
                try
                {
                    // 发送GET请求并获取响应内容
                    string responseText = client.GetStringAsync(url)
                        .ConfigureAwait(false)
                        .GetAwaiter()
                        .GetResult();

                    // 将响应文本拆分成行
                    string[] lines = responseText.Split(['\r', '\n'], StringSplitOptions.RemoveEmptyEntries);

                    // 使用锁确保线程安全地将行添加到allLines列表中
                    lock(allLines)
                    {
                        allLines.AddRange(lines);
                    }
                }
                catch(Exception ex)
                {
                    LogHelper.WriteLog($"获取源时遇到异常[{url}]，跳过。异常信息: {ex.Message}，堆栈：{ex.StackTrace}", LogTypeEnum.Error);
                }
            });

            this.trackerSourceUrlList = [.. allLines.Distinct()];
            LogHelper.WriteLog($"合并Tracker完成，共计 {this.trackerSourceUrlList.Length} 条");
        }

        private bool 检测是否获取到Tracker地址()
        {
            return this.trackerSourceUrlList.Length > 0;
        }

        private void 设置QT配置文件()
        {
            string qtConfigFilePath = this.appSettings.QtConfigFilePath;

            string[] qtConfigText = File.ReadAllLines(qtConfigFilePath);
            int trackerIndex = Array.FindIndex(qtConfigText, x => x.Contains(this.appSettings.KeyName_AppendTracker));

            //准备新内容
            StringBuilder newContentBuilder = new();
            this.trackerSourceUrlList
               .ForEach(url => newContentBuilder.Append(this.appSettings.TrackerFormatTemplet.Replace("{url}", url)));
            string newLineContent = @$"{this.appSettings.KeyName_AppendTracker}=""{newContentBuilder}""";

            //设置回去并回写文件
            qtConfigText[trackerIndex] = newLineContent;
            File.WriteAllLines(qtConfigFilePath, qtConfigText);
        }
    }
}