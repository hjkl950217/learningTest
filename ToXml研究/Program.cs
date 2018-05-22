using ServiceStack;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Xml.Serialization;

namespace ToXml研究
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("程序开始");

            TestModel model = new TestModel()
            {
                Name = "A",
                NameList = new List<string>() { "AAAA", "BBBB" },
                DictList = new Dictionary<string, string>() { { "A1", "B1" } }
                // Num = 50
            };

            int xmlNum = 4*10000 ;
            Stopwatch sp = new Stopwatch();
            sp.Start();
            for(int i = 0 ; i < xmlNum ; i++)
            {
                string xmlStr1 = model.ToXml();
            }
            sp.Stop();
            Console.WriteLine($"ServiceStack-ToXml:{sp.ElapsedMilliseconds}");

            sp.Restart();
            for(int i = 0 ; i < xmlNum ; i++)
            {
                string xmlStr2 = Serialize(model);
            }
            sp.Stop();
            Console.WriteLine($"XmlSerializer-ToXml:{sp.ElapsedMilliseconds}");

            sp.Restart();
            for(int i = 0 ; i < xmlNum ; i++)
            {
                string xmlStr3 = model.ToXml();
            }
            sp.Stop();
            Console.WriteLine($"手写-ToXml:{sp.ElapsedMilliseconds}");


            Console.ReadLine();
        }

        public static string Serialize<T>(T dataToSerialize)
        {
            try
            {
                var stringwriter = new System.IO.StringWriter();
                var serializer = new XmlSerializer(typeof(T));
                serializer.Serialize(stringwriter, dataToSerialize);
                return stringwriter.ToString();
            }
            catch
            {
                throw;
            }
        }
    }
}