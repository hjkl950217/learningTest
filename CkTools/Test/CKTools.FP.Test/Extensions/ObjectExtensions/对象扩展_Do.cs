using System;
using Xunit;

namespace CKTools.FP.Test
{
    public class 对象扩展_Do
    {
        [Fact]
        public void Do_直接执行不报错()
        {
            //准备
            int num = 1;

            //执行
            10.Do(() => num = 10 + 1);

            //断言
            Assert.Equal(11, num);
        }

        [Fact]
        public void Do_直接执行不报错_1入()
        {
            //准备
            int num = 1;

            //执行
            10.Do(n => num = n + 1);

            //断言
            Assert.Equal(11, num);
        }
    }
}