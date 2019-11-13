using AutoFixture;
using Verification.Core;

namespace 技术点验证
{
    public class A21_实体方法空间占用 : IVerification
    {
        public VerificationTypeEnum VerificationType => VerificationTypeEnum.A21_实体方法空间占用;

        /*
         * 参考 C++虚函数表原理浅析：https://www.cnblogs.com/zhxmdefj/p/11594459.html
         *
         *
         */

        public void Start(string[] args)
        {
            this.Test(10);
            this.Test(10 * 10);
            this.Test(10 * 100);
            this.Test(10 * 1000);
            //this.Test(10 * 1_0000);
        }

        private long ShowMemoryUsage()
        {
            long bytes = System.GC.GetTotalAllocatedBytes(true);

            System.Console.WriteLine($"已经占用的内存：" +
                $"\t{bytes} 字节 " +
                $"\t{bytes / 1024} KB" +
                $"\t{bytes / (1024 * 1024)} MB"
                );

            return bytes;
        }

        private void ShowDifference(long byte1, long byte2)
        {
            long byteEnd = byte2 - byte1;

            System.Console.WriteLine($"相差：\t\t" +
                $"\t{byteEnd} 字节 " +
                $"\t{byteEnd / 1024} KB" +
                $"\t{byteEnd / (1024 * 1024)} MB"
                );
        }

        public void Test(int count)
        {
            System.Console.WriteLine("======================================================");
            System.Console.WriteLine($"执行测试，测试对象个数:{count}");
            System.GC.Collect();

            System.Console.WriteLine("--使用实体方法--");
            var a1 = this.ShowMemoryUsage();
            var result1 = this.UseEntityMethod(count);
            var a2 = this.ShowMemoryUsage();
            this.ShowDifference(a1, a2);
            result1 = null;
            System.Console.WriteLine("--使用实体方法--");

            System.Console.WriteLine();

            System.GC.Collect();
            System.Console.WriteLine("--使用扩展方法--");
            var b1 = this.ShowMemoryUsage();
            var result2 = this.UseExtensionMethod(count);
            var b2 = this.ShowMemoryUsage();
            this.ShowDifference(b1, b2);
            System.Console.WriteLine("--使用扩展方法--");
            result2 = null;
            System.GC.Collect();

            System.Console.WriteLine("======================================================");
        }

        public A21_TestObj1[] UseEntityMethod(int count)
        {
            Fixture fixture = new Fixture();

            A21_TestObj1[] result = new A21_TestObj1[count];
            for (int i = 0 ; i < count ; i++)
            {
                result[i] = fixture.Create<A21_TestObj1>();
            }
            return result;
        }

        public A21_TestObj2[] UseExtensionMethod(int count)
        {
            Fixture fixture = new Fixture();
            A21_TestObj2[] result = new A21_TestObj2[count];
            for (int i = 0 ; i < count ; i++)
            {
                result[i] = fixture.Create<A21_TestObj2>();
            }
            return result;
        }
    }
}