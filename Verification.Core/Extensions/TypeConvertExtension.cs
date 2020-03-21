namespace System
{
    /// <summary>
    /// 一些类型间的转换，有业务逻辑的转换不放这里
    /// </summary>
    public static class TypeConvertExtension
    {
        /// <summary>
        /// 基础转换
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TValue"></typeparam>
        /// <param name="source">要转换的字符串</param>
        /// <param name="convert">转换的方法</param>
        /// <returns>类型为<typeparamref name="TValue"/>的值</returns>
        /// <exception cref="ArgumentException">The parameter 'str' is invalid、Empty、Null</exception>
        public static TValue BaseConvert<T, TValue>(
          this T source,
          Func<T, TValue> convert)
        {
            if (typeof(T).IsClass && source == null)
            {
                throw new ArgumentException("The parameter 'str' is invalid、Empty、Null", nameof(source));
            }
            return convert(source);
        }

        /// <summary>
        /// 基础转换，有默认值
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TValue"></typeparam>
        /// <param name="source">要转换的字符串</param>
        /// <param name="defaultValue">默认值</param>
        /// <param name="convert">转换的方法</param>
        /// <returns>类型为<typeparamref name="TValue"/>的值</returns>
        public static TValue BaseConvertAndDefalut<T, TValue>(
          this T source,
          TValue defaultValue,
          Func<T, TValue> convert)
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
    }
}