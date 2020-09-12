using CkTools.Nova.Aop;
using CkTools.Nova.Entity;
using CkTools.Nova.Helper;
using CkTools.Nova.LogicChain;
using CkTools.Nova.Test.TestModel;
using Nova.LogicalChain.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace CkTools.Nova.Test.LogicChain
{
    public class LogicalChainHelperTest
    {
        [Fact]
        public void FindAllTaskEntity_True()
        {
        }

        private static class MockHeler
        {
            //这里为了测试 枚举与步骤都是倒着来的

            public static readonly Dictionary<int, Type> stepTypeDic = new Dictionary<int, Type>()
            {
                {1,typeof(Test_C_Step) },
                {2,typeof(Test_B_Step) },
                {3,typeof(Test_A_Step) }
            };

            public static StepEntity[] GetTestArray()
            {
                return new StepEntity[]
                {
                    new StepEntity ()
                    {
                        Attribute=new StepAttribute(TestTaskEnum.EndLog,typeof(TestResult)),
                        StepInstanceObject=new Test_A_Step()
                    },
                    new StepEntity ()
                    {
                        Attribute=new StepAttribute(TestTaskEnum.End,typeof(TestResult)),
                         StepInstanceObject=new Test_B_Step()
                    },
                    new StepEntity ()
                    {
                        Attribute=new StepAttribute(TestTaskEnum.Start,typeof(TestResult)),
                        StepInstanceObject=new Test_C_Step(new TestConfig())
                    }
                };
            }

            public static bool CheckCallChain(StepEntity[] stepEntity, bool isAutoEnd)
            {
                /*
                 * 检查目标：
                 * 1.Order是不是递增
                 * 2.如果 isAutoEnd 为True，则需要最后一步的Next属性的情况
                 *      isAutoEnd 为True时，数组中最后一步的Next不能为null，并且类型应该给为EndStep
                 *
                 */

                int initOrder = int.MinValue;
                bool result = true; //都是&& 有一个false都是false

                foreach (var item in stepEntity)
                {
                    result = result && item.Attribute.StepEnumOrder >= initOrder;//检查点

                    bool isEndStep = item.GetType() == MockHeler.stepTypeDic.Last().Value;//判断是否为最后一个步骤
                    if (isEndStep && isAutoEnd)
                    {
                        result = result && item.StepInstanceObject.Next != null;//检查点
                        result = result && item.StepInstanceObject.Next.GetType() == typeof(EndStep);//检查点
                    }

                    initOrder = item.Attribute.StepEnumOrder;
                }

                return result;
            }

            public static bool CheckCallChain(IStep step, bool isAutoEnd = true, int typeOrder = 1, bool? middleResult = null)
            {
                /*
                 * 检查目标：
                 * 1.Next是不是有值
                 * 2.类型对不对，应该按 MockHeler.stepTypeDic 中的类型来
                 * 3.如果 isAutoEnd 为True，则需要最后一步的Next属性的情况
                 *      isAutoEnd 为True时，数组中最后一步的Next不能为null，并且类型应该给为EndStep
                 *
                 */

                bool result = middleResult ?? true; //都是&& 有一个false都是false

                bool isEndStep = typeOrder == MockHeler.stepTypeDic.Last().Key;//判断是否为最后一个步骤
                bool isExists = MockHeler.stepTypeDic.TryGetValue(typeOrder, out Type stepType);

                if (!isExists)//不存在的key,需要退出递归
                {
                    return result;
                }

                if (isEndStep && isAutoEnd)//最后一步 但 isAutoEnd 为true时 要检查Next的状态
                {
                    result = result && step.Next != null;//检查点3
                    result = result && step.Next.GetType() == typeof(EndStep);//检查点3

                    return result;
                }
                else if (isEndStep && !isAutoEnd)
                {
                    //最后一步 但 isAutoEnd 为false时 不检查Next的状态
                    result = result && step.GetType() == stepType;//检查点2
                    return result;
                }
                else//常规检查
                {
                    result = result && step.Next != null;//检查点1
                    result = result && step.GetType() == stepType;//检查点2
                    return CheckCallChain(step.Next, isAutoEnd, typeOrder + 1, result);
                }
            }
        }

        #region Sort

        [Fact]
        public void Sort_SortIsTrue_AutoEnd()
        {
            IStep result = null;
            var ex = Record.Exception(() =>
            {
                result = LogicalChainHelper.Sort(MockHeler.GetTestArray());
            });
            Assert.Null(ex);

            Assert.NotNull(result);
            Assert.True(MockHeler.CheckCallChain(result));
        }

        [Fact]
        public void Sort_SortIsTrue_NoAutoEnd()
        {
            IStep result = null;
            var ex = Record.Exception(() =>
            {
                result = LogicalChainHelper.Sort(MockHeler.GetTestArray(), false);
            });

            Assert.Null(ex);
            Assert.NotNull(result);
            Assert.True(MockHeler.CheckCallChain(result, false));
        }

        [Fact]
        public void SortList_SortIsTrue_AutoEnd()
        {
            StepEntity[] result = null;
            var ex = Record.Exception(() =>
            {
                result = LogicalChainHelper.SortList(MockHeler.GetTestArray(), true);
            });

            Assert.Null(ex);
            Assert.NotNull(result);
            Assert.NotEmpty(result);

            Assert.True(MockHeler.CheckCallChain(result, true));
        }

        [Fact]
        public void SortList_SortIsTrue_NoAutoEnd()
        {
            StepEntity[]? result = null;
            var ex = Record.Exception(() =>
            {
                result = LogicalChainHelper.SortList(MockHeler.GetTestArray(), false);
            });

            Assert.Null(ex);
            Assert.NotNull(result);
            Assert.NotEmpty(result);

            Assert.True(MockHeler.CheckCallChain(result, false));
        }

        [Fact]
        public void SortList_AutoEnd()
        {
            StepEntity[] result = null;
            var ex = Record.Exception(() =>
            {
                result = LogicalChainHelper.SortList(MockHeler.GetTestArray());
            });

            Assert.Null(ex);
            Assert.NotNull(result);
            Assert.NotEmpty(result);
            Assert.NotNull(result.Last().StepInstanceObject.Next);
        }

        [Fact]
        public void SortList_NoAutoEnd()
        {
            StepEntity[] result = null;
            var ex = Record.Exception(() =>
            {
                result = LogicalChainHelper.SortList(MockHeler.GetTestArray(), false);
            });

            Assert.Null(ex);
            Assert.NotNull(result);
            Assert.NotEmpty(result);
            Assert.Null(result.Last().StepInstanceObject.Next);
        }

        [Fact]
        public void Sort_NoException()
        {
            IStep result = null;
            var ex = Record.Exception(() =>
            {
                result = LogicalChainHelper.Sort(MockHeler.GetTestArray());
            });

            Assert.Null(ex);
            Assert.NotNull(result);
        }

        #endregion Sort
    }
}