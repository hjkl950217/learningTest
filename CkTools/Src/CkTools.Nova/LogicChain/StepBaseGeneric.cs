using CkTools.Nova.Entity;
using System.Threading.Tasks;
using StepContext = CkTools.Nova.Entity.StepContext;

namespace CkTools.Nova.LogicChain
{
    public abstract class StepBase<TResult> : StepBase, IStep<TResult>
    {
        public new IStep<TResult>? Next { get; set; }
        public new StepContext<TResult> Context { get; set; }

        public Task<TResult> InvokeAsync(StepContext<TResult> context)
        {
            base.InvokeAsync(context);

            return Task.FromResult(this.Context.As<TResult>().Result);
        }

        /// <summary>
        /// 由子类实现每个步骤的具体逻辑
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        protected abstract void ProcessContext(StepContext<TResult> context);

        protected override void ProcessContext(StepContext context)
        {
            this.ProcessContext(context.As<TResult>());
        }

        /// <summary>
        /// 给<see cref="StepContext.ProcessCompleted"/>属性赋值为true，结束当前的步骤链
        /// </summary>
        /// <param name="result"></param>
        /// <returns></returns>
        protected virtual StepContext<TResult> Complete(TResult result)
        {
            base.Complete();

            this.Context.Result = result;
            return this.Context.As<TResult>();
        }
    }
}