using System;
using CkTools.FP;
using Xunit;

namespace CKTools.FP.Test
{
    public class 基础函数_Try_异常处理
    {
        #region Action

        [Fact]
        public void Action_2参0返_带参数处理_正常执行()
        {
            //准备
            Exception? ex = null;
            Action<int, int, Exception> exAction = (_, _, e) => { ex = e; };
            Action<int, int> action = (_, _) => { };

            //执行
            Action<int, int> tryAction = CkFunctions.Try(exAction, action);
            tryAction(1, 2);

            //断言
            //正常执行不报错即可
        }

        [Fact]
        public void Action_2参0返_带参数处理_异常处理()
        {
            //准备
            Exception? ex = null;
            Action<int, int, Exception> exAction = (_, _, e) => { ex = e; };
            Action<int, int> action = (_, _) => { throw new NotImplementedException(); };

            //执行
            Action<int, int> tryAction = CkFunctions.Try(exAction, action);
            tryAction(1, 2);

            //断言
            Assert.NotNull(ex);
        }

        [Fact]
        public void Action_1参0返_带参数处理_正常执行()
        {
            //准备
            Exception? ex = null;
            Action<int, Exception> exAction = (_, e) => { ex = e; };
            Action<int> action = _ => { };

            //执行
            Action<int> tryAction = CkFunctions.Try(exAction, action);
            tryAction(1);

            //断言
            //正常执行不报错即可
        }

        [Fact]
        public void Action_1参0返_带参数处理_异常处理()
        {
            //准备
            Exception? ex = null;
            Action<int, Exception> exAction = (_, e) => { ex = e; };
            Action<int> action = _ => { throw new NotImplementedException(); };

            //执行
            Action<int> tryAction = CkFunctions.Try(exAction, action);
            tryAction(1);

            //断言
            Assert.NotNull(ex);
            Assert.IsType<NotImplementedException>(ex);
        }

        [Fact]
        public void Action_0参0返_无参数处理_正常执行()
        {
            //准备
            Exception? ex = null;
            Action<Exception> exAction = (e) => { ex = e; };
            Action action = () => { };

            //执行
            Action tryAction = CkFunctions.Try(exAction, action);
            tryAction();

            //断言
            //正常执行不报错即可
        }

        [Fact]
        public void Action_0参0返_无参数处理_异常处理()
        {
            //准备
            Exception? ex = null;
            Action<Exception> exAction = (e) => { ex = e; };
            Action action = () => { throw new NotImplementedException(); };

            //执行
            Action tryAction = CkFunctions.Try(exAction, action);
            tryAction();

            //断言
            Assert.NotNull(ex);
            Assert.IsType<NotImplementedException>(ex);
        }

        #endregion Action

        #region Func

        [Fact]
        public void Func_2参1返_带参数处理_正常执行()
        {
            //准备
            Exception? ex = null;
            Action<int, int, Exception> exAction = (_, _, e) => { ex = e; };
            Func<int, int, int> func = (_, _) => 1;

            //执行
            Func<int, int, int> tryFunc = CkFunctions.Try(exAction, func);
            tryFunc(1, 2);

            //断言
            //正常执行不报错即可
        }

        [Fact]
        public void Action_2参1返_带参数处理_异常处理()
        {
            //准备
            Exception? ex = null;
            Action<int, int, Exception> exAction = (_, _, e) => { ex = e; };
            Func<int, int, int> func = (_, _) => { throw new NotImplementedException(); };

            //执行
            Func<int, int, int> tryFunc = CkFunctions.Try(exAction, func);
            tryFunc(1, 2);

            //断言
            Assert.NotNull(ex);
            Assert.IsType<NotImplementedException>(ex);
        }

        [Fact]
        public void Func_1参1返_带参数处理_正常执行()
        {
            //准备
            Exception? ex = null;
            Action<int, Exception> exAction = (_, e) => { ex = e; };
            Func<int, int> func = (_) => 1;

            //执行
            Func<int, int> tryFunc = CkFunctions.Try(exAction, func);
            tryFunc(1);

            //断言
            //正常执行不报错即可
        }

        [Fact]
        public void Action_1参1返_带参数处理_异常处理()
        {
            //准备
            Exception? ex = null;
            Action<int, Exception> exAction = (_, e) => { ex = e; };
            Func<int, int> func = (_) => { throw new NotImplementedException(); };

            //执行
            Func<int, int> tryFunc = CkFunctions.Try(exAction, func);
            tryFunc(1);

            //断言
            Assert.NotNull(ex);
            Assert.IsType<NotImplementedException>(ex);
        }

        [Fact]
        public void Func_0参1返_带参数处理_正常执行()
        {
            //准备
            Exception? ex = null;
            Action<Exception> exAction = (e) => { ex = e; };
            Func<int> func = () => 1;

            //执行
            Func<int> tryFunc = CkFunctions.Try(exAction, func);
            tryFunc();

            //断言
            //正常执行不报错即可
        }

        [Fact]
        public void Action_0参1返_带参数处理_异常处理()
        {
            //准备
            Exception? ex = null;
            Action<Exception> exAction = (e) => { ex = e; };
            Func<int> func = () => { throw new NotImplementedException(); };

            //执行
            Func<int> tryFunc = CkFunctions.Try(exAction, func);
            tryFunc();

            //断言
            Assert.NotNull(ex);
            Assert.IsType<NotImplementedException>(ex);
        }

        #endregion Func
    }
}