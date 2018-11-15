using MessagePack;
using MessagePack.Resolvers;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace 技术点验证
{
    public class MsgSerializer
    {
        public const string SerializerName = "MsgSerializer";

        //防止Msg的序列化器会被多次调用
        private static bool IsSetup = false;

        /// <summary>
        /// 注册Msg的序列化器-启动时调用一次即可
        /// </summary>
        public static void InitializeMsgPackSerializer()
        {
            if (MsgSerializer.IsSetup == true) { return; }

            CompositeResolver.RegisterAndSetAsDefault(
                //Builtin原语和标准类解析器。它包括原始（int，bool，string ...）和可空，数组和列表。和一些额外的内置类型（Guid，Uri，BigInteger等......）。
                BuiltinResolver.Instance,
                //合成的解析器。它按以下顺序解析builtin -> attribute -> dynamic enum -> dynamic generic -> dynamic union -> dynamic object -> dynamic object fallback。这是MessagePackSerializer的默认值。
                StandardResolver.Instance,
                //所有类和结构的解析器。它不需要MessagePackObjectAttribute和序列化键作为字符串（与标记为[MessagePackObject（true）]相同）。
                DynamicContractlessObjectResolver.Instance
           //枚举的解析器和可空的。它使用反射调用来解析第一次可以为空。
           // DynamicEnumAsStringResolver.Instance
           );


            MsgSerializer.IsSetup = true;
        }

        public static byte[] Serialize<T>(T data)
        {
            return MessagePackSerializer.Serialize<T>(data, CompositeResolver.Instance);
        }

        public static T Deserialize<T>(byte[] data)
        {
            return MessagePackSerializer.Deserialize<T>(data, CompositeResolver.Instance);
        }

        public static byte[] SerializeDefault<T>(T obj)
        {
            IFormatter formatter = new BinaryFormatter();
            MemoryStream stream = new MemoryStream();

            //序列化
            formatter.Serialize(stream, obj);
            return stream.ToArray();
        }

        public static T DeserializeDefault<T>(byte[] arrBytes) where T : class
        {
            using (MemoryStream ms = new MemoryStream(arrBytes))
            {
                IFormatter br = new BinaryFormatter();
                return (T)br.Deserialize(ms);
            }
        }


        public static string SerializeJson<T>(T data)
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(data);
        }

        public static T DeserializeJson<T>(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(data);
        }

    }
}