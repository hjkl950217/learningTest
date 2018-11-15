using AspectCore.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using Verification.Core;

namespace 技术点验证
{
    // 用到了AspectCore.Extensions.DependencyInjection

    public class A7_动态添加Attribute : IVerification
    {
        public VerificationTypeEnum VerificationType => VerificationTypeEnum.A7_动态添加Attribute;

        public void Start(string[] args)
        {
            var di = new ServiceCollection()
             .AddSingleton<TestInterface, TestClass>()
             .AddDynamicProxy()
             .BuildDynamicProxyServiceProvider();//编译

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