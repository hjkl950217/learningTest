using CkTools.BaseExtensions.ConstAndEnum;
using Newtonsoft.Json;

namespace System
{
    public static class ObjectExtensions
    {
        #region Tojson

        //针对某些时候引用了库却没有引用json.net的情况
        public static string ToJsonExt<T>(this T obj)
        {
            return obj.ToJsonExt(null);
        }

        /// <summary>
        ///  转换成json(利于查看调试的格式设置)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        ///  <param name="setting"></param>
        /// <returns>  </returns>
        public static string ToJsonExt<T>(this T obj, JsonSerializerSettings? setting = null)
        {
            if (obj == null)
                return string.Empty;

            //序列化并返回
            setting ??= JsonSerializerSettingConst.DefaultSetting;
            return JsonConvert.SerializeObject(obj, setting);
        }

        /// <summary>
        ///  转换成json(利于查看调试的格式设置)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        ///  <param name="configAction"></param>
        /// <returns>  </returns>
        public static string ToJsonExt<T>(this T obj, Action<JsonSerializerSettings> configAction)
            where T : class
        {
            if (obj == null)
                return string.Empty;

            //序列化并返回
            JsonSerializerSettings settings = JsonSerializerSettingConst.SetOrCreateDefaultSetting();
            configAction?.Invoke(settings);

            return ToJsonExt<T>(obj, settings);
        }

        /// <summary>
        /// 使用指定类型序列化成json字符串(利于查看调试的格式设置)
        /// <para>如果属性名对不上 不会报错。规则参考json与实体的转换规则</para>
        /// </summary>
        /// <param name="obj"> </param>
        /// <param name="type">指定类型</param>
        /// <returns>Json format string</returns>
        public static string ToJsonExt(this object obj, Type type)
        {
            if (obj == null)
                return string.Empty;

            //利用 转成json字符串又转回成对象的方式   替换掉对象中的类型信息
            object? tempObj = JsonConvert.DeserializeObject(
                  obj.ToJsonExt(),
                  type,
                  JsonSerializerSettingConst.DefaultSetting);

            //序列化并返回
            return JsonConvert.SerializeObject(tempObj, JsonSerializerSettingConst.DefaultSetting);
        }

        /// <summary>
        /// 获取json字符串，默认使用<see cref="JsonSerializerSettingConst.StorageSetting"/>设置来序列化
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        public static string ToJsonStorageExt<T>(this T obj, JsonSerializerSettings? settings = null)
            where T : class
        {
            if (obj == null)
                return string.Empty;

            return JsonConvert.SerializeObject(obj, settings ?? JsonSerializerSettingConst.StorageSetting);
        }

        /// <summary>
        /// 转换成json(利于存储的格式设置)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <param name="configAction"></param>
        /// <returns></returns>
        public static string ToJsonStorageExt<T>(this T obj, Action<JsonSerializerSettings> configAction)
            where T : class
        {
            if (obj == null)
                return string.Empty;

            JsonSerializerSettings settings = JsonSerializerSettingConst.SetOrCreateSettingForStorage();
            configAction?.Invoke(settings);

            return ToJsonExt<T>(obj, settings);
        }

        /// <summary>
        /// 使用指定类型转换成json(利于存储的格式设置)
        /// <para>如果属性名对不上 不会报错。规则参考json与实体的转换规则</para>
        /// </summary>
        /// <param name="obj"> </param>
        /// <param name="type">指定类型</param>
        /// <returns>Json format string</returns>
        public static string ToJsonStorageExt(this object obj, Type type)
        {
            if (obj == null)
                return string.Empty;

            //利用 转成json字符串又转回成对象的方式   替换掉对象中的类型信息
            object? tempObj = JsonConvert.DeserializeObject(
                  obj.ToJsonExt(),
                  type,
                  JsonSerializerSettingConst.StorageSetting);

            //序列化并返回
            return JsonConvert.SerializeObject(tempObj, JsonSerializerSettingConst.StorageSetting);
        }

        #endregion Tojson

        public static T? DeepCopy<T>(this T obj)
            where T : class
        {
            string outPut = obj.ToJsonExt();
            return outPut.ToObjectExt<T>();
        }
    }
}