using System;

namespace CKTools.FP.Test
{
    public static class FpMockFunc
    {
        #region 测试用基本函数

        #region 源类型为String

        public static Func<string, int> strToInt = t => Convert.ToInt32(t);
        public static Action<string> strToVoid = t => { };

        #endregion 源类型为String

        #region 源类型为int

        public static Func<int, double> intToDouble = t => (double)t;
        public static Func<int, string> intToString = t => t.ToString();
        public static Action<int> intToVoid = t => { };

        #endregion 源类型为int

        #region 源类型为double

        public static Func<double, string> doubleToStr = t => t.ToString();
        public static Func<double, int> doubleToInt = t => (int)t;
        public static Action<double> doubleToVoid = t => { };

        #endregion 源类型为double

        #endregion 测试用基本函数
    }
}