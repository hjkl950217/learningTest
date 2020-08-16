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
            return this._serializerPool.GetOrAdd(type,
                t => new XmlSerializer(t, string.Empty)
                );
        }

        private XmlContentSerializerOptions GetXmlOptions(object? options)
        {
            if (!(options is XmlContentSerializerOptions option))
            {
                option = new XmlContentSerializerOptions();
            }
            if (option.Namespaces == null)
            {
                XmlSerializerNamespaces? xmlnamespace = new XmlSerializerNamespaces();
                xmlnamespace.Add(string.Empty, string.Empty);
                option.Namespaces = xmlnamespace;
            }
            if (option.WriterSettings == null)
            {
                option.WriterSettings = options as XmlWriterSettings ?? this.writerSettings;
            }

            return option;
        }

        public T DeserializeFromStream<T>(Stream stream, object? options = null)
        {
            XmlSerializer? serializer = this.GetXmlSerializer(typeof(T));
            return (T)serializer.Deserialize(stream);
        }

        public T DeserializeFromString<T>(string content, object? options = null)
        {
            XmlSerializer? serializer = this.GetXmlSerializer(typeof(T));
            using (TextReader reader = new StringReader(content))
            {
                return (T)serializer.Deserialize(reader);
            }
        }

        public void SerializeToStream(object? request, Stream stream, object? options = null)
        {
            if (request == null)
            {
                throw new ArgumentNullException("request");
            }
            XmlContentSerializerOptions option = this.GetXmlOptions(options);

            XmlWriter? writer = XmlWriter.Create(stream, option.WriterSettings);
            this.GetXmlSerializer(request.GetType()).Serialize(writer, request, option.Namespaces);
        }

        public string SerializeToString(object? request, object? options = null)
        {
            using (MemoryStream? stream = new MemoryStream())
            {
                this.SerializeToStream(request, stream, options);
                stream.Seek(0, SeekOrigin.Begin);
                StreamReader? reader = new StreamReader(stream, Encoding.UTF8);
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