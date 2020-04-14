using System;

namespace 技术点验证
{
    public interface IApplicationBuilder
    {
        MockRequestDelegate Build();

        ApplicationBuilder Use(Func<MockRequestDelegate, MockRequestDelegate> inlineDelegate);
    }
}