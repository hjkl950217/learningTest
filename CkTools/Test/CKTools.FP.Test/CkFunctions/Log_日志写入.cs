using System;
using CkTools.FP;
using Xunit;

namespace CKTools.FP.Test
{
    public class Log_日志写入
    {
        private static string logFileName = $"log/{DateTime.Now:yyyy-MM-dd}.log";

        #region Log to Console

        [Fact]
        public void 向控制台写日志()
        {
            CkFunctions.LogToConsole("日志内容");
        }

        [Fact]
        public void 向控制台写日志2()
        {
            Action<string> logger = CkFunctions.LogToConsole(CkFunctions.DefaultLogFormat);
            logger("123");
        }

        #endregion Log to Console

        #region Log to File

        [Fact]
        public void 向文件写日志()
        {
            CkFunctions.LogToFile("日志内容");
        }

        [Fact]
        public void 向文件写日志1()
        {
            Action<string> fileLogger = CkFunctions.LogToFile(CkFunctions.DefaultLogFormat);
            fileLogger("123");
        }

        [Fact]
        public void 向文件写日志2()
        {
            Func<Func<string, string>, Action<string>> fileLoggerGenerater = CkFunctions.LogToFile(() => logFileName);//获取一个生成器

            Action<string> fileLogger = fileLoggerGenerater(CkFunctions.DefaultLogFormat);//生成一个FileLogger
            fileLogger("123");
        }

        #endregion Log to File
    }
}