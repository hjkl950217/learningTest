using System;
using Xunit;

namespace CKTools.FP.Test
{
    public class 对象扩展_PipeIf
    {
        #region Action版本

        [Fact]
        public void PipeIf_委托判断_直接执行不报错_0入()
        {
            //准备
            int num = 1;

            //执行
            10.PipeIf(t => false, () => num = 20 + 1);

            //断言
            Assert.Equal(1, num);
        }

        [Fact]
        public void PipeIf_直接执行不报错_0入()
        {
            //准备
            int num = 1;

            //执行
            10.PipeIf(false, () => num = 10 + 1);

            //断言
            Assert.Equal(1, num);
        }

        [Fact]
        public void PipeIf_委托判断_直接执行不报错_1入()
        {
            //准备
            int num = 1;

            //执行
            10.PipeIf(t => false, n => num = n + 1);

            //断言
            Assert.Equal(1, num);
        }

        [Fact]
        public void PipeIf_直接执行不报错_1入()
        {
            //准备
            int num = 1;

            //执行
            10.PipeIf(false, n => num = n + 1);

            //断言
            Assert.Equal(1, num);
        }

        #endregion Action版本

        #region Func版本

        [Fact]
        public void PipeIf_委托判断_直接执行不报错_1入1出()
        {
            //准备
            int num = 1;

            //执行
            int result = 10.PipeIf(t => false, t => num + t);

            //断言
            Assert.Equal(10, result);
        }

        [Fact]
        public void PipeIf_委托判断2_直接执行不报错_1入1出()
        {
            //准备
            int num = 1;

            //执行
            int result = 10.PipeIf(() => false, t => num + t);

            //断言
            Assert.Equal(10, result);
        }

        [Fact]
        public void PipeIf_直接执行不报错_1入1出()
        {
            //准备
            int num = 1;

            //执行
            int result = 10.PipeIf(false, t => num + t);

            //断言
            Assert.Equal(10, result);
        }

        #endregion Func版本
    }
}