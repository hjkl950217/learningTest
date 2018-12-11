using Microsoft.Extensions.Configuration;
using System;

namespace 技术点验证
{
    public class TestConfigurationSource : IConfigurationSource
    {
        public TestConfigurationSource(string configFileFullName, bool reloadOnChange = true)
        {
            this.ConfigFileFullName = configFileFullName;
            this.ReloadOnChange = reloadOnChange;
        }

        /// <summary>
        /// 是否是可选配置
        /// </summary>
        public bool Optional { get => false; }

        /// <summary>
        /// 配置文件的全名
        /// </summary>
        public string ConfigFileFullName { get; set; }

        /// <summary>
        /// 配置发生改变时，是否更改程序中的配置
        /// </summary>
        public bool ReloadOnChange { get; set; }

        /// <summary>
        /// 构建配置提供器
        /// </summary>
        /// <param name="builder"></param>
        /// <returns></returns>
        public IConfigurationProvider Build(IConfigurationBuilder builder)
        {
            return new TestConfigurationProvider(this);
        }
    }
}