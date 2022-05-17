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

        public static void CheckNullWithException(params object[] exps)
         => CkFunctions.BatchProcessObject<object>(CkFunctions.IsNull)(CkFunctions.DefaultBatchThrow<object>())(exps);

        /// <summary>
        /// 检查函数,检查对象集合中是否有空值,有空值时抛出异常
        /// </summary>
        public static Action<object[]> CheckNullWithExceptionArray = CkFunctions.CheckNullWithException;

        #endregion CheckNullWithException

        #region CheckNullOrEmptyWithException

        public static void CheckNullOrEmptyWithException<T>(params IEnumerable[] exps)
        => CkFunctions.BatchProcessObject<IEnumerable>(CkFunctions.IsNullOrEmpty)(CkFunctions.DefaultBatchThrow<IEnumerable>())(exps);

        #endregion CheckNullOrEmptyWithException

        #region IsNull

        public static bool IsNull(params object[] exps)
        {
            return exps == null || exps.Any(t => t == null);
        }

        public static bool IsNull<T1>(T1 exp)
        {
            return exp == null;
        }

        #endregion IsNull

        #region IsNotNull

        public static bool IsNotNull<T>(params T[] exps)
        {
            return !IsNull(exps);
        }

        public static bool IsNotNull<T1>(T1 exp)
        {
            return !IsNull(exp);
        }

        #endregion IsNotNull

        #region IsNullOrEmpty

        public static bool IsNullOrEmpty(params IEnumerable[] exps)
        {
            return exps == null //检查空引用
                || !exps.Any()  //检查空集合
                || exps.Any(CkFunctions.IsNullOrEmpty); //检查集合中的元素
        }

        public static bool IsNullOrEmpty(IEnumerable exp)
        {
            return exp == null
                || !exp.Any();
        }

        #endregion IsNullOrEmpty

        #region IsNotNullOrEmpty

        public static bool IsNotNullOrEmpty<T>(params T[] exps)
            where T : IEnumerable
        {
            return !IsNullOrEmpty(exps);
        }

        public static bool IsNotNullOrEmpty<T1>(T1 exp1)
            where T1 : IEnumerable
        {
            return !IsNullOrEmpty(exp1);
        }

        #endregion IsNotNullOrEmpty
    }
}