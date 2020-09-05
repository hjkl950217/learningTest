using System;
using System.Collections.Concurrent;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace CkTools.BaseExtensions.Serialization
{
    public class Xml_System_Serializer
    {
        public static readonly XmlWriterSettings GobalXmlWriterSettings = new XmlWriterSettings();

        private readonly ConcurrentDictionary<Type, XmlSerializer> _serializerPool =
            new ConcurrentDictionary<Type, XmlSerializer>();

        private readonly XmlWriterSettings writerSettings;

        public Xml_System_Serializer() : this(GobalXmlWriterSettings)
        {
        }

        public Xml_System_Serializer(XmlWriterSettings writerSettings)
        {
            this.writerSettings = writerSettings;
        }



        private XmlSerializer GetXmlSerializer(Type type)
        {
            return this._serializerPool.GetOrAdd(type,
                t => new XmlSerializer(t, string.Empty)
                );
        }





        public void SerializeToStream(object request, Stream stream, object? options = null)
        {
            request.CheckNullWithException(nameof(request));


            XmlWriterSettings? writerSetting = this.writerSettings;

            XmlWriter writer = XmlWriter.Create(stream, writerSetting);
            XmlSerializer aaa = this.GetXmlSerializer(request.GetType());



            aaa.Serialize(writer, request, new XmlSerializerNamespaces());
        }

        public string SerializeToString(object? request, object? options = null)
        {
            if (request == null)
            {
                return string.Empty;
            }

            using MemoryStream? stream = new MemoryStream();
            this.SerializeToStream(request, stream, options);
            stream.Seek(0, SeekOrigin.Begin);
            StreamReader? reader = new StreamReader(stream, Encoding.UTF8);
            return reader.ReadToEnd();
        }


    }
}