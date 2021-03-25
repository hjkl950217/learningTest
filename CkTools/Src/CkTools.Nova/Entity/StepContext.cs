namespace CkTools.Nova.Entity
{
    /// <summary>
    /// 执行逻辑链的上下文
    /// </summary>
    public abstract partial class StepContext
    {
        /// <summary>
        /// 是否分析完成
        /// </summary>
        /// <remarks>
        /// 不建议手动设置此属性的值。
        /// </remarks>
        public virtual bool ProcessCompleted { get; set; }
    }
}