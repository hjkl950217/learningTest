namespace Nova.LogicChain.Entity
{
    /// <summary>
    /// 以中间件方式执行逻辑链的泛型上下文
    /// </summary>
    public class StepContext<TResult> : StepContext
        where TResult : class
    {
        public StepContext(TResult result, bool completed) : base(result, completed)
        {
        }

        public StepContext(TResult result) : base(result)
        {
        }

        public StepContext() : base()
        {
        }

        /// <summary>
        /// 上下文中的返回数据
        /// </summary>
        public override object Result
        {
            get => this.ResultEntiy;
            internal set => this.ResultEntiy = value as TResult;
        }

        /// <summary>
        /// 获取当前上下文中的<see cref="Result"/>
        /// </summary>
        /// <returns></returns>
        public TResult ResultEntiy { get; internal set; }
    }
}