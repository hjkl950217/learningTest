using System;

namespace CkTools.FP
{
    /// <summary>
    /// 函数式功能-常量
    /// </summary>
    public static partial class CkFunctions
    {
        public static Action EmtpyAction = () => { };
        public static Func<bool, Func<bool>> Bool = t => () => t;
        public static Func<int, Func<int>> Int = t => () => t;
        public static Func<string, Func<string>> String = t => () => t;
        public static Func<long, Func<long>> Long = t => () => t;
    }
}