using System.Runtime.CompilerServices;

namespace 技术点验证
{
    public class Program
    {
        private static void Main(string?[] args)
        {
            //开始验证
            // VerificationHelp.StartVerification(VerificationTypeEnum.A23_值对象, args);
            TraceMessage("testMsg", "testMember", "testFilePath", 20);
        }

        public static void TraceMessage(string? message,
            [CallerMemberName]string? memberName = "",
            [CallerFilePath]string? sourceFilePath = "",
            [CallerLineNumber]int sourceLineNumber = 0)
        {
            System.Diagnostics.Trace.WriteLine("message: " + message);
            System.Diagnostics.Trace.WriteLine("member name: " + memberName);
            System.Diagnostics.Trace.WriteLine("source file path: " + sourceFilePath);
            System.Diagnostics.Trace.WriteLine("source line number: " + sourceLineNumber);

            System.Console.ReadKey();
        }

        //public static List<IVerification> RegisterAllVerification()
        //{
        //    List<IVerification> verifications = new List<IVerification>();

        //    #region 验证接口的注册

        //    verifications.Add(new A01_获取当前路径的方法());
        //    verifications.Add(new A02_线程ID验证());
        //    verifications.Add(new A03_时间格式验证());
        //    verifications.Add(new A04_ConcurrentDictionary的研究());
        //    verifications.Add(new A05_EFCore学习());
        //    verifications.Add(new A05_EFCore学习());
        //    verifications.Add(new A07_动态添加Attribute());
        //    verifications.Add(new A08_MessagePack基准测试());
        //    verifications.Add(new A09_读取文件并监控变化());
        //    verifications.Add(new A10_读取文件到配置系统并监控变化());
        //    verifications.Add(new A11_日志系统研究());
        //    verifications.Add(new A12_扫描泛型接口_判断类型());
        //    verifications.Add(new A13_Asynclocal的坑());
        //    verifications.Add(new A14_查找相同对象的基准测试());
        //    verifications.Add(new A15_分割字符串的基准测试());
        //    verifications.Add(new A16_懒加载());
        //    verifications.Add(new A17_马尔科夫链());
        //    verifications.Add(new A18_预测鸢尾花的类型_多类分类());
        //    verifications.Add(new A19_熵的计算());
        //    verifications.Add(new A20_并行查找数组中非0的索引());
        //    verifications.Add(new A21_实体方法空间占用());
        //    verifications.Add(new A22_从表达式中解析成员变量名());
        //    verifications.Add(new A23_值对象());

        //    #endregion 验证接口的注册

        //    return verifications;
        //}
    }
}