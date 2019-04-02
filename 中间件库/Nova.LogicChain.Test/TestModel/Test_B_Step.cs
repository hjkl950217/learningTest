using Nova.LogicChain;
using Nova.LogicChain.Entity;
using System.Threading.Tasks;

namespace Nova.LogicalChain.Test
{
    [NovaRegister(TestTaskEnum.End, typeof(TestResult))]
    public class Test_B_Step : ITask
    {
        public ITask Next { get; set; }

        public Task InvokeAsync(TaskContext context)
        {
            var conText2 = context.GetGenericContext<TestResult>();

            if (conText2.ResultEntiy.ID == 200)
            {
                //模拟分支
                conText2.ResultEntiy.ID = 200;
                conText2.ResultEntiy.Message = "只执行到第二步";
                context.ProcessCompleted = true;
                return Task.CompletedTask;
            }

            var endTask = this.Next.InvokeAsync(conText2);

            return endTask;
        }
    }
}