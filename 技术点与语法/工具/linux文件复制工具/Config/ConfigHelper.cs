using Newtonsoft.Json;

namespace FileCopy.Config
{
    public static class ConfigHelper
    {
        public static AppSettings appSettings = null;

        public static AppSettings GetConfig()
        {
            if(appSettings == null)
            {
                // 读取 JSON 配置文件
                string json = File.ReadAllText("config.json");

                // 解析 JSON 文件
                AppSettings settings = JsonConvert.DeserializeObject<AppSettings>(json);
                appSettings = settings;
            }

            return appSettings;
        }
    }
}