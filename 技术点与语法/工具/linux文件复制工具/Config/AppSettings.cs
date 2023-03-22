using Newtonsoft.Json;

namespace FileCopy
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
        /// 文件大小
        /// </summary>
        [JsonProperty("fileSizeLimit")]
        public int FileSizeLimit { get; set; }

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
    }
}