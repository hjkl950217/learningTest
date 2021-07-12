//using System;
//using System.Collections.Generic;
//using System.Diagnostics.CodeAnalysis;
//using System.Threading.Tasks;

//namespace CkTools.FP
//{
//    /// <summary>
//    /// 函数式功能
//    /// </summary>
//    public static partial class CkFunctions
//    {
//        #region 0个入参

//        /// <summary>
//        /// 管道
//        /// </summary>
//        /// <param name="sourceFunc"></param>
//        /// <param name="funcs"></param>
//        /// <returns></returns>
//        public static Func<Task> PipeAsync(
//            [NotNull] Func<Task> sourceFunc,
//            [NotNull] params Func<Task>[] funcs)
//        {
//            sourceFunc.CheckNullWithException(nameof(sourceFunc));
//            funcs.CheckNullWithException(nameof(funcs));

//            return () =>
//            {
//                Task firstTask = sourceFunc();

//                Task tempTask = firstTask;
//                funcs.For(func =>
//                {
//                    tempTask = tempTask.ContinueWith((tk, obj) => func(), TaskContinuationOptions.OnlyOnRanToCompletion);
//                });

//                return firstTask;
//            };
//        }

//        /// <summary>
//        /// 管道
//        /// </summary>
//        /// <typeparam name="TOutput"></typeparam>
//        /// <param name="sourceFunc"></param>
//        /// <param name="funcs"></param>
//        /// <returns></returns>
//        public static Func<Task<TOutput?>> PipeAsync<TOutput>(
//            [NotNull] Func<Task<TOutput?>> sourceFunc,
//            [NotNull] params Func<TOutput?, Task>[] funcs)
//            where TOutput : class
//        {
//            sourceFunc.CheckNullWithException(nameof(sourceFunc));
//            funcs.CheckNullWithException(nameof(funcs));

//            return () =>
//            {
//                Task<TOutput?> firstTask = sourceFunc();

//                TOutput? tempResult = null;
//                firstTask.ContinueWith(t => tempResult = t.Result, TaskContinuationOptions.OnlyOnRanToCompletion);
//                Task tempTask = firstTask;
//                foreach (Func<TOutput?, Task> func in funcs)
//                {
//                    Action<Task, object> tempFunc = (tk, obj) =>
//                    {
//                        Task cc = func(tempResult);
//                        cc.Wait();
//                    };

//                    tempTask = tempTask.ContinueWith(tempFunc, TaskContinuationOptions.OnlyOnRanToCompletion);
//                }

//                return firstTask;
//            };
//        }

//        #endregion 0个入参

//        #region 1个入参

//        /// <summary>
//        /// 管道
//        /// </summary>
//        /// <typeparam name="TInput"></typeparam>
//        /// <param name="sourceFunc"></param>
//        /// <param name="funcs"></param>
//        /// <returns></returns>
//        public static Func<TInput, Task> PipeAsync<TInput>(
//            [NotNull] Func<TInput, Task> sourceFunc,
//            [NotNull] params Func<TInput, Task>[] funcs)
//        {
//            sourceFunc.CheckNullWithException(nameof(sourceFunc));
//            funcs.CheckNullWithException(nameof(funcs));

//            return input =>
//            {
//                Task firstTask = sourceFunc(input);

//                Task tempTask = firstTask;
//                foreach (Func<TInput, Task> func in funcs)
//                {
//                    tempTask = tempTask.ContinueWith(tk => func(input), TaskContinuationOptions.OnlyOnRanToCompletion);
//                }

//                return firstTask;
//            };
//        }

//        /// <summary>
//        /// 管道
//        /// </summary>
//        /// <typeparam name="TInput"></typeparam>
//        /// <typeparam name="TResult"></typeparam>
//        /// <param name="sourceFunc"></param>
//        /// <param name="funcs"></param>
//        /// <returns></returns>
//        public static Func<TInput, Task<TResult>> PipeAsync<TInput, TResult>(
//            [NotNull] Func<TInput, Task<TResult>> sourceFunc,
//            [NotNull] params Func<TResult, Task<TResult>>[] funcs)
//        {
//            sourceFunc.CheckNullWithException(nameof(sourceFunc));
//            funcs.CheckNullWithException(nameof(funcs));

//            return input =>
//            {
//                Task<TResult> firstTask = sourceFunc(input);

//                Task<TResult> tempTask = firstTask;
//                foreach (Func<TResult, Task<TResult>> func in funcs)
//                {
//                    Func<Task<TResult>, TResult> tempFunc = (tk) =>
//                    {
//                        Task<TResult> cc = func(tk.Result);
//                        cc.Wait();
//                        return cc.Result;
//                    };

//                    tempTask = tempTask.ContinueWith(tempFunc, TaskContinuationOptions.OnlyOnRanToCompletion);
//                }

//                return firstTask;
//            };
//        }

//        /// <summary>
//        /// 管道
//        /// </summary>
//        /// <typeparam name="TInput"></typeparam>
//        /// <typeparam name="TResult"></typeparam>
//        /// <param name="sourceFunc"></param>
//        /// <param name="funcs"></param>
//        /// <returns></returns>
//        public static Func<TInput, Task<TResult?>> PipeAsync<TInput, TResult>(
//            [NotNull] Func<TInput, Task<TResult?>> sourceFunc,
//            [NotNull] params Func<TResult?, Task>[] funcs)
//            where TResult : class
//        {
//            sourceFunc.CheckNullWithException(nameof(sourceFunc));
//            funcs.CheckNullWithException(nameof(funcs));

//            return input =>
//            {
//                Task<TResult?> firstTask = sourceFunc(input);

//                //取出第一个函数的返回值 放入临时变量中
//                TResult? tempResult = null;
//                firstTask.ContinueWith(t => tempResult = t.Result, TaskContinuationOptions.OnlyOnRanToCompletion);

//                Task tempTask = firstTask;
//                foreach (Func<TResult?, Task> func in funcs)
//                {
//                    Func<Task, Task> tempFunc = (tk) =>
//                    {
//                        Task cc = func(tempResult);
//                        cc.Wait();
//                        return cc;
//                    };

//                    tempTask = tempTask.ContinueWith(tempFunc, TaskContinuationOptions.OnlyOnRanToCompletion);
//                }

//                return firstTask;
//            };
//        }

//        /// <summary>
//        /// 管道
//        /// </summary>
//        /// <typeparam name="TInput"></typeparam>
//        /// <typeparam name="TCenter"></typeparam>
//        /// <typeparam name="TResult"></typeparam>
//        /// <param name="sourceFunc"></param>
//        /// <param name="func"></param>
//        /// <returns></returns>
//        public static Func<TInput, Task<TResult>> PipeAsync<TInput, TCenter, TResult>(
//          [NotNull] Func<TInput, Task<TCenter>> sourceFunc,
//          [NotNull] Func<TCenter, Task<TResult>> func)
//        {
//            sourceFunc.CheckNullWithException(nameof(sourceFunc));
//            func.CheckNullWithException(nameof(func));

//            return input =>
//            {
//                Task<TCenter> firstTask = sourceFunc(input);
//                Task<TResult> resultTask = firstTask.ContinueWith(tk =>
//               {
//                   Task<TResult> cc = func(tk.Result);
//                   cc.Wait();
//                   return cc.Result;
//               }, TaskContinuationOptions.OnlyOnRanToCompletion);

//                return resultTask;
//            };
//        }

//        #endregion 1个入参
//    }
//}