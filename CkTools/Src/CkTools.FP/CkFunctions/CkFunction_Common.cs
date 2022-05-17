using System;
using System.Collections.Generic;
using System.Linq;
using CkTools.FP.Model;

namespace CkTools.FP
{
    /// <summary>
    /// 函数式功能-小的公共功能
    /// </summary>
    public static partial class CkFunctions
    {
        #region 处理对象

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

        #endregion 处理对象

        #region JoinIndex

        public static Func<LinkedList<Entry>, string> JoinIndex(string prefix = "exp")
        {
            return arr => string.Join(",", arr.Select(t => $"{prefix}{t.Index}"));
        }

        public static Func<LinkedList<Entry<T>>, string> JoinIndex2<T>(string prefix = "exp")
        {
            return arr => string.Join(",", arr.Select(t => $"{prefix}{t.Index}"));
        }

        #endregion JoinIndex

        #region DefaultBatchThrow

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

        #endregion DefaultBatchThrow
    }
}