using MessagePack;
using MessagePack.Resolvers;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;

namespace Redis和序列化研究
{
    public class Program
    {
        private static void Main(string[] args)
        {
            StartupSerializable();

            Console.WriteLine("验证开始");

            List<Student2> msgStatusList = new List<Student2>()
            {
                new Student2() { ID = 10, Name = null },
                new Student2() { ID = 20, Name = null },
                new Student2() { ID = 10, Name = "B" },
                new Student2() { ID = 10, Name = "C" }
            };

            msgStatusList = msgStatusList
                .Where(t => t.Name != null)
                .GroupBy(t => t.ID)
                .Select(t => t.OrderByDescending(b => b.Name).FirstOrDefault())
                .ToList();

            var data = SerializableMsgPack(msgStatusList);

            //最老的方式
            //IFormatter formatter = new BinaryFormatter();
            //MemoryStream stream = new MemoryStream();
            //formatter.Serialize(stream, msgStatusList);
            //var testBytes= stream.ToArray();

            List<Student3> result = DeSerializableMsgPack<List<Student3>>(data);

            //动态类型-1
            //会报错 说没有这个类型的解析器
            //
            dynamic obj2 = new ExpandoObject();
            obj2.ID = 5;
            var data2 = SerializableMsgPack(obj2);
            dynamic result2 = DeSerializableMsgPack<dynamic>(data2);

            //动态类型-2
            Student3 obj3 = new Student3() { ID = 5 };
            var data3 = SerializableMsgPack<Student3>(obj3);
            dynamic result3 = DeSerializableMsgPack<dynamic>(data3);

            foreach (var item in result)
            {
                // Console.WriteLine($"{item.ID}\t{item.Name}");
                Console.WriteLine($"{item.ID}");
            }

            Console.WriteLine("验证结束");
            Console.ReadLine();
        }

        public static void StartupSerializable()
        {
            CompositeResolver.RegisterAndSetAsDefault(
               // BuiltinResolver.Instance,
                StandardResolver.Instance
                //DynamicContractlessObjectResolver.Instance,
                //DynamicEnumAsStringResolver.Instance
           );
        }

        public static byte[] SerializableMsgPack<T>(T students)
        {
            byte[] bytes = MessagePackSerializer.Serialize<T>(students);
            return bytes;
        }

        public static T DeSerializableMsgPack<T>(byte[] data)
        {
            var t = MessagePackSerializer.ToJson(data);

            return MessagePackSerializer.Deserialize<T>(data, CompositeResolver.Instance);
        }

        [MessagePackObject]
        [Serializable]
        public class Student
        {
            [Key(0)]
            public int ID { get; set; }

            [Key(1)]
            public string Name { get; set; }
        }

        [MessagePackObject]
        [Serializable]
        public class Student2
        {
            [Key(nameof(ID))]
            public int ID { get; set; }

            [Key(nameof(Name))]
            public string Name { get; set; }
        }

        [MessagePackObject(keyAsPropertyName: true)]
        [Serializable]
        public sealed class Student3
        {
            public int ID { get; set; }

            // public string Name { get; set; }
        }
    }
}