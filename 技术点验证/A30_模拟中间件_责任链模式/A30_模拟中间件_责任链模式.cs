using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AspectCore.DynamicProxy.Parameters;
using Microsoft.AspNetCore.Http;
using Verification.Core;

namespace 技术点验证
{
    [VerifcationType(VerificationTypeEnum.A30_模拟中间件_责任链模式)]
    public class A30_模拟中间件_责任链模式 : IVerification
    {
        public void Start(string[] args)
        {
            ApplicationBuilder application = new ApplicationBuilder();

            application.Use(async (context, next) =>
            {
                Console.WriteLine("进入第1个中间件");
                await next();
                Console.WriteLine("离开第1个中间件");
            });

            application.Use(async (context, next) =>
            {
                Console.WriteLine("进入第2个中间件");
                await next();
                Console.WriteLine("离开第2个中间件");
            });

            application.Run(context => { Console.WriteLine("进入末尾中间件"); });

            var mockPipe = application.Build();

            mockPipe.Invoke(new MockHttpContext());
        }
    }

    public class MockHttpContext
    {
    }

    public delegate Task MockRequestDelegate(MockHttpContext context);

    public class ApplicationBuilder
    {
        private readonly IList<Func<MockRequestDelegate, MockRequestDelegate>> components = new List<Func<MockRequestDelegate, MockRequestDelegate>>();

        public ApplicationBuilder Use(Func<MockRequestDelegate, MockRequestDelegate> component)
        {
            this.components.Add(component);
            return this;
        }

        public ApplicationBuilder Use([NotNull] Func<MockHttpContext, Func<Task>, Task> component)
        {
            return this.Use(next => context => component(context, () => next(context)));
        }

        public ApplicationBuilder Run(Func<MockHttpContext, Task> component)
        {
            return this.Use(next => context => component(context));
        }

        public ApplicationBuilder Run([NotNull]Action<MockHttpContext> component)
        {
            return this.Use(next => context =>
            {
                component(context);
                return Task.CompletedTask;
            });
        }

        public MockRequestDelegate Build()
        {
            MockRequestDelegate result = context => Task.CompletedTask;

            foreach (var item in this.components.Reverse())
            {
                result = item(result);
            }
            return result;
        }
    }
}