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
        public static class FpConst
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
            public static Func<string> NowDayStr = CkFunctions.FpConst.FormatDateTime(DateTime.Now)("yyyy-MM-dd");

            /// <summary>
            /// 获取当前日期时间的字符串
            /// </summary>
            public static Func<string> NowTimeStr = CkFunctions.FpConst.FormatDateTime(DateTime.Now)("yyyy-MM-dd HH:mm:ss");

            /// <summary>
            /// 获取当前日期时间的字符串（带毫秒）
            /// </summary>
            public static Func<string> NowTimeFStr = CkFunctions.FpConst.FormatDateTime(DateTime.Now)("yyyy-MM-dd HH:mm:ss.fff");

            /// <summary>
            /// 获取当前日期的字符串（UTC时间）
            /// </summary>
            public static Func<string> NowUtcDayStr = CkFunctions.FpConst.FormatDateTime(DateTime.UtcNow)("yyyy-MM-dd");

            /// <summary>
            /// 获取当前日期时间的字符串（UTC时间）
            /// </summary>
            public static Func<string> NowUtcTimeStr = CkFunctions.FpConst.FormatDateTime(DateTime.UtcNow)("yyyy-MM-dd HH:mm:ss");

            /// <summary>
            /// 获取当前日期时间的字符串（UTC时间 带毫秒）
            /// </summary>
            public static Func<string> NowUtcTimeFStr = CkFunctions.FpConst.FormatDateTime(DateTime.UtcNow)("yyyy-MM-dd HH:mm:ss.fff");

            #endregion 时间相关

            #region 地址路径相关

            /// <summary>
            /// 获取程序基目录
            /// </summary>
            public static Func<string> BaseAddress = () => AppDomain.CurrentDomain.BaseDirectory;

            #endregion 地址路径相关
        }

        #region 对象转换为常量表达式

        /// <summary>
        /// 对象转为常量表达式
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static Func<T> Constant<T>(T obj)
        {
            return () => obj;
        }

        /// <summary>
        /// 获取<typeparamref name="T"/>转为常量的表达式
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static Func<T, Func<T>> Constant<T>()
        {
            return t => () => t;
        }

        public static Func<char, Func<char>> Char = CkFunctions.Constant<char>();
        public static Func<string, Func<string>> String = CkFunctions.Constant<string>();
        public static Func<byte, Func<byte>> Byte = CkFunctions.Constant<byte>();
        public static Func<sbyte, Func<sbyte>> SByte = CkFunctions.Constant<sbyte>();//带符号8位整数
        public static Func<bool, Func<bool>> Bool = CkFunctions.Constant<bool>();
        public static Func<int, Func<int>> Int = CkFunctions.Constant<int>();
        public static Func<uint, Func<uint>> UInt = CkFunctions.Constant<uint>();
        public static Func<nint, Func<nint>> NInt = CkFunctions.Constant<nint>();//带符号的IntPtr
        public static Func<nuint, Func<nuint>> NuInt = CkFunctions.Constant<nuint>();//不带符号的IntPtr
        public static Func<short, Func<short>> Short = CkFunctions.Constant<short>();
        public static Func<ushort, Func<ushort>> UShort = CkFunctions.Constant<ushort>();
        public static Func<long, Func<long>> Long = CkFunctions.Constant<long>();
        public static Func<ulong, Func<ulong>> ULong = CkFunctions.Constant<ulong>();

        #endregion 对象转换为常量表达式
    }
}