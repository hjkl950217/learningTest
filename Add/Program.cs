namespace Add
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string a = AddOnne.AddByString("12321425443443", "433222");

            // string a = AddOnne.AddByString("19", "17");

            string result = "12321425876665";

            #region 基准测试

            ////需要在发布模式下测试

            //Type[] types = new Type[]
            //{
            //    typeof(AddTest)
            //};
            //BenchmarkSwitcher.FromTypes(types).RunAll();

            #endregion 基准测试
        }
    }
}