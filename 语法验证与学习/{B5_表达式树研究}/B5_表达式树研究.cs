using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Verification.Core;

namespace 语法验证与学习
{
    public class B5_表达式树研究 : IVerification
    {
        public VerificationTypeEnum VerificationType => VerificationTypeEnum.B5_表达式树研究;

        public void Start(string[] args)
        {
            //定义演示的集合
            this.DemoList = new List<Action>();

            this.DemoList.AddRange(new Action[]
            {
                this.Demo1,this.Demo2,this.Demo3,this.Demo4,this.Demo5
            });

            //批量执行
            foreach (var item in this.DemoList)
            {
                item();
                Console.WriteLine("--------------------------------");
                Console.WriteLine();
            }
        }

        public List<Action> DemoList { get; set; }

        public void Demo1()
        {
            Console.WriteLine("演示1-最简单的表达式");

            Expression firstArg = Expression.Constant(2);//这是常量表达式
            Expression secondArg = Expression.Constant(4);

            Expression add = Expression.Add(firstArg, secondArg);//这是二进制表达式

            Console.WriteLine(add.ToString());
        }

        public void Demo2()
        {
            Console.WriteLine("演示2-将表达式编译成委托");

            Expression firstArg = Expression.Constant(2);
            Expression secondArg = Expression.Constant(4);
            Expression add = Expression.Add(firstArg, secondArg);

            Expression<Func<int>> func = Expression.Lambda<Func<int>>(add);

            Console.WriteLine(func);
            Console.WriteLine(func.Compile());
            Console.WriteLine("结果：" + func.Compile()());
        }

        public void Demo3()
        {
            Console.WriteLine("演示3-将Lamda表达式转换成表达树");

            Expression<Func<int>> return5 = () => 5;

            Console.WriteLine(return5);
            Console.WriteLine(return5.Compile());
            Console.WriteLine(return5.Compile()());
        }

        public void Demo4()
        {
            Console.WriteLine("演示4-Lambda表达式转换为Expression");

            Expression<Func<int, int>> expr = x => x + 10;
            Console.WriteLine(expr.ToString());

            var lambdaExpr = expr as LambdaExpression;
            Console.WriteLine(lambdaExpr.Body);   // (x + 1)
            Console.WriteLine("返回值类型:" + lambdaExpr.ReturnType.ToString());  // System.Int32
            Console.WriteLine("第一个参数类型:" + lambdaExpr.Parameters[0].Name + "    " + lambdaExpr.Parameters[0].Type.Name);
        }

        public void Demo5()
        {
            Console.WriteLine("演示5-Lambda表达式转换为Expression");
        }
    }
}