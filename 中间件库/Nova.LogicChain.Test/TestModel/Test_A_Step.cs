using Nova.LogicChain;
using Nova.LogicChain.Entity;
using System.Threading.Tasks;

namespace Nova.LogicalChain.Test
{
    [NovaRegister(TestTaskEnum.Start, typeof(TestResult))]
    public class Test_A_Step : ITask
    {
        public ITask Next { get; set; }

        public Task InvokeAsync(TaskContext context)
        {
            var conText2 = context.GetGenericContext<TestResult>();

            // 模拟自己的操作

            if (conText2.ResultEntiy.ID == 100)
            {
                //模拟分支
                conText2.ResultEntiy.Message = "只执行到第一步";
                context.ProcessCompleted = true;
                return Task.CompletedTask;
            }

            var endTask = this.Next.InvokeAsync(conText2);

            // 模拟上一步完成后自己的操作

            return endTask;
        }
    }
}