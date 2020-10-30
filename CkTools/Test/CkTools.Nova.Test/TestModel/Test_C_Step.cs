using CkTools.Nova.Aop;
using CkTools.Nova.Entity;
using CkTools.Nova.LogicChain;
using Nova.LogicalChain.Test;
using System.Threading.Tasks;
using StepContext = CkTools.Nova.Entity.StepContext;

namespace CkTools.Nova.Test.TestModel
{
    [Step(TestTaskEnum.EndLog, ContextResultType = typeof(TestResult))]
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
            StepContext<TestResult>? conText2 = context.As<TestResult>();

            if (this.testConfig.IsRelease)
            {
                //模拟分支
                conText2.Result.ID = 300;
                conText2.Result.Message = $"ServiceName:{this.testConfig.ServiceName}";
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