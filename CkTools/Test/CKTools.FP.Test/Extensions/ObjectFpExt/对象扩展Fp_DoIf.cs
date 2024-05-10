using System;
using Xunit;

namespace CKTools.FP.Test
{
    public class 对象扩展Fp_DoIf
    {
        [Fact]
        public void DoIf_委托判断_直接执行不报错_0入()
        {
            //准备
            int num = 1;

            //执行
            10.DoIf(t => false, () => num = 20 + 1);

            //断言
            Assert.Equal(1, num);
        }

        [Fact]
        public void DoIf_直接执行不报错_0入()
        {
            //准备
            int num = 1;

            //执行
            10.DoIf(false, () => num = 10 + 1);

            //断言
            Assert.Equal(1, num);
        }

        [Fact]
        public void DoIf_委托判断_直接执行不报错_1入()
        {
            //准备
            int num = 1;

            //执行
            10.DoIf(t => false, n => num = n + 1);

            //断言
            Assert.Equal(1, num);
        }

        [Fact]
        public void DoIf_直接执行不报错_1入()
        {
            //准备
            int num = 1;

            //执行
            10.DoIf(false, n => num = n + 1);

            //断言
            Assert.Equal(1, num);
        }
    }
}