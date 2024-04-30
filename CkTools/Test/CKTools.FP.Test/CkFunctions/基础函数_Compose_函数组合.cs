using System;
using CkTools.FP;
using NSubstitute;
using Xunit;

namespace CKTools.FP.Test
{
    public class 基础函数_Compose_函数组合
    {
        #region Action

        #region 第1行

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
            Action<string> result = CkFunctions.Compose(
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
            Action<string, string> result = CkFunctions.Compose(
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

        #endregion 第1行

        #region 第2行

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
            Action<string> result = CkFunctions.Compose<string>(
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
        public void Action_1参0返_2参0返_第1种情况()
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
                actionInterface.Test1(Arg.Any<string>());
                actionInterface.Test2(Arg.Any<string>(), Arg.Any<string>());
            });
        }

        [Fact]
        public void Action_1参0返_2参0返_第2种情况()
        {
            //准备
            IAction actionInterface = Substitute.For<IAction>();

            //执行
            Action<string, int> result = CkFunctions.Compose<string, int>(
               actionInterface.Test22,
               actionInterface.Test11);
            result("a", 1);

            //断言
            Received.InOrder(() =>
            {
                actionInterface.Test11(Arg.Any<int>());
                actionInterface.Test22(Arg.Any<string>(), Arg.Any<int>());
            });
        }

        [Fact]
        public void Action_1参0返_2参0返_第3种情况()
        {
            //准备
            IAction actionInterface = Substitute.For<IAction>();

            //执行
            Action<string, int> result = CkFunctions.Compose<string, int>(
               actionInterface.Test22,
               actionInterface.Test1);
            result("a", 1);

            //断言
            Received.InOrder(() =>
            {
                actionInterface.Test1(Arg.Any<string>());
                actionInterface.Test22(Arg.Any<string>(), Arg.Any<int>());
            });
        }

        #endregion 第2行

        #region 第3行

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
                actionInterface.Test2(Arg.Any<string>(), Arg.Any<string>());
                actionInterface.Test0();
            });
        }

        [Fact]
        public void Action_2参0返_1参0返_第1种情况()
        {
            //准备
            IAction actionInterface = Substitute.For<IAction>();

            //执行
            Action<string, int> result = CkFunctions.Compose<string, int>(
                actionInterface.Test11,
                actionInterface.Test22);
            result("a", 1);

            //断言
            Received.InOrder(() =>
            {
                actionInterface.Test22(Arg.Any<string>(), Arg.Any<int>());
                actionInterface.Test11(Arg.Any<int>());
            });
        }

        [Fact]
        public void Action_2参0返_1参0返_第2种情况()
        {
            //准备
            IAction actionInterface = Substitute.For<IAction>();

            //执行
            Action<string, int> result = CkFunctions.Compose<string, int>(
                actionInterface.Test1,
                actionInterface.Test22);
            result("a", 1);

            //断言
            Received.InOrder(() =>
            {
                actionInterface.Test22(Arg.Any<string>(), Arg.Any<int>());
                actionInterface.Test1(Arg.Any<string>());
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
                actionInterface.Test2(Arg.Any<string>(), Arg.Any<string>());
                actionInterface.Test2(Arg.Any<string>(), Arg.Any<string>());
            });
        }

        #endregion 第3行

        #region 其他

        [Fact]
        public void Action_0参0返_3个以上()
        {
            //准备
            IAction actionInterface = Substitute.For<IAction>();

            //执行
            Action result = CkFunctions.Compose(
                actionInterface.Test00,
                actionInterface.Test0,
                actionInterface.Test0);
            result();

            //断言
            Received.InOrder(() =>
            {
                actionInterface.Test0();
                actionInterface.Test0();
                actionInterface.Test00();
            });
        }

        [Fact]
        public void Action_0参0返_3个以上_倒序()
        {
            //准备
            IAction actionInterface = Substitute.For<IAction>();

            //执行
            Action result = CkFunctions.ComposeReverse(
                actionInterface.Test00,
                actionInterface.Test0,
                actionInterface.Test0);
            result();

            //断言
            Received.InOrder(() =>
            {
                actionInterface.Test00();
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
            Action<string> result = CkFunctions.Compose<string>(
                actionInterface.Test1111,
                actionInterface.Test1,
                actionInterface.Test1);
            result("a");

            //断言
            Received.InOrder(() =>
            {
                actionInterface.Test1(Arg.Any<string>());
                actionInterface.Test1(Arg.Any<string>());
                actionInterface.Test1111(Arg.Any<string>());
            });
        }

        [Fact]
        public void Action_1参0返_3个以上_倒序()
        {
            //准备
            IAction actionInterface = Substitute.For<IAction>();

            //执行
            Action<string> result = CkFunctions.ComposeReverse<string>(
                actionInterface.Test1111,
                actionInterface.Test1,
                actionInterface.Test1);
            result("a");

            //断言
            Received.InOrder(() =>
            {
                actionInterface.Test1111(Arg.Any<string>());
                actionInterface.Test1(Arg.Any<string>());
                actionInterface.Test1(Arg.Any<string>());
            });
        }

        #endregion 其他

        #endregion Action

        #region Func

        #region 第1行

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
                funcInterface.Test0();
                funcInterface.Test1(Arg.Any<int>());
            });
        }

        #endregion 第1行

        #region 第2行

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
                funcInterface.Test1(Arg.Any<int>());
                funcInterface.Test11(Arg.Any<string>());
            });
        }

        #endregion 第2行

        #region 第3行

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
                funcInterface.Test2(Arg.Any<string>(), Arg.Any<int>());
                funcInterface.Test111(Arg.Any<double>());
            });
        }

        #endregion 第3行

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
                funcInterface.Test1(Arg.Any<int>());
                funcInterface.Test11(Arg.Any<string>());
                funcInterface.Test1(Arg.Any<int>());
                funcInterface.Test11(Arg.Any<string>());
                funcInterface.Test1(Arg.Any<int>());
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
                funcInterface.Test1(Arg.Any<int>());
                funcInterface.Test11(Arg.Any<string>());
                funcInterface.Test1(Arg.Any<int>());
                funcInterface.Test11(Arg.Any<string>());
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
                funcInterface.Test1(Arg.Any<int>());
                funcInterface.Test11(Arg.Any<string>());
                funcInterface.Test1(Arg.Any<int>());
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
                funcInterface.Test1(Arg.Any<int>());
                funcInterface.Test11(Arg.Any<string>());
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
                funcInterface.Test0();
                actionInterface.Test11(Arg.Any<int>());
            });
        }

        #endregion 其他

        #endregion Func

        #region exp1 Func  -  exp2 Action

        #region 第1行

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
                funcInterface.Test0();
                actionInterface.TestVoid();
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
                funcInterface.Test0();
                actionInterface.Test11(Arg.Any<int>());
            });
        }

        #endregion 第1行

        #region 第2行

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
            Func<int, string> result = CkFunctions.Compose<int, string>(
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

        #endregion 第2行

        #region 第3行

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
            Func<string, int, double> result = CkFunctions.Compose<string, int, double>(
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

        #endregion 第3行

        #endregion exp1 Func  -  exp2 Action

        #region exp1 Action  -  exp2 Func

        #region 第1行

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
            Func<int, string> result = CkFunctions.Compose<int, string>(
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
            Func<string, int, double> result = CkFunctions.Compose<string, int, double>(
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

        #endregion 第1行

        #region 第2行

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
                actionInterface.Test11(Arg.Any<int>());
                funcInterface.Test1(Arg.Any<int>());
            });
        }

        #endregion 第2行

        #region 第3行

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
                actionInterface.Test22(Arg.Any<string>(), Arg.Any<int>());
                funcInterface.Test2(Arg.Any<string>(), Arg.Any<int>());
            });
        }

        #endregion 第3行

        #endregion exp1 Action  -  exp2 Func
    }
}