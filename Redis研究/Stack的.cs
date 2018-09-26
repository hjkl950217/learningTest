
//using Microsoft.Extensions.DependencyInjection;
//using StackExchange.Redis;
//using System;

//namespace Redis研究
//{
//    internal class Program
//    {
//        private static void Main(string[] args)
//        {
//            Console.WriteLine("验证开始");

//            IServiceCollection services = new ServiceCollection();
           
//            IServiceProvider di = services.BuildServiceProvider();


  

//            ConnectionMultiplexer conn = ConnectionMultiplexer.Connect("localhost");



//          IDatabase redis = conn.GetDatabase();


//           // redis.listSet();

//            Console.WriteLine("验证结束");
//            Console.ReadLine();
//        }
//    }
//}