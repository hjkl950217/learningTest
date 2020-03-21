using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Formatting = Newtonsoft.Json.Formatting;

namespace Verification.Core.ConstAndEnum
{
    /// <summary>
    /// json序列化设置的设置常量
    /// </summary>
    public static class JsonSerializerSettingConst
    {
        /// <summary>
        /// 默认json序列化设置<para></para>
        /// 包括空值、缩进，所以更适合调试、开发。
        /// </summary>
        public static readonly JsonSerializerSettings DefaultSetting = GetDefaultSetting();

        /// <summary>
        /// json序列化设置,用于存储。<para></para>
        /// 不包括空值、缩进，所以更适合存储、传输。
        /// </summary>
        public static readonly JsonSerializerSettings StorageSetting = GetSettingForStorage();

        /// <summary>
        /// 获取默认json序列化设置，每次获取引用不同。<para></para>
        /// 包括空值、缩进，所以更适合调试、开发。
        /// </summary>
        /// <returns></returns>
        public static JsonSerializerSettings GetDefaultSetting()
        {
            return new JsonSerializerSettings()
            {
                NullValueHandling = NullValueHandling.Include,//包括空值
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore,//忽略循环引用
                Formatting = Formatting.Indented,//设置缩进
                Converters = new List<JsonConverter>()
                {
                    new IsoDateTimeConverter(){ DateTimeFormat=DateTimeFormatConst.Standard },//时间格式转换器
                    new StringEnumConverter(),//枚举序列化时采用更string而不使用值类型
                }
            };
        }

        /// <summary>
        /// 获取用存储、传输的Json对象，每次获取引用不同。<para></para>
        /// 不包括空值、缩进，所以更适合存储、传输。
        /// </summary>
        /// <returns></returns>
        public static JsonSerializerSettings GetSettingForStorage()
        {
            return new JsonSerializerSettings()
            {
                NullValueHandling = NullValueHandling.Ignore,//不包括空值
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore,//忽略循环引用
                Formatting = Formatting.None,//设置不缩进
                Converters = new List<JsonConverter>()
                {
                    new IsoDateTimeConverter(){ DateTimeFormat=DateTimeFormatConst.Standard },//时间格式转换器
                    new StringEnumConverter(),//枚举序列化时采用更string而不使用值类型
                }
            };
        }
    }
}