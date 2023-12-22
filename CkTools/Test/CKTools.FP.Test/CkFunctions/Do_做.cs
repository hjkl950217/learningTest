using System;
using CkTools.FP;
using NSubstitute;
using Xunit;

namespace CKTools.FP.Test
{
    public class Do_做
    {
        #region Action

        #region 第1排

        [Fact]
        public void Action_0参0返_0参0返()
        {
            //准备
            IAction actionInterface = Substitute.For<IAction>();

            //执行
            Action result = CkFunctions.Do(
                actionInterface.Test00,
                actionInterface.Test0);
            result();

            //断言
            Received.InOrder(() =>
            {
                actionInterface.Test0();
                actionInterface.Test00();
            });
        }

        [Fact]
        public void Action_0参0返_1参0返()
        {
            //准备
            IAction actionInterface = Substitute.For<IAction>();

            //执行
            Action<string> result = CkFunctions.Do(
                (Action<string>)actionInterface.Test1,
                actionInterface.Test0);
            result("a");

            //断言
            Received.InOrder(() =>
            {
                actionInterface.Test0();
                actionInterface.Test1(Arg.Any<string>());
            });
        }

        [Fact]
        public void Action_0参0返_2参0返()
        {
            //准备
            IAction actionInterface = Substitute.For<IAction>();

            //执行
            Action<string, string> result = CkFunctions.Do(
                (Action<string, string>)actionInterface.Test2,
                actionInterface.Test0);
            result("a", "b");

            //断言
            Received.InOrder(() =>
            {
                actionInterface.Test0();
                actionInterface.Test2(Arg.Any<string>(), Arg.Any<string>());
            });
        }

        #endregion 第1排

        #region 第2排

        [Fact]
        public void Action_1参0返_0参0返()
        {
            //准备
            IAction actionInterface = Substitute.For<IAction>();

            //执行
            Action<string> result = CkFunctions.Do<string>(
                actionInterface.Test0,
                actionInterface.Test1);
            result("a");

            //断言
            Received.InOrder(() =>
            {
                actionInterface.Test1(Arg.Any<string>());
                actionInterface.Test0();
            });
        }

        [Fact]
        public void Action_1参0返_1参0返()
        {
            //准备
            IAction actionInterface = Substitute.For<IAction>();

            //执行
            Action<string> result = CkFunctions.Do<string>(
                actionInterface.Test1,
                actionInterface.Test1);
            result("a");

            //断言
            Received.InOrder(() =>
            {
                actionInterface.Test1(Arg.Any<string>());
                actionInterface.Test1(Arg.Any<string>());
            });
        }

        [Fact]
        public void Action_1参0返_2参0返()
        {
            //准备
            IAction actionInterface = Substitute.For<IAction>();

            //执行
            Action<string, string> result = CkFunctions.Do<string, string>(
               actionInterface.Test2,
               actionInterface.Test1);
            result("a", "b");

            //断言
            Received.InOrder(() =>
            {
                actionInterface.Test1(Arg.Any<string>());
                actionInterface.Test2(Arg.Any<string>(), Arg.Any<string>());
            });
        }

        [Fact]
        public void Action_1参0返_2参0返_相同类型()
        {
            //准备
            IAction actionInterface = Substitute.For<IAction>();

            //执行
            Action<string, string> result = CkFunctions.Do<string>(
               actionInterface.Test2,
               actionInterface.Test1);
            result("a", "b");

            //断言
            Received.InOrder(() =>
            {
                actionInterface.Test1(Arg.Any<string>());
                actionInterface.Test2(Arg.Any<string>(), Arg.Any<string>());
            });
        }

        #endregion 第2排

        #region 第3排

        [Fact]
        public void Action_2参0返_0参0返()
        {
            //准备
            IAction actionInterface = Substitute.For<IAction>();

            //执行
            Action<string, string> result = CkFunctions.Do<string, string>(
                actionInterface.Test0,
                actionInterface.Test2);
            result("a", "b");

            //断言
            Received.InOrder(() =>
            {
                actionInterface.Test2(Arg.Any<string>(), Arg.Any<string>());
                actionInterface.Test0();
            });
        }

        [Fact]
        public void Action_2参0返_2参0返()
        {
            //准备
            IAction actionInterface = Substitute.For<IAction>();

            //执行
            Action<string, string> result = CkFunctions.Do<string, string>(
                actionInterface.Test2,
                actionInterface.Test2);
            result("a", "b");

            //断言
            Received.InOrder(() =>
            {
                actionInterface.Test2(Arg.Any<string>(), Arg.Any<string>());
                actionInterface.Test2(Arg.Any<string>(), Arg.Any<string>());
            });
        }

        #endregion 第3排

        #region 其他

        [Fact]
        public void Action_0参0返_3个以上()
        {
            //准备
            IAction actionInterface = Substitute.For<IAction>();

            //执行
            Action result = CkFunctions.Do(
                actionInterface.Test0,
                actionInterface.Test0,
                actionInterface.Test0);
            result();

            //断言
            Received.InOrder(() =>
            {
                actionInterface.Test0();
                actionInterface.Test0();
                actionInterface.Test0();
            });
        }

        [Fact]
        public void Action_1参0返_3个以上()
        {
            //准备
            IAction actionInterface = Substitute.For<IAction>();

            //执行
            Action<string> result = CkFunctions.Do<string>(
                actionInterface.Test1,
                actionInterface.Test1,
                actionInterface.Test1);
            result("a");

            //断言
            Received.InOrder(() =>
            {
                actionInterface.Test1(Arg.Any<string>());
                actionInterface.Test1(Arg.Any<string>());
                actionInterface.Test1(Arg.Any<string>());
            });
        }

        #endregion 其他

        #endregion Action

        #region Func

        #region 其他

        [Fact]
        public void Func_5函数合并_0参1返()
        {
            //准备
            IAction actionInterface = Substitute.For<IAction>();
            IFunc funcInterface = Substitute.For<IFunc>();
            funcInterface.Test0().Returns(10);

            //执行
            Func<int> result = CkFunctions.Do(
                funcInterface.Test0,
                actionInterface.Test0,
                actionInterface.Test0,
                actionInterface.Test0,
                actionInterface.Test0);
            int resultCount = result();

            //断言
            Received.InOrder(() =>
            {
                actionInterface.Test0();
                actionInterface.Test0();
                actionInterface.Test0();
                actionInterface.Test0();
                funcInterface.Test0();
            });
            Assert.Equal(10, resultCount);
        }

        [Fact]
        public void Func_5函数合并_1参1返()
        {
            //准备
            IAction actionInterface = Substitute.For<IAction>();
            IFunc funcInterface = Substitute.For<IFunc>();
            funcInterface.Test1(Arg.Any<int>()).Returns("a");

            //执行
            Func<int, string> result = CkFunctions.Do<int, string>(
                funcInterface.Test1,
                actionInterface.Test11,
                actionInterface.Test11,
                actionInterface.Test11,
                actionInterface.Test11);
            string resultStr = result(10);

            //断言
            Received.InOrder(() =>
            {
                actionInterface.Test11(Arg.Any<int>());
                actionInterface.Test11(Arg.Any<int>());
                actionInterface.Test11(Arg.Any<int>());
                actionInterface.Test11(Arg.Any<int>());
                funcInterface.Test1(Arg.Any<int>());
            });
            Assert.Equal("a", resultStr);
        }

        [Fact]
        public void Func_5函数合并_1参1返_2()
        {
            //准备
            IAction actionInterface = Substitute.For<IAction>();
            IFunc funcInterface = Substitute.For<IFunc>();
            funcInterface.Test1(Arg.Any<int>()).Returns("a");

            //执行
            Func<int, string> result = CkFunctions.Do<int, string>(
                funcInterface.Test1,
                actionInterface.Test0,
                actionInterface.Test0,
                actionInterface.Test0,
                actionInterface.Test0);
            string resultStr = result(10);

            //断言
            Received.InOrder(() =>
            {
                actionInterface.Test0();
                actionInterface.Test0();
                actionInterface.Test0();
                actionInterface.Test0();
                funcInterface.Test1(Arg.Any<int>());
            });
            Assert.Equal("a", resultStr);
        }

        #endregion 其他

        #endregion Func

        #region exp1 Func  -  exp2 Action

        #region 第1排

        [Fact]
        public void 组合_0参1返_0参0返()
        {
            //准备
            IAction actionInterface = Substitute.For<IAction>();
            IFunc funcInterface = Substitute.For<IFunc>();

            //执行
            Func<int> result = CkFunctions.Do(
                actionInterface.TestVoid,
                funcInterface.Test0);
            result();

            //断言
            funcInterface.Test0();
            actionInterface.TestVoid();
        }

        [Fact]
        public void 组合_0参1返_1参0返()
        {
            //准备
            IAction actionInterface = Substitute.For<IAction>();
            IFunc funcInterface = Substitute.For<IFunc>();

            //执行
            Func<int> result = CkFunctions.Do(
                actionInterface.Test11,
                funcInterface.Test0);
            result();

            //断言
            Received.InOrder(() =>
            {
                funcInterface.Test0();
                actionInterface.Test11(Arg.Any<int>());
            });
        }

        #endregion 第1排

        #region 第2排

        [Fact]
        public void 组合_1参1返_0参0返()
        {
            //准备
            IAction actionInterface = Substitute.For<IAction>();
            IFunc funcInterface = Substitute.For<IFunc>();

            //执行
            Func<int, string> result = CkFunctions.Do<int, string>(
                actionInterface.TestVoid,
                funcInterface.Test1);
            result(1);

            //断言
            Received.InOrder(() =>
            {
                funcInterface.Test1(Arg.Any<int>());
                actionInterface.TestVoid();
            });
        }

        [Fact]
        public void 组合_1参1返_0参1返()
        {
            //准备
            IAction actionInterface = Substitute.For<IAction>();
            IFunc funcInterface = Substitute.For<IFunc>();

            //执行
            Func<int, string> result = CkFunctions.Do<int, string>(
                actionInterface.Test1,
                funcInterface.Test1);
            result(1);

            //断言
            Received.InOrder(() =>
            {
                funcInterface.Test1(Arg.Any<int>());
                actionInterface.Test1(Arg.Any<string>());
            });
        }

        #endregion 第2排

        #region 第3排

        [Fact]
        public void 组合_2参1返_0参0返()
        {
            //准备
            IAction actionInterface = Substitute.For<IAction>();
            IFunc funcInterface = Substitute.For<IFunc>();

            //执行
            Func<string, int, double> result = CkFunctions.Do<string, int, double>(
                actionInterface.TestVoid,
                funcInterface.Test2);
            result("a", 1);

            //断言
            Received.InOrder(() =>
            {
                funcInterface.Test2(Arg.Any<string>(), Arg.Any<int>());
                actionInterface.TestVoid();
            });
        }

        [Fact]
        public void 组合_2参1返_1参0返()
        {
            //准备
            IAction actionInterface = Substitute.For<IAction>();
            IFunc funcInterface = Substitute.For<IFunc>();

            //执行
            Func<string, int, double> result = CkFunctions.Do<string, int, double>(
                actionInterface.Test111,
                funcInterface.Test2);
            result("a", 1);

            //断言
            Received.InOrder(() =>
            {
                funcInterface.Test2(Arg.Any<string>(), Arg.Any<int>());
                actionInterface.Test111(Arg.Any<double>());
            });
        }

        #endregion 第3排

        #endregion exp1 Func  -  exp2 Action

        #region exp1 Action  -  exp2 Func

        #region 第1排

        [Fact]
        public void 组合_0参0返_0参1返()
        {
            //准备
            IAction actionInterface = Substitute.For<IAction>();
            IFunc funcInterface = Substitute.For<IFunc>();

            //执行
            Func<int> result = CkFunctions.Do(
                funcInterface.Test0,
                actionInterface.TestVoid);
            result();

            //断言
            Received.InOrder(() =>
            {
                actionInterface.TestVoid();
                funcInterface.Test0();
            });
        }

        [Fact]
        public void 组合_0参0返_1参1返()
        {
            //准备
            IAction actionInterface = Substitute.For<IAction>();
            IFunc funcInterface = Substitute.For<IFunc>();

            //执行
            Func<int, string> result = CkFunctions.Do<int, string>(
                funcInterface.Test1,
                actionInterface.TestVoid);
            result(1);

            //断言
            Received.InOrder(() =>
            {
                actionInterface.TestVoid();
                funcInterface.Test1(Arg.Any<int>());
            });
        }

        [Fact]
        public void 组合_0参0返_2参1返()
        {
            //准备
            IAction actionInterface = Substitute.For<IAction>();
            IFunc funcInterface = Substitute.For<IFunc>();

            //执行
            Func<string, int, double> result = CkFunctions.Do<string, int, double>(
                funcInterface.Test2,
                actionInterface.TestVoid);
            result("a", 1);

            //断言
            Received.InOrder(() =>
            {
                actionInterface.TestVoid();
                funcInterface.Test2(Arg.Any<string>(), Arg.Any<int>());
            });
        }

        #endregion 第1排

        #region 第2排

        [Fact]
        public void 组合_1参0返_1参1返()
        {
            //准备
            IAction actionInterface = Substitute.For<IAction>();
            IFunc funcInterface = Substitute.For<IFunc>();

            //执行
            Func<int, string> result = CkFunctions.Do<int, string>(
                funcInterface.Test1,
                actionInterface.Test11);
            result(1);

            //断言
            Received.InOrder(() =>
            {
                actionInterface.Test11(Arg.Any<int>());
                funcInterface.Test1(Arg.Any<int>());
            });
        }

        #endregion 第2排

        #region 第3排

        [Fact]
        public void 组合_2参0返_2参1返()
        {
            //准备
            IAction actionInterface = Substitute.For<IAction>();
            IFunc funcInterface = Substitute.For<IFunc>();

            //执行
            Func<string, int, double> result = CkFunctions.Do<string, int, double>(
                funcInterface.Test2,
                actionInterface.Test22);
            result("a", 1);

            //断言
            Received.InOrder(() =>
            {
                actionInterface.Test22(Arg.Any<string>(), Arg.Any<int>());
                funcInterface.Test2(Arg.Any<string>(), Arg.Any<int>());
            });
        }

        #endregion 第3排

        #endregion exp1 Action  -  exp2 Func
    }
}