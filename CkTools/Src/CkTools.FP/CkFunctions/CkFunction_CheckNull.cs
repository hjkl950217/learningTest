using System;
using System.Collections;
using System.Linq;

namespace CkTools.FP
{
    /// <summary>
    /// 函数式功能-检查空
    /// </summary>
    public static partial class CkFunctions
    {
        #region CheckNullWithException

        /// <summary>
        /// [检查函数]检查对象集合中是否有空值,有空值时抛出异常
        /// </summary>
        /// <param name="exps"></param>
        public static void CheckNullWithException(params object?[]? exps)
        {
            CkFunctions.Foreach<object>(t => throw new ArgumentNullException())(CkFunctions.IsNull)(exps);
        }

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
        /// <param name="exp"></param>
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