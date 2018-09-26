using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using System.Threading.Tasks;

namespace Redis研究
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("验证开始");

            IServiceCollection services = new ServiceCollection();
            services.AddDistributedRedisCache(options =>
            {
                options.Configuration = "localhost:6379";
                //options.Configuration = "10.1.24.68:8020";
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

        [Serializable]
        public class Student
        {
            public int ID { get; set; }
            public string Name { get; set; }
        }

        public static byte[] SerializaStu(Student student)
        {
            IFormatter formatter = new BinaryFormatter();

            MemoryStream stream = new MemoryStream();

            formatter.Serialize(stream, student);

            return stream.ToArray();
        }





        public static T ByteArrayToObject<T>(byte[] arrBytes) where T : class
        {
            IFormatter formatter = new BinaryFormatter();

            MemoryStream memStream = new MemoryStream(arrBytes);

            //memStream.Write(arrBytes, 0, arrBytes.Length);
            //memStream.Seek(0, SeekOrigin.Begin);

            object obj = formatter.Deserialize(memStream);
            return obj as T;
        }
    }
}