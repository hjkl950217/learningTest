using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Primitives;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace 技术点验证
{
    public class TestConfigurationProvider : ConfigurationProvider
    {
        /// <summary>
        /// 配置源-代表具体配置
        /// </summary>
        public TestConfigurationSource ConfigurationSource { get; set; }

        public IFileProvider FileProvider { get; set; }

        public TestConfigurationProvider(TestConfigurationSource configurationSource)
        {
            this.ConfigurationSource = configurationSource;

            //设置一个目录映射
            this.FileProvider = new PhysicalFileProvider(this.ConfigurationSource.ConfigFileFullName);

            //注册改变时的事件
            if (configurationSource.ReloadOnChange == true)//配置时说不监控，则不注册了
            {
                ChangeToken.OnChange(
                    () => this.FileProvider.Watch(this.ConfigurationSource.ConfigFileFullName),
                    () => this.Load());

                /*
                 *  ChangeToken只是传递数据被改变这样的消息
                 *
                 * 消息产生后，程序怎么处理它是不管的，所以需要自己再读取一次
                 *
                 */
            }
        }

        public override void Load()
        {
            //获取最新的配置数据
            Stream fileStream = this.FileProvider.GetFileInfo(this.ConfigurationSource.ConfigFileFullName)
               .CreateReadStream();

            var newDate = this.ReadData(fileStream);

            foreach (var item in newDate)
            {
                if (base.Data.ContainsKey(item.Key))//存在则更新
                {
                    base.Data[item.Key] = item.Key;
                }
                else//不存在则新加
                {
                    base.Data.Add(item.Key, item.Value);
                }

            }


        }

        /// <summary>
        /// 从流中读取数据
        /// </summary>
        /// <param name="stream"></param>
        /// <returns></returns>
        private IDictionary<string, string> ReadData(Stream stream)
        {
            StreamReader reader = new StreamReader(stream, Encoding.UTF8);
            string result = reader.ReadToEnd();

            reader.Close();
            stream.Close();

            return JsonConvert.DeserializeObject<Dictionary<string, string>>(result);
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