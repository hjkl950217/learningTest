using System;
using System.Collections.Generic;
using System.Linq;

namespace FluentValidation
{
    public static class ValidatorExtension
    {
        #region 内部方法

        public static Func<string, bool> checkSellerIDFormat = str => isUpper(str[0])
                           && isUpperOrInt(str[1])
                           && isUpperOrInt(str[2])
                           && isUpperOrInt(str[3]);

        //严格模式
        public static Func<string, bool> checkSellerIDFormatByStrictMode = checkPipe(Collect(
            isNotNullOrEmpty,
            checkLength(equalOperator(strLength), 4),
            checkSellerIDFormat
            ));

        //宽容模式
        public static Func<string, bool> checkSellerIDFormatByNormalMode = checkPipe(Collect(
            isNotNull,
            checkLength(equalOperator(strTrimLength), 4)
            ));

        /// <summary>
        /// 获得一个管道。单独一个方法是为了用泛型
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static Func<Func<T, bool>[], Func<T, bool>> GetPipeByType<T>()
        {
            return methods => str =>
            {
                for(int i = 0 ; i < methods.Length ; i++)
                {
                    if(!methods[i](str))
                    {
                        return false;//有一个返回false则中断，然后直接返回 表示检查不过
                    }
                }
                return true;
            };
        }

        public static T[] Collect<T>(params T[] source)
        {
            return source;
        }

        /// <summary>
        /// 针对值类型的必填
        /// <para>值类型的字段，不填时有默认值，所以需要判断下是不是等于默认值</para>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TProperty"></typeparam>
        /// <param name="ruleBuilder"></param>
        /// <param name="notEqualValue">要比较的值</param>
        /// <returns></returns>
        private static IRuleBuilderOptions<T, TProperty> Required<T, TProperty>(
            this IRuleBuilder<T, TProperty> ruleBuilder,
            TProperty notEqualValue)
        {
            return ruleBuilder
                .NotNull()
                .NotEmpty()
                .NotEqual(notEqualValue);
        }

        /// <summary>
        /// 基于谓词来添加规则
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TProperty"></typeparam>
        /// <param name="ruleBuilder"></param>
        /// <param name="selectter">传入选择元素的委托后，选择元素的选择器。如<see cref="Enumerable.Any{TSource}(IEnumerable{TSource})"/></param>
        /// <param name="predicate"></param>
        /// <param name="errorMsg"></param>
        /// <returns></returns>
        private static IRuleBuilderOptions<T, IEnumerable<TProperty>> Predicate<T, TProperty>(
            this IRuleBuilder<T, IEnumerable<TProperty>> ruleBuilder,
            Func<IEnumerable<TProperty>, Func<TProperty, bool>, bool> selectter,
            Func<TProperty, bool> predicate,
            string errorMsg)
        {
            Func<IEnumerable<TProperty>, bool> muster = list =>
            {
                list = list ?? Array.Empty<TProperty>();
                return selectter(list, predicate);
            };

            return ruleBuilder
                .Must(muster)
                .WithMessage(errorMsg);
        }

        #region 如果有FP库就不用写的函数

        public static Func<string, bool> isNull = c => c == null;
        public static Func<string, bool> isNotNull = c => c != null;
        public static Func<string, bool> isNotNullOrEmpty = c => c.IsNullOrEmpty();
        public static Func<char, bool> isUpper = char.IsUpper;

        public static Func<char, bool> isInt = c => 47 < c && c < 58;//0~9asc值：48-57
        public static Func<char, bool> isUpperOrInt = c => isUpper(c) || isInt(c);

        public static Func<string, int> strLength = str => str.Length;
        public static Func<string, int> strTrimLength = str => str == null ? 0 : str.Trim().Length;

        public static Func<Func<string, int>, Func<string, int, bool>> equalOperator = getLength => (str, num) => getLength(str) == num;

        public static Func<Func<string, int, bool>, int, Func<string, bool>> checkLength = (@operator, length) => str => @operator(str, length);

        public static Func<Func<string, bool>[], Func<string, bool>> checkPipe = GetPipeByType<string>();

        #endregion 如果有FP库就不用写的函数

        /// <summary>
        /// 只判断<paramref name="value"/>是否符合sellerID规则<para></para>
        /// 不处理大小写 空格 长度等问题
        /// </summary>
        /// <returns></returns>
        private static bool CheckSellerIDFormat(string value, bool enableStrictMode)
        {
            /*
             * sellerID生成规则：SP  s7edidb01.mktpls.UP_EDI_GenerateSellerID_V2
             *
             * 4位，每一位可能是大写字母或数字
             *
             */

            if(enableStrictMode)
            {
                return checkSellerIDFormatByStrictMode(value);
            }
            else
            {
                return checkSellerIDFormatByNormalMode(value);
            }
        }

        #endregion 内部方法

        #region CheckSellerID

        /// <summary>
        /// 检查SellerID
        /// <para>不能为null或"",忽略首尾首位空格,长度必须是4位</para>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="ruleBuilder"></param>
        /// <returns></returns>
        public static IRuleBuilderOptions<T, string> CheckSellerID<T>(this IRuleBuilder<T, string> ruleBuilder)
        {
            return ruleBuilder
                .NotNull()
                .NotEmpty()
                .Must((chars) => CheckSellerIDFormat(chars, enableStrictMode: false))
                .WithMessage("SellerId length must be 4 after ignoring leading and trailing spaces");
        }

        /// <summary>
        /// [严格模式]检查SellerID
        /// <para>不能为null或"",不忽略首尾空格,长度必须是4位，全大写</para>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="ruleBuilder"></param>
        /// <returns></returns>
        public static IRuleBuilderOptions<T, IEnumerable<char>> StrictCheckSellerID<T>(this IRuleBuilder<T, IEnumerable<char>> ruleBuilder)
        {
            return ruleBuilder
                .NotNull()
                .NotEmpty()
                .Must(chars =>
                {
                    if(chars == null)
                    {
                        return false;
                    }

                    string? tempStr = chars as string;
                    if(tempStr == null)
                    {
                        tempStr = new string(tempStr.ToArray());
                    }

                    return CheckSellerIDFormat(tempStr, enableStrictMode: true);
                })
                .WithMessage("SellerId is malformed. Cannot be null or \"\". It must not contain spaces at the beginning and end. It must be 4 digits in length and all words are capitalized.");
        }

        #endregion CheckSellerID

        #region Required

        /// <summary>
        /// 引对引用类型的必填
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TProperty"></typeparam>
        /// <param name="ruleBuilder"></param>
        /// <returns></returns>
        public static IRuleBuilderOptions<T, TProperty> Required<T, TProperty>(this IRuleBuilder<T, TProperty> ruleBuilder)
            where TProperty : class
        {
            return ruleBuilder
                .NotNull()
                .NotEmpty();
        }

        /// <summary>
        /// 针对int类型的必填.值不能为null 0
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="ruleBuilder"></param>
        /// <returns></returns>
        public static IRuleBuilderOptions<T, int> Required<T>(this IRuleBuilder<T, int> ruleBuilder)
        {
            return ruleBuilder.Required(0);//复用值类型的验证方法
        }

        #endregion Required

        #region Predicate

        /// <summary>
        /// 要求集合中的所有元素必须满足指定条件
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TProperty"></typeparam>
        /// <param name="ruleBuilder"></param>
        /// <param name="predicate"></param>
        /// <param name="errorMsg"></param>
        /// <returns></returns>
        public static IRuleBuilderOptions<T, IEnumerable<TProperty>> All<T, TProperty>(
           this IRuleBuilder<T, IEnumerable<TProperty>> ruleBuilder,
           Func<TProperty, bool> predicate,
           string errorMsg)
        {
            return ruleBuilder.Predicate(Enumerable.All, predicate, errorMsg);
        }

        /// <summary>
        /// 要求集合中的所有元素必须满足指定条件
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TProperty"></typeparam>
        /// <param name="ruleBuilder"></param>
        /// <param name="predicate"></param>
        /// <param name="errorMsg"></param>
        /// <returns></returns>
        public static IRuleBuilderOptions<T, IEnumerable<TProperty>> AllNot<T, TProperty>(
           this IRuleBuilder<T, IEnumerable<TProperty>> ruleBuilder,
           Func<TProperty, bool> predicate,
           string errorMsg)
        {
            Func<IEnumerable<TProperty>, Func<TProperty, bool>, bool> allNot = (list, predicater) => !Enumerable.All(list, predicater);

            return ruleBuilder.Predicate(allNot, predicate, errorMsg);
        }

        /// <summary>
        /// 要求集合中的任意元素必须满足指定条件
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TProperty"></typeparam>
        /// <param name="ruleBuilder"></param>
        /// <param name="predicate"></param>
        /// <param name="errorMsg"></param>
        /// <returns></returns>
        public static IRuleBuilderOptions<T, IEnumerable<TProperty>> Any<T, TProperty>(
           this IRuleBuilder<T, IEnumerable<TProperty>> ruleBuilder,
           Func<TProperty, bool> predicate,
           string errorMsg)
        {
            return ruleBuilder.Predicate(Enumerable.Any, predicate, errorMsg);
        }

        #endregion Predicate

        #region CharCase 大小写

        public static IRuleBuilderOptions<T, IEnumerable<char>> AllUpper<T>(
           this IRuleBuilder<T, IEnumerable<char>> ruleBuilder,
           string? errorMsg = null)
        {
            return ruleBuilder.Predicate(
                Enumerable.All,
                char.IsUpper,
                errorMsg ?? "All element must be uppercase");
        }

        public static IRuleBuilderOptions<T, IEnumerable<char>> AnyUpper<T>(
            this IRuleBuilder<T, IEnumerable<char>> ruleBuilder,
            string? errorMsg = null)
        {
            return ruleBuilder.Predicate(
                Enumerable.Any,
                char.IsUpper,
                errorMsg ?? "Any element must be uppercase");
        }

        public static IRuleBuilderOptions<T, IEnumerable<char>> AllLower<T>(
           this IRuleBuilder<T, IEnumerable<char>> ruleBuilder,
           string? errorMsg = null)
        {
            return ruleBuilder.Predicate(
                Enumerable.All,
                char.IsLower,
                errorMsg ?? "All element must be lowercase");
        }

        public static IRuleBuilderOptions<T, IEnumerable<char>> AnyLower<T>(
            this IRuleBuilder<T, IEnumerable<char>> ruleBuilder,
            string? errorMsg = null)
        {
            return ruleBuilder.Predicate(
                Enumerable.Any,
                char.IsLower,
                errorMsg ?? "Any element must be uppercase");
        }

        #endregion CharCase 大小写

        #region 验证器注入

        /// <summary>
        /// 使用服务提供者为属性类型注入默认验证器
        /// </summary>
        /// <example>
        /// <![CDATA[
        ///
        ///  using Microsoft.Extensions.DependencyInjection;
        ///
        ///  base.RuleForEach(a => a.x)
        ///       .InjectValidator(t => t.GetService<XXXXValidator>());
        ///  ]]>
        /// </example>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TProperty"></typeparam>
        /// <param name="ruleBuilder"></param>
        /// <param name="simpCallback"></param>
        /// <param name="ruleSets"></param>
        /// <returns></returns>
        public static IRuleBuilderOptions<T, TProperty> InjectValidator<T, TProperty>(
            this IRuleBuilder<T, TProperty> ruleBuilder,
            Func<IServiceProvider, IValidator<TProperty>> simpCallback,
            params string[] ruleSets)
        {
            Func<IServiceProvider, ValidationContext<T>, IValidator<TProperty>> callback = (services, context) => simpCallback(services);

            return ruleBuilder.InjectValidator(callback, ruleSets);
        }

        #endregion 验证器注入
    }
}