using System;
using Xunit;

namespace CKTools.FP.Test
{
    public class 对象扩展_ToFp
    {
        [Fact]
        public void ToFunc_直接执行不报错()
        {
            //准备
            //int num = 1;

            //执行
            Func<int> result = 10.ToFunc();

            //断言
            Assert.Equal(10, result());
        }
    }
}