using System;

namespace Add
{

    public static class TestHelper
    {
        public static Random random = new Random(DateTime.UtcNow.Second);

        /// <summary>
        /// 返回一个随机的数字字符
        /// </summary>
        /// <returns></returns>
        public static char GetRandomNum()
        {
            //0-9
            return Convert.ToChar(TestHelper.random.Next(0, 10));
        }
    }
}