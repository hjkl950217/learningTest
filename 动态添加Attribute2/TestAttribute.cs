using AspectCore.DynamicProxy;
using System;
using System.Threading.Tasks;

namespace 动态添加Attribute2
{
    public class TestAttribute : AbstractInterceptorAttribute
    {
        /// <summary>
        /// 测试用的Name
        /// </summary>
        public string Name { get; set; }

        public override async Task Invoke(AspectContext context, AspectDelegate next)
        {
            try
            {
                Console.WriteLine($"触发了-{this.Name}");
                await next(context);
            }
            catch(Exception ex)
            {
                throw;
            }
        }

        //public TestAttribute(string name)
        //{
        //    this.Name = name;
        //}
    }
}