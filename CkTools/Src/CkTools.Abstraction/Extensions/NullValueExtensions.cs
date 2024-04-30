namespace System
{
    public static class NullValueExtensions
    {
        /// <summary>
        /// 返回数据或返回默认值
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="value"></param>
        /// <param name="defauleValue"><paramref name="value"/>为null时的默认值</param>
        /// <param name="func">做转换的方法</param>
        /// <returns></returns>
        public static TResult GetValueOrDefault<T, TResult>(
            this Nullable<T> value,
            TResult defauleValue,
            Func<T, TResult> func)
            where T : struct
        {
            if(value.HasValue == false)
            {
                return defauleValue;
            }
            else
            {
                return func(value.GetValueOrDefault());//把可空值类型中的数据做转换
            }
        }
    }
}