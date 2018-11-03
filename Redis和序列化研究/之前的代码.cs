//using MessagePack;
//using MessagePack.Resolvers;
//using System;
//using System.Collections.Generic;
//using System.Diagnostics;
//using System.IO;
//using System.Linq;
//using System.Runtime.Serialization;
//using System.Runtime.Serialization.Formatters.Binary;

///*
// * 缺少包则引用：
//    <PackageReference Include = "MessagePack" Version="1.7.3.4" />
//    <PackageReference Include = "MessagePack.AspNetCoreMvcFormatter" Version="1.7.3.4" />
//    <PackageReference Include = "MessagePack.ImmutableCollection" Version="1.7.3.4" />
//    <PackageReference Include = "MessagePackAnalyzer" Version="1.6.0" />
//    */

//namespace Redis和序列化研究
//{
//    public class Program
//    {
//        private static void Main(string[] args)
//        {
     
//            Console.WriteLine("验证开始");
//            Stopwatch stopwatch = new Stopwatch();
//            int testTotal = 50 * 10000;

//            StartupSerializable();//初始化序列化器

//            // 反序列化时使用，代表使用上面的组合序列化器
//            // CompositeResolver.Instanc
//            // 设置自定义解析器的Singleton帮助器。您可以使用Register或RegisterAndSetAsDefaultAPI。

//            #region 显示测试数据

//            List<Student> showList = new List<Student>()
//            {
//                new Student() { ID = 10, Name = null },
//                new Student() { ID = 20, Name = null },
//                new Student() { ID = 10, Name = "B" },
//                new Student() { ID = 10, Name = "C" }
//            };

//            foreach (var item in showList)
//            {
//                Console.WriteLine($"-{item.ID}\t{item.Name}-");
//            }

//            #endregion 显示测试数据

//            #region 第0组-默认序列化器

//            Console.WriteLine();
//            Console.WriteLine("第0组-默认序列化器");

//            List<Student> source0 = new List<Student>()
//            {
//                new Student() { ID = 10, Name = null },
//                new Student() { ID = 20, Name = null },
//                new Student() { ID = 10, Name = "B" },
//                new Student() { ID = 10, Name = "C" }
//            };

//            source0 = source0
//               .Where(t => t.Name != null)
//               .GroupBy(t => t.ID)
//               .Select(t => t.OrderByDescending(b => b.Name).FirstOrDefault())
//               .ToList();

//            //序列化
//            byte[] data0 = SerializeDefault(source0);
//            Console.WriteLine($"序列化后byte大小：{data0.Length}");

//            //反序列化
//            List<Student> result0 = DeserializeDefault<List<Student>>(data0);

//            Console.WriteLine("结果显示:");
//            foreach (var item in result0)
//            {
//                Console.WriteLine($"{item.ID}\t{item.Name}");
//            }

//            Console.WriteLine();

//            Console.WriteLine("性能测试：");
//            List<Student> testList0 = GetTestData(testTotal);

//            stopwatch.Restart();
//            stopwatch.Start();
//            byte[] testByte0 = SerializeDefault(testList0);
//            stopwatch.Stop();
//            Console.WriteLine($"序列化{testTotal}条,耗时:{stopwatch.ElapsedMilliseconds.ToString("N0")}ms,大小:{IntTo1024(testByte0.Length)}");

//            stopwatch.Restart();
//            stopwatch.Start();
//            DeserializeDefault<List<Student>>(testByte0);
//            stopwatch.Stop();
//            Console.WriteLine($"反序列化{testTotal}条,耗时:{stopwatch.ElapsedMilliseconds.ToString("N0")}ms");
//            Console.WriteLine("-----------END--------------");

//            #endregion 第0组-默认序列化器

//            #region 第一组测试-intKey-to-intKey

//            Console.WriteLine("第一组测试-intKey-to-intKey");

//            List<Student> source = new List<Student>()
//            {
//                new Student() { ID = 10, Name = null },
//                new Student() { ID = 20, Name = null },
//                new Student() { ID = 10, Name = "B" },
//                new Student() { ID = 10, Name = "C" }
//            };

//            source = source
//               .Where(t => t.Name != null)
//               .GroupBy(t => t.ID)
//               .Select(t => t.OrderByDescending(b => b.Name).FirstOrDefault())
//               .ToList();

//            //序列化
//            byte[] data = Serialize(source);
//            Console.WriteLine($"序列化后byte大小：{data.Length}");

//            //反序列化
//            List<Student> result = Deserialize<List<Student>>(data);
//            string resultStr = MessagePackSerializer.ToJson(data);

//            Console.WriteLine("结果显示:");
//            foreach (var item in result)
//            {
//                Console.WriteLine($"{item.ID}\t{item.Name}");
//            }

//            Console.WriteLine();

//            Console.WriteLine("性能测试：");
//            List<Student> testList = GetTestData(testTotal);

//            stopwatch.Restart();
//            stopwatch.Start();
//            byte[] testByte = Serialize(testList);
//            stopwatch.Stop();
//            Console.WriteLine($"序列化{testTotal}条,耗时:{stopwatch.ElapsedMilliseconds.ToString("N0")}ms,大小:{IntTo1024(testByte.Length)}");

//            stopwatch.Restart();
//            stopwatch.Start();
//            Deserialize<List<Student>>(testByte);
//            stopwatch.Stop();
//            Console.WriteLine($"反序列化{testTotal}条,耗时:{stopwatch.ElapsedMilliseconds.ToString("N0")}ms");
//            Console.WriteLine("-----------END--------------");

//            #endregion 第一组测试-intKey-to-intKey

//            #region 第二组测试-StringKey-to-StringKey

//            Console.WriteLine();
//            Console.WriteLine("第二组测试-StringKey2-to-StringKey0");

//            List<Student2> source2 = new List<Student2>()
//            {
//                new Student2() { ID = 10, Name = null },
//                new Student2() { ID = 20, Name = null },
//                new Student2() { ID = 10, Name = "B" },
//                new Student2() { ID = 10, Name = "C" }
//            };

//            source2 = source2
//               .Where(t => t.Name != null)
//               .GroupBy(t => t.ID)
//               .Select(t => t.OrderByDescending(b => b.Name).FirstOrDefault())
//               .ToList();

//            //序列化
//            byte[] data2 = Serialize(source2);
//            Console.WriteLine($"序列化后byte大小：{data2.Length}");

//            //反序列化
//            List<Student3> result2 = Deserialize<List<Student3>>(data2);
//            string resultStr2 = MessagePackSerializer.ToJson(data2);

//            Console.WriteLine("结果显示:");
//            foreach (var item in result2)
//            {
//                Console.WriteLine($"{item.ID}\t{item.Name}");
//            }

//            Console.WriteLine();

//            Console.WriteLine("性能测试：");
//            List<Student2> testList2 = GetTestData2(testTotal);

//            stopwatch.Restart();
//            stopwatch.Start();
//            byte[] testByte2 = Serialize(testList2);
//            stopwatch.Stop();
//            Console.WriteLine($"序列化{testTotal}条,耗时:{stopwatch.ElapsedMilliseconds.ToString("N0")}ms,大小:{IntTo1024(testByte2.Length)}");

//            stopwatch.Restart();
//            stopwatch.Start();
//            Deserialize<List<Student3>>(testByte2);
//            stopwatch.Stop();
//            Console.WriteLine($"反序列化{testTotal}条,耗时:{stopwatch.ElapsedMilliseconds.ToString("N0")}ms");
//            Console.WriteLine("-----------END--------------");

//            #endregion 第二组测试-StringKey-to-StringKey

//            #region 第三组测试-NonAttribute

//            Console.WriteLine();
//            Console.WriteLine("第三组测试-NonAttribute");

//            List<Student3> source3 = new List<Student3>()
//            {
//                new Student3() { ID = 10, Name = null },
//                new Student3() { ID = 20, Name = null },
//                new Student3() { ID = 10, Name = "B" },
//                new Student3() { ID = 10, Name = "C" }
//            };

//            source3 = source3
//               .Where(t => t.Name != null)
//               .GroupBy(t => t.ID)
//               .Select(t => t.OrderByDescending(b => b.Name).FirstOrDefault())
//               .ToList();

//            //序列化
//            byte[] data3 = Serialize(source3);
//            Console.WriteLine($"序列化后byte大小：{data3.Length}");

//            //反序列化
//            List<Student3> result3 = Deserialize<List<Student3>>(data3);
//            string resultStr3 = MessagePackSerializer.ToJson(data3);

//            Console.WriteLine("结果显示:");
//            foreach (var item in result3)
//            {
//                Console.WriteLine($"{item.ID}\t{item.Name}");
//            }

//            Console.WriteLine();

//            Console.WriteLine("性能测试：");
//            List<Student3> testList3 = GetTestData3(testTotal);

//            stopwatch.Restart();
//            stopwatch.Start();
//            byte[] testByte3 = Serialize(testList3);
//            stopwatch.Stop();
//            Console.WriteLine($"序列化{testTotal}条,耗时:{stopwatch.ElapsedMilliseconds.ToString("N0")}ms,大小:{IntTo1024(testByte3.Length)}");

//            stopwatch.Restart();
//            stopwatch.Start();
//            Deserialize<List<Student3>>(testByte3);
//            stopwatch.Stop();
//            Console.WriteLine($"反序列化{testTotal}条,耗时:{stopwatch.ElapsedMilliseconds.ToString("N0")}ms");
//            Console.WriteLine("-----------END--------------");

//            #endregion 第三组测试-NonAttribute

//            #region 第四组测试-NonAttribute-To-Dynamic

//            Console.WriteLine();
//            Console.WriteLine("第四组测试-NonAttribute-To-Dynamic");

//            List<Student3> source4 = new List<Student3>()
//            {
//                new Student3() { ID = 10, Name = null },
//                new Student3() { ID = 20, Name = null },
//                new Student3() { ID = 10, Name = "B" },
//                new Student3() { ID = 10, Name = "C" }
//            };

//            source4 = source4
//               .Where(t => t.Name != null)
//               .GroupBy(t => t.ID)
//               .Select(t => t.OrderByDescending(b => b.Name).FirstOrDefault())
//               .ToList();

//            //序列化
//            byte[] data4 = Serialize(source4);
//            Console.WriteLine($"序列化后byte大小：{data4.Length}");

//            //反序列化
//            dynamic result4 = Deserialize<dynamic>(data4);
//            string resultStr4 = MessagePackSerializer.ToJson(data4);

//            Console.WriteLine();

//            Console.WriteLine("性能测试：");
//            List<Student3> testList4 = GetTestData3(testTotal);

//            stopwatch.Restart();
//            stopwatch.Start();
//            byte[] testByte4 = Serialize(testList4);
//            stopwatch.Stop();
//            Console.WriteLine($"序列化{testTotal}条,耗时:{stopwatch.ElapsedMilliseconds.ToString("N0")}ms,大小:{IntTo1024(testByte4.Length)}");

//            stopwatch.Restart();
//            stopwatch.Start();
//            Deserialize<dynamic>(testByte4);
//            stopwatch.Stop();
//            Console.WriteLine($"反序列化{testTotal}条,耗时:{stopwatch.ElapsedMilliseconds.ToString("N0")}ms");
//            Console.WriteLine("-----------END--------------");

//            #endregion 第四组测试-NonAttribute-To-Dynamic

//            #region 第五组测试-StringKey-To-NonAttribute

//            Console.WriteLine();
//            Console.WriteLine("第五组测试-StringKey-To-NonAttribute");

//            List<Student2> source5 = new List<Student2>()
//            {
//                new Student2() { ID = 10, Name = null },
//                new Student2() { ID = 20, Name = null },
//                new Student2() { ID = 10, Name = "B" },
//                new Student2() { ID = 10, Name = "C" }
//            };

//            source5 = source5
//               .Where(t => t.Name != null)
//               .GroupBy(t => t.ID)
//               .Select(t => t.OrderByDescending(b => b.Name).FirstOrDefault())
//               .ToList();

//            //序列化
//            byte[] data5 = Serialize(source5);
//            Console.WriteLine($"序列化后byte大小：{data5.Length}");

//            //反序列化
//            List<Student3> result5 = Deserialize<List<Student3>>(data5);
//            string resultStr5 = MessagePackSerializer.ToJson(data5);

//            Console.WriteLine("结果显示:");
//            foreach (var item in result5)
//            {
//                Console.WriteLine($"{item.ID}\t{item.Name}");
//            }

//            Console.WriteLine();

//            Console.WriteLine("性能测试：");
//            List<Student2> testList5 = GetTestData2(testTotal);

//            stopwatch.Restart();
//            stopwatch.Start();
//            byte[] testByte5 = Serialize(testList5);
//            stopwatch.Stop();
//            Console.WriteLine($"序列化{testTotal}条,耗时:{stopwatch.ElapsedMilliseconds.ToString("N0")}ms,大小:{IntTo1024(testByte5.Length)}");

//            stopwatch.Restart();
//            stopwatch.Start();
//            Deserialize<dynamic>(testByte5);
//            stopwatch.Stop();
//            Console.WriteLine($"反序列化{testTotal}条,耗时:{stopwatch.ElapsedMilliseconds.ToString("N0")}ms");
//            Console.WriteLine("-----------END--------------");

//            #endregion 第五组测试-StringKey-To-NonAttribute

//            //最老的方式
//            //IFormatter formatter = new BinaryFormatter();
//            //MemoryStream stream = new MemoryStream();
//            //formatter.Serialize(stream, msgStatusList);
//            //var testBytes= stream.ToArray();

//            //List<Student3> result = DeSerializableMsgPack<List<Student3>>(data);

//            ////动态类型-1
//            ////会报错 说没有这个类型的解析器
//            ////
//            //dynamic obj2 = new ExpandoObject();
//            //obj2.ID = 5;
//            //var data2 = SerializableMsgPack(obj2);
//            //dynamic result2 = DeSerializableMsgPack<dynamic>(data2);

//            ////动态类型-2
//            //Student3 obj3 = new Student3() { ID = 5 };
//            //var data3 = SerializableMsgPack<Student3>(obj3);
//            //dynamic result3 = DeSerializableMsgPack<dynamic>(data3);

//            Console.WriteLine();
//            Console.WriteLine("验证结束");
//            Console.ReadLine();
//        }

//        public static void StartupSerializable()
//        {
//            CompositeResolver.RegisterAndSetAsDefault(
//                //Builtin原语和标准类解析器。它包括原始（int，bool，string ...）和可空，数组和列表。和一些额外的内置类型（Guid，Uri，BigInteger等......）。
//                BuiltinResolver.Instance,
//                //合成的解析器。它按以下顺序解析builtin -> attribute -> dynamic enum -> dynamic generic -> dynamic union -> dynamic object -> dynamic object fallback。这是MessagePackSerializer的默认值。
//                StandardResolver.Instance,
//                //所有类和结构的解析器。它不需要MessagePackObjectAttribute和序列化键作为字符串（与标记为[MessagePackObject（true）]相同）。
//                DynamicContractlessObjectResolver.Instance
//           //枚举的解析器和可空的。它使用反射调用来解析第一次可以为空。
//           // DynamicEnumAsStringResolver.Instance
//           );
//        }

//        public static byte[] Serialize<T>(T data)
//        {
//            return MessagePackSerializer.Serialize<T>(data, CompositeResolver.Instance);
//        }

//        public static T Deserialize<T>(byte[] data)
//        {
//            return MessagePackSerializer.Deserialize<T>(data, CompositeResolver.Instance);
//        }

//        public static byte[] SerializeDefault<T>(T data)
//        {
//            IFormatter formatter = new BinaryFormatter();
//            MemoryStream stream = new MemoryStream();

//            //序列化
//            formatter.Serialize(stream, data);
//            return stream.ToArray();
//        }

//        private static T DeserializeDefault<T>(byte[] param)
//        {
//            using (MemoryStream ms = new MemoryStream(param))
//            {
//                IFormatter br = new BinaryFormatter();
//                return (T)br.Deserialize(ms);
//            }
//        }

//        public static List<Student> GetTestData(int count)
//        {
//            List<Student> result = new List<Student>();

//            Random random = new Random();
//            for (int i = 0 ; i < count ; i++)
//            {
//                Student temp = new Student()
//                {
//                    ID = random.Next(count),
//                    Name = GetRandomString(random.Next(64))
//                };
//                result.Add(temp);
//            }

//            return result;
//        }

//        public static List<Student2> GetTestData2(int count)
//        {
//            List<Student2> result = new List<Student2>();

//            Random random = new Random();
//            for (int i = 0 ; i < count ; i++)
//            {
//                Student2 temp = new Student2()
//                {
//                    ID = random.Next(count),
//                    Name = GetRandomString(random.Next(64))
//                };
//                result.Add(temp);
//            }

//            return result;
//        }

//        public static List<Student3> GetTestData3(int count)
//        {
//            List<Student3> result = new List<Student3>();

//            Random random = new Random();
//            for (int i = 0 ; i < count ; i++)
//            {
//                Student3 temp = new Student3()
//                {
//                    ID = random.Next(count),
//                    Name = GetRandomString(random.Next(64))
//                };
//                result.Add(temp);
//            }

//            return result;
//        }

//        private static char[] constant = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

//        /// <summary>
//        /// 生成0-z的随机字符串
//        /// </summary>
//        /// <param name="length">字符串长度</param>
//        /// <returns>随机字符串</returns>
//        public static string GetRandomString(int length)
//        {
//            string checkCode = String.Empty;
//            Random rd = new Random();
//            for (int i = 0 ; i < length ; i++)
//            {
//                checkCode += constant[rd.Next(36)].ToString();
//            }
//            return checkCode;
//        }

//        public static string IntTo1024(int num)
//        {
//            int m1 = 1024 * 1024;//1M
//            int k1 = 1024;//1K

//            int m = num / m1;

//            int k = (num - m * m1) / 1024;

//            int size = (num - m * m1 - k * k1) % 1024;

//            return $"{m}M {k}k {size}byte";
//        }

//        //[MessagePackObject]
//        [Serializable]
//        public class Student
//        {
//            [Key(0)]
//            public int ID { get; set; }

//            [Key(1)]
//            public string Name { get; set; }
//        }

//        //[MessagePackObject]
//        [Serializable]
//        public class Student2
//        {
//            [Key(nameof(ID))]
//            public int ID { get; set; }

//            [Key(nameof(Name))]
//            public string Name { get; set; }
//        }

//        //[MessagePackObject(keyAsPropertyName: true)]
//        // [Serializable]
//        public sealed class Student3
//        {
//            public int ID { get; set; }

//            public string Name { get; set; }
//            public int Age { get; set; }
//        }
//    }
//}