using System;
using System.IO;
using System.Text;

namespace CkTools.FP
{
    /// <summary>
    /// 函数式功能-日志
    /// </summary>
    /// <remarks>
    /// 定义简单日志相关的函数或表达式
    /// </remarks>
    public static partial class CkFunctions
    {
        public static Func<string, string> DefaultLogFormat = debugMsg => $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss.fff}]  {debugMsg}";

        public static Func<Action<string>, Func<Func<string, string>, Action<Func<string>>>> Log =>
            log =>
            format =>
            msg => log(format(msg()));

        #region Log to Console

        /// <summary>
        /// 向控制台输出日志
        /// </summary>
        public static void LogToConsole(string msg = "")
        {
            Action<Func<string>> aaa = CkFunctions.Log(Console.WriteLine)(CkFunctions.DefaultLogFormat);
            CkFunctions.Log(Console.WriteLine)(CkFunctions.DefaultLogFormat)(() => msg);
        }

        /// <summary>
        /// 传递一个格式化函数,返回一个日志函数
        /// </summary>
        public static Action<string> LogToConsole(Func<string, string> msgFormat)
        {
            return msg => CkFunctions.Log(Console.WriteLine)(msgFormat)(() => msg);
        }

        #endregion Log to Console

        #region Log to File

        /// <summary>
        /// 传递一个文件名函数返回一个记录函数
        /// </summary>
        /// <remarks>
        /// 文件日志需要文件名，会比向控制台输出多一个创建文件的步骤
        /// </remarks>
        public static Action<string> GenerateFileLogger(Func<string> logFileName)
        {
            string fileName = logFileName();
            CkFunctions.TryCreateFile(fileName);

            return msg =>
            {
                File.AppendAllLines(fileName, new[] { msg, Environment.NewLine }, Encoding.UTF8);
            };
        }

        /// <summary>
        /// 默认文件日志写入器
        /// </summary>
        public static Action<string> DefaultFileLoggr = CkFunctions.GenerateFileLogger(() => $"log/{DateTime.Now:yyyy-MM-dd}.log");

        /// <summary>
        /// 向文件中输出日志
        /// </summary>
        /// <param name="msg"></param>
        public static void LogToFile(string msg = "")
        {
            CkFunctions.Log(CkFunctions.DefaultFileLoggr)(CkFunctions.DefaultLogFormat)(() => msg);
        }

        /// <summary>
        /// 传递一个格式化函数,返回一个日志函数
        /// </summary>
        /// <param name="msgFormat"></param>
        /// <returns></returns>
        public static Action<string> LogToFile(Func<string, string> msgFormat)
        {
            return msg => CkFunctions.Log(CkFunctions.DefaultFileLoggr)(msgFormat)(() => msg);
        }

        /// <summary>
        /// 传递一个获取文件名的函数,返回一个日志生成函数
        /// </summary>
        /// <param name="logFileName"></param>
        /// <returns></returns>
        public static Func<Func<string, string>, Action<string>> LogToFile(Func<string> logFileName)
        {
            return
                msgFormat =>
                msg => CkFunctions.Log(CkFunctions.GenerateFileLogger(logFileName))(msgFormat)(() => msg);
        }

        #endregion Log to File
    }
}