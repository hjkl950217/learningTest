using Newtonsoft.Json;

namespace linux文件复制工具
{
    public class AppSettings
    {
        /// <summary>
        /// 源地址-完整地址
        /// </summary>
        [JsonProperty("source")]
        public string Source { get; set; }

        /// <summary>
        /// 目标地址-完整地址
        /// </summary>
        [JsonProperty("target")]
        public string Target { get; set; }

        /// <summary>
        /// 最小文件限制（M）
        /// </summary>
        [JsonProperty("minFileSizeLimit")]
        public int MinFileSizeLimit { get; set; }

        /// <summary>
        /// 最大文件限制（M）
        /// </summary>
        [JsonProperty("maxFileSizeLimit")]
        public int MaxFileSizeLimit { get; set; }

        /// <summary>
        /// 时间点，大于这个时间节点的数据不会被复制
        /// </summary>
        [JsonProperty("timeLimit")]
        public DateTime? TimeLimit { get; set; }

        /// <summary>
        /// 允许复制的后缀名
        /// </summary>
        [JsonProperty("allowedExtensions")]
        public string[] AllowedExtensions { get; set; }

        /// <summary>
        /// 排除地址
        /// </summary>
        [JsonProperty("excludeAddrs")]
        public string[] ExcludeAddrs { get; set; }
    }
}