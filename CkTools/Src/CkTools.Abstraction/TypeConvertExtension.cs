namespace System
{
    /// <summary>
    /// 一些类型间的转换，有业务逻辑的转换不放这里
    /// </summary>
    public static class TypeConvertExtension
    {
        private static readonly Action<string> emptyWithException = t =>
        {
            if (t.Length == 0)
            {
                throw new ArgumentException("The parameter 'str' is invalid、Empty、Null");
            }
        };

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
            Func<string, TValue> convertTemp = t => { emptyWithException(t); return convert(t); };
            return str.BaseConvert(convertTemp);
        }

        /// <summary>
        /// 基础转换,转换失败时会返回默认值
        /// </summary>
        /// <typeparam name="TValue"></typeparam>
        /// <param name="str">要转换的字符串</param>
        /// <param name="defaultValue">默认值</param>
        /// <param name="convert">转换的方法</param>
        /// <returns>类型为 <typeparamref name="TValue" /> 的值</returns>
        private static TValue BaseConvertOrDefalut<TValue>(
          this string str,
          Func<string, TValue> convert,
          TValue defaultValue = default)
        {
            Func<string, TValue> convertTemp = t => { emptyWithException(t); return convert(t); };
            return str.BaseConvertOrDefalut<string, TValue>(convertTemp, defaultValue);
        }

        /// <summary>
        /// 基础转换
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TValue"></typeparam>
        /// <param name="source">要转换的字符串</param>
        /// <param name="convert">转换的方法</param>
        /// <returns>类型为<typeparamref name="TValue"/>的值</returns>
        /// <exception cref="ArgumentException">The parameter is invalid</exception>
        public static TValue BaseConvert<T, TValue>(
          this T source,
          Func<T, TValue> convert)
        {
            if (typeof(T).IsClass
                && (source == null || source.GetHashCode() == string.Empty.GetHashCode()))
            {
                throw new ArgumentException($"The parameter is invalid,value:{source}", nameof(source));
            }

            return convert(source);
        }

        /// <summary>
        /// 基础转换，有默认值
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TValue"></typeparam>
        /// <param name="source">要转换的字符串</param>
        /// <param name="convert">转换的方法</param>
        /// <param name="defaultValue">默认值</param>
        /// <returns>类型为<typeparamref name="TValue"/>的值</returns>
        public static TValue BaseConvertOrDefalut<T, TValue>(
          this T source,
          Func<T, TValue> convert,
          TValue defaultValue)
        {
            if (typeof(T).IsClass && source == null)
            {
                return defaultValue;
            }
            try
            {
                return convert(source);
            }
            catch
            {
                return defaultValue;
            }
        }

        #region ToEnum

        private static TEnum BaseToEnum<TEnum, TValue>(TValue value)
            where TEnum : Enum
            where TValue : struct
        {
            return (TEnum)Enum.ToObject(typeof(TEnum), value);
        }

        public static TEnum ToEnum<TEnum>(this byte value)
           where TEnum : Enum
        {
            return BaseToEnum<TEnum, byte>(value);
        }

        public static TEnum ToEnum<TEnum>(this ushort value)
          where TEnum : Enum
        {
            return BaseToEnum<TEnum, ushort>(value);
        }

        #endregion ToEnum
    }
}