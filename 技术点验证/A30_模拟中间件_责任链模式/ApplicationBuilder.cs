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
    public class ApplicationBuilder : IApplicationBuilder
    {
        private readonly IList<Func<MockRequestDelegate, MockRequestDelegate>> inlineDelegates = new List<Func<MockRequestDelegate, MockRequestDelegate>>();

        public ApplicationBuilder Use(Func<MockRequestDelegate, MockRequestDelegate> inlineDelegate)
        {
            this.inlineDelegates.Add(inlineDelegate);
            return this;
        }

        public MockRequestDelegate Build()
        {
            MockRequestDelegate result = context => Task.CompletedTask;

            foreach (var item in this.inlineDelegates.Reverse())
            {
                result = item(result);
            }
            return result;
        }
    }
}