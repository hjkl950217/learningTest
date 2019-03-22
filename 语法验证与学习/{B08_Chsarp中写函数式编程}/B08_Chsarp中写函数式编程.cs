using System;
using System.Threading;
using Verification.Core;

namespace 语法验证与学习
{
    public class B08_Chsarp中写函数式编程 : IVerification
    {
        //参考资料： https://www.oschina.net/translate/functional-programming-in-csharp?lang=chs&p=1

        public VerificationTypeEnum VerificationType => VerificationTypeEnum.B08_Chsarp中写函数式编程;

        public void Start(string[] args)
        {
            VerificationHelp.Start()
                .Add(this.FactorialDemo)
                .Add(this.ClosureDemo)
                .BatchRun();
        }

        /// <summary>
        /// 闭包Demo
        /// </summary>
        /// <remarks>
        /// 如果一个委托在其函数体中引用了一些变量，那么这些变量将会像这个函数的“属性”一样，在这个函数被调用时作为它的一部分。
        ///
        /// 上面是我理解的闭包
        /// </remarks>
        public void ClosureDemo()
        {
            Console.WriteLine("演示--利用闭包特性完成缓存");

            Func<DateTime> now = () => DateTime.Now;

            Func<DateTime> nowCached = now.Cache(3);

            Console.WriteLine("\tCurrent time\tCached time");
            for (int i = 0 ; i < 9 ; i++)
            {
                Console.WriteLine("{0}.\t{1:T}\t{2:T}", i + 1, now(), nowCached());
                Thread.Sleep(1000);
            }
        }

        /// <summary>
        /// 阶乘
        /// </summary>
        /// <remarks>
        /// 阶乘：n! = n*(n-1)*(n-2)*(n-3)*...*3*2*1
        /// 阶乘最小是1，所以使用递归是比较好的。
        /// </remarks>
        public void FactorialDemo()
        {
            //
            /*
             * lambda不能引用自己(因为没有名字)，则需要使用委托变量来套一层
             *
             * 但利用内部方法可以引用自己
             */
            Console.WriteLine("演示--利用递归完成阶乘");

            int factorial(int num)
            {
                return num < 1 ? 1 : num * factorial(num - 1);
            }

            int number = 5;
            Console.WriteLine($"{number}的阶乘为: {{0}}", factorial(number));
        }

        /// <summary>
        /// 分部方法
        /// <para>使用默认值来降低调用时的参数个数的一种方法</para>
        /// </summary>
        public void PartialFunctionDemo()
        {
            Func<double, double, double> pow = Math.Pow;
            var exp = pow.Partial1(Math.E);//得到: e^x  这样的函数
            var step = pow.Partial1(2);//得到: 2^x  这样的函数

            var square = pow.Partial2(2);//得到 x^2 这样的函数
            var cube = pow.Partial2(3);//得到 x^3 这样的函数
        }

        /// <summary>
        /// 柯里化
        /// </summary>
        public void CurryFunctionDemo()
        {
            //https://www.oschina.net/translate/functional-programming-in-csharp?lang=chs&p=8
        }
    }

    /// <summary>
    /// 仅仅只是放这次研究中，写的一些扩展方法，不要在意名字
    /// </summary>
    public static class B08_Chsarp中写函数式编程Fun
    {
        public static Func<T> Cache<T>(this Func<T> func, int cacheInterval)
        {
            var cachedValue = func();//记录第一次调用的值
            var timeCached = DateTimeOffset.Now;//记录缓存方法第一次调用时的时间

            T cachedFunc()
            {
                bool isExpired = (DateTimeOffset.Now - timeCached).Seconds >= cacheInterval;
                if (isExpired)
                {
                    timeCached = DateTimeOffset.Now;
                    cachedValue = func();//过期后，调用方法更新返回值
                }
                return cachedValue;
            }

            return cachedFunc;
        }

        /// <summary>
        /// 分部方法
        /// <para>使用默认值来降低调用时的参数个数的一种方法</para>
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TR"></typeparam>
        /// <param name="func"></param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        public static Func<T2, TR> Partial1<T1, T2, TR>(this Func<T1, T2, TR> func, T1 defaultValue)
        {
            return b => func(defaultValue, b);
        }

        public static Func<T1, TR> Partial2<T1, T2, TR>(this Func<T1, T2, TR> func, T2 defaultValue)
        {
            return a => func(a, defaultValue);
        }

        public static Func<T1, Func<T2, Func<T3, TResult>>> Curry<T1, T2, T3, TResult>(
            Func<T1, T2, T3, TResult> function)
        {
            return a => b => c => function(a, b, c);
        }
    }
}