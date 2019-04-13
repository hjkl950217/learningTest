using Nova.LogicChain.Entity;
using System;
using System.Threading.Tasks;

namespace Nova.LogicChain
{
    public abstract class StepBase<TResult> : IStep<TResult>
        where TResult : class
    {
        public IStep<TResult> Next { get; set; }

        public StepContext Context { get; set; }

        public Task<TResult> InvokeAsync(StepContext<TResult> context)
        {
            context.CheckNull(nameof(context));
            this.Context = context;

            if (this.Context.ProcessCompleted)
            {
                return Task.FromResult(this.Context.As<TResult>().ResultEntiy);
            }

            return this.Next.InvokeAsync(this.ProcessContext(context));
        }

        /// <summary>
        /// 由子类实现每个步骤的具体逻辑
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        protected abstract StepContext<TResult> ProcessContext(StepContext<TResult> context);

        /// <summary>
        /// 给<see cref="StepContext.ProcessCompleted"/>属性赋值为true，结束当前的步骤链
        /// </summary>
        /// <param name="result"></param>
        /// <returns></returns>
        protected virtual StepContext<TResult> Complete(TResult result = null)
        {
            this.Context.ProcessCompleted = true;
            return this.Context.As<TResult>();
        }
    }
}