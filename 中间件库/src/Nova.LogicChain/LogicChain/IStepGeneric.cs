using Nova.LogicChain.Entity;
using System.Threading.Tasks;

namespace Nova.LogicChain.LogicChain
{
    /// <summary>
    /// 以中间件方式执行的步骤接口，一个实现对应一步逻辑
    /// </summary>
    /// <typeparam name="TResult">步骤处理的结果类型</typeparam>
    public interface IStep<TResult>
          where TResult : class
    {
        /// <summary>
        /// 下一个中间件
        /// </summary>
        /// <remarks>
        /// 由<see cref="LogicalChainHelper"/>中排序或初始化时统一指定
        /// </remarks>
        IStep<TResult> Next { get; set; }

        /// <summary>
        /// 异步执行任务
        /// </summary>
        /// <param name="context">要处理的步骤上下文.</param>
        /// <remarks>
        /// 参数初始化：<para></para>
        /// 一般来说第一个步骤代码执行时不会判断null，由调用者负责初始化化。如果使用IOC，则不需要关心此参数
        /// </remarks>
        /// <returns></returns>
        Task<TResult> InvokeAsync(StepContext<TResult> context);
    }
}