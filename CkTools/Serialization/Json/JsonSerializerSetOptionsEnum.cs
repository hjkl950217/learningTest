using CkTools.ConstAndEnum;
using CkTools.Serializer.Abstraction;

namespace CkTools.Serializer
{
    public enum JsonSerializerSetOptionsEnum
    {
        Newtonsoft,
        SystemText,
        ServiceStack
    }

    public static class SerializationGlobalOptions
    {
        public static void ChangeJsonSerializerTo(JsonSerializerSetOptionsEnum option = JsonSerializerSetOptionsEnum.Newtonsoft)
        {
            ISerializer serializer = null;
            switch (option)
            {
                case JsonSerializerSetOptionsEnum.Newtonsoft:
                    serializer = new Json_NewtonsoftSerializer();
                    break;

                case JsonSerializerSetOptionsEnum.SystemText:
                    // serializer = new SystemTextJsonContentSerializer();
                    throw new System.NotSupportedException();

                case JsonSerializerSetOptionsEnum.ServiceStack:
                    serializer = new Json_ServiceStackSerializer();
                    break;

                default:
                    break;
            }

            SerializerFactory.Instance.Register(ContentTypeEnum.Json, serializer);
        }
    }
}