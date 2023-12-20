using System;
using System.Collections.Generic;

namespace CkTools.FP
{
    /// <summary>
    /// 函数式功能-小的公共功能
    /// </summary>
    public static partial class CkFunctions
    {
        #region 处理对象

        /// <summary>
        /// 处理对象,返回一个处理对象的函数
        /// </summary>
        /// <value>
        /// <para>函数1：处理函数</para>
        /// <para>函数2：判断函数,返回true时才会处理对象</para>
        /// </value>
        public static Func<
            Func<T?, bool>,
            Action<T?>> ProcessObject<T>(Action<T?> processObj)
        {
            return
                judge =>
                value =>
                {
                    if(judge(value))
                    {
                        processObj(value);
                    }
                };
        }

        public static Func<
            Func<T?, bool>,
            Action<IEnumerable<T?>?>> Foreach<T>(Action<T?> projessObj)
        {
            return judge =>
             valueArray =>
             {
                 #region 异常检测

                 if(judge == null)
                 {
                     throw new ArgumentNullException(nameof(judge));
                 }

                 if(projessObj == null)
                 {
                     throw new ArgumentNullException(nameof(projessObj));
                 }

                 if(valueArray == null)
                 {
                     throw new ArgumentNullException(nameof(valueArray));
                 }

                 #endregion 异常检测

                 //判断
                 foreach(T? item in valueArray)
                 {
                     if(judge(item))
                     {
                         projessObj(item);
                     }
                 }
             };
        }

        #endregion 处理对象
    }
}