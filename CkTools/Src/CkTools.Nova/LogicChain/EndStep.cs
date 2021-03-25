using StepContext = CkTools.Nova.Entity.StepContext;

namespace CkTools.Nova.LogicChain
{
    /// <summary>
    /// 结束调用链，代表最后一步
    /// </summary>
    public class EndStep : StepBase
    {
        protected override void ProcessContext(StepContext context)
        {
            base.Complete();
        }
    }
}