using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Verification.Core;

namespace 技术点验证
{
    /*
     * 需要
     * Microsoft.Extensions.Configuration
     * Microsoft.Extensions.DependencyInjection
     * 
     */

    public class A10_读取文件到配置系统并监控变化 : IVerification
    {
        public VerificationTypeEnum VerificationType => 
            VerificationTypeEnum.A10_读取文件到配置系统并监控变化;

        private const string testFile = "testA10.json";

        public void Start(string[] args)
        {
            IConfiguration configuration = new ConfigurationBuilder()
                //IConfiguration在构建webhost的时候就确定了
              
                .Build();
                



            IServiceCollection services = new ServiceCollection();
            services.AddSingleton(configuration);

            //后面要模拟从IOC中获取对象并能监控的场景

        }
    }
}
