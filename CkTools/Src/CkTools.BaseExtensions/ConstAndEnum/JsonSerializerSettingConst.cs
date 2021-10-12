using System.Collections.Generic;
using CkTools.Abstraction.ConstAndEnum;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;

namespace CkTools.BaseExtensions.ConstAndEnum
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
        public static readonly JsonSerializerSettings DefaultSetting = SetOrCreateDefaultSetting();

        /// <summary>
        /// json序列化设置,用于存储。<para></para>
        /// 不包括空值、缩进，所以更适合存储、传输。
        /// </summary>
        public static readonly JsonSerializerSettings StorageSetting = SetOrCreateSettingForStorage();

        /// <summary>
        /// 获取默认json序列化设置，每次获取引用不同。<para></para>
        /// 包括空值、缩进，所以更适合调试、开发。
        /// </summary>
        /// <param name="settings">json配置对象</param>
        /// <returns></returns>
        public static JsonSerializerSettings SetOrCreateDefaultSetting(JsonSerializerSettings settings = null)
        {
            settings ??= new JsonSerializerSettings();

            settings.NullValueHandling = NullValueHandling.Include;//忽略空值
            settings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;//忽略循环引用
            settings.Formatting = Formatting.Indented;//设置缩进

            settings.ContractResolver = new DefaultContractResolver();//默认为大驼峰
            // settings.ContractResolver = new CamelCasePropertyNamesContractResolver();//小驼峰
            settings.DateFormatString = DateTimeFormatConst.CHN;

            settings.Converters ??= new List<JsonConverter>();
            //settings.Converters.Add(new IsoDateTimeConverter());//时间格式转换器  (ISO的会带上T 目前不使用ISO标准的)
            settings.Converters = new List<JsonConverter>()
            {
                new IsoDateTimeConverter(){ DateTimeFormat=DateTimeFormatConst.Standard },//时间格式转换器
                new StringEnumConverter(),//枚举序列化时采用更string而不使用值类型
            };

            return settings;
        }

        /// <summary>
        /// 获取用存储、传输的Json对象，每次获取引用不同。<para></para>
        /// 不包括空值、缩进，所以更适合存储、传输。
        /// </summary>
        /// <param name="settings">json配置对象</param>
        /// <returns></returns>
        public static JsonSerializerSettings SetOrCreateSettingForStorage(JsonSerializerSettings? settings = null)
        {
            settings ??= SetOrCreateDefaultSetting(settings);

            settings.NullValueHandling = NullValueHandling.Ignore;//忽略空值
            settings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;//忽略循环引用
            settings.Formatting = Formatting.None;//设置缩进

            settings.Converters = new List<JsonConverter>()
            {
                new IsoDateTimeConverter(){ DateTimeFormat=DateTimeFormatConst.Standard },//时间格式转换器
                new StringEnumConverter(),//枚举序列化时采用更string而不使用值类型
            };

            return settings;
        }
    }
}