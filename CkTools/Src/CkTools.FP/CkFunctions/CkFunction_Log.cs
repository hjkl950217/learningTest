#pragma warning disable CS8602 // 解引用可能出现空引用。

using System;
using System.IO;

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

        /// <summary>
        ///
        /// </summary>
        public static Func<Action<string>, Func<Func<string, string>, Action<Func<string>>>> Log =>
            log =>
            format =>
            msg => log(format(msg()));

        public static Func<Action<string>, Func<Func<string, string>, Action<string>>> Log1 =>
            log =>
            format =>
            msg => CkFunctions.Log(log)(format)(() => msg);

        #region Console

        /// <summary>
        /// 向控制台记录时间,使用默认格式
        /// </summary>
        public static Action ConsoleLogTime = () => CkFunctions.ConsoleLog(string.Empty);

        /// <summary>
        /// 传递一个格式化函数,返回一个记录函数
        /// </summary>
        public static Func<Func<string, string>, Action<Func<string>>> ConsoleLog3 =
            msgFormat =>
            msg => CkFunctions.Log(Console.WriteLine)(msgFormat)(msg);

        /// <summary>
        /// 传递一个格式化函数,返回一个记录函数
        /// </summary>
        public static Func<Func<string, string>, Action<string>> ConsoleLog2 =
            msgFormat =>
            msg => CkFunctions.Log(Console.WriteLine)(msgFormat)(() => msg);

        /// <summary>
        /// 返回一个记录函数
        /// </summary>
        public static Action<Func<string>> ConsoleLog1 =
           msg => CkFunctions.Log(Console.WriteLine)(CkFunctions.DefaultLogFormat)(msg);

        /// <summary>
        /// 返回一个记录函数
        /// </summary>
        public static Action<string> ConsoleLog =
            msg => CkFunctions.Log(Console.WriteLine)(CkFunctions.DefaultLogFormat)(() => msg);

        #endregion Console

        #region File

        /// <summary>
        /// 传递一个文件名函数返回一个记录函数
        /// </summary>
        public static Func<Func<string>, Action<string>> LogToFile =
            logFileName =>
            {
                string fileName = logFileName();
                CkFunctions.TryCreateFile(fileName);

                return msg => File.AppendAllText(fileName, msg);
            };

        /// <summary>
        /// 默认文件名函数
        /// </summary>
        public static Action<string> DefaultFileLog = CkFunctions.LogToFile(CkFunctions.NowDayStr);

        public static Func<Func<string>, Func<Func<string, string>, Action<Func<string>>>> FileLog4 =
            logFileName =>
            msgFormat =>
            msg => CkFunctions.Log(CkFunctions.LogToFile(logFileName))(msgFormat)(msg);

        public static Func<Func<string, string>, Action<Func<string>>> FileLog3 =
            msgFormat =>
            msg => CkFunctions.Log(CkFunctions.DefaultFileLog)(msgFormat)(msg);

        public static Func<Func<string, string>, Action<string>> FileLog2 =
            msgFormat =>
            msg => CkFunctions.Log(CkFunctions.DefaultFileLog)(msgFormat)(() => msg);

        public static Action<Func<string>> FileLog1 =
            msg => CkFunctions.Log(CkFunctions.DefaultFileLog)(CkFunctions.DefaultLogFormat)(msg);

        public static Action<string> FileLog =
            msg => CkFunctions.Log(CkFunctions.DefaultFileLog)(CkFunctions.DefaultLogFormat)(() => msg);

        #endregion File
    }
}

#pragma warning restore CS8602 // 解引用可能出现空引用。