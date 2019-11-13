using System;
using System.Linq.Expressions;
using Verification.Core;

namespace 语法验证与学习
{
    public class B11_表达式树修改 : IVerification
    {
        public VerificationTypeEnum VerificationType => VerificationTypeEnum.B11_表达式树修改;

        public void Start(string[] args)
        {
			//https://www.cnblogs.com/snailblog/p/11521359.html
            Expression<Func<int, int, int>> func = (x, y) => x + y;
            Expression<Func<int, Func<int, int>>> func2 = x => y => x + y;

            Console.WriteLine($"func1:  {func.ToString()}");
            Console.WriteLine($"func2:  {func2.ToString()}");

            var t = new Binary_ChangeType().Chage(func.Body, ExpressionType.Subtract);

            var t2 = t as BinaryExpression;

            //  Expression result1 = this.ChangeGreaterThanToSubtraction(func);
            //  Console.WriteLine($"result1:  {result1.ToString()}");
        }

        //将大于修改为减
        //public Expression ChangeGreaterThanToSubtraction(Expression expression)
        //{
        // //   return new Binary_ChangeType().Chage(expression, ExpressionType.Subtract);
        //}
    }
}