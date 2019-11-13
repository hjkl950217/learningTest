using System;

namespace 技术点验证
{
    public static class A21_TestObj2Extension
    {
        public static string Method1(this A21_TestObj2 a21_TestObj2)
        {
            return $"{a21_TestObj2.StringArry.ToJson()}{a21_TestObj2.DicList.ToJson()}";
        }

        public static string Method2(this A21_TestObj2 a21_TestObj2)
        {
            return $"{a21_TestObj2.DoubleList.ToJson()}";
        }

        public static string Method3(this A21_TestObj2 a21_TestObj2)
        {
            return $"{a21_TestObj2.TestColor.ToJson()}";
        }

        public static string Method4(this A21_TestObj2 a21_TestObj2)
        {
            return $"{a21_TestObj2.Integr.ToJson()}";
        }

        public static string Method5(this A21_TestObj2 a21_TestObj2)
        {
            return $"{a21_TestObj2.Double.ToJson()}";
        }

        public static string Method6(this A21_TestObj2 a21_TestObj2)
        {
            return $"{a21_TestObj2.Name.ToJson()}";
        }

        public static string Method7(this A21_TestObj2 a21_TestObj2)
        {
            return $"{a21_TestObj2.TestEnum.ToJson()}";
        }

        public static string Method8(this A21_TestObj2 a21_TestObj2)
        {
            return $"{a21_TestObj2.TestEnum.ToJson()}{a21_TestObj2.Integr.ToJson()}";
        }

        public static string Method9(this A21_TestObj2 a21_TestObj2)
        {
            return $"{a21_TestObj2.Double.ToJson()}{a21_TestObj2.Integr.ToJson()}";
        }

        public static string Method10(this A21_TestObj2 a21_TestObj2)
        {
            return $"{a21_TestObj2.StringArry.ToJson()}{a21_TestObj2.Integr.ToJson()}";
        }
    }
}