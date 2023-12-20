using System;

namespace CkTools.FP
{
    /// <summary>
    /// 函数式功能-对象或泛型方法
    /// </summary>
    public static partial class CkFunctions
    {
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
        /// 对象转为常量表达式
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static Func<T, Func<T>> Constant<T>()
        {
            return t => () => t;
        }

        public static Func<string, Func<string>> String = CkFunctions.Constant<string>();
        public static Func<byte, Func<byte>> Byte = CkFunctions.Constant<byte>();
        public static Func<bool, Func<bool>> Bool = CkFunctions.Constant<bool>();
        public static Func<int, Func<int>> Int = CkFunctions.Constant<int>();
        public static Func<uint, Func<uint>> UInt = CkFunctions.Constant<uint>();
        public static Func<short, Func<short>> Short = CkFunctions.Constant<short>();
        public static Func<ushort, Func<ushort>> UShort = CkFunctions.Constant<ushort>();
        public static Func<long, Func<long>> Long = CkFunctions.Constant<long>();
        public static Func<ulong, Func<ulong>> ULong = CkFunctions.Constant<ulong>();
    }
}