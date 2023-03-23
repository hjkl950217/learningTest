using FileCopy.Config;
using Newtonsoft.Json;

namespace FileCopy
{
    public class Program
    {
        private const string separatorMsg = "==============================";

        public static void Main(string[] args)
        {
            #region 读取配置

            AppSettings settings = ConfigHelper.GetConfig();

            string sourceDir = settings.Source;
            string targetDir = settings.Target;
            long fileSizeLimit = settings.FileSizeLimit * 1024 * 1024;
            DateTime timeLimit = settings.TimeLimit ?? DateTime.MinValue;
            string[] allowedExtensions = settings.AllowedExtensions ?? Array.Empty<string>();

            #endregion 读取配置

            #region 准备日志相关

            DateTime lastModifiedTime = DateTime.MinValue; // 定义最新复制文件的修改时间
            DateTime now = DateTime.Now;//定义当前时间

            #endregion 准备日志相关

            #region 复制文件

            int count = 0;
            foreach(string sourceFilePath in Directory.GetFiles(sourceDir))
            {
                string fileName = Path.GetFileName(sourceFilePath);

                #region 条件判断

                // 判断是否为允许的文件后缀，如果不是则跳过
                string extension = Path.GetExtension(fileName).TrimStart('.');
                if(allowedExtensions.Length > 0 && !allowedExtensions.Contains(extension))
                {
                    string message = $"文件 {fileName} 不是允许的文件后缀，跳过复制";
                    LogHelper.WriteLog(message, now);
                    continue;
                }

                // 判断目标地址下是否已经存在同名文件，如果存在则跳过该文件
                string targetFilePath = Path.Combine(targetDir, fileName);
                if(File.Exists(targetFilePath))
                {
                    string message = $"文件 {fileName} 已经存在于目标地址，跳过复制";
                    LogHelper.WriteLog(message, now);
                    continue;
                }

                // 判断文件大小是否小于限制，如果小于则跳过该文件
                FileInfo fileInfo = new(sourceFilePath);
                long fileSize = fileInfo.Length;
                if(fileSize < fileSizeLimit)
                {
                    string message = $"文件 {fileName} 小于限制大小，跳过复制";
                    LogHelper.WriteLog(message, now);
                    continue;
                }

                // 判断文件修改时间是否晚于限制，如果晚于则进行复制
                DateTime lastWriteTime = fileInfo.LastWriteTime;
                if(lastWriteTime <= timeLimit)
                {
                    string message = $"文件 {fileName} 修改时间早于限制时间，跳过复制";
                    LogHelper.WriteLog(message, now);
                    continue;
                }

                #endregion 条件判断

                //复制
                File.Copy(sourceFilePath, targetFilePath);
                count++;

                #region 复制后

                string successMessage = $"成功复制文件 {fileName}";
                LogHelper.WriteLog(successMessage, now);

                // 更新最新复制文件的修改时间为当前文件的修改时间
                if(lastModifiedTime < lastWriteTime)
                {
                    lastModifiedTime = lastWriteTime;
                }

                #endregion 复制后
            }

            #endregion 复制文件

            #region 复制后的处理

            // 如果成功复制过文件，则更新配置文件中的修改时间
            if(lastModifiedTime != DateTime.MinValue)
            {
                settings.TimeLimit = lastModifiedTime;
                string updatedJson = JsonConvert.SerializeObject(settings, Formatting.Indented);
                File.WriteAllText("config.json", updatedJson);

                string updateTimeMessage = $"复制完成，成功更新{count}个文件,成功更新配置文件，最新修改时间为 {lastModifiedTime}";
                LogHelper.WriteLog(updateTimeMessage, now);
            }

            LogHelper.WriteLog(separatorMsg, now); //输出分割符

            #endregion 复制后的处理
        }
    }
}