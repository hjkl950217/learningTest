using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using CkTools.FP.Model;

namespace CkTools.FP
{
    /// <summary>
    /// 函数式功能-检查空
    /// </summary>
    public static partial class CkFunctions
    {
        #region 公共

        /// <summary>
        /// 处理对象,返回一个处理对象的函数
        /// </summary>
        /// <value>
        /// <para>函数1：判断函数,返回true时才会处理对象</para>
        /// <para>函数2：处理函数</para>
        /// </value>
        public static Func<
            Action<T>,
            Action<T>> ProcessObject<T>(Func<T, bool> judge)
        {
            return
                processObj =>
                exp =>
                {
                    if (judge(exp))
                    {
                        processObj(exp);
                    }
                };
        }

        /// <summary>
        /// 批量处理对象,返回一个处理对象集合的函数
        /// </summary>
        /// <value>
        /// <para>函数1：判断函数,返回true时才会处理对象</para>
        /// <para>函数2：处理函数,处理一个链表对象</para>
        /// </value>
        public static Func<
            Action<LinkedList<Entry<T>>>,
            Action<T[]>> BatchProcessObject<T>(Func<T, bool> judge)
        {
            return
                processObjs =>
                exps =>
                {
                    #region 异常检测

                    if (judge == null)
                    {
                        throw new ArgumentNullException(nameof(judge));
                    }

                    if (processObjs == null)
                    {
                        throw new ArgumentNullException(nameof(processObjs));
                    }

                    if (exps == null)
                    {
                        throw new ArgumentNullException(nameof(exps));
                    }

                    #endregion 异常检测

                    //判断
                    LinkedList<Entry<T>> errorList = new LinkedList<Entry<T>>();
                    for (int i = exps.Length - 1 ; i > -1 ; i--)
                    {
                        if (judge(exps[i]))
                        {
                            errorList.AddLast(Entry.Create(i, exps[i]));
                        }
                    }

                    //处理
                    if (errorList.Any())
                    {
                        processObjs(errorList);
                    }
                };
        }

        public static Func<LinkedList<Entry>, string> JoinIndex(string prefix = "exp")
        {
            return arr => string.Join(",", arr.Select(t => $"{prefix}{t.Index}"));
        }

        public static Func<LinkedList<Entry<T>>, string> JoinIndex2<T>(string prefix = "exp")
        {
            return arr => string.Join(",", arr.Select(t => $"{prefix}{t.Index}"));
        }

        /// <summary>
        /// 默认,将条目聚集后抛出一个<see cref="ArgumentNullException"/>
        /// </summary>
        public static Action<LinkedList<Entry<T>>> DefaultBatchThrow<T>()
        {
            return errorArray
                => throw new ArgumentNullException(CkFunctions.JoinIndex2<T>("exp")(errorArray));
        }

        /// <summary>
        /// 默认,将条目聚集后抛出一个<see cref="ArgumentNullException"/>
        /// </summary>
        public static Action<LinkedList<Entry>> DefaultBatchThrow()
        {
            return errorArray
                => throw new ArgumentNullException(string.Join(",", errorArray.Select(t => $"exp{t.Index}")));
        }

        #endregion 公共

        #region CheckNullWithException

        public static void CheckNullWithException(params object[] exps)
        //{
        //    if (exps == null)
        //        throw new ArgumentNullException(nameof(exps));

        //    for (int i = exps.Length - 1 ; i > -1 ; i--)
        //    {
        //        if (exps[i] == null)
        //            throw new ArgumentNullException($"exp{i + 1}");
        //    }

        //    Action<object[]>? aa = CkFunctions.BatchCkeckNull(CkFunctions.IsNull)(DefaultThrowBatchNull);
        //}
         => CkFunctions.BatchProcessObject<object>(CkFunctions.IsNull)(CkFunctions.DefaultBatchThrow<object>())(exps);

        /// <summary>
        /// 检查函数,检查对象集合中是否有空值,有空值时抛出异常
        /// </summary>
        public static Action<object[]> CheckNullWithExceptionArray = CkFunctions.CheckNullWithException;

        #endregion CheckNullWithException

        #region CheckNullOrEmptyWithException

        public static void CheckNullOrEmptyWithException<T>(params IEnumerable[] exps)
        //{
        //    if (exps == null || !exps.Any())
        //        throw new ArgumentNullException(nameof(exps));
        //    foreach (IEnumerable exp in exps)
        //    {
        //        if (exp == null || !exp.Any())
        //            throw new ArgumentNullException(nameof(exp));
        //    }
        //}
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