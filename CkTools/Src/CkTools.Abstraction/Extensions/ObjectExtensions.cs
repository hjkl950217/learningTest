using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using CkTools.Abstraction.Serialization;

namespace System
{
    public static class ObjectExtensions
    {
        #region CheckNull

        /// <summary>
        /// 检查参数是否为null，为null时抛出异常
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj">      要检查的对象</param>
        /// <param name="paramName">抛出异常时,显示的参数名</param>
        /// <exception cref="ArgumentNullException"><paramref name="obj" /> 为null时抛出</exception>
        public static void CheckNullWithException<T>(this T? obj, string paramName)
            where T : class
        {
            if(obj == null)
            {
                throw new ArgumentNullException(paramName);
            }
        }

        /// <summary>
        /// 检查参数是否为null，为null时抛出异常
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj">      要检查的对象</param>
        /// <param name="paramName">抛出异常时,显示的参数名</param>
        /// <param name="message">  抛出异常时,显示的错误信息</param>
        /// <exception cref="ArgumentNullException"><paramref name="obj" /> 为null时抛出</exception>
        public static void CheckNullWithException<T>(this T? obj, string paramName, string message)
            where T : class
        {
            if(obj == null)
            {
                throw new ArgumentNullException(paramName, message);
            }
        }

        /// <summary>
        /// 检查参数是否为null或emtpy，为null或emtpy时抛出异常
        /// </summary>
        /// <param name="obj">      要检查的对象</param>
        /// <param name="paramName">抛出异常时,显示的参数名</param>
        /// <exception cref="ArgumentNullException"><paramref name="obj" /> 为null或emtpy时抛出</exception>
        public static void CheckNullOrEmptyWithException(this IEnumerable? obj, string paramName)
        {
            if(obj.IsNullOrEmpty())
            {
                throw new ArgumentNullException(paramName);
            }
        }

        /// <summary>
        /// 检查参数是否为null或emtpy，为null或emtpy时抛出异常
        /// </summary>
        /// <param name="obj">      要检查的对象</param>
        /// <param name="paramName">抛出异常时,显示的参数名</param>
        /// <param name="message">  抛出异常时,显示的错误信息</param>
        /// <exception cref="ArgumentNullException"><paramref name="obj" /> 为null或emtpy时抛出</exception>
        public static void CheckNullOrEmptyWithException(this IEnumerable? obj, string paramName, string message)
        {
            if(obj.IsNullOrEmpty())
            {
                throw new ArgumentNullException(paramName, message);
            }
        }

        #endregion CheckNull

        #region IsNull and IsNullOrEmpty

        /// <summary>
        /// 判断null，null或0长度都返回true
        /// </summary>
        /// <typeparam name="T">对象类型</typeparam>
        /// <param name="value">要判断的对象</param>
        /// <returns>判断结果,null或0长度返回true,否则返回false</returns>
        public static bool IsNullOrEmpty<T>(this T value)
          where T : class?
        {
            #region 1.对象级别

            //引用为null
            bool isObjectNull = value == null;
            if(isObjectNull == true)
            {
                return true;
            }

            //判断是否为集合
            IEnumerator? tempEnumerator = (value as IEnumerable)?.GetEnumerator();
            if(tempEnumerator == null)
            {
                return false;//这里出去代表是对象 且 引用不为null.所以为false
            }

            #endregion 1.对象级别

            #region 2.集合级别

            //到这里就代表是集合且引用不为空，判断长度
            //MoveNext方法返回tue代表集合中至少有一个数据,返回false就代表0长度
            bool isZeroLenth = tempEnumerator.MoveNext() == false;
            if(isZeroLenth == true)
            {
                return true;
            }

            return isZeroLenth;

            #endregion 2.集合级别
        }

        /// <summary>
        /// 判断null
        /// </summary>
        /// <param name="value">要判断的对象</param>
        /// <returns>判断结果,null返回true,否则返回false</returns>
        public static bool IsNull(this object value)
        {
            return value == null;
        }

        /// <summary>
        /// 判断null,空数组
        /// </summary>
        /// <typeparam name="T">对象类型</typeparam>
        /// <param name="value">要判断的数组</param>
        /// <returns>判断结果,null或空数组返回true,否则返回false</returns>
        public static bool IsNullOrEmpty<T>(this T[]? value)
        {
            return value == null || value.Length == 0;
        }

        /// <summary>
        /// 判断null,空集合
        /// </summary>
        /// <typeparam name="T">对象类型</typeparam>
        /// <param name="value">要判断的集合</param>
        /// <returns>判断结果,null或空集合返回true,否则返回false</returns>
        public static bool IsNullOrEmpty<T>(this IList<T> value)
        {
            return value == null || value.Count == 0;
        }

        /// <summary>
        /// 判断null,空字典
        /// </summary>
        /// <typeparam name="T">对象类型</typeparam>
        /// <param name="value">要判断的字典</param>
        /// <returns>判断结果,null或空字典返回true,否则返回false</returns>
        public static bool IsNullOrEmpty<T>(this IDictionary value)
        {
            return value == null || value.Keys.Count == 0;
        }

        /// <summary>
        /// 判断null,空枚举器
        /// </summary>
        /// <param name="value">要判断的字典</param>
        /// <returns>判断结果,null或空枚举器返回true,否则返回false</returns>
        public static bool IsNullOrEmpty(this IEnumerable? value)
        {
            return value == null
                || !value.GetEnumerator().MoveNext();
        }

        #endregion IsNull and IsNullOrEmpty

        #region IsNotNull and IsNotNullOrEmpty

        /// <summary>
        /// 判断非null，非0长度
        /// </summary>
        /// <typeparam name="T">对象类型</typeparam>
        /// <param name="value">要判断的对象</param>
        /// <returns>判断结果,非null，非0长度返回true,否则返回false</returns>
        /// <returns></returns>
        public static bool IsNotNullOrEmpty<T>(this T value)
          where T : class
        {
            //IsNullOrEmpty取反
            return !value.IsNullOrEmpty();
        }

        /// <summary>
        /// 判断非null
        /// </summary>
        /// <param name="value">要判断的对象</param>
        /// <returns>判断结果,非null返回true,否则返回false</returns>
        public static bool IsNotNull(this object value)
        {
            return !value.IsNull();
        }

        /// <summary>
        /// 判断非null,非空数组
        /// </summary>
        /// <typeparam name="T">对象类型</typeparam>
        /// <param name="value">要判断的数组</param>
        /// <returns>判断结果,非null和非空数组返回true,否则为false</returns>
        public static bool IsNotNullOrEmpty<T>(this T[] value)
        {
            return !value.IsNullOrEmpty();
        }

        /// <summary>
        /// 判断非null,非空集合
        /// </summary>
        /// <typeparam name="T">对象类型</typeparam>
        /// <param name="value">要判断的集合</param>
        /// <returns>判断结果,非null和非空集合返回true,否则为false</returns>
        public static bool IsNotNullOrEmpty<T>(this IList<T> value)
        {
            return !value.IsNullOrEmpty();
        }

        /// <summary>
        /// 判断非null,非空字典
        /// </summary>
        /// <param name="value">要判断的字典</param>
        /// <returns>判断结果,非null和非空字典返回true,否则为false</returns>
        public static bool IsNotNullOrEmpty(this IDictionary value)
        {
            return !value.IsNullOrEmpty();
        }

        /// <summary>
        /// 判断非null,非空枚举器
        /// </summary>
        /// <param name="value">要判断的字典</param>
        /// <returns>判断结果,null或空枚举器返回true,否则返回false</returns>
        public static bool IsNotNullOrEmpty(this IEnumerable value)
        {
            return !value.IsNullOrEmpty();
        }

        #endregion IsNotNull and IsNotNullOrEmpty

        /// <summary>
        /// 转换为<see cref="Task"/>类型
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static Task<TResult> ToTask<TResult>(this TResult obj)
        {
            return Task.FromResult(obj);
        }

        /// <summary>
        /// 转换成XML字符串,对象为空时返回null
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj">                </param>
        /// <param name="isRemoveDeclaration">是否去掉XML声明。</param>
        /// <returns></returns>
        public static string ToXmlExtV2<T>(this T obj, bool isRemoveDeclaration = true)
             where T : class
        {
            // 0.数据检查
            if(obj.IsNullOrEmpty())
            {
                return string.Empty;
            }

            // 1.获取定制的xml序列化器
            XmlWriterSettings xmlSetting = new()
            {
                //忽略XML声明
                OmitXmlDeclaration = isRemoveDeclaration,
                Indent = true,
                Encoding = Encoding.UTF8,
            };
            Xml_System_Serializer? xmlSeria = new(xmlSetting);

            // 2.序列化并返回
            return xmlSeria.SerializeToString(obj);
        }

        /// <summary>
        /// 判断对象是否是指定类型
        /// </summary>
        /// <typeparam name="T">要判断的源类型</typeparam>
        /// <param name="object1">   源类型的对象，可以为null</param>
        /// <param name="targetType">指定类型</param>
        /// <returns>
        /// 如果相等，则为true，否则为false。
        /// <para></para>
        /// 如果是继承关系，为false。 如果obect1为null，也不会影响判断
        /// </returns>
#pragma warning disable IDE0060 // 删除未使用的参数

        public static bool EqualsType<T>(this T object1, Type targetType)
#pragma warning restore IDE0060 // 删除未使用的参数
        {
            return typeof(T).Equals(targetType);
        }

        /// <summary>
        /// 返回一个迭代器。此迭代器将 <paramref name="source" /> 转换成KV型的数据。只会解析一层
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source">      要处理的对象。只能是对象，不能是集合！</param>
        /// <param name="isIgnoreNull">是否忽略null值。如果为null，则跳过此属性</param>
        /// <returns>
        /// 返回解析后的数据
        /// <para>key:属性名</para>
        /// <para>value:数据值</para>
        /// </returns>
        /// <exception cref="ArgumentException">当 <paramref name="source" /> 为null时会引发此异常</exception>
        /// <exception cref="TypeAccessException">当 <paramref name="source" /> 为数组类型时引发此异常</exception>
        public static IEnumerable<KeyValuePair<string, object>> GetAllPropertyValue<T>(
          this T source,
          bool isIgnoreNull = false)
          where T : class
        {
            if(source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            //判断是否为集合
            IEnumerator? tempEnumerator = (source as IEnumerable)?.GetEnumerator();//为null才代表是对象
            if(tempEnumerator != null)
            {
                throw new TypeAccessException($"{nameof(source)}'s type not is array type!");
            }

            PropertyDescriptorCollection props = TypeDescriptor.GetProperties(source);//获取对象的所有属性信息
            return GetAllPropertyValueIterator(source, props, isIgnoreNull);//遍历
        }

        /// <summary>
        /// 遍历属性信息
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source">      </param>
        /// <param name="props">       </param>
        /// <param name="isIgnoreNull"></param>
        /// <returns></returns>
        private static IEnumerable<KeyValuePair<string, object>> GetAllPropertyValueIterator<T>(
            T source,
            PropertyDescriptorCollection props,
            bool isIgnoreNull)
            where T : class
        {
            //因为用yield返回迭代器，如果异常检查和逻辑放在一起，抛出异常时可能已距离发生源很远了
            //所以把遍历这部分独立成一个方法

            foreach(PropertyDescriptor item in props)
            {
                object value = item.GetValue(source);
                if(isIgnoreNull && value == null)
                {
                    continue;
                }

                yield return new KeyValuePair<string, object>(item.Name, item.GetValue(source));
            }
        }

        #region 基础类型与Object之间的转换

        public static int ToInt32<T>(this T str)
            where T : class
        {
            return str.BaseConvert(System.Convert.ToInt32);
        }

        public static int ToInt32OrDefault<T>(this T str, int defaultValue = 0)
             where T : class
        {
            return str.BaseConvertOrDefalut(System.Convert.ToInt32, defaultValue);
        }

        public static bool ToBool<T>(this T str)
              where T : class
        {
            return str.BaseConvert(System.Convert.ToBoolean);
        }

        public static bool ToBoolOrDefault<T>(this T str, bool defaultValue = false)
              where T : class
        {
            return str.BaseConvertOrDefalut(System.Convert.ToBoolean, defaultValue);
        }

        public static decimal ToDecimal<T>(this T str)
              where T : class
        {
            return str.BaseConvert(System.Convert.ToDecimal);
        }

        public static decimal ToDecimalOrDefault<T>(
            this T str,
            decimal defaultValue = 0.00M) where T : class
        {
            return str.BaseConvertOrDefalut(System.Convert.ToDecimal, defaultValue);
        }

        public static double ToDouble<T>(this T str)
              where T : class
        {
            return str.BaseConvert(System.Convert.ToDouble);
        }

        public static double ToDoubleOrDefault<T>(
            this T str,
            double defaultValue = 0.00) where T : class
        {
            return str.BaseConvertOrDefalut(System.Convert.ToDouble, defaultValue);
        }

        #endregion 基础类型与Object之间的转换

        /// <summary>
        /// 转换成单元素数组(用于包装结构)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <returns></returns>
        public static T[] AsToArray<T>(this T source)
        {
            return new T[] { source };
        }

        /// <summary>
        /// 转换成<see cref="IEnumerable{T}"/>(用于包装结构)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <returns></returns>
        public static IEnumerable<T> AsToEnumerable<T>(this T source)
        {
            yield return source;
        }

        #region 清理导航属性

        public static ConcurrentDictionary<Type, object> AssignFuncDic = new();

        public static TDbEntity? CleanNavigationProperty<TDbEntity>(this TDbEntity dbEntity)
            where TDbEntity : class
        {
            dbEntity.CheckNullWithException(nameof(dbEntity));

            Type entityTypeInfo = typeof(TDbEntity);
            Func<TDbEntity, TDbEntity>? assignFunc = AssignFuncDic
                ?.GetOrAdd(entityTypeInfo, BuildAssignFunc().Compile())
                as Func<TDbEntity, TDbEntity>;

            return assignFunc?.Invoke(dbEntity);

            LambdaExpression BuildAssignFunc()
            {
                Type entityTypeInfo = typeof(TDbEntity);
                Type stringTypeInfo = typeof(string);
                ParameterExpression paramExpression = Expression.Parameter(entityTypeInfo, "t");//准备参数t

                //获取要赋值的属性
                PropertyInfo[] propertyInfos = entityTypeInfo.GetProperties()
                     .Where(t => t.CanWrite
                         && !t.PropertyType.IsValueType
                         && t.PropertyType != stringTypeInfo && Nullable.GetUnderlyingType(t.PropertyType) == null
                         )
                     .ToArray();

                //准备return标签
                LabelTarget returnTarget = Expression.Label(entityTypeInfo);
                GotoExpression returnExpression = Expression.Return(returnTarget, paramExpression, entityTypeInfo);
                LabelExpression returnLabel = Expression.Label(returnTarget, Expression.Constant(null, entityTypeInfo));

                //生成赋值表达式
                Expression[] assignExps = propertyInfos
                    .Select(t =>
                    {
                        MemberExpression propExp = Expression.Property(paramExpression, t);//获取属性访问表达式 t.xx
                        return Expression.Assign(propExp, Expression.Constant(null, t.PropertyType)) as Expression;//赋值 t.xx=null
                    })
                    .Concat(new LabelExpression[] { returnLabel })//return t;
                    .ToArray();
                ;

                //打包
                BlockExpression body = Expression.Block(assignExps);
                Expression<Func<TDbEntity, TDbEntity>> funcExp = Expression.Lambda<Func<TDbEntity, TDbEntity>>(body, paramExpression);

                return funcExp;
            }
        }

        public static IEnumerable<TDbEntity?> BatchCleanNavigationProperty<TDbEntity>(this IEnumerable<TDbEntity?> dbEntities)
             where TDbEntity : class
        {
            dbEntities.CheckNullOrEmptyWithException(nameof(dbEntities));

            dbEntities = dbEntities
                .Select(t =>
                {
                    return t?.CleanNavigationProperty<TDbEntity>();
                });

            return dbEntities;
        }

        #endregion 清理导航属性
    }
}