using System;
using System.Collections.Generic;
using CkTools.FP;
using Xunit;

namespace CKTools.FP.Test
{
    public class Common公共函数
    {
        [Fact]
        public void 单个对象处理()
        {
            //准备
            int count = 100;
            Action<int> process = t => count = t + count;
            Func<int, bool> judge = t => t == 10;

            //执行
            Action<int> result = CkFunctions.ProcessObject(process)(judge);
            result(10);

            //断言
            Assert.Equal(110, count);
        }

        [Fact]
        public void 批量对象处理()
        {
            //准备
            int targetValue = 0;//检查值
            string[] objectArray = new string[] { "a", "b" };

            Action<string?> process = t => targetValue += 100;
            Func<string?, bool> judge = t => t == "b";

            //执行
            Action<IEnumerable<string?>?> result = CkFunctions.Foreach(process)(judge);
            result(objectArray);

            //断言
            Assert.Equal(100, targetValue);
        }
    }
}