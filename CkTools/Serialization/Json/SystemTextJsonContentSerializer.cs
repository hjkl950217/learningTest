//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Text;
//using System.Text.Json;
//using CkTools.Serializer.Abstraction;

//namespace CkTools.Serializer
//{
//    public class Json_SystemTextContentSerializer : ISerializer
//    {
//        public T DeserializeFromBytes<T>(byte[] content, object? options = null)
//        {
//            return JsonSerializer.Deserialize<T>(content, options as JsonSerializerOptions);
//        }

//        public T DeserializeFromStream<T>(Stream stream, object? options = null)
//        {
//            var reader = new StreamReader(stream);
//            T result;
//            bool isString = typeof(T) == typeof(string);
//            var data = reader.ReadToEnd();

//            if (isString)
//            {
//                result = (T)(object)data;
//            }
//            else
//            {
//                result = DeserializeFromString<T>(data, options);
//            }
//            return result;
//        }

//        public T DeserializeFromString<T>(string content, object? options = null)
//        {
//            return JsonSerializer.Deserialize<T>(content, options as JsonSerializerOptions);
//        }

//        public byte[] SerializeToBytes<T>(T request, object? options = null)
//        {
//            return JsonSerializer.SerializeToUtf8Bytes(request, options as JsonSerializerOptions);
//        }

//        public void SerializeToStream(object request, Stream stream, object? options = null)
//        {
//            var bytes = SerializeToBytes(request, options);
//            stream.Write(bytes, 0, bytes.Length);
//        }

//        public string SerializeToString(object request, object? options = null)
//        {
//            return JsonSerializer.Serialize(request, options as JsonSerializerOptions);
//        }
//    }
//}