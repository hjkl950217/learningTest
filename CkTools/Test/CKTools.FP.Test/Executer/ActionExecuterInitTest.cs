using CkTools.FP.Executer;
using Xunit;

namespace CKTools.FP.Test.Executer
{
    public class ActionExecuterInitTest
    {
        #region Init初始化

        [Fact]
        public void 初始化_无返回值()
        {
            //准备
            ActionExecuter executer = ActionExecuter.Init();

            //执行
            executer.Execute();

            //断言
            Assert.NotNull(executer);
            Assert.NotNull(executer.StepList);
            Assert.True(executer.IsEnd);
        }

        [Fact]
        public void 初始化_有返回值()
        {
            //准备

            //执行
            ActionExecuter<int> executer = ActionExecuter<int>.Init();
            executer.Execute();

            //断言
            Assert.NotNull(executer);
            Assert.NotNull(executer.StepList);
            Assert.True(executer.IsEnd);
        }

        [Fact]
        public void 初始化_有返回值_有默认结果()
        {
            //准备

            //执行
            ActionExecuter<int> executer = ActionExecuter<int>.Init(10);
            executer.ExecuteAndResult();
            executer.ExecuteAndResult();

            //断言
            Assert.NotNull(executer);
            Assert.NotNull(executer.StepList);
            Assert.True(executer.IsEnd);
            Assert.Equal(10, executer.Result);
        }

        [Fact]
        public void 初始化_有返回值_有默认结果初始化函数()
        {
            //准备

            //执行
            ActionExecuter<int> executer = ActionExecuter<int>.Init(() => 10);
            executer.ExecuteAndResult();
            executer.ExecuteAndResult();

            //断言
            Assert.NotNull(executer);
            Assert.NotNull(executer.StepList);
            Assert.True(executer.IsEnd);
            Assert.Equal(10, executer.Result);
        }

        #endregion Init初始化
    }
}