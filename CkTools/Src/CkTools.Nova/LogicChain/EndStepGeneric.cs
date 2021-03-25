using CkTools.Nova.Entity;

namespace CkTools.Nova.LogicChain
{
    /// <summary>
    /// 结束调用链，代表最后一步。
    /// </summary>
    /// <typeparam name="TResult"></typeparam>
    public class EndStep<TResult> : StepBase<TResult>
    {
        protected override void ProcessContext(StepContext<TResult> context)
        {
            base.Complete();
        }
    }
}