using System.IO;
using System.Text;
using Newtonsoft.Json;
using CkTools.Serializer.Abstraction;

namespace CkTools.Serializer
{
    public class Json_NewtonsoftSerializer : ISerializer
    {
        public T DeserializeFromBytes<T>(byte[] content, object? options = null)
        {
            string tempStr = Encoding.UTF8.GetString(content);
            return this.DeserializeFromString<T>(tempStr, options);
        }

        public T DeserializeFromStream<T>(Stream stream, object? options = null)
        {
            var reader = new StreamReader(stream);
            T result;
            bool isString = typeof(T) == typeof(string);

            if (isString)
            {
                result = (T)(object)reader.ReadToEnd();
            }
            else
            {
                JsonSerializer jsonSerializer = JsonSerializer.CreateDefault();
                var jsonReader = new JsonTextReader(reader);
                result = jsonSerializer.Deserialize<T>(jsonReader);
            }
            return result;
        }

        public T DeserializeFromString<T>(string content, object? options = null)
        {
            return JsonConvert.DeserializeObject<T>(content);
        }

        public byte[] SerializeToBytes<T>(T request, object? options = null)
        {
            string tempStr = this.SerializeToString(request, options);
            return Encoding.UTF8.GetBytes(tempStr);
        }

        public void SerializeToStream(object request, Stream stream, object? options = null)
        {
            var writer = new StreamWriter(stream);
            writer.Write(this.SerializeToString(request));
            writer.Flush();
        }

        public string SerializeToString(object request, object? options = null)
        {
            return JsonConvert.SerializeObject(request);
        }
    }
}