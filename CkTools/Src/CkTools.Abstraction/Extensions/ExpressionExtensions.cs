using System.Collections.Generic;

namespace System.Linq.Expressions
{
    /// <summary>
    /// 表达式帮助类
    /// </summary>
    public static class ExpressionExtensions
    {
        /// <summary>
        /// 创建一个访问属性的表达式
        /// </summary>
        /// <param name="expression">表达式</param>
        /// <param name="propertyName">属性名称</param>
        /// <returns></returns>
        public static Expression Property(this Expression expression, string propertyName)
        {
            return Expression.Property(expression, propertyName);
        }

        /// <summary>
        /// 条件表达式且（第一个true才执行第二个）
        /// </summary>
        /// <param name="left">左表达式</param>
        /// <param name="right">右表达式</param>
        /// <returns></returns>
        public static Expression AndAlso(this Expression left, Expression right)
        {
            return Expression.AndAlso(left, right);
        }

        /// <summary>
        /// 创建一个回调带有参数方法的表达式
        /// </summary>
        /// <param name="instance">表达式</param>
        /// <param name="methodName">方法名字</param>
        /// <param name="arguments">参数</param>
        /// <returns></returns>
        public static Expression Call(this Expression instance, string methodName, params Expression[] arguments)
        {
            return Expression.Call(instance, instance.Type.GetMethod(methodName), arguments);
        }

        /// <summary>
        /// 创建一个比较表达式
        /// </summary>
        /// <param name="left">左表达式</param>
        /// <param name="right">右表达式</param>
        /// <returns></returns>
        public static Expression GreaterThan(this Expression left, Expression right)
        {
            return Expression.GreaterThan(left, right);
        }

        /// <summary>
        /// Lambda表达式
        /// </summary>
        /// <typeparam name="T">类型</typeparam>
        /// <param name="body">表达式</param>
        /// <param name="parameters">参数</param>
        /// <returns></returns>
        public static Expression<T> ToLambda<T>(this Expression body, params ParameterExpression[] parameters)
        {
            return Expression.Lambda<T>(body, parameters);
        }

        /// <summary>
        /// Lambda(真)
        /// </summary>
        /// <typeparam name="T">类型</typeparam>
        /// <returns></returns>
        public static Expression<Func<T, bool>> True<T>()
        { return param => true; }

        /// <summary>
        /// Lambda（假）
        /// </summary>
        /// <typeparam name="T">类型</typeparam>
        /// <returns></returns>
        public static Expression<Func<T, bool>> False<T>()
        { return param => false; }

        /// <summary>
        /// 组合And
        /// </summary>
        /// <returns></returns>
        public static Expression<Func<T, bool>> And<T>(
            this Expression<Func<T, bool>> first,
            Expression<Func<T, bool>> second)
        {
            return first.Compose(second, Expression.AndAlso);
        }

        /// <summary>
        /// 组合Or
        /// </summary>
        /// <returns></returns>
        public static Expression<Func<T, bool>> Or<T>(
            this Expression<Func<T, bool>> first,
            Expression<Func<T, bool>> second)
        {
            return first.Compose(second, Expression.OrElse);
        }

        /// <summary>
        /// 使用指定的合并函数将第一个表达式与第二个表达式合并。
        /// </summary>
        public static Expression<T> Compose<T>(
            this Expression<T> first,
            Expression<T> second,
            Func<Expression, Expression, Expression> merge)
        {
            Dictionary<ParameterExpression, ParameterExpression>? map = first.Parameters
                .Select((f, i) => new
                {
                    f,
                    s = second.Parameters[i]
                })
                .ToDictionary(p => p.s, p => p.f);

            Expression? secondBody = ParameterRebinder.ReplaceParameters(map, second.Body);
            return Expression.Lambda<T>(
                merge(first.Body, secondBody),
                first.Parameters);
        }

        #region 参数重新绑定器

        /// <summary>
        /// 参数重新绑定器
        /// </summary>
        private class ParameterRebinder : ExpressionVisitor
        {
            /// <summary>
            /// The ParameterExpression map
            /// </summary>
            private readonly Dictionary<ParameterExpression, ParameterExpression> map;

            /// <summary>
            /// Initializes a new instance of the <see cref="ParameterRebinder"/> class.
            /// </summary>
            /// <param name="map">The map.</param>
            private ParameterRebinder(Dictionary<ParameterExpression, ParameterExpression> map)
            {
                this.map = map ?? new Dictionary<ParameterExpression, ParameterExpression>();
            }

            /// <summary>
            ///替换参数
            /// </summary>
            /// <param name="map">The map.</param>
            /// <param name="exp">The exp.</param>
            /// <returns>Expression</returns>
            public static Expression ReplaceParameters(
                Dictionary<ParameterExpression, ParameterExpression> map,
                Expression exp)
            {
                return new ParameterRebinder(map).Visit(exp);
            }

            /// <summary>
            /// Visits the parameter.
            /// </summary>
            /// <param name="p">The p.</param>
            /// <returns>Expression</returns>
            protected override Expression VisitParameter(ParameterExpression p)
            {
                if(this.map.TryGetValue(p, out ParameterExpression replacement))
                {
                    p = replacement;
                }
                return base.VisitParameter(p);
            }
        }

        #endregion 参数重新绑定器
    }
}