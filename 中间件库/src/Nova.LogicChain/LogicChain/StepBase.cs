using Nova.LogicChain.Entity;
using Nova.LogicChain.LogicChain;
using System;
using System.Threading.Tasks;

namespace Nova.LogicChain
{
    public abstract class StepBase<TResult> : IStep<TResult>
        where TResult : class
    {
        IStep<TResult> IStep<TResult>.Next { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Task<TResult> InvokeAsync(StepContext<TResult> context)
        {
            if (context == null) throw new ArgumentNullException(nameof(context));

            //todo:只是写了抽象类，其它的都还没做

            return this.GetResult(context);
        }

        protected abstract Task<TResult> GetResult(StepContext<TResult> context);

        protected StepContext<TResult> Complete(TResult result)
        {
            return new StepContext<TResult>(result, true);
        }
    }
}