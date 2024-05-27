using CkTools.Nova.Executer;
using Xunit;

namespace CkTools.Nova.Test.Executer
{
    public class ActionExecuterTTest
    {
        [Fact]
        public void 正常执行不报错()
        {
            //准备
            ActionExecuter executer = ActionExecuter.Init();
            executer.StepList.AddLast(() => { });

            //执行
            executer.Execute();

            //断言
        }

        [Fact]
        public void 零步骤时不报错()
        {
            //准备
            ActionExecuter executer = ActionExecuter.Init();

            //执行
            executer.Execute();

            //断言
        }

        [Fact]
        public void 正常执行不报错_有初始化函数()
        {
            //准备
            ActionExecuter<int> executer = ActionExecuter.Init(() => 10);
            executer.StepList.AddLast(() => { });

            //执行
            executer.Execute();

            //断言
            Assert.Equal(10, executer.Result);
        }

        [Fact]
        public void 正常执行并获取结果()
        {
            //准备
            ActionExecuter<int> executer = ActionExecuter.Init(() => 10);
            executer.StepList.AddLast(() => { });

            //执行
            int result = executer.ExecuteAndResult();

            //断言
            Assert.Equal(10, result);
        }
    }
}