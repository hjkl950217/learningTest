namespace System.Linq
{
    public static class TypeExtensions
    {
        /// <summary>
        /// 判断指定的类型 <paramref name="type"/> 是否是指定泛型类型的子类型，或实现了指定泛型接口。
        /// </summary>
        /// <param name="checkType">需要测试的类型。不能为null</param>
        /// <param name="type">泛型接口类型，支持。不能为null</param>
        /// <returns>如果是泛型接口的子类型，则返回 true，否则返回 false。</returns>
        public static bool IsImplementedForm(this Type checkType, Type type)
        {
            if(checkType == null)
            {
                throw new ArgumentNullException(nameof(checkType));
            }

            if(type == null)
            {
                throw new ArgumentNullException(nameof(type));
            }

            // 接口类型

            Type[] intArray = checkType.GetInterfaces();

            bool isTheRawGenericType = checkType.GetInterfaces().Any(IsTheRawGenericType);
            if(isTheRawGenericType)
            {
                return true;
            }

            // 普通类型
            while(checkType != null && checkType != typeof(object))
            {
                isTheRawGenericType = IsTheRawGenericType(checkType);
                if(isTheRawGenericType)
                {
                    return true;
                }

                checkType = checkType.BaseType;//测试他的父类
            }

            // 没有找到任何匹配的接口或类型
            return false;

            // 测试某个类型是否是指定的原始接口
            bool IsTheRawGenericType(Type test)
            {
                if(type.IsGenericTypeDefinition)
                {
                    return type == (test.IsGenericType ? test.GetGenericTypeDefinition() : test);
                }
                else
                {
                    return type == test;
                }
            }
        }
    }
}