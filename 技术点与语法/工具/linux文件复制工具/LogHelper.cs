namespace FileCopy
{
    public static class LogHelper
    {
        public static FileStream logFileStream = null;
        public static StreamWriter logWriter = null;
        private static string isDebug= Environment.GetEnvironmentVariable("IsDebug");

        private static void PreLogWriter(DateTime logDate)
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
            DateTime logDate,
            LogTypeEnum logType=LogTypeEnum.Info)
        {

           
            if(logType==LogTypeEnum.Debug&&isDebug!="1")
            {
                return;
            }
         

            LogHelper.PreLogWriter(logDate);//初始化日志写入器

            string timestamp = DateTime.Now.ToString("HH:mm:ss");
            string logMessage = $"[{timestamp}\t{logType}\t] {message}";
           logWriter.WriteLine(logMessage);

            Console.WriteLine(logMessage);
        }
    }
}