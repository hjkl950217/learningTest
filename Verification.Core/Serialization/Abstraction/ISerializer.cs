using System.IO;

namespace Verification.Core.Serializer.Abstraction
{
    public interface ISerializer
    {
        string SerializeToString(object request, object? options = null);

        void SerializeToStream(object request, Stream stream, object? options = null);

        byte[] SerializeToBytes<T>(T request, object? options = null);

        T DeserializeFromStream<T>(Stream stream, object? options = null);

        T DeserializeFromString<T>(string content, object? options = null);

        T DeserializeFromBytes<T>(byte[] content, object? options = null);
    }
}