using System;
using System.Diagnostics.CodeAnalysis;
using CkTools.BaseExtensions.ConstAndEnum;
using CkTools.BaseExtensions.Helper;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CkTools.BaseExtensions.BaseType
{
    /// <summary>
    /// 字符串扩展类
    /// </summary>
    public static class StringExtensions
    {
        #region 基础类型与string之间的转换

        public static long ToLong(this string str, long defaultValue = 0L)
        {
            return str.BaseConvertOrDefalut(TypeConvertDelegate.stringToLong, defaultValue);
        }

        #region TryToDateTimeOffset

        /// <summary>
        /// 标准时间格式中包含的符号(用于和long区分使用)
        /// </summary>
        private static readonly string[] timeSysmbols = new string[] { ":", "+", "T", "Z", "-", "/" };

        /// <summary>
        /// 执行转换,会判断格式
        /// <para>如果是标准格式，则调用默认方法转换<see cref="TypeConvertDelegate.stringToDateTimeOffset"/></para>
        /// <para>如果不是标准格式，则调用传递的转换<paramref name="convert"/></para>
        /// </summary>
        /// <param name="str">要转的值，支持标准ISO格式和时间戳，判断顺序:ISO>传递的委托</param>
        /// <param name="convert"></param>
        /// <returns></returns>
        private static DateTimeOffset ConvertToDateTimeOffset(
            this string str,
            Func<string, DateTimeOffset> convert)
        {
            return str switch
            {
                string a when a.IsNullOrEmpty() => throw new FormatException($"format error,value: {str}."),
                var a when a.ContainsSymbol(timeSysmbols) => str.BaseConvert(TypeConvertDelegate.stringToDateTimeOffset),
                _ => str.BaseConvert(convert)   //匹配不上则为long
            };
        }

        /// <summary>
        /// 执行转换,会判断格式
        /// <para>如果是标准格式，则调用默认方法转换<see cref="TypeConvertDelegate.stringToDateTimeOffset"/></para>
        /// <para>如果不是标准格式，则调用传递的转换<paramref name="convert"/></para>
        /// </summary>
        /// <param name="str"></param>
        /// <param name="convert"></param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        private static DateTimeOffset TryConvertToDateTimeOffset(
            this string str,
            Func<string, DateTimeOffset> convert,
            DateTimeOffset defaultValue)
        {
            return str switch
            {
                string a when a.IsNullOrEmpty() => defaultValue,
                var a when a.ContainsSymbol(timeSysmbols) => str.BaseConvertOrDefalut(TypeConvertDelegate.stringToDateTimeOffset, defaultValue),
                _ => str.BaseConvertOrDefalut(convert, defaultValue)   //匹配不上则为long
            };
        }

        #region To->原始时区

        /// <summary>
        /// 转换为<see cref="DateTimeOffset"/>
        /// <para><paramref name="str"/>示例:"2020-10-16T11:36:56+08:00" -> 2020-10-16T11:36:56+08:00</para>
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static DateTimeOffset ToDateTimeOffset(this string str)
        {
            return str.ConvertToDateTimeOffset(TypeConvertDelegate.stringToDateTimeOffset);
        }

        /// <summary>
        /// 尝试转换为<see cref="DateTimeOffset"/>,失败时返回<paramref name="defaultValue"/>
        /// <para><paramref name="str"/>示例:"2020-10-16T11:36:56+08:00" -> 2020-10-16T11:36:56+08:00</para>
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static DateTimeOffset TryToDateTimeOffset(this string str, DateTimeOffset defaultValue = default)
        {
            return str.TryConvertToDateTimeOffset(TypeConvertDelegate.stringToDateTimeOffset, defaultValue);
        }

        #endregion To->原始时区

        #region TO->UTC

        /// <summary>
        /// 按秒转换为UTC的<see cref="DateTimeOffset"/>
        /// <para><paramref name="str"/>示例:"1602819416" -> 2020-10-16T03:36:56+00:00</para>
        /// <para><paramref name="str"/>示例:"2020-10-16 03:36:56" -> 2020-10-16T03:36:56+00:00</para>
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static DateTimeOffset ToUtcDateTimeOffset(this string str)
        {
            return str.ConvertToDateTimeOffset(TypeConvertDelegate.longStringToUtcDateTimeOffset).UtcDateTime;
        }

        /// <summary>
        /// 尝试按秒转换为UTC的<see cref="DateTimeOffset"/>,失败时返回<paramref name="defaultValue"/>
        /// <para><paramref name="str"/>示例:"1602819416" -> 2020-10-16T03:36:56+00:00</para>
        /// <para><paramref name="str"/>示例:"2020-10-16 03:36:56" -> 2020-10-16T03:36:56+00:00</para>
        /// <para><paramref name="str"/>示例:"0" -> 1970-01-01T00:00:00.0000000+00:00</para>
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static DateTimeOffset TryToUtcDateTimeOffset(this string str, DateTimeOffset defaultValue = default)
        {
            return str
                .TryConvertToDateTimeOffset(TypeConvertDelegate.longStringToUtcDateTimeOffset, defaultValue)
                .UtcDateTime;
        }

        /// <summary>
        /// 按毫秒转换为UTC的<see cref="DateTimeOffset"/>
        /// <para><paramref name="str"/>示例:"1602819416123" -> 2020-10-16T03:36:56+00:00</para>
        /// <para><paramref name="str"/>示例:"2020-10-16 03:36:56" -> 2020-10-16T03:36:56+00:00</para>
        /// <para><paramref name="str"/>示例:"0" -> 1970-01-01T00:00:00.0000000+00:00</para>
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static DateTimeOffset ToUtcDateTimeOffsetByMilliseconds(this string str)
        {
            return str
                .ConvertToDateTimeOffset(TypeConvertDelegate.longStringToUtcDateTimeOffsetByMilliseconds)
                .UtcDateTime;
        }

        /// <summary>
        /// 尝试按毫秒转换为UTC的<see cref="DateTimeOffset"/>,失败时返回<paramref name="defaultValue"/>
        /// <para><paramref name="str"/>示例:"1602819416123" -> 2020-10-16T03:36:56+00:00</para>
        /// <para><paramref name="str"/>示例:"2020-10-16 03:36:56" -> 2020-10-16T03:36:56+00:00</para>
        /// <para><paramref name="str"/>示例:"0" -> 1970-01-01T00:00:00.0000000+00:00</para>
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static DateTimeOffset TryToUtcDateTimeOffsetByMilliseconds(
            this string str,
            DateTimeOffset defaultValue = default)
        {
            return str
                .TryConvertToDateTimeOffset(TypeConvertDelegate.longStringToUtcDateTimeOffsetByMilliseconds, defaultValue)
                .UtcDateTime;
        }

        #endregion TO->UTC

        #region To->Local

        /// <summary>
        /// 尝试按秒转换为本地时区的<see cref="DateTimeOffset"/>
        /// <para><paramref name="str"/>示例:"1602819416" -> 2020-10-16T11:36:56+08:00</para>
        /// <para><paramref name="str"/>示例:"2020-10-16 11:36:56" -> 2020-10-16T11:36:56+08:00</para>
        /// <para><paramref name="str"/>示例:"0" -> 1970-01-01T00:00:00.0000000+08:00</para>
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static DateTimeOffset ToLocalDateTimeOffset(this string str)
        {
            return str
                .ConvertToDateTimeOffset(TypeConvertDelegate.longStringToLocalDateTimeOffset)
                .LocalDateTime;
        }

        /// <summary>
        /// 尝试按秒转换为本地时区的<see cref="DateTimeOffset"/>,失败时返回<paramref name="defaultValue"/>
        /// <para><paramref name="str"/>示例:"1602819416" -> 2020-10-16T11:36:56+08:00</para>
        /// <para><paramref name="str"/>示例:"2020-10-16 11:36:56" -> 2020-10-16T11:36:56+08:00</para>
        /// <para><paramref name="str"/>示例:"0" -> 1970-01-01T00:00:00.0000000+08:00</para>
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static DateTimeOffset TryToLocalDateTimeOffset(
            this string str,
            DateTimeOffset defaultValue = default)
        {
            return str
                .TryConvertToDateTimeOffset(TypeConvertDelegate.longStringToLocalDateTimeOffset, defaultValue)
                .LocalDateTime;
        }

        /// <summary>
        /// 尝试转换为<see cref="DateTimeOffset"/>
        ///  <para><paramref name="str"/>示例:"1602819416123" -> 2020-10-16T11:36:56.123+08:00</para>
        ///  <para><paramref name="str"/>示例:"0" -> 1970-01-01T00:00:00.0000000+08:00</para>
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static DateTimeOffset ToLocalDateTimeOffsetByMilliseconds(
            this string str)
        {
            return str
                .ConvertToDateTimeOffset(TypeConvertDelegate.longStringToLocalDateTimeOffsetByMilliseconds)
                .LocalDateTime;
        }

        /// <summary>
        /// 尝试转换为<see cref="DateTimeOffset"/>,失败时返回<paramref name="defaultValue"/>
        ///  <para><paramref name="str"/>示例:"1602819416123" -> 2020-10-16T11:36:56.123+08:00</para>
        ///  <para><paramref name="str"/>示例:"0" -> 1970-01-01T00:00:00.0000000+08:00</para>
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static DateTimeOffset TryToLocalDateTimeOffsetByMilliseconds(
            this string str,
            DateTimeOffset defaultValue = default)
        {
            return str
                .TryConvertToDateTimeOffset(TypeConvertDelegate.longStringToLocalDateTimeOffsetByMilliseconds, defaultValue)
                .LocalDateTime;
        }

        #endregion To->Local

        #endregion TryToDateTimeOffset

        #endregion 基础类型与string之间的转换

        /// <summary>
        /// 转成json对象
        /// </summary>
        /// <typeparam name="T">要序列化的string</typeparam>
        /// <param name="jsonStr">               </param>
        /// <param name="jsonSerializerSettings">自定义的序列化设置</param>
        /// <returns></returns>
        [return: MaybeNull]
        public static T ToObjectExt<T>(
            this string jsonStr,
            JsonSerializerSettings? jsonSerializerSettings = null)
        {
            jsonSerializerSettings ??= JsonSerializerSettingConst.DefaultSetting;

            return JsonConvert.DeserializeObject<T>(jsonStr, jsonSerializerSettings);
        }

        /// <summary>
        /// string转换为MD5字符串,null或""会返回""
        /// </summary>
        /// <param name="str"> 要加密的字符串</param>
        /// <param name="is32">是否返回32位长度，为false时返回16位</param>
        /// <returns></returns>
        public static string ToMD5(this string str, bool is32 = true)
        {
            if (str.IsNullOrEmpty() == true)
                return string.Empty;

            return EncryptionHelper.EncryptMD5(str, is32);
        }

        /// <summary>
        /// 判断字符串是否为json格式
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool IsJson(this string str)
        {
            if (str.IsNullOrEmpty())
            {
                return false;
            }

            try
            {
                _ = JToken.Parse(str);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}