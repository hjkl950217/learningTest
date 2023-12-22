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

            executer.StepList.AddLast(action);
            return executer;
        }

        /// <summary>
        /// 管道-添加一个<see cref="Action"/>到管道中
        /// </summary>
        /// <param name="executer">执行器实例</param>
        /// <param name="actionArray">要添加的委托集合</param>
        /// <returns></returns>
        public static ActionExecuter Pipe(
            [NotNull] this ActionExecuter executer,
            [NotNull] params Action[] actionArray)
        {
            CkFunctions.CheckNullWithException(executer);
            foreach(Action item in actionArray)
            {
                executer.StepList.AddLast(item);
            }

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

            if(predicate)
            {
                executer.StepList.AddLast(action1);
            }
            else
            {
                executer.StepList.AddLast(action2);
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
        /// <param name="predicate">条件判断</param>
        /// <param name="action">当条件为true时添加的委托</param>
        /// <returns></returns>
        public static ActionExecuter PipeIf(
            [NotNull] this ActionExecuter executer,
            [NotNull] bool predicate,
            [NotNull] Action action)
        {
            CkFunctions.CheckNullWithException(executer, action);

            if(predicate)
            {
                executer.StepList.AddLast(action);
            }

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

        #region End

        /// <summary>
        /// 指定管道忽略之前的状态，结束执行
        /// </summary>
        /// <param name="executer"></param>
        /// <param name="onEnded"></param>
        /// <returns></returns>
        public static ActionExecuter End(
            [NotNull] this ActionExecuter executer,
             Action? onEnded = null)
        {
            CkFunctions.CheckNullWithException(executer);

            executer.Pipe(() =>
            {
                executer.IsEnd = true;
                onEnded?.Invoke();
            });
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

            executer.StepList.AddLast(() =>
            {
                executer.IsEnd = predicate();
                if(executer.IsEnd)
                {
                    onEnded?.Invoke();//为true时执行后续
                }
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

        #region Debug调试

        /// <summary>
        /// 调试,添加一个调试的<see cref="Action"/>到管道中
        /// </summary>
        /// <param name="executer">执行器实例</param>
        /// <param name="msg">调试信息</param>
        /// <param name="logger">日志记录委托</param>
        /// <returns></returns>
        public static ActionExecuter Debug(
            [NotNull] this ActionExecuter executer,
            [NotNull] string msg,
            Action<string>? logger = null)
        {
            CkFunctions.CheckNullWithException(executer);
            if(CkFunctions.IsNullOrEmpty(msg))
            {
                return executer;
            }
            logger ??= CkFunctions.LogToConsole;

            return executer.Pipe(() => logger?.Invoke(msg));
        }

        /// <summary>
        /// 调试,有条件添加一个调试的<see cref="Action"/>到管道中
        /// </summary>
        /// <param name="executer">执行器实例</param>
        /// <param name="predicate">条件判断委托</param>
        /// <param name="msg">调试信息</param>
        /// <param name="logger">日志记录委托,默认为<see cref="CkFunctions.LogToConsole(string)"/></param>
        /// <returns></returns>
        public static ActionExecuter DebugIf(
            [NotNull] this ActionExecuter executer,
            [NotNull] Func<bool> predicate,
            [NotNull] string msg,
            Action<string>? logger = null)
        {
            CkFunctions.CheckNullWithException(executer, predicate);
            if(CkFunctions.IsNullOrEmpty(msg))
            {
                return executer;
            }

            logger ??= CkFunctions.LogToConsole;

            return executer.PipeIf(
                predicate,
                () => logger.Invoke(msg));
        }

        /// <summary>
        /// 调试,有条件添加一个调试的<see cref="Action"/>到管道中
        /// </summary>
        /// <param name="executer">执行器实例</param>
        /// <param name="isDebug">是否输出调试信息</param>
        /// <param name="msg">调试信息</param>
        /// <returns></returns>
        public static ActionExecuter DebugIf(
            [NotNull] this ActionExecuter executer,
            [NotNull] bool isDebug,
            [NotNull] string msg)
        {
            CkFunctions.CheckNullWithException(executer, msg);
            return executer.DebugIf(
                CkFunctions.Bool(isDebug),
                msg,
                CkFunctions.LogToConsole);
        }

        #endregion Debug调试

        #region Try

        /// <summary>
        /// 异常捕获（无异常抛出，有需要请在<paramref name="tryAction"/>中处理）
        /// </summary>
        /// <param name="executer"></param>
        /// <param name="action"></param>
        /// <param name="tryAction"></param>
        /// <returns></returns>
        public static ActionExecuter Try(
            [NotNull] this ActionExecuter executer,
            [NotNull] Action action,
            [NotNull] Action<Exception> tryAction)
        {
            CkFunctions.CheckNullWithException(executer, action, tryAction);

            Action<Exception> endAction = e => executer.IsEnd = true;
            tryAction = CkFunctions.Compose(
               endAction,
               tryAction);
            return executer.Pipe(CkFunctions.Try(tryAction, action));
        }

        /// <summary>
        /// 异常捕获,发生异常时会调用<paramref name="tryAction"/>处理，然后抛出异常
        /// </summary>
        /// <param name="executer"></param>
        /// <param name="action"></param>
        /// <param name="tryAction"></param>
        /// <returns></returns>
        public static ActionExecuter TryThrow(
            [NotNull] this ActionExecuter executer,
            [NotNull] Action action,
            [NotNull] Action<Exception> tryAction)
        {
            CkFunctions.CheckNullWithException(executer, action, tryAction);

            Action<Exception> endAction = e => executer.IsEnd = true;
            tryAction = CkFunctions.Compose(endAction, tryAction);
            return executer.Pipe(CkFunctions.TryThrow(tryAction, action));
        }

        #endregion Try

        #region 其他

        /// <summary>
        /// 连接两个执行器
        /// </summary>
        /// <param name="executer"></param>
        /// <param name="otherExecuter"></param>
        /// <returns></returns>
        public static ActionExecuter Concat(
           [NotNull] this ActionExecuter executer,
           [NotNull] ActionExecuter otherExecuter)
        {
            CkFunctions.CheckNullWithException(executer, otherExecuter);
            foreach(Action item in otherExecuter.StepList)
            {
                executer.Pipe(item);
            }

            return executer;
        }

        /// <summary>
        /// 重置为初始状态
        /// </summary>
        /// <param name="executer"></param>
        /// <returns></returns>
        public static ActionExecuter Reset(
           [NotNull] this ActionExecuter executer)
        {
            CkFunctions.CheckNullWithException(executer);
            executer.IsEnd = false;
            return executer;
        }

        #endregion 其他
    }
}