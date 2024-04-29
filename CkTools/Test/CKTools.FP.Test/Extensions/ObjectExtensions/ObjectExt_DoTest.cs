using System;
using Xunit;

namespace CKTools.FP.Test
{
    public class FpObjectDoExtensionTest
    {
        [Fact]
        public void Do_直接执行不报错()
        {
            //准备
            int num = 1;

            //执行
            10.Do(n => num = n + 1);

            //断言
            Assert.Equal(11, num);
        }

        [Fact]
        public void DoIf_委托判断_直接执行不报错()
        {
            //准备
            int num = 1;

            //执行
            10.DoIf(t => false, n => num = n + 1);

            //断言
            Assert.Equal(1, num);
        }

        [Fact]
        public void DoIf_直接执行不报错()
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