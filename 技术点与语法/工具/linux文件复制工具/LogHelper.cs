namespace linux文件复制工具
{
    public static class LogHelper
    {
        public static FileStream logFileStream = null;
        public static StreamWriter logWriter = null;
        private static string isDebug = Environment.GetEnvironmentVariable("IsDebug");
        private static CancellationTokenSource loadCts = null;//用于控制load效果的取消

        /// <summary>
        /// 日志格式化函数
        /// </summary>
        private static Func<DateTime, LogTypeEnum, string, string> logFormat = (logDate, logType, message) =>
        {
            string timestamp = DateTime.Now.ToString("HH:mm:ss");
            return $"[{timestamp}\t{logType}\t] {message}";
        };

        public static void PreLogWriter(DateTime logDate)
        {
            // 每天创建一个新的日志文件，如果当前日期与日志日期不同，则关闭当前日志文件并创建一个新的日志文件

            if(logWriter == null)
            {
                LogHelper.CreateWriter(DateTime.Now);
                return;
            }
            else if(logDate.Date != DateTime.Today)
            {
                logWriter.Close();
                logWriter.Dispose();
                logWriter = null;

                LogHelper.CreateWriter(logDate);
                return;
            }
        }

        private static void CreateWriter(DateTime? logDate)
        {
            // 创建日志文件夹
            string logFolder = "logs";
            if(!Directory.Exists(logFolder))
            {
                Directory.CreateDirectory(logFolder);
            }

            // 计算当前日期的字符串表示
            string currentDateStr = (logDate ?? DateTime.Now).ToString("yyyy-MM-dd");
            string logFilePath = Path.Combine(logFolder, $"log_{currentDateStr}.txt");

            // 如果当天的日志文件不存在，则创建一个新的日志文件
            if(!File.Exists(logFilePath))
            {
                logFileStream = new FileStream(logFilePath, FileMode.CreateNew, FileAccess.Write);
                logWriter = new StreamWriter(logFileStream);
            }
            else
            {
                logFileStream = new FileStream(logFilePath, FileMode.Append, FileAccess.Write);
                logWriter = new StreamWriter(logFileStream);
            }
        }

        public static void CloseLog()
        {
            //关闭日志流
            logWriter?.Close();
            logFileStream?.Close();
        }

        public static void WriteLog(
            string message,
            LogTypeEnum logType = LogTypeEnum.Info)
        {
            if(logType == LogTypeEnum.Debug && isDebug != "1")
            {
                return;
            }

            string logMessage = logFormat(DateTime.Now, logType, message);

            logWriter.WriteLine(logMessage);
            Console.WriteLine(logMessage);
        }

        public static void StartLoad(
            string message,
            LogTypeEnum logType = LogTypeEnum.Info)
        {
            LogHelper.loadCts = new CancellationTokenSource();
            CancellationToken ct = LogHelper.loadCts.Token;

            if(logType == LogTypeEnum.Debug && isDebug != "1")
            {
                return;
            }

            string logMessage = logFormat(DateTime.Now, logType, message);

            Console.CursorVisible = false;//隐藏光标
            Console.Write(logMessage);//写入消息
            _ = new ConsoleSpinner().TurnAsync(ct);//显示加载效果

            return;
        }

        public static void StopLoad(
            string endMsg,
            LogTypeEnum logType = LogTypeEnum.Info)
        {
            if(Console.CursorLeft != 0)
            {
                Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);//将光标移回到上一次的位置
            }

            string logMessage = logFormat(DateTime.Now, logType, endMsg);

            Console.WriteLine();
            Console.WriteLine(logMessage);
            Console.CursorVisible = true;//显示光标
            LogHelper.loadCts.Cancel();
        }
    }

    public class ConsoleSpinner
    {
        private int counter;

        public async Task TurnAsync(CancellationToken ct)
        {
            while(!ct.IsCancellationRequested)
            {
                this.InternalTurn();
                await Task.Delay(100);
            }
        }

        private void InternalTurn()
        {
            this.counter++;
            switch(this.counter % 4)
            {
                case 0:
                    Console.Write("/");
                    this.counter = 0;
                    break;

                case 1:
                    Console.Write("-");
                    break;

                case 2:
                    Console.Write("\\");
                    break;

                case 3:
                    Console.Write("|");
                    break;
            }

            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);//将光标移回到上一次的位置
        }
    }
}