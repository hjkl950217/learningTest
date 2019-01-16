using System;
using System.Threading;
using System.Threading.Tasks;
using Verification.Core;

namespace 技术点验证
{
    public class A13_Asynclocal的坑 : IVerification
    {
        public VerificationTypeEnum VerificationType => VerificationTypeEnum.A13_Asynclocal的坑;

        public static AsyncLocal<int> v = new AsyncLocal<int>();

        public void Start(string[] args)
        {
            var task = Task.Run(async () =>
            {
                v.Value = 123;
                A13_Asynclocal的坑.Show("await之前的值");

                var intercept = new Intercept();
                await Intercept.Invoke();

                A13_Asynclocal的坑.Show("await之后的值");
            });
            task.Wait();
        }

        public static void Show(string preStr)
        {
            Console.WriteLine("当前线程ID:"+Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine(preStr + A13_Asynclocal的坑.v.Value);
            Console.WriteLine("----------------");
            Console.WriteLine(); 
        }
    }

    public class Intercept
    {
        public static async Task Invoke()
        {
            A13_Asynclocal的坑.v.Value = 888;
            A13_Asynclocal的坑.Show("await之中的值");
        }
    }
}