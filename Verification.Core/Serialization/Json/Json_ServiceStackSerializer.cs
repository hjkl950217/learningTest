using System.IO;
using System.Text;
using ServiceStack.Text;
using Verification.Core.Serializer.Abstraction;

namespace Verification.Core.Serializer
{
    public class Json_ServiceStackSerializer : ISerializer
    {
        public T DeserializeFromBytes<T>(byte[] content, object? options = null)
        {
            string tempStr = Encoding.UTF8.GetString(content);
            return this.DeserializeFromString<T>(tempStr, options);
        }

        public T DeserializeFromStream<T>(Stream stream, object? options = null)
        {
            return JsonSerializer.DeserializeFromStream<T>(stream);
        }

        public T DeserializeFromString<T>(string content, object? options = null)
        {
            return JsonSerializer.DeserializeFromString<T>(content);
        }

        public byte[] SerializeToBytes<T>(T request, object? options = null)
        {
            string tempStr = this.SerializeToString(request, options);
            return Encoding.UTF8.GetBytes(tempStr);
        }

        public void SerializeToStream(object request, Stream stream, object? options = null)
        {
            JsonSerializer.SerializeToStream(request, stream);
        }

        public string SerializeToString(object request, object? options = null)
        {
            return JsonSerializer.SerializeToString(request);
        }
    }
}