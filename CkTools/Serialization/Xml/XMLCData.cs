using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace CkTools.Serializer
{
    public class XMLCData : IXmlSerializable
    {
        public XMLCData()
        {
        }

        public XMLCData(string value)
        {
            Value = value;
        }

        [XmlIgnore]
        public string Value { get; set; }

        public XmlSchema GetSchema()
        {
            return new XmlSchema() { };
        }

        public void ReadXml(XmlReader reader)
        {
            Value = reader.ReadElementContentAsString();
        }

        public void WriteXml(XmlWriter writer)
        {
            writer.WriteCData(Value);
        }

        public static implicit operator string(XMLCData values)
        {
            return values?.Value;
        }

        public static implicit operator XMLCData(string values)
        {
            return new XMLCData() { Value = values };
        }

        public static bool operator ==(XMLCData left, XMLCData right)
        {
            return left?.Value == right?.Value;
        }

        public static bool operator !=(XMLCData left, XMLCData right)
        {
            return !(left == right);
        }

        public static bool operator ==(XMLCData left, string right)
        {
            return left?.Value == right;
        }

        public static bool operator ==(string left, XMLCData right)
        {
            return left == right?.Value;
        }

        public static bool operator !=(XMLCData left, string right)
        {
            return !(left == right);
        }

        public static bool operator !=(string left, XMLCData right)
        {
            return !(left == right);
        }

        public override bool Equals(object obj)
        {
            if (obj is string str)
            {
                return this.Value == str;
            }
            else if (obj is XMLCData cdata)
            {
                return this == cdata;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }

        public override string ToString()
        {
            return Value?.ToString();
        }
    }
}