using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace 技术点验证
{
  public static  class TestConfigurationExtension
    {
        /// <summary>
        /// 添加测试配置
        /// </summary>
        /// <param name="configurationBuilder"></param>
        /// <param name="configFileName"></param>
        /// <param name="reloadOnChange"></param>
        /// <returns></returns>
        public static IConfigurationBuilder AddTestConfiguration(
            this IConfigurationBuilder configurationBuilder,
            string configFileName ,
            bool reloadOnChange=false
            )
        {
            IConfigurationSource testConfigurationSource = new TestConfigurationSource(
                configFileName, 
                reloadOnChange);

            configurationBuilder.Add(testConfigurationSource);//添加一个配置源

            return configurationBuilder;
        }

    }
}
