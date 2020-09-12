using CkTools.Nova.Aop;
using CkTools.Nova.Entity;
using CkTools.Nova.LogicChain;
using Nova.LogicalChain.Test;
using System.Threading.Tasks;
using StepContext = CkTools.Nova.Entity.StepContext;

namespace CkTools.Nova.Test.TestModel
{
    [Step(TestTaskEnum.End, typeof(TestResult))]
    public class Test_B_Step : IStep
    {
        public IStep Next { get; set; }

        public Task InvokeAsync(StepContext context)
        {
            var conText2 = context.As<TestResult>();

            if (conText2.Result.ID == 200)
            {
                //模拟分支
                conText2.Result.ID = 200;
                conText2.Result.Message = "只执行到第二步";
                context.ProcessCompleted = true;
                return Task.CompletedTask;
            }

            var endTask = this.Next.InvokeAsync(conText2);

            return endTask;
        }
    }
}