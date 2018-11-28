using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
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
                this.Demo1,this.Demo2,this.Demo3,this.Demo4,this.Demo5,
                this.Demo6,
                this.DemoEnd
            });

            //批量执行
            foreach (var item in this.DemoList)
            {
                item();//执行示例的委托
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
            Console.WriteLine("演示5-打印Lambda表达式第一个行参的名称");
            Console.WriteLine("如果没显示内容说明代码不正确");

            Expression<Func<int, int>> addFunc = num => num + 5;

            if (addFunc.NodeType == ExpressionType.Lambda)
            {
                LambdaExpression lambdaExp = addFunc as LambdaExpression;
                IReadOnlyList<ParameterExpression> paraList = lambdaExp.Parameters;

                if (paraList != null)
                {
                    Console.WriteLine("形参名： " + paraList[0].Name);
                    Console.WriteLine("形参类型： " + paraList[0].Type.Name);
                }
            }
        }

        public void Demo6()
        {
            Console.WriteLine("演示6-翻译表达式");
            Console.WriteLine("如果没显示内容说明代码不正确");
            Console.WriteLine();

            StringBuilder showTxt = new StringBuilder();

            //翻译基本信息
            Expression<Func<int, int>> sum = num => num + 5;
            showTxt.AppendLine($"根节点的节点类型是:{sum.NodeType}");
            showTxt.AppendLine($"根节点的类型是:{sum.Type.Name}");
            showTxt.AppendLine($"根节点的名字是:{sum.Name}");
            showTxt.AppendLine($"根节点的代码是:{sum.ToString()}");
            showTxt.AppendLine();

            //翻译形参
            showTxt.AppendLine($@"表达式的形参有:{sum.Parameters.Count}个,");
            foreach (var item in sum.Parameters)
            {
                showTxt.Append($"节点的节点类型是:{sum.Parameters[0].NodeType},");
                showTxt.Append($"类型是:{sum.Parameters[0].Type.Name},");
                showTxt.Append($"参数的名字是:{sum.Parameters[0]}");
                showTxt.AppendLine();
                showTxt.AppendLine();
            }

            //翻译主体
            var sumBody = sum.Body as BinaryExpression;
            showTxt.AppendLine($"主体节点的节点类型是:{sumBody.NodeType}");
            showTxt.AppendLine($"主体节点代码:{sumBody.ToString()}");
            showTxt.AppendLine();

            //翻译左节点
            var leftNode = sumBody.Left as ParameterExpression;
            showTxt.AppendLine($"主体左节点的节点类型是:{leftNode.NodeType}");
            showTxt.AppendLine($"主体左节点的类型是：{leftNode.Type.Name}");
            showTxt.Append($"主体左节点的名字是:{leftNode.Name}");
            showTxt.AppendLine();
            showTxt.AppendLine();

            //翻译右节点
            var rightNode = sumBody.Left as ParameterExpression;
            showTxt.AppendLine($"主体右节点的节点类型是:{rightNode.NodeType}");
            showTxt.AppendLine($"主体右节点的类型是：{rightNode.Type.Name}");
            showTxt.Append($"主体右节点的名字是:{rightNode.Name}");
            showTxt.AppendLine();
            showTxt.AppendLine();

            Console.WriteLine(showTxt.ToString());
        }

        public void DemoEnd()
        {
        }
    }
}