using AspectCore.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using 动态添加Attribute2;

namespace 动态添加Attribute
{
    internal class Program
    {
        private static void Main(string[] args)
        {
           

            var di = new ServiceCollection()
             .AddSingleton<TestInterface, TestClass>()
             .AddDynamicProxy()
             .BuildAspectCoreServiceProvider();//编译


     
            TestInterface testInterface = di.GetService<TestInterface>();



            TypeDescriptor.AddAttributes(typeof(TestInterface), new TestAttribute());
            AttributeCollection collection = TypeDescriptor.GetAttributes(typeof(TestInterface));
            TestAttribute attr = ((TestAttribute)collection[typeof(TestAttribute)]);

            Type temp = testInterface.GetType();


            Assembly[] allAssembly = AppDomain.CurrentDomain.GetAssemblies();
            Assembly tragetAssembly = allAssembly
                .FirstOrDefault(t => t.FullName.Contains("动态添加Attribute2"));

            IEnumerable<Type> results = from type in tragetAssembly.GetTypes()
                                        where type.IsInterface == true
                                        select type;

            var resultAttr = (from type in tragetAssembly.GetTypes()
                              where type.FullName.Contains("动态添加Attribute2")
                              select type.GetCustomAttributes<TestAttribute>().ToList()
                             )
                             .ToList();

            testInterface.AddName("");

            Console.WriteLine("运行完成");
            Console.ReadLine();
        }
    }
}