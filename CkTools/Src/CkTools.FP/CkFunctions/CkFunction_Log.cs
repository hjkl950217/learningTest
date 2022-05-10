using System;
using System.IO;

namespace CkTools.FP
{
    /// <summary>
    /// 函数式功能-日志
    /// </summary>
    public static partial class CkFunctions
    {
        public static Func<string, string> DefaultLogFormat = debugMsg => $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss.fff}]  {debugMsg}";

        public static void Log(
            Action<string> log,
            Func<string, string> format,
            Func<string> msg)
        {
            log(format(msg()));
        }

        #region Console

        public static Action ConsoleLogTime = () => CkFunctions.ConsoleLog(string.Empty);

        public static void ConsoleLog(Func<string> msg)
        {
            CkFunctions.ConsoleLog(CkFunctions.DefaultLogFormat, msg);
        }

        public static void ConsoleLog(string msg)
        {
            CkFunctions.ConsoleLog(CkFunctions.DefaultLogFormat, msg);
        }

        public static void ConsoleLog(Func<string, string> msgFormat, string msg)
        {
            CkFunctions.ConsoleLog(
                msgFormat,
                () => msg);
        }

        public static void ConsoleLog(Func<string, string> msgFormat, Func<string> msg)
        {
            CkFunctions.Log(
                Console.WriteLine,
                msgFormat,
                msg);
        }

        #endregion Console

        #region File

        public static Action<string> DefaultFileLog(Func<string> logFileName)
        {
            string fileName = logFileName();
            CkFunctions.TryCreateFile(fileName);

            return msg =>
            {
                File.AppendAllText(fileName, msg);
            };
        }

        public static void FileLog(Func<string> msg)
        {
            CkFunctions.FileLog(
                CkFunctions.DefaultLogFormat,
                msg);
        }

        public static void FileLog(string msg)
        {
            CkFunctions.FileLog(
                CkFunctions.DefaultLogFormat,
                () => msg);
        }

        public static void FileLog(Func<string, string> msgFormat, string msg)
        {
            CkFunctions.FileLog(
                msgFormat,
                () => msg);
        }

        public static void FileLog(Func<string, string> msgFormat, Func<string> msg)
        {
            CkFunctions.FileLog(
                CkFunctions.NowDayStr,
                msgFormat,
                msg);
        }

        public static void FileLog(
            Func<string> logFileName,
            Func<string, string> msgFormat,
            Func<string> msg)
        {
            Action<string>? fileLog = CkFunctions.DefaultFileLog(logFileName);

            CkFunctions.Log(
                fileLog,
                msgFormat,
                msg);
        }

        #endregion File
    }
}