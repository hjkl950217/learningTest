using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using AspectCore.Extensions.Reflection;

namespace CkTools.Helper
{
    public static class ReflectionUtil
    {
        #region 内置类型判断方法

        /// <summary>
        /// 是否实现接口
        /// <para>参数1：接口的<see cref="System.Type"/></para>
        /// <para>返回： 判断类型是否实现某个接口的委托</para>
        /// <para>例：传递typeof(Ilist)返回一个委托，这个委托可判断任意type是否实现Ilist接口</para>
        /// </summary>
        public static readonly Func<Type, Func<Type, bool>> isImplementInterface = interfaceType => type => type.GetInterfaces().Contains(interfaceType);

        public static readonly Func<Type, bool> isInterface = i => i.IsInterface;
        public static readonly Func<Type, bool> isPublic = i => i.IsPublic;
        public static readonly Func<Type, bool> isClass = i => i.IsPublic;

        /// <summary>
        /// 是否实现包含特性
        /// <para>参数1：特性的<see cref="System.Type"/></para>
        /// <para>返回： 判断类型是否实现标记特性的委托</para>
        /// <para>例：传递typeof(Attribute)，返回一个委托，这个委托可判断任意type是否标记Attribute</para>
        /// </summary>
        public static readonly Func<Type, Func<Type, bool>> isClassAttribute = attrType => t => t.GetReflector().GetCustomAttribute(attrType) == null;

        /// <summary>
        /// 是否实现包含特性
        /// <para>参数1：特性的<see cref="System.Type"/></para>
        /// <para>参数1：方法名</para>
        /// <para>返回： 判断类型是否实现标记特性的委托</para>
        /// <para>例：传递typeof(Attribute)和"ToString"，返回一个委托，这个委托可判断任意type下名为"ToString"的方法是否标记Attribute</para>
        /// </summary>
        public static readonly Func<Type, string, Func<Type, bool>> isMethodAttribute = (attrType, methodName) => classType => classType.GetMethod(methodName).GetReflector().GetCustomAttribute(attrType) == null;

        #endregion 内置类型判断方法

        /// <summary>
        /// 【请熟悉反射再使用】从程序集中扫描需要的类型
        /// <para><paramref name="typerPreJudger"/>:初步判断类型是否为需要的</para>
        /// <para><paramref name="typeInfoConvert"/>:指示如何从初步过滤的type信息中获得自己需要的信息</para>
        /// <para><paramref name="filter"/>:指示如何从初步过滤的type信息中获得自己需要的信息</para>
        /// </summary>
        /// <typeparam name="TTypeInfo"></typeparam>
        /// <param name="typerPreJudger"></param>
        /// <param name="typeInfoConvert"></param>
        /// <param name="findTypeByAppDomain"></param>
        /// <param name="filter"></param>
        /// <returns></returns>
        public static IEnumerable<TTypeInfo> ScanType<TTypeInfo>(
            Func<Type, bool> typerPreJudger,
            Func<Type, TTypeInfo> typeInfoConvert,
            Func<TTypeInfo, bool>? filter = null,
            Func<IEnumerable<Type>>? findTypeByAppDomain = null)
        {
            typerPreJudger.CheckNull(nameof(typerPreJudger));
            typeInfoConvert.CheckNull(nameof(typeInfoConvert));

            filter ??= t => t != null;
            findTypeByAppDomain ??= () => AppDomain.CurrentDomain.GetAssemblies()
                      .SelectMany(i => { try { return i.GetTypes(); } catch { return Array.Empty<Type>(); } });

            return findTypeByAppDomain()
                    .Where(typerPreJudger)
                    .Select(typeInfoConvert)
                    .Where(filter);
        }
    }
}