using CkTools.Nova.Aop;
using CkTools.Nova.Entity;
using CkTools.Nova.LogicChain;
using Nova.LogicalChain.Test;
using System.Threading.Tasks;
using StepContext = CkTools.Nova.Entity.StepContext;

namespace CkTools.Nova.Test.TestModel
{
    [Step(TestTaskEnum.Start, typeof(TestResult))]
    public class Test_A_Step : IStep
    {
        public IStep Next { get; set; }

        public Task InvokeAsync(StepContext context)
        {
            var conText2 = context.As<TestResult>();

            // 模拟自己的操作

            if (conText2.Result.ID == 100)
            {
                //模拟分支
                conText2.Result.Message = "只执行到第一步";
                context.ProcessCompleted = true;
                return Task.CompletedTask;
            }

            var endTask = this.Next.InvokeAsync(conText2);

            // 模拟上一步完成后自己的操作

            return endTask;
        }
    }
}