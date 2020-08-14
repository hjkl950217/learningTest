using System;
using System.Collections.Generic;
using CkTools.ConstAndEnum;
using CkTools.Serializer.Abstraction;

namespace CkTools.Serializer
{
    public class SerializerFactory : ISerializerFactory
    {
        private static readonly Dictionary<ContentTypeEnum, ISerializer> serializerList =
            new Dictionary<ContentTypeEnum, ISerializer>()
            {
                //{ ContentTypes.Json.ToLower(), new SystemTextJsonContentSerializer()},
                { ContentTypeEnum.Json, new Json_NewtonsoftSerializer()},
                { ContentTypeEnum.Xml, new Xml_System_Serializer()},
            };

        public static readonly ISerializerFactory Instance = new SerializerFactory();

        public ISerializer GetSerializerByType(ContentTypeEnum contentType)
        {
            if (!serializerList.ContainsKey(contentType))
            {
                throw new InvalidOperationException(
                    string.Format("Unsupported content type {0} specified.", contentType));
            }

            return serializerList[contentType];
        }

        public bool TryGet(ContentTypeEnum contentType, out ISerializer serializer)
        {
            return serializerList.TryGetValue(contentType, out serializer);
        }

        public void Register(ContentTypeEnum contentType, ISerializer serializer)
        {
            serializer.CheckNullWithException(nameof(serializer));
            serializerList.AddOrUpdate(contentType, serializer);
        }
    }
}