using System.IO;
using CkTools.ConstAndEnum;
using CkTools.Serializer.Abstraction;

namespace CkTools.Serializer
{
    public static class SerializationExtensions
    {
        public static T Deserialize<T>(this ISerializerFactory factory, Stream stream, ContentTypeEnum contentType, object? options = null)
        {
            return factory.GetSerializerByType(contentType)
                .DeserializeFromStream<T>(stream, options);
        }

        public static T Deserialize<T>(this Stream stream, ContentTypeEnum contentType, object? options = null)
        {
            return SerializerFactory.Instance.Deserialize<T>(stream, contentType, options);
        }

        public static T DeserializeFromJson<T>(this ISerializerFactory factory, Stream stream, object? options = null)
        {
            return Deserialize<T>(factory, stream, ContentTypeEnum.Json, options);
        }

        public static T DeserializeFromJson<T>(this Stream stream, object? options = null)
        {
            return Deserialize<T>(stream, ContentTypeEnum.Json, options);
        }

        public static T DeserializeFromXml<T>(this ISerializerFactory factory, Stream stream, object? options = null)
        {
            return Deserialize<T>(factory, stream, ContentTypeEnum.Xml, options);
        }

        public static T DeserializeFromXml<T>(this Stream stream, object? options = null)
        {
            return Deserialize<T>(stream, ContentTypeEnum.Xml, options);
        }

        public static T Deserialize<T>(this ISerializerFactory factory, string data, ContentTypeEnum contentType, object? options = null)
        {
            return factory.GetSerializerByType(contentType).DeserializeFromString<T>(data, options);
        }

        public static T Deserialize<T>(this string data, ContentTypeEnum contentType, object? options = null)
        {
            return SerializerFactory.Instance.GetSerializerByType(contentType).DeserializeFromString<T>(data, options);
        }

        public static T DeserializeFromJson<T>(this ISerializerFactory factory, string data, object? options = null)
        {
            return Deserialize<T>(factory, data, ContentTypeEnum.Json, options);
        }

        public static T DeserializeFromJson<T>(this string data, object? options = null)
        {
            return Deserialize<T>(data, ContentTypeEnum.Json, options);
        }

        public static T DeserializeFromXml<T>(this ISerializerFactory factory, string data, object? options = null)
        {
            return Deserialize<T>(factory, data, ContentTypeEnum.Xml, options);
        }

        public static T DeserializeFromXml<T>(this string data, object? options = null)
        {
            return Deserialize<T>(data, ContentTypeEnum.Xml, options);
        }

        public static string SerializeToString(this object obj, ContentTypeEnum contentType, object? options = null)
        {
            return SerializerFactory.Instance.SerializeToString(obj, contentType, options);
        }

        public static string SerializeToString(this ISerializerFactory factory, object obj, ContentTypeEnum contentType, object? options = null)
        {
            return factory.GetSerializerByType(contentType).SerializeToString(obj, options);
        }

        public static string SerializeToJsonString(this object obj, object? options = null)
        {
            return SerializeToString(obj, ContentTypeEnum.Json, options);
        }

        public static string SerializeToJsonString(this ISerializerFactory factory, object obj, object? options = null)
        {
            return SerializeToString(factory, obj, ContentTypeEnum.Json, options);
        }

        public static string SerializeToXmlString(this object obj, object? options = null)
        {
            return SerializeToString(obj, ContentTypeEnum.Xml, options);
        }

        public static string SerializeToXmlString(this ISerializerFactory factory, object obj, object? options = null)
        {
            return SerializeToString(factory, obj, ContentTypeEnum.Xml, options);
        }

        public static Stream SerializeToStream(this ISerializerFactory factory, object obj, ContentTypeEnum contentType, Stream stream = null, object? options = null)
        {
            if (stream == null)
            {
                stream = new MemoryStream();
            }

            factory.GetSerializerByType(contentType).SerializeToStream(obj, stream, options);
            return stream;
        }

        public static Stream SerializeToStream(this object obj, ContentTypeEnum contentType, Stream stream = null, object? options = null)
        {
            return SerializerFactory.Instance.SerializeToStream(obj, contentType, stream, options);
        }

        public static Stream SerializeToJsonStream(this ISerializerFactory factory, object obj, Stream stream = null, object? options = null)
        {
            return SerializeToStream(factory, obj, ContentTypeEnum.Json, stream, options);
        }

        public static Stream SerializeToJsonStream(this object obj, Stream stream = null, object? options = null)
        {
            return SerializeToStream(obj, ContentTypeEnum.Json, stream, options);
        }

        public static Stream SerializeToXmlStream(this ISerializerFactory factory, object obj, object? options = null)
        {
            return SerializeToStream(factory, obj, ContentTypeEnum.Xml, null, options);
        }

        public static Stream SerializeToXmlStream(this object obj, Stream stream = null, object? options = null)
        {
            return SerializeToStream(obj, ContentTypeEnum.Xml, stream, options);
        }
    }
}