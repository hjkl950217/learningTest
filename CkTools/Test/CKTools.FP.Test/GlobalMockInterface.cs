namespace CKTools.FP.Test
{
    /// <summary>
    /// 测试接口
    /// </summary>
    public interface IAction
    {
        void TestVoid();

        void Test0();

        void Test00();

        void Test1(string a);

        void Test11(int a);

        void Test111(double a);

        void Test1111(string a);

        void Test2(string b, string a);

        void Test22(string b, int a);

        void Test222(string b, int a);
    }

    /// <summary>
    /// 测试接口
    /// </summary>
    public interface IFunc
    {
        int Test0();

        int Test00();

        double Test000();

        string Test1(int a);

        int Test11(string a);

        double Test111(double a);

        double Test1111(double a);

        double Test11111(int a);

        double Test2(string b, int a);

        int Test22(string b, int a);

        double Test222(string b, int a);
    }
}