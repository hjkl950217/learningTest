using System;

namespace CkTools.FP
{
    /// <summary>
    /// 函数式功能-常量
    /// </summary>
    public static partial class CkFunctions
    {
        public static Action<string> DefaultLog = debugInfo => Console.WriteLine($"{DateTime.Now:yyyy-MM-dd HH:mm:ss.fff} {debugInfo}");
        public static Action DefaultLogTime = () => Console.WriteLine($"{DateTime.Now:yyyy-MM-dd HH:mm:ss.fff}");

        public static Action EmtpyAction = () => { };
        public static Func<bool> True = () => true;
        public static Func<bool> False = () => false;
        public static Func<bool, Func<bool>> Bool = t => () => t;
        public static Func<int, Func<int>> Int = t => () => t;
        public static Func<string, Func<string>> String = t => () => t;
        public static Func<long, Func<long>> Long = t => () => t;
    }
}