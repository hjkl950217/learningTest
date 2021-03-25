using System.Threading.Tasks;

namespace System
{
    /// <summary>
    /// <see cref="System.Threading.Tasks.Task"/>的扩展
    /// </summary>
    public static class TaskExtensions
    {
        /// <summary>
        /// ContinueWith，指定<see cref="TaskContinuationOptions"/>为<see cref="TaskContinuationOptions.AttachedToParent"/>
        /// </summary>
        /// <param name="task"></param>
        /// <param name="continuationAction"></param>
        /// <returns></returns>
        private static Task ContinueWithByAttached(Task task, Action<Task> continuationAction)
        {
            return task.ContinueWith(continuationAction, TaskContinuationOptions.AttachedToParent);
        }

        /// <summary>
        /// 注册异常处理委托,返回这段代码的<see cref="Task"/>
        /// </summary>
        /// <typeparam name="TTask"></typeparam>
        /// <param name="task"></param>
        /// <param name="handle"></param>
        /// <returns></returns>
        public static Task HandleByException<TTask>(this TTask task, Action<Task> handle)
            where TTask : Task
        {
            return TaskExtensions.ContinueWithByAttached(task, t =>
            {
                if (t.IsFaulted)
                {
                    handle(t);
                }
            });
        }

        /// <summary>
        /// 注册异常处理委托,返回这段代码的<see cref="Task"/>
        /// </summary>
        /// <typeparam name="TTask"></typeparam>
        /// <param name="task"></param>
        /// <param name="handle"></param>
        /// <returns></returns>
        public static Task HandleByException<TTask>(this TTask task, Action<Exception> handle)
            where TTask : Task
        {
            return TaskExtensions.ContinueWithByAttached(task, t =>
            {
                if (t.IsFaulted)
                {
                    t.Exception.Handle(ex => { handle(ex); return true; });
                }
            });
        }

        /// <summary>
        /// 注册异常处理委托,返回这段代码的<see cref="Task"/>
        /// </summary>
        /// <typeparam name="TTask"></typeparam>
        /// <param name="task"></param>
        /// <param name="handle"></param>
        /// <returns></returns>
        public static Task HandleByCanceled<TTask>(this TTask task, Action<Task> handle)
            where TTask : Task
        {
            return TaskExtensions.ContinueWithByAttached(task, t =>
            {
                if (t.IsCanceled)
                {
                    handle(t);
                }
            });
        }
    }
}