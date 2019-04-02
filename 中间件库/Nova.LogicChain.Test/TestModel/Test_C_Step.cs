using Nova.LogicChain;
using Nova.LogicChain.Entity;
using System.Threading.Tasks;

namespace Nova.LogicalChain.Test
{
    [NovaRegister(TestTaskEnum.EndLog, typeof(TestResult))]
    public class Test_C_Step : ITask
    {
        private readonly TestConfig testConfig;

        public Test_C_Step(TestConfig testConfig)
        {
            this.testConfig = testConfig;
        }

        public ITask Next { get; set; }

        public Task InvokeAsync(TaskContext context)
        {
            var conText2 = context.GetGenericContext<TestResult>();

            //模拟分支
            conText2.ResultEntiy.ID = 300;
            conText2.ResultEntiy.Message = $"ServiceName:{this.testConfig.ServiceName}";
            context.ProcessCompleted = true;
            return Task.CompletedTask;
        }
    }
}