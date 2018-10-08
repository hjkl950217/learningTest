using MessagePack;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Redis和序列化研究
{
    public class Program
    {
        private static void Main(string[] args)
        {
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


            IFormatter formatter = new BinaryFormatter();
            MemoryStream stream = new MemoryStream();
            formatter.Serialize(stream, msgStatusList);
            var testBytes= stream.ToArray();

            List<Student3> result = DeSerializableMsgPack<List<Student3>>(data);

            foreach (var item in result)
            {
               // Console.WriteLine($"{item.ID}\t{item.Name}");
                Console.WriteLine($"{item.ID}");
            }

            Console.WriteLine("验证结束");
            Console.ReadLine();
        }

        public static byte[] SerializableMsgPack<T>(T students)
        {
            byte[] bytes = MessagePackSerializer.Serialize<T>(students);
            return bytes;
        }

        public static T DeSerializableMsgPack<T>(byte[] data)
        {

          var t=  MessagePackSerializer.ToJson(data);

            return MessagePackSerializer.Deserialize<T>(data);
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
        public class Student3
        {
            public int ID { get; set; }

        
           // public string Name { get; set; }
        }
    }
}