using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace CkTools.FP
{
    /// <summary>
    /// 函数式功能
    /// </summary>
    public static partial class CkFunctions
    {
        #region Action

        #region Compose镜像版本

        /* 横 exp1  竖 exp2
                        Action     Action<T>   Action<T2,T1>
         Action         1           1          1
         Action<T>      1           1          2
         Action<T2,T1>  1           2          1
         */

        public static Action Pipe(
            [NotNull] Action exp2,
            [NotNull] Action exp1)
        {
            CheckNullWithException(exp2, exp1);
            return CkFunctions.Compose(exp2, exp1);
        }

        public static Action<TInput> Pipe<TInput>(
            [NotNull] Action exp2,
            [NotNull] Action<TInput> exp1)
        {
            CheckNullWithException(exp2, exp1);
            return CkFunctions.Compose(exp2, exp1);
        }

        public static Action<TInput2, TInput1> Pipe<TInput2, TInput1>(
            [NotNull] Action exp2,
            [NotNull] Action<TInput2, TInput1> exp1)
        {
            CheckNullWithException(exp2, exp1);
            return CkFunctions.Compose(exp2, exp1);
        }

        public static Action<TInput> Pipe<TInput>(
            [NotNull] Action<TInput> exp2,
            [NotNull] Action exp1)
        {
            CheckNullWithException(exp2, exp1);
            return CkFunctions.Compose(exp2, exp1);
        }

        public static Action<TInput> Pipe<TInput>(
            [NotNull] Action<TInput> exp2,
            [NotNull] Action<TInput> exp1)
        {
            CheckNullWithException(exp2, exp1);
            return CkFunctions.Compose(exp2, exp1);
        }

        public static Action<TInput2, TInput1> Pipe<TInput2, TInput1>(
            [NotNull] Action<TInput2> exp2,
            [NotNull] Action<TInput2, TInput1> exp1)
        {
            CheckNullWithException(exp2, exp1);
            return CkFunctions.Compose(exp2, exp1);
        }

        public static Action<TInput2, TInput1> Pipe<TInput2, TInput1>(
            [NotNull] Action<TInput1> exp2,
            [NotNull] Action<TInput2, TInput1> exp1)
        {
            CheckNullWithException(exp2, exp1);
            return CkFunctions.Compose(exp2, exp1);
        }

        public static Action<TInput2, TInput1> Pipe<TInput2, TInput1>(
            [NotNull] Action<TInput2, TInput1> exp2,
            [NotNull] Action exp1)
        {
            CheckNullWithException(exp2, exp1);
            return CkFunctions.Compose(exp2, exp1);
        }

        public static Action<TInput2, TInput1> Pipe<TInput2, TInput1>(
            [NotNull] Action<TInput2, TInput1> exp2,
            [NotNull] Action<TInput2> exp1)
        {
            CheckNullWithException(exp2, exp1);
            return CkFunctions.Compose(exp2, exp1);
        }

        public static Action<TInput2, TInput1> Pipe<TInput2, TInput1>(
            [NotNull] Action<TInput2, TInput1> exp2,
            [NotNull] Action<TInput1> exp1)
        {
            CheckNullWithException(exp2, exp1);
            return CkFunctions.Compose(exp2, exp1);
        }

        public static Action<TInput2, TInput1> Pipe<TInput2, TInput1>(
            [NotNull] Action<TInput2, TInput1> exp2,
            [NotNull] Action<TInput2, TInput1> exp1)
        {
            CheckNullWithException(exp2, exp1);
            return CkFunctions.Compose(exp2, exp1);
        }

        #endregion Compose镜像版本

        #region 其它

        public static Action Pipe(
            [NotNull] params Action[] exps)
        {
            CheckNullWithException(exps);
            switch (exps.Length)
            {
                case 0:
                    return () => { };

                case 1:
                    return exps[0];

                default:
                {
                    Action temp = exps[0];
                    foreach (Action? item in exps[1..].Where(t => t != null))
                    {
                        temp += item;
                    }
                    return temp;
                }
            }
        }

        public static Action<TInput> Pipe<TInput>(
            [NotNull] params Action<TInput>[] exps)
        {
            CheckNullWithException(exps);
            switch (exps.Length)
            {
                case 0:
                    return t => { };

                case 1:
                    return exps[0];

                default:
                {
                    Action<TInput> temp = exps[0];
                    foreach (Action<TInput>? item in exps[1..].Where(t => t != null))
                    {
                        temp += item;
                    }
                    return temp;
                }
            }
        }

        public static Action<TInput1, TInput2> Pipe<TInput1, TInput2>(
            [NotNull] params Action<TInput1, TInput2>[] exps)
        {
            CheckNullWithException(exps);
            switch (exps.Length)
            {
                case 0:
                    return (t1, t2) => { };

                case 1:
                    return exps[0];

                default:
                {
                    Action<TInput1, TInput2> temp = exps[0];
                    foreach (Action<TInput1, TInput2>? item in exps[1..].Where(t => t != null))
                    {
                        temp += item;
                    }
                    return temp;
                }
            }
        }

        #endregion 其它

        #endregion Action

        #region Func - 0入参 1出参

        /// <summary>
        /// 管道
        /// </summary>
        /// <param name="exp"></param>
        /// <param name="exps"></param>
        /// <returns></returns>
        public static Func<TOutput> Pipe<TOutput>(
            [NotNull] Func<TOutput> exp,
            [NotNull] params Action<TOutput>[] exps)
        {
            CkFunctions.CheckNullWithException(exp, exps);

            return () =>
            {
                TOutput result = exp();
                exps.For(t => t(result));
                return result;
            };
        }

        #endregion Func - 0入参 1出参

        #region Fun - 1入参 1出参

        #endregion Fun - 1入参 1出参

        ///// <summary>
        ///// 管道
        ///// </summary>
        ///// <param name="exp"></param>
        ///// <param name="exps"></param>
        ///// <returns></returns>
        //public static Func<TOutput> Pipe<TOutput>(
        //    [NotNull] Func<TOutput> exp,
        //    [NotNull] params Action<TOutput>[] exps)
        //{
        //    exp.CheckNullWithException(nameof(exp));
        //    exps.CheckNullWithException(nameof(exps));

        //    return () =>
        //    {
        //        TOutput result = exp();
        //        exps.For(t => t(result));
        //        return result;
        //    };
        //}

        /// <summary>
        /// 管道
        /// </summary>
        /// <typeparam name="TInput"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="exp"></param>
        /// <param name="exps"></param>
        /// <returns></returns>
        public static Func<TInput, TResult> Pipe<TInput, TResult>(
            [NotNull] Func<TInput, TResult> exp,
            [NotNull] params Func<TResult, TResult>[] exps)
        {
            CkFunctions.CheckNullWithException(exp, exps);

            return t =>
            {
                TResult tempResult = exp(t);
                exps.For(item => tempResult = item(tempResult));
                return tempResult;
            };
        }

        /// <summary>
        /// 管道
        /// </summary>
        /// <typeparam name="TInput"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="exp"></param>
        /// <param name="exps"></param>
        /// <returns></returns>
        public static Func<TInput, TResult> Pipe<TInput, TResult>(
            [NotNull] Func<TInput, TResult> exp,
            [NotNull] params Action<TResult>[] exps)
        {
            CkFunctions.CheckNullWithException(exp, exps);

            return input =>
            {
                TResult tempResult = exp(input);
                exps.For(item => item(tempResult));

                return tempResult;
            };
        }

        ///// <summary>
        ///// 管道
        ///// </summary>
        ///// <typeparam name="TInput"></typeparam>
        ///// <typeparam name="TCenter"></typeparam>
        ///// <typeparam name="TResult"></typeparam>
        ///// <param name="exp"></param>
        ///// <param name="func"></param>
        ///// <returns></returns>
        //public static Func<TInput, TResult> Pipe<TInput, TCenter, TResult>(
        //  [NotNull] Func<TInput, TCenter> exp,
        //  [NotNull] Func<TCenter, TResult> func)
        //{
        //    exp.CheckNullWithException(nameof(exp));
        //    func.CheckNullWithException(nameof(func));
        //    return t => func(exp(t));
        //}
    }
}