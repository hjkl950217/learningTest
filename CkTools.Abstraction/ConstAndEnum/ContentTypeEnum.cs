using System.ComponentModel;

namespace CkTools.Abstraction.ConstAndEnum
{
    public enum ContentTypeEnum
    {
        [Description("application/xml")]
        Xml,

        [Description("application/json")]
        Json,

        [Description("application/jsv")]
        Jsv,

        [Description("multipart/form-data")]
        FormData,

        [Description("application/octet-stream")]
        OctetStream,

        [Description("application/x-www-form-urlencoded")]
        FormUrlEncoded
    }
}