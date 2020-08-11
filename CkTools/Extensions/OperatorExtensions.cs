namespace System
{
    /// <summary>
    /// 扩展出一些操作符，用于不能使用新操作符的情况
    /// </summary>
    public static class SdkExtension
    {
        /// <summary>
        /// 通用获取值的方式
        /// <para>示例:  A.GetDataOrDefault(t => t.Value, string.Empty) </para>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="data"></param>
        /// <param name="getData"></param>
        /// <param name="defaultValueFunc"></param>
        /// <returns></returns>
        public static TResult GetDataOrDefault<T, TResult>(
            this T data,
            Func<T, TResult> getData,
            Func<TResult> defaultValueFunc,
            Func<TResult, bool>? useDefault = null)
        {
            useDefault ??= t => t == null;

            if (getData == null) throw new ArgumentNullException($"{nameof(getData)} not can be null");
            if (defaultValueFunc == null) throw new ArgumentNullException($"{nameof(defaultValueFunc)} not can be null");
            if (data == null) return defaultValueFunc();

            TResult result = getData(data);
            return useDefault(result) ? defaultValueFunc() : result;
        }

        /// <summary>
        /// 通用获取值的方式
        /// <para>示例:  A.Cookies.GetDataOrDefault(t => t.Value, string.Empty) </para>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="data"></param>
        /// <param name="defaultValue"></param>
        /// <remarks>
        /// 这里不对<paramref name="defaultValue"/>做空检测。只是想让调用者给一个值，如果给的是null值则代表默认值就是null
        /// </remarks>
        /// <returns></returns>
        public static TResult GetDataOrDefault<T, TResult>(
            this T data,
            Func<T, TResult> getData,
            TResult defaultValue)
        {
            return data.GetDataOrDefault(getData, () => defaultValue);
        }

        /// <summary>
        /// 通用获取值的方式
        /// <para>示例:  A.Cookies.GetDataOrDefault(t => t.Value, string.Empty) </para>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="data"></param>
        /// <param name="getData"></param>
        /// <returns></returns>
        public static TResult GetDataOrDefault<TResult>(
            this TResult data,
            TResult defaultValue)
        {
            return data.GetDataOrDefault(t => t, () => defaultValue);
        }

        /// <summary>
        /// 替代?.的方式
        /// <para>示例1: A.GetDataOrNull(t=>t.Trim()) </para>
        /// <para><![CDATA[示例2: A.GetDataOrNull(t=>t.t,new List<int>()).Find(t=>t==2)]]></para>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="data"></param>
        /// <param name="getData"></param>
        /// <param name="defaultValue">可选参数，当data为null时的默认值</param>
        /// <returns></returns>
        public static TResult GetDataOrNull<T, TResult>(
            this T data,
            Func<T, TResult> getData)
            where T : class
            where TResult : class
        {
#pragma warning disable CS8603 // 可能的 null 引用返回。
            return data.GetDataOrDefault(getData, () => null);
#pragma warning restore CS8603 // 可能的 null 引用返回。
        }

        /// <summary>
        /// 代替??=的方式，但要求TResult必须有无参数的构造方法
        /// <para>示例:  A.Object.GetDataOrNew() </para>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="data"></param>
        /// <param name="getData"></param>
        /// <returns></returns>
        public static TResult GetDataOrNew<TResult>(this TResult data)
            where TResult : class, new()
        {
            return data.GetDataOrDefault(t => t, () => new TResult());
        }

        /// <summary>
        /// 代替??的方式
        /// <para>示例:  A.Ints.GetDataOrNew(() =>new int[0]) </para>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="data"></param>
        /// <param name="getData"></param>
        /// <returns></returns>
        public static TResult GetDataOrCreate<TResult>(this TResult data, Func<TResult> func)
            where TResult : class
        {
            return data.GetDataOrDefault(t => t, func);
        }
    }
}