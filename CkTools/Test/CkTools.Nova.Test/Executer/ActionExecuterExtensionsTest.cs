using System;
using CkTools.Nova.Executer;
using CKTools.FP.Test;
using NSubstitute;
using Xunit;

namespace CkTools.Nova.Test.Executer
{
    public class ActionExecuterExtensionsTest
    {
        #region Pipe

        [Fact]
        public void Pipe_添加1个()
        {
            //准备
            IAction action = Substitute.For<IAction>();

            //执行
            ActionExecuter executer = ActionExecuter.Init();
            executer.Pipe(action.Test0);
            executer.Execute();

            //断言
            Assert.NotNull(executer);
            Assert.NotNull(executer.StepList);
            Assert.True(executer.IsEnd);
            action.Received(1).Test0();
        }

        [Fact]
        public void Pipe_添加多个()
        {
            //准备
            IAction action = Substitute.For<IAction>();

            //执行
            ActionExecuter executer = ActionExecuter.Init();
            executer.Pipe(action.Test0, action.Test0, action.Test0);
            executer.Execute();

            //断言
            Assert.NotNull(executer);
            Assert.NotNull(executer.StepList);
            Assert.True(executer.IsEnd);
            action.Received(3).Test0();
        }

        [Fact]
        public void PipeIf_添加2个()
        {
            //准备
            IAction action = Substitute.For<IAction>();

            //执行
            ActionExecuter executer = ActionExecuter.Init();
            executer.PipeIf(false, action.Test0, action.Test00);
            executer.Execute();

            //断言
            Assert.NotNull(executer);
            Assert.NotNull(executer.StepList);
            Assert.True(executer.IsEnd);
            action.DidNotReceive().Test0();
            action.Received(1).Test00();
        }

        [Fact]
        public void PipeIf_添加1个()
        {
            //准备
            IAction action = Substitute.For<IAction>();

            //执行
            ActionExecuter executer = ActionExecuter.Init();
            executer.PipeIf(true, action.Test0);
            executer.Execute();

            //断言
            Assert.NotNull(executer);
            Assert.NotNull(executer.StepList);
            Assert.True(executer.IsEnd);
            action.Received(1).Test0();
        }

        [Fact]
        public void PipeIf_添加2个_用委托判断()
        {
            //准备
            IAction action = Substitute.For<IAction>();

            //执行
            ActionExecuter executer = ActionExecuter.Init();
            executer.PipeIf(() => false, action.Test0, action.Test00);
            executer.Execute();

            //断言
            Assert.NotNull(executer);
            Assert.NotNull(executer.StepList);
            Assert.True(executer.IsEnd);
            action.DidNotReceive().Test0();
            action.Received(1).Test00();
        }

        [Fact]
        public void PipeIf_添加1个_用委托判断()
        {
            //准备
            IAction action = Substitute.For<IAction>();

            //执行
            ActionExecuter executer = ActionExecuter.Init();
            executer.PipeIf(() => true, action.Test0);
            executer.Execute();

            //断言
            Assert.NotNull(executer);
            Assert.NotNull(executer.StepList);
            Assert.True(executer.IsEnd);
            action.Received(1).Test0();
        }

        #endregion Pipe

        #region End

        [Fact]
        public void End_有后续()
        {
            //准备
            int count = 0;
            IAction action = Substitute.For<IAction>();

            //执行
            ActionExecuter executer = ActionExecuter.Init();
            executer.Pipe(() => count++);
            executer.End(action.Test0);
            executer.Pipe(() => count++);
            executer.Execute();

            //断言
            Assert.NotNull(executer);
            Assert.NotNull(executer.StepList);
            Assert.True(executer.IsEnd);
            action.Received().Test0();
            Assert.Equal(1, count);
        }

        [Fact]
        public void EndIf_有后续_用委托判断()
        {
            //准备
            int count = 0;
            IAction action = Substitute.For<IAction>();

            //执行
            ActionExecuter executer = ActionExecuter.Init();
            executer.Pipe(() => count++);
            executer.EndIf(() => true, action.Test0);
            executer.Pipe(() => count++);
            executer.Execute();

            //断言
            Assert.NotNull(executer);
            Assert.NotNull(executer.StepList);
            Assert.True(executer.IsEnd);
            action.Received().Test0();
            Assert.Equal(1, count);
        }

        [Fact]
        public void EndIf_有后续()
        {
            //准备
            int count = 0;
            IAction action = Substitute.For<IAction>();

            //执行
            ActionExecuter executer = ActionExecuter.Init();
            executer.Pipe(() => count++);
            executer.EndIf(true, action.Test0);
            executer.Pipe(() => count++);
            executer.Execute();

            //断言
            Assert.NotNull(executer);
            Assert.NotNull(executer.StepList);
            Assert.True(executer.IsEnd);
            action.Received().Test0();
            Assert.Equal(1, count);
        }

        #endregion End

        #region Debug

        [Fact]
        public void Debug_直接调用()
        {
            //准备
            int count = 0;
            string actualStr = string.Empty;
            IAction action = Substitute.For<IAction>();

            //执行
            ActionExecuter executer = ActionExecuter.Init();
            executer.Pipe(() => count++);
            executer.Debug("test");
            executer.Pipe(() => count++);
            executer.Execute();

            //断言
            Assert.NotNull(executer);
            Assert.NotNull(executer.StepList);
            Assert.True(executer.IsEnd);
            Assert.Equal(2, count);
        }

        [Fact]
        public void Debug_传递日志器()
        {
            //准备
            int count = 0;
            string actualStr = string.Empty;
            IAction action = Substitute.For<IAction>();

            //执行
            ActionExecuter executer = ActionExecuter.Init();
            executer.Pipe(() => count++);
            executer.Debug("test", t => actualStr = t);
            executer.Pipe(() => count++);
            executer.Execute();

            //断言
            Assert.NotNull(executer);
            Assert.NotNull(executer.StepList);
            Assert.True(executer.IsEnd);
            Assert.Equal(2, count);
            Assert.Equal("test", actualStr);
        }

        [Fact]
        public void DebugIf_传递委托()
        {
            //准备
            int count = 0;
            string actualStr = string.Empty;
            IAction action = Substitute.For<IAction>();

            //执行
            ActionExecuter executer = ActionExecuter.Init();
            executer.Pipe(() => count++);
            executer.DebugIf(() => true, "test");
            executer.Pipe(() => count++);
            executer.Execute();

            //断言
            Assert.NotNull(executer);
            Assert.NotNull(executer.StepList);
            Assert.True(executer.IsEnd);
            Assert.Equal(2, count);
        }

        [Fact]
        public void DebugIf_传递日志器()
        {
            //准备
            int count = 0;
            string actualStr = string.Empty;
            IAction action = Substitute.For<IAction>();

            //执行
            ActionExecuter executer = ActionExecuter.Init();
            executer.Pipe(() => count++);
            executer.DebugIf(() => true, "test", t => actualStr = t);
            executer.Pipe(() => count++);
            executer.Execute();

            //断言
            Assert.NotNull(executer);
            Assert.NotNull(executer.StepList);
            Assert.True(executer.IsEnd);
            Assert.Equal(2, count);
            Assert.Equal("test", actualStr);
        }

        [Fact]
        public void DebugIf_直接调用()
        {
            //准备
            int count = 0;
            string actualStr = string.Empty;
            IAction action = Substitute.For<IAction>();

            //执行
            ActionExecuter executer = ActionExecuter.Init();
            executer.Pipe(() => count++);
            executer.DebugIf(true, "test");
            executer.Pipe(() => count++);
            executer.Execute();

            //断言
            Assert.NotNull(executer);
            Assert.NotNull(executer.StepList);
            Assert.True(executer.IsEnd);
            Assert.Equal(2, count);
        }

        #endregion Debug

        #region Try

        [Fact]
        public void Try_异常处理()
        {
            //准备
            int count = 0;
            Exception actualEx = null;
            IAction action = Substitute.For<IAction>();

            //执行
            ActionExecuter executer = ActionExecuter.Init();
            executer.Pipe(() => count++);
            executer.Try(() => throw new NotImplementedException(), e => actualEx = e);
            executer.Pipe(() => count++);
            executer.Execute();

            //断言
            Assert.NotNull(executer);
            Assert.NotNull(executer.StepList);
            Assert.True(executer.IsEnd);
            Assert.Equal(1, count);
            Assert.NotNull(actualEx);
            Assert.IsType<NotImplementedException>(actualEx);
        }

        [Fact]
        public void TryThrow_异常处理()
        {
            //准备
            int count = 0;
            Exception actualEx = null;
            IAction action = Substitute.For<IAction>();

            //执行
            ActionExecuter executer = ActionExecuter.Init();
            executer.Pipe(() => count++);
            executer.TryThrow(() => throw new NotImplementedException(), e => actualEx = e);
            executer.Pipe(() => count++);
            Assert.Throws<NotImplementedException>(executer.Execute);

            executer.Execute();

            //断言
            Assert.NotNull(executer);
            Assert.NotNull(executer.StepList);
            Assert.True(executer.IsEnd);
            Assert.Equal(1, count);
            Assert.NotNull(actualEx);
            Assert.IsType<NotImplementedException>(actualEx);
        }

        #endregion Try

        #region 其他

        [Fact]
        public void Concat_连接()
        {
            //准备
            int count = 0;
            int countB = 0;
            IAction action = Substitute.For<IAction>();

            //执行
            ActionExecuter executer = ActionExecuter.Init();
            executer.Pipe(() => count++);
            executer.Pipe(() => count++);

            ActionExecuter executer2 = ActionExecuter.Init();
            executer2.Pipe(() => countB++);
            executer2.Pipe(() => countB++);

            executer.Concat(executer2);
            executer.Execute();

            //断言
            Assert.NotNull(executer);
            Assert.NotNull(executer.StepList);
            Assert.True(executer.IsEnd);
            Assert.Equal(2, count);
            Assert.Equal(2, countB);
        }

        [Fact]
        public void Reset_重置()
        {
            //准备
            int count = 0;
            IAction action = Substitute.For<IAction>();

            //执行
            ActionExecuter executer = ActionExecuter.Init();
            executer.Pipe(() => count++);
            executer.Pipe(() => count++);
            executer.Execute();
            executer.Reset();
            executer.Execute();

            //断言
            Assert.NotNull(executer);
            Assert.NotNull(executer.StepList);
            Assert.True(executer.IsEnd);
            Assert.Equal(4, count);
        }

        #endregion 其他
    }
}