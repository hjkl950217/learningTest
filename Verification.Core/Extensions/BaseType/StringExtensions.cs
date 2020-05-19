using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Verification.Core.ConstAndEnum;
using Verification.Core.Helper;
using Verification.Core.Serializer;

namespace System
{
    /// <summary>
    /// 字符串扩展类
    /// </summary>
    public static class StringExtensions
    {
        public static readonly char[] DefualtSeparators = new[] { ',', ';' };

        /// <summary>
        /// 转成json对象
        /// </summary>
        /// <typeparam name="T">要序列化的string</typeparam>
        /// <param name="jsonStr">               </param>
        /// <param name="jsonSerializerSettings">自定义的序列化设置</param>
        /// <returns></returns>
        public static T ToObjectExt<T>(
            this string jsonStr,
            JsonSerializerSettings jsonSerializerSettings = null)
        {
            jsonSerializerSettings = jsonSerializerSettings ?? JsonSerializerSettingConst.DefaultSetting;

            return JsonConvert.DeserializeObject<T>(jsonStr, jsonSerializerSettings);
        }

        /// <summary>
        /// 格式化国家名字，转换成首字母大写，其他小写。如CHINA-&gt;China
        /// </summary>
        /// <param name="countryName">国家名字</param>
        /// <returns></returns>
        public static string ToCountryName(this string countryName)
        {
            /* 思路
           * 1.把国家名字按空格分拆成几部分,全小写。比如 ABC  DE F->[abc,de,f]
           * 2.再把每部分的第一个字符变成大写。比如：[Abc,De,F]
           * 3.再把字符串数组装回去。比如："Abc De F"
           */

            if (countryName.IsNullOrEmpty()) return string.Empty;

            List<char[]> countryNameTempList = countryName
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)//分割，去掉空字符串
                .Where(t => t != null && t.Length > 0)//去掉空格字符的情况
                .Select(t => t.ToLower().ToCharArray())
                .ToList();

            StringBuilder sb = new StringBuilder();

            //遍历分割后的字符串，把首字母大写
            for (int i = 0 ; i < countryNameTempList.Count ; i++)//froeach不能给枚举值赋值，所以用for
            {
                countryNameTempList[i][0] = char.ToUpper(countryNameTempList[i][0]);//首字母大写
                sb.Append(countryNameTempList[i]);//添加到缓存变量里
                sb.Append(' ');
            }
            sb.Remove(sb.Length - 1, 1);//移除最后一个多加的空格

            return sb.ToString();
        }

        #region 基础类型与string之间的转换

        /// <summary>
        /// 基础转换,转换失败时会报错
        /// </summary>
        /// <typeparam name="TValue"></typeparam>
        /// <param name="str">    要转换的字符串</param>
        /// <param name="convert">转换的方法</param>
        /// <returns>类型为 <typeparamref name="TValue" /> 的值</returns>
        /// <exception cref="ArgumentException">The parameter 'str' is invalid、Empty、Null</exception>
        private static TValue BaseConvert<TValue>(
          this string str,
          Func<string, TValue> convert)
        {
            if (str.IsNullOrEmpty() == true)
                throw new ArgumentException("The parameter 'str' is invalid、Empty、Null", nameof(str));

            return convert(str);
        }

        /// <summary>
        /// 基础转换,转换失败时会返回默认值
        /// </summary>
        /// <typeparam name="TValue"></typeparam>
        /// <param name="str">         要转换的字符串</param>
        /// <param name="defaultValue">默认值</param>
        /// <param name="convert">     转换的方法</param>
        /// <returns>类型为 <typeparamref name="TValue" /> 的值</returns>
        private static TValue TryBaseConvert<TValue>(
          this string str,
          TValue defaultValue,
          Func<string, TValue> convert)
        {
            if (str.IsNullOrEmpty())
            {
                return defaultValue;
            }
            try
            {
                return convert(str);
            }
            catch
            {
                return defaultValue;
            }
        }

        public static int ToInt32(this string str)
        {
            return str.BaseConvert(System.Convert.ToInt32);
        }

        public static int ToInt32OrDefault(this string str, int defaultValue = 0)
        {
            return str.TryBaseConvert(defaultValue, System.Convert.ToInt32);
        }

        public static bool ToBool(this string str)
        {
            return str.BaseConvert(System.Convert.ToBoolean);
        }

        public static bool ToBoolOrDefault(this string str, bool defaultValue = false)
        {
            return str.TryBaseConvert(defaultValue, System.Convert.ToBoolean);
        }

        public static decimal ToDecimal(this string str)
        {
            return str.BaseConvert(System.Convert.ToDecimal);
        }

        public static decimal ToDecimalOrDefault(
            this string str,
            decimal defaultValue = 0.00M)
        {
            return str.TryBaseConvert(defaultValue, System.Convert.ToDecimal);
        }

        public static double ToDouble(this string str)
        {
            return str.BaseConvert(System.Convert.ToDouble);
        }

        public static double ToDoubleOrDefault(
            this string str,
            double defaultValue = 0.00)
        {
            return str.TryBaseConvert(defaultValue, System.Convert.ToDouble);
        }

        #endregion 基础类型与string之间的转换

        /// <summary>
        /// string转换为MD5字符串,null或""会返回""
        /// </summary>
        /// <param name="str"> 要加密的字符串</param>
        /// <param name="is32">是否返回32位长度，为false时返回16位</param>
        /// <returns></returns>
        public static string ToMD5(this string str, bool is32 = true)
        {
            if (str.IsNullOrEmpty() == true) return string.Empty;

            return EncryptionHelper.EncryptMD5(str, is32);
        }

        /// <summary>
        /// 判断两个字符串是否相等，忽略大小写
        /// </summary>
        /// <param name="str1"></param>
        /// <param name="str2"></param>
        /// <returns></returns>
        public static bool EqualsIgnoreCase(this string str1, string str2)
        {
            return string.Equals(str1, str2, StringComparison.OrdinalIgnoreCase);
        }

        /// <summary>
        /// 判断两个字符串是否相等，忽略大小写，忽略首尾空格
        /// </summary>
        /// <param name="str1"></param>
        /// <param name="str2"></param>
        /// <returns></returns>
        public static bool EqualsLoose(this string str1, string str2)
        {
            return string.Equals(str1?.Trim(), str2?.Trim(), StringComparison.OrdinalIgnoreCase);
        }

        /// <summary>
        /// 分割为数组
        /// </summary>
        /// <param name="source">    要处理的字符串</param>
        /// <param name="separators">
        /// 要分割的字符串. 默认使用 ,或 ; 参考： <see cref="StringExtensions.DefualtSeparators" />
        /// </param>
        /// <param name="selector">  字符串的处理，默认使用Trim().ToUpper()</param>
        /// <returns></returns>
        public static string[] SplitToArray(
            this string source,
            char[]? separators = null,
            Func<string, string>? selector = null)
        {
            if (source.IsNullOrEmpty())
            {
                return Array.Empty<string>();
            }

            selector = selector ?? (t => t.Trim().ToUpper());
            return source
                .Split(separators
                        ?? StringExtensions.DefualtSeparators,
                        StringSplitOptions.RemoveEmptyEntries)
                .Where(i => !string.IsNullOrWhiteSpace(i))
                .Select(i => selector(i))
                .ToArray();
        }

        /// <summary>
        /// 移除字符串中最后一位多余的符号.需要做trim操作的请先处理好
        /// <para>例:"1;2;3;"--&gt;"1;2;3"</para>
        /// </summary>
        /// <param name="source"> </param>
        /// <param name="symbols">要处理的符号集合</param>
        /// <returns></returns>
        public static string RemoveExtraSymbol(this string source, params char[] symbols)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }
            else if (source.Length < 2)
            {
                return source;
            }

            ReadOnlySpan<char> chars = source.AsSpan();

            bool isExtra = false;
            foreach (var item in symbols)
            {
                isExtra = chars[source.Length - 1] == item;
                if (isExtra == true) break;
            }
            if (isExtra == true)
            {
                return chars.Slice(0, source.Length - 1).ToString();
            }
            else
            {
                return source;
            }
        }

        /// <summary>
        /// 截取字符串，默认从0开始截取。如果参数比实际值大，则用实际值
        /// <para>
        /// 如果 <paramref name="length" /> 大于 <paramref name="source" /> 的长度，则截取 <paramref
        /// name="source" /> 的长度
        /// </para>
        /// </summary>
        /// <param name="source">    为null或长度为0时返回 <see cref="string.Empty" /></param>
        /// <param name="length">    要截取的长度。不能小于0</param>
        /// <param name="startIndex">开始截取的索引号。默认为0,不能小于0</param>
        /// <returns></returns>
        public static string SubstringExt(this string source, int length, int startIndex = 0)
        {
            if (source.IsNullOrEmpty()) return string.Empty;
            if (length < 0) throw new ArgumentException("The parameter must be greater than or equal to 0", nameof(length));
            if (startIndex < 0) throw new ArgumentException("The parameter must be greater than or equal to 0", nameof(startIndex));

            length = length > source.Length ? source.Length : length;//如果参数比实际值大，则用实际值

            return source.Substring(startIndex, length);
        }

        /// <summary>
        /// 转换为byte[]
        /// </summary>
        /// <param name="source">  </param>
        /// <param name="encoding">编码格式，默认 <see cref="Encoding.UTF8" /></param>
        /// <returns></returns>
        public static byte[] ToBytes(this string source, Encoding encoding = null)
        {
            encoding = encoding ?? Encoding.UTF8;
            return source.BaseConvertAndDefalut(Array.Empty<byte>(), encoding.GetBytes);
        }

        public static T ToEnum<T>(this string str, bool ignoreCase = false)
            where T : struct
        {
            if (Enum.TryParse<T>(str, ignoreCase, out var enumValue))
            {
                return enumValue;
            }
            return default(T);
        }
    }
}