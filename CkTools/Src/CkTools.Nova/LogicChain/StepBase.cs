using System;
using System.Threading.Tasks;
using StepContext = CkTools.Nova.Entity.StepContext;

namespace CkTools.Nova.LogicChain
{
    public abstract class StepBase : IStep
    {
        public IStep Next { get; set; }

        public StepContext Context { get; set; }

        public Task InvokeAsync(StepContext context)
        {
            context.CheckNullWithException(nameof(context));
            this.Context = context;

            //检查任务是否完成
            if (this.Context.ProcessCompleted || this.Next == null)
            {
                return Task.CompletedTask;
            }

            //执行任务
            this.ProcessContext(context);

            //调用下一个任务
            return this.Next.InvokeAsync(context);
        }

        /// <summary>
        /// 由子类实现每个步骤的具体逻辑
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        protected abstract void ProcessContext(StepContext context);

        protected virtual StepContext Complete()
        {
            this.Context.ProcessCompleted = true;
            return this.Context;
        }
    }
}