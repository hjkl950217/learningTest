using System.Xml;
using System.Xml.Serialization;

namespace Verification.Core.Serializer
{
    public class XmlContentSerializerOptions
    {
        public XmlSerializerNamespaces Namespaces { get; set; }
        public XmlWriterSettings WriterSettings { get; set; }
    }
}