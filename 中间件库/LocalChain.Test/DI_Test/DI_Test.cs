using Microsoft.Extensions.DependencyInjection;
using Nova.LogicChain;
using Nova.LogicChain.Entity;
using System;
using Xunit;

namespace Nova.LogicalChain.Test.DiI_Test
{
    public class DI_Test
    {
        private static class MockHelper
        {
            public const string TestServiceName = "TestService";

            public static IServiceProvider GetMockeDI()
            {
                IServiceCollection diBuilder = new ServiceCollection();
                diBuilder.AddNova();//注册服务

                diBuilder.AddSingleton<TestConfig>(new TestConfig()
                {
                    ServiceName = MockHelper.TestServiceName,
                    IsRelease = true
                }
                );

                IServiceProvider di = diBuilder.BuildServiceProvider();

                return di;
            }

            public static (ITask ITask, TaskContext<TestResult> TestContext) GetMockeTaskAndContext(int expectID)
            {
                IServiceProvider di = MockHelper.GetMockeDI();

                ITask testTask = di
                    .GetService<INovaFactory>()
                    .GetFirstTask<TestTaskEnum>();

                TestResult testContext = new TestResult()
                {
                    ID = expectID,
                };
                TaskContext<TestResult> taskContext = TaskContext.CreateContext(testContext);

                return (testTask, taskContext);
            }
        }

        [Fact]
        public void Test_DI_StepA()
        {
            var mockObject = MockHelper.GetMockeTaskAndContext(100);

            //执行
            mockObject.ITask.InvokeAsync(mockObject.TestContext);

            //验证
            var result = mockObject.TestContext;
            var resultObj = mockObject.TestContext.ResultEntiy;

            Assert.True(result.ProcessCompleted);
            Assert.Equal(100, resultObj.ID);
            Assert.Contains("只执行到第一步", resultObj.Message);
        }

        [Fact]
        public void Test_DI_StepB()
        {
            var mockObject = MockHelper.GetMockeTaskAndContext(200);

            //执行
            mockObject.ITask.InvokeAsync(mockObject.TestContext);

            //验证
            var result = mockObject.TestContext;
            var resultObj = mockObject.TestContext.ResultEntiy;

            Assert.True(result.ProcessCompleted);
            Assert.Equal(200, resultObj.ID);
            Assert.Contains("只执行到第二步", resultObj.Message);
        }

        [Fact]
        public void Test_DI_StepC()
        {
            var mockObject = MockHelper.GetMockeTaskAndContext(300);

            //执行
            mockObject.ITask.InvokeAsync(mockObject.TestContext);

            //验证
            var result = mockObject.TestContext;
            var resultObj = mockObject.TestContext.ResultEntiy;

            Assert.True(result.ProcessCompleted);
            Assert.Equal(300, resultObj.ID);
            Assert.Contains(MockHelper.TestServiceName, resultObj.Message);//C这一步返回的是模拟配置中的数据
        }
    }
}