using CkTools.Nova.LogicChain;

namespace CkTools.Nova.Entity
{
    /// <summary>
    /// 执行逻辑链的泛型上下文
    /// </summary>
    public class StepContext<TResult> : StepContext
    {
        /// <summary>
        /// 初始化一个<see cref="StepBase{TResult}"/>实例
        /// </summary>
        /// <param name="result">初始化到上下文实例中的结果</param>
        /// <param name="completed">初始化到上下文中的处理结果</param>
        public StepContext(TResult result, bool completed)
        {
            this.Result = result;
            base.ProcessCompleted = completed;
        }

        /// <summary>
        /// 初始化一个<see cref="StepBase{TResult}"/>实例
        /// </summary>
        /// <param name="result">初始化到上下文实例中的结果</param>
        public StepContext(TResult result) : this(result, false)
        {
        }

        /// <summary>
        /// 初始化一个<see cref="StepBase{TResult}"/>实例
        /// </summary>
        public StepContext() : this(default, false)
        {
        }

        /// <summary>
        /// 当前上下文中的返回数据
        /// </summary>
        /// <returns></returns>
        public TResult Result { get; internal set; }
    }
}