using Newtonsoft.Json;

namespace linux文件复制工具.BaseTool.Config
{
    public static class ConfigHelper
    {
        public static AppSettings appSettings = null;
        public static string ConfigPath = "config.json";

        public static AppSettings GetConfig()
        {
            if(appSettings == null)
            {
                // 如果配置文件不存在，则创建默认配置文件
                if(!File.Exists(ConfigPath))
                {
                    appSettings = new AppSettings();
                    appSettings.TryInitDefaultConfig();
                    string jsonContent = JsonConvert.SerializeObject(appSettings, Formatting.Indented);
                    File.WriteAllText(ConfigPath, jsonContent);
                    return appSettings;
                }

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