    using Microsoft.Extensions.Caching.Distributed;
    using Microsoft.Extensions.DependencyInjection;

    using System;
    using System.Collections.Generic;
    using System.Linq;

    namespace Redis和序列化研究
    {
        internal class Program
        {
            private static void Main(string[] args)
            {
                List<Student> msgStatusList = new List<Student>()
                {
                    new Student() { ID = 10, Name = null },
                    new Student() { ID = 10, Name = "B" },
                    new Student() { ID = 10, Name = "C" }
                };

                msgStatusList = msgStatusList
                    .Where(t => t.Name != null)
                    .GroupBy(t => t.ID)
                    .Select(t => t.OrderByDescending(b => b.Name).FirstOrDefault())
                    .ToList();



                TestMsgPack();

                Console.WriteLine("验证开始");

                IServiceCollection services = new ServiceCollection();
                services.AddDistributedRedisCache(options =>
                {
                    //options.Configuration = "localhost:6379";
                    options.Configuration = "10.1.24.68:8020,10.1.24.69:8020";
                });

                IServiceProvider di = services.BuildServiceProvider();

                var redis = di.GetService<IDistributedCache>();

                Student stu = new Student() { ID = 10, Name = "Test" };

                //redis.SetString(
                //    "Test",
                //    JsonConvert.SerializeObject(stu),
                //    new DistributedCacheEntryOptions()
                //    {
                //        AbsoluteExpirationRelativeToNow = TimeSpan.FromSeconds(5)
                //    }
                //    );

                redis.SetEntry(
                    "Test",
                     stu
                    //new DistributedCacheEntryOptions()
                    //{
                    //    AbsoluteExpirationRelativeToNow = TimeSpan.FromSeconds(5)
                    //}
                    );

                int timeOut = 0;

                var result = redis.GetEntryAsync<Student>("Test")
                    .ConfigureAwait(false)
                    .GetAwaiter()
                    .GetResult();
                Console.WriteLine(result.Name);

                //要测试过期时间使用下面的while
                //while (timeOut == 0)
                //{
                //    // var result = redis.GetString("Test");

                //    System.Threading.Thread.Sleep(1 * 1000);

                //    if (result == null || result.Length == 0)
                //    {
                //        timeOut = 1;
                //    }
                //    else
                //    {
                //        var stuEnd = JsonConvert.DeserializeObject<Student>(result);

                //        Console.WriteLine(stuEnd.Name);
                //    }
                //}

                Console.WriteLine("验证结束");
                Console.ReadLine();
            }


            public static void TestMsgPack()
            {
                Student stu = new Student() { ID = 10, Name = "Test" };





            }

            [Serializable]
            public class Student
            {
                public int ID { get; set; }
                public string Name { get; set; }
            }
        }
    }