using System;
using System.Threading.Tasks;
using Nova.LogicChain.Entity;

namespace Nova.LogicChain
{
    public class EndStep<TResult> : IStep<TResult>
        where TResult:class
    {
        /// <summary>
        /// 下一个中间件
        /// </summary>
        /// <remarks>
        /// 由框架统一排序和赋值
        /// </remarks>
        public IStep<TResult> Next { get; set; }

        /// <summary>
        /// 直接返回一个<see cref="Task{TResult}"/>来结束调用
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public Task<TResult> InvokeAsync(StepContext<TResult> context)
        {
            context.ProcessCompleted = true;
            return context.ResultEntiy.ToTask();
        }
    }
}