using System;
using System.Diagnostics.CodeAnalysis;

namespace CkTools.FP.Executer
{
    /// <summary>
    /// <see cref="ActionExecuter"/>的扩展
    /// </summary>
    public static class ActionExecuterExtensions
    {
        #region Pipe 管道

        /// <summary>
        /// 管道-添加一个<see cref="Action"/>到管道中
        /// </summary>
        /// <param name="executer">执行器实例</param>
        /// <param name="action">要添加的委托</param>
        /// <returns></returns>
        public static ActionExecuter Pipe(
            [NotNull] this ActionExecuter executer,
            [NotNull] Action action)
        {
            CkFunctions.CheckNullWithException(executer, action);

            executer.StepList.Add(action);
            return executer;
        }

        /// <summary>
        /// 管道-有条件的添加一个<see cref="Action"/>到管道中
        /// </summary>
        /// <param name="executer">执行器实例</param>
        /// <param name="predicate">条件判断</param>
        /// <param name="action1">当条件为true时添加的委托</param>
        /// <param name="action2">当条件为false时添加的委托</param>
        /// <returns></returns>
        public static ActionExecuter PipeIf(
            [NotNull] this ActionExecuter executer,
            [NotNull] bool predicate,
            [NotNull] Action action1,
            [NotNull] Action action2)
        {
            CkFunctions.CheckNullWithException(executer, action1, action2);

            if (predicate)
            {
                executer.StepList.Add(action1);
            }
            else
            {
                executer.StepList.Add(action2);
            }
            return executer;
        }

        /// <summary>
        /// 管道-有条件的添加一个<see cref="Action"/>到管道中
        /// </summary>
        /// <param name="executer">执行器实例</param>
        /// <param name="predicate">条件判断</param>
        /// <param name="action">当条件为true时添加的委托</param>
        /// <returns></returns>
        public static ActionExecuter PipeIf(
            [NotNull] this ActionExecuter executer,
            [NotNull] bool predicate,
            [NotNull] Action action)
        {
            CkFunctions.CheckNullWithException(executer, action);

            if (predicate)
            {
                executer.StepList.Add(action);
            }

            return executer;
        }

        /// <summary>
        /// 管道-有条件的添加一个<see cref="Action"/>到管道中
        /// </summary>
        /// <param name="executer">执行器实例</param>
        /// <param name="predicate">条件判断委托</param>
        /// <param name="action1">当条件为true时添加的委托</param>
        /// <param name="action2">当条件为false时添加的委托</param>
        /// <returns></returns>
        public static ActionExecuter PipeIf(
            [NotNull] this ActionExecuter executer,
            [NotNull] Func<bool> predicate,
            [NotNull] Action action1,
            [NotNull] Action action2)
        {
            CkFunctions.CheckNullWithException(executer, predicate, action1, action1);

            executer.PipeIf(predicate(), action1, action2);
            return executer;
        }

        /// <summary>
        /// 管道-有条件的添加一个<see cref="Action"/>到管道中
        /// </summary>
        /// <param name="executer">执行器实例</param>
        /// <param name="predicate">条件判断委托</param>
        /// <param name="action">当条件为true时添加的委托</param>
        /// <returns></returns>
        public static ActionExecuter PipeIf(
            [NotNull] this ActionExecuter executer,
            [NotNull] Func<bool> predicate,
            [NotNull] Action action)
        {
            CkFunctions.CheckNullWithException(executer, predicate, action);

            executer.PipeIf(predicate(), action);
            return executer;
        }

        #endregion Pipe 管道

        #region MayEndPipe 可能结束的管道

        /// <summary>
        /// 可能结束的管道节点,true时执行后续节点,false时结束执行
        /// </summary>
        /// <param name="executer">执行器实例</param>
        /// <param name="predicate">是否结束判断委托</param>
        /// <param name="onEnded">结束后执行的委托</param>
        [Obsolete("请使用End、EndIf、Continue来让管道更加清晰")]
        public static ActionExecuter MayEndPipe(
            [NotNull] this ActionExecuter executer,
            [NotNull] Func<bool> predicate,
            [NotNull] Action onEnded)
        {
            CkFunctions.CheckNullWithException(executer, predicate, onEnded);

            executer.StepList.Add(() =>
            {
                executer.IsEnd = predicate();
                if (executer.IsEnd) onEnded();//为true时执行后续
            });
            return executer;
        }

        /// <summary>
        /// 可能结束的管道节点,true时执行后续节点,false时结束执行
        /// </summary>
        /// <param name="executer">执行器实例</param>
        /// <param name="isEnd">是否结束</param>
        [Obsolete("请使用End、EndIf、Continue来让管道更加清晰")]
        public static ActionExecuter MayEndPipe(
            [NotNull] this ActionExecuter executer,
            [NotNull] bool isEnd)
        {
            CkFunctions.CheckNullWithException(executer);

            return executer.EndIf(
                predicate: CkFunctions.True,
                onEnded: ActionExecuter.NullAction);
        }

        /// <summary>
        /// 可能结束的管道节点,true时执行后续节点,false时结束执行
        /// </summary>
        /// <param name="executer">执行器实例</param>
        /// <param name="predicate">是否结束判断委托</param>
        [Obsolete("请使用End、EndIf、Continue来让管道更加清晰")]
        public static ActionExecuter MayEndPipe(
            [NotNull] this ActionExecuter executer,
            [NotNull] Func<bool> predicate)
        {
            CkFunctions.CheckNullWithException(executer);

            return executer.EndIf(
                predicate: predicate,
                onEnded: ActionExecuter.NullAction);
        }

        #endregion MayEndPipe 可能结束的管道

        #region End

        /// <summary>
        /// 指定管道忽略之前的状态，结束执行
        /// </summary>
        /// <param name="executer"></param>
        /// <returns></returns>
        public static ActionExecuter End(
            [NotNull] this ActionExecuter executer)
        {
            CkFunctions.CheckNullWithException(executer);

            executer.Pipe(() => executer.IsEnd = true);
            return executer;
        }

        /// <summary>
        /// 管道在满足条件时，结束执行
        /// </summary>
        /// <param name="executer">执行器实例</param>
        /// <param name="predicate">是否结束判断委托</param>
        /// <param name="onEnded">结束后执行的委托</param>
        /// <returns></returns>
        public static ActionExecuter EndIf(
            [NotNull] this ActionExecuter executer,
            [NotNull] Func<bool> predicate,
            Action? onEnded = null)
        {
            CkFunctions.CheckNullWithException(executer, predicate, onEnded);

            executer.StepList.Add(() =>
            {
                executer.IsEnd = predicate();
                if (executer.IsEnd) onEnded?.Invoke();//为true时执行后续
            });
            return executer;
        }

        /// <summary>
        /// 管道在满足条件时，结束执行
        /// </summary>
        /// <param name="executer">执行器实例</param>
        /// <param name="isEnd">是否结束</param>
        /// <param name="onEnded">结束后执行的委托</param>
        /// <returns></returns>
        public static ActionExecuter EndIf(
            [NotNull] this ActionExecuter executer,
            [NotNull] bool isEnd,
            Action? onEnded = null)
        {
            CkFunctions.CheckNullWithException(executer);

            return executer.EndIf(
                predicate: CkFunctions.Bool(isEnd),
                onEnded: onEnded);
        }

        #endregion End

        #region Continue

        /// <summary>
        /// 指定管道忽略之前的状态，继续执行
        /// </summary>
        /// <param name="executer"></param>
        /// <returns></returns>
        public static ActionExecuter Continue(
            [NotNull] this ActionExecuter executer)
        {
            CkFunctions.CheckNullWithException(executer);
            executer.Pipe(() => executer.IsEnd = false);
            return executer;
        }

        #endregion Continue

        #region Debug调试

        /// <summary>
        /// 调试,添加一个调试的<see cref="Action"/>到管道中
        /// </summary>
        /// <param name="executer">执行器实例</param>
        /// <param name="debugInfo">调试信息</param>
        /// <returns></returns>
        public static ActionExecuter Debug(
            [NotNull] this ActionExecuter executer,
            [NotNull] string debugInfo)
        {
            CkFunctions.CheckNullWithException(executer);
            if (CkFunctions.IsNullOrEmpty(debugInfo)) return executer;

            return executer.Pipe(() => Console.WriteLine($"{DateTime.Now:yyyy-MM-dd HH:mm:ss.fff} {debugInfo}"));
        }

        /// <summary>
        /// 调试,添加一个调试的<see cref="Action"/>到管道中
        /// </summary>
        /// <param name="executer">执行器实例</param>
        /// <param name="debugInfo">调试信息</param>
        /// <param name="loggerAction">日志记录委托</param>
        /// <returns></returns>
        public static ActionExecuter Debug(
            [NotNull] this ActionExecuter executer,
            [NotNull] string debugInfo,
            [NotNull] Action<string> loggerAction)
        {
            CkFunctions.CheckNullWithException(executer, loggerAction);
            if (CkFunctions.IsNullOrEmpty(debugInfo)) return executer;

            return executer.Pipe(() => loggerAction?.Invoke(debugInfo));
        }

        /// <summary>
        /// 调试,有条件添加一个调试的<see cref="Action"/>到管道中
        /// </summary>
        /// <param name="executer">执行器实例</param>
        /// <param name="predicate">条件判断委托</param>
        /// <param name="debugInfo">调试信息</param>
        /// <param name="loggerAction">日志记录委托,默认为<see cref="CkFunctions.DefaultLog"/></param>
        /// <returns></returns>
        public static ActionExecuter DebugIf(
            [NotNull] this ActionExecuter executer,
            [NotNull] Func<bool> predicate,
            [NotNull] string debugInfo,
            Action<string>? loggerAction = null)
        {
            CkFunctions.CheckNullWithException(executer, predicate, loggerAction);
            if (CkFunctions.IsNullOrEmpty(debugInfo)) return executer;

            loggerAction ??= CkFunctions.DefaultLog;

            return executer.PipeIf(
                predicate,
                () => loggerAction.Invoke(debugInfo));
        }

        /// <summary>
        /// 调试,有条件添加一个调试的<see cref="Action"/>到管道中
        /// </summary>
        /// <param name="executer">执行器实例</param>
        /// <param name="isDebug">是否输出调试信息</param>
        /// <param name="debugInfo">调试信息</param>
        /// <returns></returns>
        public static ActionExecuter DebugIf(
            [NotNull] this ActionExecuter executer,
            [NotNull] bool isDebug,
            [NotNull] string debugInfo)
        {
            CkFunctions.CheckNullWithException(executer);
            if (CkFunctions.IsNullOrEmpty(debugInfo)) return executer;

            return executer.DebugIf(
                CkFunctions.Bool(isDebug),
                debugInfo,
                CkFunctions.DefaultLog);
        }

        #endregion Debug调试

        #region 其它

        #endregion 其它
    }
}