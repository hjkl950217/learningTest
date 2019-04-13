using Nova.LogicChain;
using Nova.LogicChain.Entity;
using System.Threading.Tasks;

namespace Nova.LogicalChain.Test
{
    [LogicChainStep(TestTaskEnum.EndLog, typeof(TestResult))]
    public class Test_C_Step : IStep
    {
        private readonly TestConfig testConfig;

        public Test_C_Step(TestConfig testConfig)
        {
            this.testConfig = testConfig;
        }

        public IStep Next { get; set; }

        public Task InvokeAsync(StepContext context)
        {
            var conText2 = context.As<TestResult>();

            if (this.testConfig.IsRelease)
            {
                //模拟分支
                conText2.ResultEntiy.ID = 300;
                conText2.ResultEntiy.Message = $"ServiceName:{this.testConfig.ServiceName}";
                context.ProcessCompleted = true;
                return Task.CompletedTask;
            }
            else
            {
                return Task.CompletedTask;
            }

          
        }
    }
}