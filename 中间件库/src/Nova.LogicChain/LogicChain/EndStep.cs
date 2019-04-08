using System.Threading.Tasks;
using Nova.LogicChain.Entity;

namespace Nova.LogicChain
{
    /// <summary>
    /// 结束中间件，代表最后一步
    /// </summary>
    public class EndStep : IStep
    {
        /// <summary>
        /// 下一个中间件
        /// </summary>
        /// <remarks>
        /// 由TaskMwHelper初始化时统一排序和赋值
        /// </remarks>
        public IStep Next { get; set; }

        /// <summary>
        /// 直接返回一个<see cref="Task.CompletedTask"/>来结束调用
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public Task InvokeAsync(StepContext context)
        {
            return Task.CompletedTask;
        }
    }
}