using CkTools.ConstAndEnum;

namespace CkTools.Serializer.Abstraction
{
    public interface ISerializerFactory
    {
        ISerializer GetSerializerByType(ContentTypeEnum contentType);

        bool TryGet(ContentTypeEnum contentType, out ISerializer serializer);

        void Register(ContentTypeEnum contentType, ISerializer serializer);
    }
}