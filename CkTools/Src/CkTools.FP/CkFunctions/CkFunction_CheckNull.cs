using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace CkTools.FP
{
    /// <summary>
    /// 函数式功能-检查空
    /// </summary>
    public static partial class CkFunctions
    {
        #region CheckNullWithException

        #region 分参数名抛出异常

        /// <summary>
        /// 记录参数信息
        /// </summary>
        private struct ArgInfo
        {
            public object? Arg { get; set; }
            public string Name { get; set; }
        }

        /// <summary>
        /// 聚合参数名，抛出参数为空异常
        /// </summary>
        private static Action<IEnumerable<ArgInfo>> joinMsgThrow = arg => throw new ArgumentNullException(string.Join(",", arg.Select(t => t.Name)));

        /// <summary>
        /// [私有-检查函数]检查对象集合中是否有空值,有空值时抛出异常
        /// </summary>
        /// <param name="args"></param>
        private static void InternalCheckNullWithException(params ArgInfo[] args)
        {
            CkFunctions.ForeachEnd<ArgInfo>(joinMsgThrow)(t => t.Arg == null)(args);
        }

        public static void CheckNullWithException(
            object? arg1,
            [CallerArgumentExpression(nameof(arg1))] string arg1Name = "")
        {
            ArgInfo[] argArray =
            [
                new() {Arg = arg1, Name = arg1Name}
            ];
            CkFunctions.InternalCheckNullWithException(argArray);
        }

        public static void CheckNullWithException(
            object? arg1,
            object? arg2,
            [CallerArgumentExpression(nameof(arg1))] string arg1Name = "",
            [CallerArgumentExpression(nameof(arg2))] string arg2Name = "")
        {
            ArgInfo[] argArray =
            [
                new() {Arg = arg1, Name = arg1Name},
                new() {Arg = arg2, Name = arg2Name}
            ];
            CkFunctions.InternalCheckNullWithException(argArray);
        }

        public static void CheckNullWithException(
            object? arg1,
            object? arg2,
            object? arg3,
            [CallerArgumentExpression(nameof(arg1))] string arg1Name = "",
            [CallerArgumentExpression(nameof(arg2))] string arg2Name = "",
            [CallerArgumentExpression(nameof(arg3))] string arg3Name = "")
        {
            ArgInfo[] argArray =
            [
                new() {Arg = arg1, Name = arg1Name},
                new() {Arg = arg2, Name = arg2Name},
                new() {Arg = arg3, Name = arg3Name}
            ];
            CkFunctions.InternalCheckNullWithException(argArray);
        }

        public static void CheckNullWithException(
            object? arg1,
            object? arg2,
            object? arg3,
            object? arg4,
            [CallerArgumentExpression(nameof(arg1))] string arg1Name = "",
            [CallerArgumentExpression(nameof(arg2))] string arg2Name = "",
            [CallerArgumentExpression(nameof(arg3))] string arg3Name = "",
            [CallerArgumentExpression(nameof(arg4))] string arg4Name = "")
        {
            ArgInfo[] argArray =
            [
                new() {Arg = arg1, Name = arg1Name},
                new() {Arg = arg2, Name = arg2Name},
                new() {Arg = arg3, Name = arg3Name},
                new() {Arg = arg4, Name = arg4Name}
            ];

            CkFunctions.InternalCheckNullWithException(argArray);
        }

        public static void CheckNullWithException(
            object? arg1,
            object? arg2,
            object? arg3,
            object? arg4,
            object? arg5,
            [CallerArgumentExpression(nameof(arg1))] string arg1Name = "",
            [CallerArgumentExpression(nameof(arg2))] string arg2Name = "",
            [CallerArgumentExpression(nameof(arg3))] string arg3Name = "",
            [CallerArgumentExpression(nameof(arg4))] string arg4Name = "",
            [CallerArgumentExpression(nameof(arg5))] string arg5Name = "")
        {
            ArgInfo[] argArray =
            [
                new() {Arg = arg1, Name = arg1Name},
                new() {Arg = arg2, Name = arg2Name},
                new() {Arg = arg3, Name = arg3Name},
                new() {Arg = arg4, Name = arg4Name},
                new() {Arg = arg5, Name = arg5Name}
            ];

            CkFunctions.InternalCheckNullWithException(argArray);
        }

        public static void CheckNullWithException(
            object? arg1,
            object? arg2,
            object? arg3,
            object? arg4,
            object? arg5,
            object? arg6,
            [CallerArgumentExpression(nameof(arg1))] string arg1Name = "",
            [CallerArgumentExpression(nameof(arg2))] string arg2Name = "",
            [CallerArgumentExpression(nameof(arg3))] string arg3Name = "",
            [CallerArgumentExpression(nameof(arg4))] string arg4Name = "",
            [CallerArgumentExpression(nameof(arg5))] string arg5Name = "",
            [CallerArgumentExpression(nameof(arg6))] string arg6Name = "")
        {
            ArgInfo[] argArray =
            [
                new() {Arg = arg1, Name = arg1Name},
                new() {Arg = arg2, Name = arg2Name},
                new() {Arg = arg3, Name = arg3Name},
                new() {Arg = arg4, Name = arg4Name},
                new() {Arg = arg5, Name = arg5Name},
                new() {Arg = arg6, Name = arg6Name}
            ];

            CkFunctions.InternalCheckNullWithException(argArray);
        }

        #endregion 分参数名抛出异常

        /// <summary>
        /// [检查函数]检查集合中是否有空值,有空值时抛出异常
        /// </summary>
        /// <param name="exps"></param>
        public static void CheckNullOrEmptyWithException(params IEnumerable?[]? exps)
        {
            CkFunctions.Foreach<IEnumerable>(t => throw new ArgumentNullException())(CkFunctions.isNullOrEmpty)(exps);
        }

        #endregion CheckNullWithException

        #region IsNull

        public static bool IsNull<T>(params T?[] exps)
            where T : class?
        {
            return exps.Any(t => t == null);
        }

        public static bool IsNull<T>(T exp)
            where T : class?
        {
            return exp == null;
        }

        #endregion IsNull

        #region IsNotNull

        public static bool IsNotNull<T>(params T[] exps)
            where T : class?
        {
            return exps.All(t => t != null);
        }

        public static bool IsNotNull<T>(T exp)
            where T : class?
        {
            return exp != null;
        }

        #endregion IsNotNull

        #region IsNullOrEmpty

        private static readonly Func<IEnumerable?, bool> isNullOrEmpty = exp => exp == null || !exp.Any();

        /// <summary>
        /// 判断集合是否为空或长度为0
        /// </summary>
        /// <param name="exps"></param>
        /// <returns></returns>
        public static bool IsNullOrEmpty(params IEnumerable?[]? exps)
        {
            return exps == null //检查空引用
                || !exps.Any()  //检查空集合
                || exps.Any(CkFunctions.isNullOrEmpty); //检查集合中的元素
        }

        /// <summary>
        /// 判断集合是否为空或长度为0
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static bool IsNullOrEmpty(IEnumerable? array)
        {
            return CkFunctions.isNullOrEmpty(array);
        }

        #endregion IsNullOrEmpty

        #region IsNotNullOrEmpty

        public static bool IsNotNullOrEmpty(params IEnumerable?[] exps)
        {
            return !IsNullOrEmpty(exps);
        }

        public static bool IsNotNullOrEmpty(IEnumerable? exp1)
        {
            return !IsNullOrEmpty(exp1);
        }

        #endregion IsNotNullOrEmpty
    }
}