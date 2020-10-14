namespace CkTools.Nova.Entity
{
    /// <summary>
    /// 针对<see cref="CkTools.Nova.Entity.StepContext"/>及其泛型的扩展方法
    /// </summary>
    public static class StepContextExtension
    {
        #region 获取TaskContext

        /// <summary>
        /// 获取泛型的<see cref="StepContext{TResult}"/>上下文
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="taskContext"></param>
        /// <remarks>
        /// 转换逻辑同As关键字<para></para>
        /// 因为使用<see cref="CkTools.Nova.Entity.StepContext"/>不太方便，所以提供了此方法，代替了自己转换
        /// 能转换的前提是<paramref name="taskContext"/>已经是<see cref="StepContext{TResult}"/>类型的上下文了。
        /// </remarks>
        /// <returns></returns>
        public static StepContext<TResult>? As<TResult>(this StepContext taskContext)
        {
            return taskContext as StepContext<TResult>;
        }

        #endregion 获取TaskContext
    }
}