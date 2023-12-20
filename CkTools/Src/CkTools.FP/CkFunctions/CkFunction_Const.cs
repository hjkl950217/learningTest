using System;

namespace CkTools.FP
{
    /// <summary>
    /// 函数式功能-常量
    /// </summary>
    /// <remarks>
    /// 定义被认为是"数据"的常量表达式<br/>
    /// 只定义委托变量，不定义方法
    /// </remarks>
    public static partial class CkFunctions
    {
        public static Action EmtpyAction = () => { };

        #region 基础值对应的常量表达式

        public static Func<bool> True = () => true;
        public static Func<bool> False = () => false;

        #endregion 基础值对应的常量表达式

        #region 时间相关

        /// <summary>
        /// 格式化时间为字符串
        /// </summary>
        public static Func<DateTime, Func<string, Func<string>>> FormatDateTime = dt => format => () => dt.ToString(format);

        /// <summary>
        /// 获取当前日期的字符串
        /// </summary>
        public static Func<string> NowDayStr = CkFunctions.FormatDateTime(DateTime.Now)("yyyy-MM-dd");

        /// <summary>
        /// 获取当前日期时间的字符串
        /// </summary>
        public static Func<string> NowTimeStr = CkFunctions.FormatDateTime(DateTime.Now)("yyyy-MM-dd HH:mm:ss");

        /// <summary>
        /// 获取当前日期时间的字符串（带毫秒）
        /// </summary>
        public static Func<string> NowTimeFStr = CkFunctions.FormatDateTime(DateTime.Now)("yyyy-MM-dd HH:mm:ss.fff");

        /// <summary>
        /// 获取当前日期的字符串（UTC时间）
        /// </summary>
        public static Func<string> NowUtcDayStr = CkFunctions.FormatDateTime(DateTime.UtcNow)("yyyy-MM-dd");

        /// <summary>
        /// 获取当前日期时间的字符串（UTC时间）
        /// </summary>
        public static Func<string> NowUtcTimeStr = CkFunctions.FormatDateTime(DateTime.UtcNow)("yyyy-MM-dd HH:mm:ss");

        /// <summary>
        /// 获取当前日期时间的字符串（UTC时间 带毫秒）
        /// </summary>
        public static Func<string> NowUtcTimeFStr = CkFunctions.FormatDateTime(DateTime.UtcNow)("yyyy-MM-dd HH:mm:ss.fff");

        #endregion 时间相关

        #region 地址路径相关

        /// <summary>
        /// 获取程序基目录
        /// </summary>
        public static Func<string> BaseAddress = () => AppDomain.CurrentDomain.BaseDirectory;

        #endregion 地址路径相关
    }
}