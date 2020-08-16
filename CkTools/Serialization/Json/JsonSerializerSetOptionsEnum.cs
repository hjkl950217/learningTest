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
            ISerializer serializer = option switch
            {
                JsonSerializerSetOptionsEnum.Newtonsoft => new Json_NewtonsoftSerializer(),
                JsonSerializerSetOptionsEnum.SystemText => throw new System.NotSupportedException(),
                JsonSerializerSetOptionsEnum.ServiceStack => new Json_ServiceStackSerializer(),
                _ => new Json_NewtonsoftSerializer()
            };

            SerializerFactory.Instance.Register(ContentTypeEnum.Json, serializer);
        }
    }
}