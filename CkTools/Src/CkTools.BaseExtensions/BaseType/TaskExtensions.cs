using System.Threading.Tasks;

namespace System
{
    /// <summary>
    /// <see cref="System.Threading.Tasks.Task"/>的扩展
    /// </summary>
    public static class TaskExtensions
    {
        /// <summary>
        /// 注册异常处理委托
        /// </summary>
        /// <typeparam name="TTask"></typeparam>
        /// <param name="task"></param>
        /// <param name="handle"></param>
        /// <returns></returns>
        public static Task HandleByException<TTask>(this TTask task, Action<Task> handle)
            where TTask : Task
        {
            return task.ContinueWith(t =>
            {
                if (t.IsFaulted)
                {
                    handle(t);
                }
            });
        }

        /// <summary>
        /// 注册异常处理委托
        /// </summary>
        /// <typeparam name="TTask"></typeparam>
        /// <param name="task"></param>
        /// <param name="handle"></param>
        /// <returns></returns>
        public static Task HandleByException<TTask>(this TTask task, Action<Exception> handle)
            where TTask : Task
        {
            return task.ContinueWith(t =>
            {
                if (t.IsFaulted)
                {
                    t.Exception.Handle(ex => { handle(ex); return true; });
                }
            });
        }

        /// <summary>
        /// 注册异常处理委托
        /// </summary>
        /// <typeparam name="TTask"></typeparam>
        /// <param name="task"></param>
        /// <param name="handle"></param>
        /// <returns></returns>
        public static Task HandleByCanceled<TTask>(this TTask task, Action<Task> handle)
            where TTask : Task
        {
            return task.ContinueWith(t =>
            {
                if (t.IsCanceled)
                {
                    handle(t);
                }
            });
        }
    }
}