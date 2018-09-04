using System;
using System.Drawing;

namespace CSharp语法学习
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("示例启动！");
            Console.WriteLine();

            new Demo().Run();

            Console.WriteLine();
            Console.WriteLine("示例执行完成！");
            Console.ReadLine();
        }

        /*
         * 语法说明...
         *
         * 对方法上添加in关键字的示例
         *
         */
    }

    public class Demo
    {
        /// <summary>
        /// 初始化数据
        /// </summary>
        public Demo()
        {
        }

        /// <summary>
        /// 代替Main方法，使用非静态方式
        /// </summary>
        public void Run()
        {
            this.ValueReference(new Point(10 , 200));
            Console.WriteLine();
            this.ObjectReference(new TestStu() { ID = "10" });
        }

        public Point ValueReference(in Point point)
        {
            //这里对任何struct值的修改，写完代码就会报错
            Console.WriteLine($"原始Point X:{point.X}\t原始Point Y:{point.Y}");
            Console.WriteLine($"原始code:{ point.GetHashCode()}");

            //输出不同方式获得的数据的哈西值
            Point testPoint = point;
            Console.WriteLine($"赋值后code:{ testPoint.GetHashCode()}");
            //Console.WriteLine(testPoint.Equals());

            Point newPoint = new Point() { X = point.X , Y = point.Y };//这里看起来new了 其实哈西值后上面一样的
            Console.WriteLine($"new 1后code:{ newPoint.GetHashCode()}");

            Point newPoint2 = new Point() { X = point.X , Y = point.Y+100 };
            Console.WriteLine($"new 2后code:{ newPoint2.GetHashCode()}");



            //经过模拟处理后的值（只能读取，因为修改不了值）
            Console.WriteLine($"处理后Point X:{point.X}\t处理后Point Y:{point.Y}");
            return point;
        }

        public TestStu ObjectReference(in TestStu point)
        {
            Console.WriteLine($"原始TestStu ID:{point.ID}\t原始TestStu Name:{point.Name}");

            point.ID = "AAAA";
            point.Name = "new Name";

            //这里修改不了point的引用。如果直接 point = new TestStu();写完就会报错

            Console.WriteLine($"处理后TestStu ID:{point.ID}\t处理后TestStu Name:{point.Name}");

            return point;
        }
    }

    public class TestStu
    {
        public string ID { get; set; }
        public string Name { get; set; }
    }
}