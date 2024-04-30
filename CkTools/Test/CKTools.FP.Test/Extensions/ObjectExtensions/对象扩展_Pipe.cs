using System;
using Xunit;

namespace CKTools.FP.Test
{
    public class 对象扩展_Pipe
    {
        [Fact]
        public void Pipe_直接执行不报错_0入()
        {
            //准备
            int num = 1;

            //执行
            10.Pipe(() => num = 10 + 1);

            //断言
            Assert.Equal(11, num);
        }

        [Fact]
        public void Pipe_直接执行不报错_1入()
        {
            //准备
            int num = 1;

            //执行
            10.Pipe(n => { num = n + 1; });

            //断言
            Assert.Equal(11, num);
        }

        [Fact]
        public void Pipe_转换为新类型_直接执行不报错_1入1出()
        {
            //准备
            int num = 1;

            //执行
            string result = 10.Pipe(n => (num + n).ToString());

            //断言
            Assert.Equal("11", result);
        }
    }
}