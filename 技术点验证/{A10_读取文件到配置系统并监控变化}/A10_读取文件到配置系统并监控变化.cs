using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Verification.Core;

namespace 技术点验证
{
    public class A10_读取文件到配置系统并监控变化 : IVerification
    {
        public VerificationTypeEnum VerificationType => 
            VerificationTypeEnum.A10_读取文件到配置系统并监控变化;

        private const string testFile = "testA10.json";

        public void Start(string[] args)
        {
            IServiceCollection services = new ServiceCollection();
        }
    }
}
