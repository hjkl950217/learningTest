using System;

namespace CkTools.FP
{
    /// <summary>
    /// 函数式功能-常量
    /// </summary>
    /// <remarks>
    /// 定义被认为是"数据"的常量表达式
    /// </remarks>
    public static partial class CkFunctions
    {
        public static Action EmtpyAction = () => { };

        #region 基础数据转为常量表达式

        public static Func<bool> True = () => true;
        public static Func<bool> False = () => false;

        #endregion 基础数据转为常量表达式

        #region 时间相关

        /// <summary>
        /// 获取当前日期的字符串
        /// </summary>
        public static Func<string> NowDayStr = () => DateTime.Now.ToString("yyyy-MM-dd");

        /// <summary>
        /// 获取当前日期时间的字符串
        /// </summary>
        public static Func<string> NowTimeStr = () => DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

        /// <summary>
        /// 获取当前日期时间的字符串（带毫秒）
        /// </summary>
        public static Func<string> NowTimeFStr = () => DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");

        /// <summary>
        /// 获取当前日期的字符串（UTC时间）
        /// </summary>
        public static Func<string> NowUtcDayStr = () => DateTime.UtcNow.ToString("yyyy-MM-dd");

        /// <summary>
        /// 获取当前日期时间的字符串（UTC时间）
        /// </summary>
        public static Func<string> NowUtcTimeStr = () => DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss");

        /// <summary>
        /// 获取当前日期时间的字符串（UTC时间 带毫秒）
        /// </summary>
        public static Func<string> NowUtcTimeFStr = () => DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss.fff");

        #endregion 时间相关

        #region 地址路径相关

        /// <summary>
        /// 获取程序基目录
        /// </summary>
        public static Func<string> BaseAddress = () => AppDomain.CurrentDomain.BaseDirectory;

        #endregion 地址路径相关
    }
}