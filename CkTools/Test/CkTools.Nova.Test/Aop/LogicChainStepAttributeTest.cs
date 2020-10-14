using CkTools.Nova.Aop;
using CkTools.Nova.Test.TestModel;
using Microsoft.Extensions.DependencyInjection;
using Nova.LogicalChain.Test;
using System;
using Xunit;

namespace CkTools.Nova.Test.Aop
{
    public class LogicChainStepAttributeTest
    {
        #region Construction method

        [Fact]
        public void Construction_One_Parameter()
        {
            StepAttribute? result = new StepAttribute(TestTaskEnum.Start);

            Assert.Equal(typeof(TestTaskEnum), result.StepEnumType);
            Assert.Equal((int)TestTaskEnum.Start, result.StepEnumOrder);
            Assert.Null(result.ContextResultType);
            Assert.Equal(ServiceLifetime.Singleton, result.Lifetime);
        }

        [Fact]
        public void Construction_Two_Parameter()
        {
            StepAttribute? result = new StepAttribute(TestTaskEnum.Start, ServiceLifetime.Scoped);

            Assert.Equal(typeof(TestTaskEnum), result.StepEnumType);
            Assert.Equal((int)TestTaskEnum.Start, result.StepEnumOrder);
            Assert.Null(result.ContextResultType);
            Assert.Equal(ServiceLifetime.Scoped, result.Lifetime);
        }

        [Fact]
        public void Construction_Two_Parameter2()
        {
            StepAttribute? result = new StepAttribute(TestTaskEnum.Start, typeof(TestResult));

            Assert.Equal(typeof(TestTaskEnum), result.StepEnumType);
            Assert.Equal((int)TestTaskEnum.Start, result.StepEnumOrder);
            Assert.NotNull(result.ContextResultType);
            Assert.Equal(typeof(TestResult), result.ContextResultType);
            Assert.Equal(ServiceLifetime.Singleton, result.Lifetime);
        }

        [Fact]
        public void Construction_Three_Parameter()
        {
            StepAttribute? result = new StepAttribute(TestTaskEnum.Start, typeof(TestResult), ServiceLifetime.Transient);

            Assert.Equal(typeof(TestTaskEnum), result.StepEnumType);
            Assert.Equal((int)TestTaskEnum.Start, result.StepEnumOrder);
            Assert.NotNull(result.ContextResultType);
            Assert.Equal(typeof(TestResult), result.ContextResultType);
            Assert.Equal(ServiceLifetime.Transient, result.Lifetime);
        }

        [Fact]
        public void Construction_stepEnumTypeValue_Null()
        {
            ArgumentNullException? ex = Assert.Throws<ArgumentNullException>(() =>
            {
#pragma warning disable CS8625 // 无法将 null 文本转换为不可为 null 的引用类型。
                _ = new StepAttribute(null, typeof(TestResult));
#pragma warning restore CS8625 // 无法将 null 文本转换为不可为 null 的引用类型。
            });

            Assert.NotNull(ex);
        }

        [Fact]
        public void Construction_stepEnumTypeValue_NoEnum()
        {
            TypeAccessException? ex = Assert.Throws<TypeAccessException>(() =>
            {
                _ = new StepAttribute(123, typeof(TestResult));
            });
            Assert.NotNull(ex);
        }

        #endregion Construction method
    }
}