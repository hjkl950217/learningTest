using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Linq;
using Test.DB;

namespace Test
{
    public class ServiceCode
    {
        private readonly ConfluenceContext confluenceContext;
        private readonly JiraContext jiraContext;
        private readonly ILogger logger;

        public ServiceCode(
            ConfluenceContext confluenceContext,
              JiraContext jiraContext,
            ILoggerFactory loggerFactory)
        {
            this.confluenceContext = confluenceContext;
            this.jiraContext = jiraContext;
            this.logger = loggerFactory.CreateLogger("EF-Demo");
        }

        public void Run()
        {
            Console.WriteLine("开始运行");

          var test=  this.confluenceContext.CwdUser
                .AsNoTracking()
               // .Take(2)
                .FirstOrDefault();
            this.logger.LogInformation(test.ToJson());

            Console.WriteLine("运行结束");
            Console.ReadLine();
        }
    }

    //显示测试结果用的
    public static class Extensions
    {
        private static JsonSerializerSettings jsonSerializerSettings = new JsonSerializerSettings()
        {
            Formatting = Formatting.Indented,
            ReferenceLoopHandling = ReferenceLoopHandling.Ignore
        };

        public static string ToJson<T>(this T obj)
        {
            return JsonConvert.SerializeObject(obj, jsonSerializerSettings);
        }
    }
}