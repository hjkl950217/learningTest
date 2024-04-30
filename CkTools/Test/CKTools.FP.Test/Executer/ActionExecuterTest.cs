using CkTools.FP.Executer;
using Xunit;

namespace CKTools.FP.Test.Executer
{
    public class ActionExecuterTest
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
    }
}