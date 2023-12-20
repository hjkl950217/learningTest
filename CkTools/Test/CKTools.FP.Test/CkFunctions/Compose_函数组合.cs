using System;
using CkTools.FP;
using NSubstitute;
using Xunit;

namespace CKTools.FP.Test
{
    public class Compose_函数组合
    {
        #region Action

        #region 第1排

        [Fact]
        public void Action_0参0返_0参0返()
        {
            //准备
            IAction actionInterface = Substitute.For<IAction>();

            //执行
            Action result = CkFunctions.Compose(
                actionInterface.Test00,
                actionInterface.Test0);
            result();

            //断言
            Received.InOrder(() =>
            {
                actionInterface.Received().Test0();
                actionInterface.Received().Test00();
            });
        }

        [Fact]
        public void Action_0参0返_1参0返()
        {
            //准备
            IAction actionInterface = Substitute.For<IAction>();

            //执行
            Action<string> result = CkFunctions.Compose(
                (Action<string>)actionInterface.Test1,
                actionInterface.Test0);
            result("a");

            //断言
            Received.InOrder(() =>
            {
                actionInterface.Received().Test0();
                actionInterface.Received().Test1(Arg.Any<string>());
            });
        }

        [Fact]
        public void Action_0参0返_2参0返()
        {
            //准备
            IAction actionInterface = Substitute.For<IAction>();

            //执行
            Action<string, string> result = CkFunctions.Compose(
                (Action<string, string>)actionInterface.Test2,
                actionInterface.Test0);
            result("a", "b");

            //断言
            Received.InOrder(() =>
            {
                actionInterface.Received().Test0();
                actionInterface.Received().Test2(Arg.Any<string>(), Arg.Any<string>());
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
            Action<string> result = CkFunctions.Compose<string>(
                actionInterface.Test0,
                actionInterface.Test1);
            result("a");

            //断言
            Received.InOrder(() =>
            {
                actionInterface.Received().Test1(Arg.Any<string>());
                actionInterface.Received().Test0();
            });
        }

        [Fact]
        public void Action_1参0返_1参0返()
        {
            //准备
            IAction actionInterface = Substitute.For<IAction>();

            //执行
            Action<string> result = CkFunctions.Compose<string>(
                actionInterface.Test1,
                actionInterface.Test1);
            result("a");

            //断言
            Received.InOrder(() =>
            {
                actionInterface.Received().Test1(Arg.Any<string>());
                actionInterface.Received().Test1(Arg.Any<string>());
            });
        }

        [Fact]
        public void Action_1参0返_2参0返()
        {
            //准备
            IAction actionInterface = Substitute.For<IAction>();

            //执行
            Action<string, string> result = CkFunctions.Compose<string, string>(
               actionInterface.Test2,
               actionInterface.Test1);
            result("a", "b");

            //断言
            Received.InOrder(() =>
            {
                actionInterface.Received().Test1(Arg.Any<string>());
                actionInterface.Received().Test2(Arg.Any<string>(), Arg.Any<string>());
            });
        }

        [Fact]
        public void Action_1参0返_2参0返_相同类型()
        {
            //准备
            IAction actionInterface = Substitute.For<IAction>();

            //执行
            Action<string, string> result = CkFunctions.Compose<string>(
               actionInterface.Test2,
               actionInterface.Test1);
            result("a", "b");

            //断言
            Received.InOrder(() =>
            {
                actionInterface.Received().Test1(Arg.Any<string>());
                actionInterface.Received().Test2(Arg.Any<string>(), Arg.Any<string>());
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
            Action<string, string> result = CkFunctions.Compose<string, string>(
                actionInterface.Test0,
                actionInterface.Test2);
            result("a", "b");

            //断言
            Received.InOrder(() =>
            {
                actionInterface.Received().Test2(Arg.Any<string>(), Arg.Any<string>());
                actionInterface.Received().Test0();
            });
        }

        [Fact]
        public void Action_2参0返_2参0返()
        {
            //准备
            IAction actionInterface = Substitute.For<IAction>();

            //执行
            Action<string, string> result = CkFunctions.Compose<string, string>(
                actionInterface.Test2,
                actionInterface.Test2);
            result("a", "b");

            //断言
            Received.InOrder(() =>
            {
                actionInterface.Received().Test2(Arg.Any<string>(), Arg.Any<string>());
                actionInterface.Received().Test2(Arg.Any<string>(), Arg.Any<string>());
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
            Action result = CkFunctions.Compose(
                actionInterface.Test0,
                actionInterface.Test0,
                actionInterface.Test0);
            result();

            //断言
            Received.InOrder(() =>
            {
                actionInterface.Received().Test0();
                actionInterface.Received().Test0();
                actionInterface.Received().Test0();
            });
        }

        [Fact]
        public void Action_1参0返_3个以上()
        {
            //准备
            IAction actionInterface = Substitute.For<IAction>();

            //执行
            Action<string> result = CkFunctions.Compose<string>(
                actionInterface.Test1,
                actionInterface.Test1,
                actionInterface.Test1);
            result("a");

            //断言
            Received.InOrder(() =>
            {
                actionInterface.Received().Test1(Arg.Any<string>());
                actionInterface.Received().Test1(Arg.Any<string>());
                actionInterface.Received().Test1(Arg.Any<string>());
            });
        }

        #endregion 其他

        #endregion Action

        #region Func

        #region 第1排

        [Fact]
        public void Func_0参1返_1参1返()
        {
            //准备
            IFunc funcInterface = Substitute.For<IFunc>();

            //执行
            Func<string> result = CkFunctions.Compose(
                funcInterface.Test1,
                funcInterface.Test0);
            result();

            //断言
            Received.InOrder(() =>
            {
                funcInterface.Received().Test0();
                funcInterface.Received().Test1(Arg.Any<int>());
            });
        }

        #endregion 第1排

        #region 第2排

        [Fact]
        public void Func_1参1返_1参1返()
        {
            //准备
            IFunc funcInterface = Substitute.For<IFunc>();

            //执行
            Func<int, int> result = CkFunctions.Compose<int, string, int>(
                funcInterface.Test11,
                funcInterface.Test1);
            result(1);

            //断言
            Received.InOrder(() =>
            {
                funcInterface.Received().Test1(Arg.Any<int>());
                funcInterface.Received().Test11(Arg.Any<string>());
            });
        }

        #endregion 第2排

        #region 第3排

        [Fact]
        public void Func_2参1返_1参1返()
        {
            //准备
            IFunc funcInterface = Substitute.For<IFunc>();

            //执行
            Func<string, int, double> result = CkFunctions.Compose<string, int, double>(
                funcInterface.Test111,
                funcInterface.Test2);
            result("a", 1);

            //断言
            Received.InOrder(() =>
            {
                funcInterface.Received().Test2(Arg.Any<string>(), Arg.Any<int>());
                funcInterface.Received().Test111(Arg.Any<double>());
            });
        }

        #endregion 第3排

        #region 其他

        [Fact]
        public void Func_5连环()
        {
            //准备
            IFunc funcInterface = Substitute.For<IFunc>();

            //执行
            Func<int, string> result = CkFunctions.Compose<int, string, int, string, int, string>(
                funcInterface.Test1,
                funcInterface.Test11,
                funcInterface.Test1,
                funcInterface.Test11,
                funcInterface.Test1);
            result(1);

            //断言
            Received.InOrder(() =>
            {
                funcInterface.Received().Test1(Arg.Any<int>());
                funcInterface.Received().Test11(Arg.Any<string>());
                funcInterface.Received().Test1(Arg.Any<int>());
                funcInterface.Received().Test11(Arg.Any<string>());
                funcInterface.Received().Test1(Arg.Any<int>());
            });
        }

        [Fact]
        public void Func_4连环()
        {
            //准备
            IFunc funcInterface = Substitute.For<IFunc>();

            //执行
            Func<int, int> result = CkFunctions.Compose<int, string, int, string, int>(
                funcInterface.Test11,
                funcInterface.Test1,
                funcInterface.Test11,
                funcInterface.Test1);
            result(1);

            //断言
            Received.InOrder(() =>
            {
                funcInterface.Received().Test1(Arg.Any<int>());
                funcInterface.Received().Test11(Arg.Any<string>());
                funcInterface.Received().Test1(Arg.Any<int>());
                funcInterface.Received().Test11(Arg.Any<string>());
            });
        }

        [Fact]
        public void Func_3连环()
        {
            //准备
            IFunc funcInterface = Substitute.For<IFunc>();

            //执行
            Func<int, string> result = CkFunctions.Compose<int, string, int, string>(
                funcInterface.Test1,
                funcInterface.Test11,
                funcInterface.Test1);
            result(1);

            //断言
            Received.InOrder(() =>
            {
                funcInterface.Received().Test1(Arg.Any<int>());
                funcInterface.Received().Test11(Arg.Any<string>());
                funcInterface.Received().Test1(Arg.Any<int>());
            });
        }

        [Fact]
        public void Func_2连环()
        {
            //准备
            IFunc funcInterface = Substitute.For<IFunc>();

            //执行
            Func<int, int> result = CkFunctions.Compose<int, string, int>(
                funcInterface.Test11,
                funcInterface.Test1);
            result(1);

            //断言
            Received.InOrder(() =>
            {
                funcInterface.Received().Test1(Arg.Any<int>());
                funcInterface.Received().Test11(Arg.Any<string>());
            });
        }

        [Fact]
        public void Func_0参1返_N个1参()
        {
            //准备
            IAction actionInterface = Substitute.For<IAction>();
            IFunc funcInterface = Substitute.For<IFunc>();

            //执行
            Func<int> result = CkFunctions.Compose(
                actionInterface.Test11,
                funcInterface.Test0);
            result();

            //断言
            Received.InOrder(() =>
            {
                funcInterface.Received().Test0();
                actionInterface.Received().Test11(Arg.Any<int>());
            });
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
            Func<int> result = CkFunctions.Compose(
                actionInterface.TestVoid,
                funcInterface.Test0);
            result();

            //断言
            Received.InOrder(() =>
            {
                funcInterface.Received().Test0();
                actionInterface.Received().TestVoid();
            });
        }

        [Fact]
        public void 组合_0参1返_1参0返()
        {
            //准备
            IAction actionInterface = Substitute.For<IAction>();
            IFunc funcInterface = Substitute.For<IFunc>();

            //执行
            Func<int> result = CkFunctions.Compose(
                actionInterface.Test11,
                funcInterface.Test0);
            result();

            //断言
            Received.InOrder(() =>
            {
                funcInterface.Received().Test0();
                actionInterface.Received().Test11(Arg.Any<int>());
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
            Func<int, string> result = CkFunctions.Compose<int, string>(
                actionInterface.TestVoid,
                funcInterface.Test1);
            result(1);

            //断言
            Received.InOrder(() =>
            {
                funcInterface.Received().Test1(Arg.Any<int>());
                actionInterface.Received().TestVoid();
            });
        }

        [Fact]
        public void 组合_1参1返_0参1返()
        {
            //准备
            IAction actionInterface = Substitute.For<IAction>();
            IFunc funcInterface = Substitute.For<IFunc>();

            //执行
            Func<int, string> result = CkFunctions.Compose<int, string>(
                actionInterface.Test1,
                funcInterface.Test1);
            result(1);

            //断言
            Received.InOrder(() =>
            {
                funcInterface.Received().Test1(Arg.Any<int>());
                actionInterface.Received().Test1(Arg.Any<string>());
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
            Func<string, int, double> result = CkFunctions.Compose<string, int, double>(
                actionInterface.TestVoid,
                funcInterface.Test2);
            result("a", 1);

            //断言
            Received.InOrder(() =>
            {
                funcInterface.Received().Test2(Arg.Any<string>(), Arg.Any<int>());
                actionInterface.Received().TestVoid();
            });
        }

        [Fact]
        public void 组合_2参1返_1参0返()
        {
            //准备
            IAction actionInterface = Substitute.For<IAction>();
            IFunc funcInterface = Substitute.For<IFunc>();

            //执行
            Func<string, int, double> result = CkFunctions.Compose<string, int, double>(
                actionInterface.Test111,
                funcInterface.Test2);
            result("a", 1);

            //断言
            Received.InOrder(() =>
            {
                funcInterface.Received().Test2(Arg.Any<string>(), Arg.Any<int>());
                actionInterface.Received().Test111(Arg.Any<double>());
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
            Func<int> result = CkFunctions.Compose(
                funcInterface.Test0,
                actionInterface.TestVoid);
            result();

            //断言
            Received.InOrder(() =>
            {
                actionInterface.Received().TestVoid();
                funcInterface.Received().Test0();
            });
        }

        [Fact]
        public void 组合_0参0返_1参1返()
        {
            //准备
            IAction actionInterface = Substitute.For<IAction>();
            IFunc funcInterface = Substitute.For<IFunc>();

            //执行
            Func<int, string> result = CkFunctions.Compose<int, string>(
                funcInterface.Test1,
                actionInterface.TestVoid);
            result(1);

            //断言
            Received.InOrder(() =>
            {
                actionInterface.Received().TestVoid();
                funcInterface.Received().Test1(Arg.Any<int>());
            });
        }

        [Fact]
        public void 组合_0参0返_2参1返()
        {
            //准备
            IAction actionInterface = Substitute.For<IAction>();
            IFunc funcInterface = Substitute.For<IFunc>();

            //执行
            Func<string, int, double> result = CkFunctions.Compose<string, int, double>(
                funcInterface.Test2,
                actionInterface.TestVoid);
            result("a", 1);

            //断言
            Received.InOrder(() =>
            {
                actionInterface.Received().TestVoid();
                funcInterface.Received().Test2(Arg.Any<string>(), Arg.Any<int>());
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
            Func<int, string> result = CkFunctions.Compose<int, string>(
                funcInterface.Test1,
                actionInterface.Test11);
            result(1);

            //断言
            Received.InOrder(() =>
            {
                actionInterface.Received().Test11(Arg.Any<int>());
                funcInterface.Received().Test1(Arg.Any<int>());
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
            Func<string, int, double> result = CkFunctions.Compose<string, int, double>(
                funcInterface.Test2,
                actionInterface.Test22);
            result("a", 1);

            //断言
            Received.InOrder(() =>
            {
                actionInterface.Received().Test22(Arg.Any<string>(), Arg.Any<int>());
                funcInterface.Received().Test2(Arg.Any<string>(), Arg.Any<int>());
            });
        }

        #endregion 第3排

        #endregion exp1 Action  -  exp2 Func
    }
}