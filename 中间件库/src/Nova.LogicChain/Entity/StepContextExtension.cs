namespace Nova.LogicChain.Entity
{
    /// <summary>
    /// 针对<see cref="StepContext"/>及其泛型的扩展方法
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
        /// 因为使用<see cref="StepContext"/>不太方便，所以提供了此方法，代替了自己转换
        /// 能转换的前提是<paramref name="taskContext"/>已经是<typeparamref name="TResult"/>类型的上下文了。
        /// </remarks>
        /// <returns></returns>
        public static StepContext<TResult> GetGenericContext<TResult>(this StepContext taskContext)
            where TResult : class
        {
            return taskContext as StepContext<TResult>;
        }

        #endregion 获取TaskContext
    }
}