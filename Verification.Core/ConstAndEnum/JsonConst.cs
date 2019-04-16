using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Text;

namespace Verification.Core.ConstAndEnum
{
   public static class JsonConst
    {
        /// <summary>
        /// 默认的json序列化配置
        /// </summary>
        public static JsonSerializerSettings DefaultSettings = new JsonSerializerSettings()
        {
            Formatting = Formatting.Indented,//设置缩进
            ReferenceLoopHandling = ReferenceLoopHandling.Ignore,//忽略循环引用
            NullValueHandling = NullValueHandling.Include,//包括空值
            Converters = new List<JsonConverter>()
            {
                new IsoDateTimeConverter(){ DateTimeFormat=DateTimeFormatConst.Standard },//时间格式转换器
                new StringEnumConverter(),//枚举序列化时采用更string而不使用值类型
            }
        };
    }
}
