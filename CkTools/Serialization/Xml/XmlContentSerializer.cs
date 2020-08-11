using System;
using System.Collections.Concurrent;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using CkTools.Serializer.Abstraction;

namespace CkTools.Serializer
{
    public class Xml_System_Serializer : ISerializer
    {
        public static readonly XmlWriterSettings GobalXmlWriterSettings = new XmlWriterSettings();

        private readonly ConcurrentDictionary<Type, XmlSerializer> _serializerPool =
            new ConcurrentDictionary<Type, XmlSerializer>();

        private readonly XmlWriterSettings writerSettings;

        public Xml_System_Serializer(XmlWriterSettings writerSettings)
        {
            this.writerSettings = writerSettings;
        }

        public Xml_System_Serializer() : this(GobalXmlWriterSettings)
        {
        }

        private XmlSerializer GetXmlSerializer(Type type)
        {
            return _serializerPool.GetOrAdd(type,
                t => new XmlSerializer(t, string.Empty)
                );
        }

        private XmlContentSerializerOptions GetXmlOptions(object options)
        {
            if (!(options is XmlContentSerializerOptions option))
            {
                option = new XmlContentSerializerOptions();
            }
            if (option.Namespaces == null)
            {
                var xmlnamespace = new XmlSerializerNamespaces();
                xmlnamespace.Add(string.Empty, string.Empty);
                option.Namespaces = xmlnamespace;
            }
            if (option.WriterSettings == null)
            {
                option.WriterSettings = options as XmlWriterSettings ?? writerSettings;
            }

            return option;
        }

        public T DeserializeFromStream<T>(Stream stream, object? options = null)
        {
            var serializer = GetXmlSerializer(typeof(T));
            return (T)serializer.Deserialize(stream);
        }

        public T DeserializeFromString<T>(string content, object? options = null)
        {
            var serializer = GetXmlSerializer(typeof(T));
            using (TextReader reader = new StringReader(content))
            {
                return (T)serializer.Deserialize(reader);
            }
        }

        public void SerializeToStream(object request, Stream stream, object? options = null)
        {
            if (request == null)
            {
                throw new ArgumentNullException("request");
            }
            XmlContentSerializerOptions option = GetXmlOptions(options);

            var writer = XmlWriter.Create(stream, option.WriterSettings);
            GetXmlSerializer(request.GetType()).Serialize(writer, request, option.Namespaces);
        }

        public string SerializeToString(object request, object? options = null)
        {
            using (var stream = new MemoryStream())
            {
                SerializeToStream(request, stream, options);
                stream.Seek(0, SeekOrigin.Begin);
                var reader = new StreamReader(stream, Encoding.UTF8);
                return reader.ReadToEnd();
            }
        }

        public byte[] SerializeToBytes<T>(T request, object? options = null)
        {
            string tempStr = this.SerializeToString(request, options);
            return Encoding.UTF8.GetBytes(tempStr);
        }

        public T DeserializeFromBytes<T>(byte[] content, object? options = null)
        {
            string tempStr = Encoding.UTF8.GetString(content);
            return this.DeserializeFromString<T>(tempStr, options);
        }
    }
}