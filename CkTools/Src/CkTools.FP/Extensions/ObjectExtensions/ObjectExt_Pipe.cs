using System.Diagnostics.CodeAnalysis;
using CkTools.FP;

namespace System
{
    public static class ObjectExt_Pipe
    {
        #region Action-无入参

        /// <summary>
        /// 管道
        /// </summary>
        /// <typeparam name="TObject"></typeparam>
        /// <param name="sourceObject">源对象</param>
        /// <param name="actions">要执行的操作集合</param>
        /// <returns></returns>
        public static TObject Pipe<TObject>(
            this TObject sourceObject,
            [NotNull] params Action[] actions)
        {
            CkFunctions.CheckNullWithException(actions);

            CkFunctions.ComposeReverse(actions)();
            return sourceObject;
        }

        #endregion Action-无入参

        #region Action-1个入参

        /// <summary>
        /// 管道
        /// </summary>
        /// <typeparam name="TObject"></typeparam>
        /// <param name="sourceObject">源对象</param>
        /// <param name="action">要执行的操作</param>
        /// <returns></returns>
        public static TObject Pipe<TObject>(
            this TObject sourceObject,
            [NotNull] Action<TObject> action)
        {
            CkFunctions.CheckNullWithException(action);
            action(sourceObject);
            return sourceObject;
        }

        /// <summary>
        /// 管道
        /// </summary>
        /// <typeparam name="TObject"></typeparam>
        /// <param name="sourceObject">源对象</param>
        /// <param name="actions">要执行的操作集合</param>
        /// <returns></returns>
        public static TObject Pipe<TObject>(
            this TObject sourceObject,
            [NotNull] params Action<TObject>[] actions)
        {
            CkFunctions.CheckNullWithException(actions);
            CkFunctions.ComposeReverse(actions)(sourceObject);
            return sourceObject;
        }

        #endregion Action-1个入参

        #region Action-其它

        #endregion Action-其它

        #region Func

        /// <summary>
        /// 管道
        /// </summary>
        /// <Value>
        /// <para><paramref name="sourceObject"/>：要处理的值 </para>
        /// <para><paramref name="func"/>：将要执行的处理 </para>
        /// </Value>
        /// <typeparam name="TObject">可传递任意类型</typeparam>
        /// <typeparam name="TOutput">输出类型</typeparam>
        /// <returns></returns>
        public static TOutput Pipe<TObject, TOutput>(
            this TObject sourceObject,
            [NotNull] Func<TObject, TOutput> func)
        {
            CkFunctions.CheckNullWithException(func);
            return func(sourceObject);
        }

        /// <summary>
        /// 管道
        /// </summary>
        /// <Value>
        /// <para><paramref name="sourceObject"/>：要处理的值 </para>
        /// <para><paramref name="func"/>：将要执行的处理 </para>
        /// </Value>
        /// <typeparam name="TObject">可传递任意类型</typeparam>
        /// <returns></returns>
        public static TObject Pipe<TObject>(
            this TObject sourceObject,
            [NotNull] Func<TObject, TObject> func)
        {
            CkFunctions.CheckNullWithException(func);
            return func(sourceObject);
        }

        #endregion Func
    }
}