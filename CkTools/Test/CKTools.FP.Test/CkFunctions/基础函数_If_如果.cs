using System;
using CkTools.FP;
using NSubstitute;
using Xunit;
using static CkTools.FP.CkFunctions;

namespace CKTools.FP.Test
{
    public class 基础函数_If_如果
    {
        #region Action

        #region 第1排

        [Fact]
        public void Action_0参0返_0参0返()
        {
            //准备
            IAction actionInterface = Substitute.For<IAction>();

            //执行
            Action result = CkFunctions.If(
                actionInterface.Test00,
                actionInterface.Test0,
                FpConst.False);

            result();

            //断言
            actionInterface.DidNotReceive().Test0();
            actionInterface.Received().Test00();
        }

        [Fact]
        public void Action_0参0返_1参0返()
        {
            //准备
            IAction actionInterface = Substitute.For<IAction>();

            //执行
            Action<string> result = CkFunctions.If<string>(
                actionInterface.Test1,
                actionInterface.Test0,
                FpConst.False);

            result("a");

            //断言

            actionInterface.DidNotReceive().Test0();
            actionInterface.Received().Test1(Arg.Any<string>());
        }

        [Fact]
        public void Action_0参0返_2参0返()
        {
            //准备
            IAction actionInterface = Substitute.For<IAction>();

            //执行
            Action<string, string> result = CkFunctions.If<string, string>(
                actionInterface.Test2,
                actionInterface.Test0,
                FpConst.False);

            result("a", "b");

            //断言

            actionInterface.DidNotReceive().Test0();
            actionInterface.Received().Test2(Arg.Any<string>(), Arg.Any<string>());
        }

        #endregion 第1排

        #region 第2排

        [Fact]
        public void Action_1参0返_0参0返()
        {
            //准备
            IAction actionInterface = Substitute.For<IAction>();

            //执行
            Action<string> result = CkFunctions.If<string>(
                actionInterface.Test0,
                actionInterface.Test1,
                FpConst.False);

            result("a");

            //断言

            actionInterface.DidNotReceive().Test1(Arg.Any<string>());
            actionInterface.Received().Test0();
        }

        [Fact]
        public void Action_1参0返_1参0返()
        {
            //准备
            IAction actionInterface = Substitute.For<IAction>();

            //执行
            Action<string> result = CkFunctions.If<string>(
                actionInterface.Test1111,
                actionInterface.Test1,
                FpConst.False);

            result("a");

            //断言

            actionInterface.DidNotReceive().Test1(Arg.Any<string>());
            actionInterface.Received().Test1111(Arg.Any<string>());
        }

        [Fact]
        public void Action_1参0返_2参0返()
        {
            //准备
            IAction actionInterface = Substitute.For<IAction>();

            //执行
            Action<string, string> result = CkFunctions.If<string, string>(
                actionInterface.Test2,
                actionInterface.Test1,
                FpConst.False);

            result("a", "b");

            //断言

            actionInterface.DidNotReceive().Test1(Arg.Any<string>());
            actionInterface.Received().Test2(Arg.Any<string>(), Arg.Any<string>());
        }

        #endregion 第2排

        #region 第3排

        [Fact]
        public void Action_2参0返_0参0返()
        {
            //准备
            IAction actionInterface = Substitute.For<IAction>();

            //执行
            Action<string, string> result = CkFunctions.If<string, string>(
                actionInterface.Test0,
                actionInterface.Test2,
                FpConst.False);

            result("a", "b");

            //断言

            actionInterface.DidNotReceive().Test2(Arg.Any<string>(), Arg.Any<string>());
            actionInterface.Received().Test0();
        }

        [Fact]
        public void Action_2参0返_1参0返()
        {
            //准备
            IAction actionInterface = Substitute.For<IAction>();

            //执行
            Action<string, string> result = CkFunctions.If<string, string>(
                actionInterface.Test1,
                actionInterface.Test2,
                FpConst.False);

            result("a", "b");

            //断言

            actionInterface.DidNotReceive().Test2(Arg.Any<string>(), Arg.Any<string>());
            actionInterface.Received().Test1(Arg.Any<string>());
        }

        [Fact]
        public void Action_2参0返_2参0返()
        {
            //准备
            IAction actionInterface = Substitute.For<IAction>();

            //执行
            Action<string, int> result = CkFunctions.If<string, int>(
                actionInterface.Test222,
                actionInterface.Test22,
                FpConst.False);

            result("a", 1);

            //断言

            actionInterface.DidNotReceive().Test22(Arg.Any<string>(), Arg.Any<int>());
            actionInterface.Received().Test222(Arg.Any<string>(), Arg.Any<int>());
        }

        #endregion 第3排

        #endregion Action

        #region Func

        #region 第1排

        [Fact]
        public void Func_0参1返_0参1返()
        {
            //准备
            IFunc funcInterface = Substitute.For<IFunc>();

            //执行
            Func<int> result = CkFunctions.If(
                funcInterface.Test00,
                funcInterface.Test0,
                FpConst.False);

            result();

            //断言

            funcInterface.DidNotReceive().Test0();
            funcInterface.Received().Test00();
        }

        [Fact]
        public void Func_0参1返_1参1返()
        {
            //准备
            IFunc funcInterface = Substitute.For<IFunc>();

            //执行
            Func<string, int> result = CkFunctions.If<string, int>(
                funcInterface.Test11,
                funcInterface.Test0,
                FpConst.False);

            result("a");

            //断言

            funcInterface.DidNotReceive().Test0();
            funcInterface.Received().Test11(Arg.Any<string>());
        }

        [Fact]
        public void Func_0参1返_2参1返()
        {
            //准备
            IFunc funcInterface = Substitute.For<IFunc>();

            //执行
            Func<string, int, int> result = CkFunctions.If<string, int, int>(
                funcInterface.Test22,
                funcInterface.Test0,
                FpConst.False);

            result("a", 1);

            //断言

            funcInterface.DidNotReceive().Test0();
            funcInterface.Received().Test22(Arg.Any<string>(), Arg.Any<int>());
        }

        #endregion 第1排

        #region 第2排

        [Fact]
        public void Func_1参1返_0参1返()
        {
            //准备
            IFunc funcInterface = Substitute.For<IFunc>();

            //执行
            Func<string, int> result = CkFunctions.If<string, int>(
                funcInterface.Test11,
                funcInterface.Test0,
                FpConst.False);

            result("a");

            //断言

            funcInterface.DidNotReceive().Test0();
            funcInterface.Received().Test11(Arg.Any<string>());
        }

        [Fact]
        public void Func_1参1返_1参1返()
        {
            //准备
            IFunc funcInterface = Substitute.For<IFunc>();

            //执行
            Func<string, int> result = CkFunctions.If<string, int>(
                funcInterface.Test11,
                funcInterface.Test0,
                FpConst.False);

            result("a");

            //断言

            funcInterface.DidNotReceive().Test0();
            funcInterface.Received().Test11(Arg.Any<string>());
        }

        [Fact]
        public void Func_1参1返_2参1返()
        {
            //准备
            IFunc funcInterface = Substitute.For<IFunc>();

            //执行
            Func<string, int, double> result = CkFunctions.If<string, int, double>(
                funcInterface.Test2,
                funcInterface.Test11111,
                FpConst.False);

            result("a", 1);

            //断言

            funcInterface.DidNotReceive().Test11111(Arg.Any<int>());
            funcInterface.Received().Test2(Arg.Any<string>(), Arg.Any<int>());
        }

        #endregion 第2排

        #region 第3排

        [Fact]
        public void Func_2参1返_0参1返()
        {
            //准备
            IFunc funcInterface = Substitute.For<IFunc>();

            //执行
            Func<string, int, double> result = CkFunctions.If<string, int, double>(
                funcInterface.Test000,
                funcInterface.Test2,
                FpConst.False);

            result("a", 1);

            //断言
            funcInterface.DidNotReceive().Test2(Arg.Any<string>(), Arg.Any<int>());
            funcInterface.Received().Test000();
        }

        [Fact]
        public void Func_2参1返_1参1返()
        {
            //准备
            IFunc funcInterface = Substitute.For<IFunc>();

            //执行
            Func<string, int, double> result = CkFunctions.If<string, int, double>(
                funcInterface.Test11111,
                funcInterface.Test2,
                FpConst.False);

            result("a", 1);

            //断言
            funcInterface.DidNotReceive().Test2(Arg.Any<string>(), Arg.Any<int>());
            funcInterface.Received().Test11111(Arg.Any<int>());
        }

        [Fact]
        public void Func_2参1返_2参1返()
        {
            //准备
            IFunc funcInterface = Substitute.For<IFunc>();

            //执行
            Func<string, int, double> result = CkFunctions.If<string, int, double>(
                funcInterface.Test222,
                funcInterface.Test2,
                FpConst.False);

            result("a", 1);

            //断言
            funcInterface.DidNotReceive().Test2(Arg.Any<string>(), Arg.Any<int>());
            funcInterface.Received().Test222(Arg.Any<string>(), Arg.Any<int>());
        }

        #endregion 第3排

        #endregion Func
    }
}