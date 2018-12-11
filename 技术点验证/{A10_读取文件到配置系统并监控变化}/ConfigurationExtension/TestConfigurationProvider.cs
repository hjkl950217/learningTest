using Microsoft.Extensions.Configuration;

namespace 技术点验证
{
    public class TestConfigurationProvider : ConfigurationProvider
    {
        /// <summary>
        /// 配置源-代表具体配置
        /// </summary>
        public IConfigurationSource ConfigurationSource { get; set; }

        public TestConfigurationProvider(IConfigurationSource configurationSource)
        {
            this.ConfigurationSource = configurationSource;
        }

        public override void Load()
        {
           //读取配置文件并加载
        }

        public override void Set(string key, string value)
        {
            //调用父类方法，走配置系统的流程更新配置
            base.Set(key, value);

            //调用其它方法，更新配置文件
        }

        public override bool TryGet(string key, out string value)
        {
            /*
             *
             * 在测试中其实不需要，
             * 因为数据源是本地文件。文件改变的时候直接会调回调方法更新数据
             *
             * 但数据源在远端的时候，就需要先判断是不是在内存中，然后再判断是不是在远端了
             *
             */

            return base.TryGet(key, out value);
        }
    }
}