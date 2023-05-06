using System.Diagnostics;
using FileCopy.Config;
using Newtonsoft.Json;

namespace FileCopy
{
    public class Program
    {
        private const string separatorMsg = "==============================";

        // 发布命令
        // dotnet publish -c Release -r linux-x64 --self-contained -p:PublishReadyToRun=true -p:PublishSingleFile=true

        public static void Main(string[] args)
        {
            //string addr = @"C:\Users\2A023\Desktop\Sf\f1\f2\f3\vide1.mp4";

            //// 设置最后修改时间为当前时间
            //File.SetCreationTime(addr, DateTime.Now.AddDays(-20));

            //return;

            #region 读取配置

            AppSettings settings = ConfigHelper.GetConfig();

            string sourceDir = settings.Source;
            string targetDir = settings.Target;
            long fileSizeLimit = settings.FileSizeLimit * 1024 * 1024;
            DateTime timeLimit = settings.TimeLimit ?? DateTime.MinValue;
            string[] allowedExtensions = settings.AllowedExtensions ?? Array.Empty<string>();
            string[] excludeAddrs = settings.ExcludeAddrs ?? Array.Empty<string>();

            #endregion 读取配置

            #region 准备日志相关

            DateTime lastModifiedTime = DateTime.MinValue; // 定义最新复制文件的修改时间
            DateTime now = DateTime.Now;//定义当前时间

            LogHelper.WriteLog(separatorMsg, now); //输出分割符
            LogHelper.WriteLog($"当前最新复制时间:{timeLimit:yyyy-MM-dd HH:mm:ss}", now);

            #endregion 准备日志相关

            #region 复制文件

            int count = 0;
            Stopwatch stopwatch = Stopwatch.StartNew();
            string[] fileNameArray = Directory.GetFiles(sourceDir, "*.*", SearchOption.AllDirectories);
            foreach(string sourceFilePath in fileNameArray)
            {
                FileInfo sourceFileInfo = new(sourceFilePath);
                // string sourceFileName = Path.GetFileName(sourceFilePath);

                string sourceFolderPath = Path.GetDirectoryName(sourceFilePath);
                DirectoryInfo sourceFolderInfo = new DirectoryInfo(sourceFolderPath);

                string targetFilePath = Path.Combine(targetDir, sourceFileInfo.Name);
                FileInfo targetFileInfo = new(targetFilePath);

                #region 条件判断

                // 判断是否为排除地址，如果不是则跳过
                if(excludeAddrs.Any(t => sourceFilePath.Contains(t)))
                {
                    //string message = $"文件 {sourceFileInfo.Name} 在排除文件夹中，跳过复制";
                    //LogHelper.WriteLog(message, now);
                    continue;
                }

                // 判断是否为允许的文件后缀，如果不是则跳过
                string extension = sourceFileInfo.Extension
                    .TrimStart('.')
                    .ToLower();
                if(allowedExtensions.Length > 0 && !allowedExtensions.Contains(extension))
                {
                    //string message = $"文件 {sourceFileInfo.Name} 不是允许的文件后缀，跳过复制";
                    //LogHelper.WriteLog(message, now);
                    continue;
                }

                // 判断目标地址下是否已经存在同名文件，如果存在则跳过该文件
                if(File.Exists(targetFilePath))
                {
                    if(targetFileInfo.Length == sourceFileInfo.Length)
                    {
                        //string message = $"文件 {sourceFileInfo.Name} 已经存在于目标地址，跳过复制";
                        //LogHelper.WriteLog(message, now);
                        continue;
                    }

                    //遇到同名但长度不一样的文件，需要重命名后计算
                    targetFilePath = Path.Combine(targetDir, sourceFileInfo.GetMD5Name());
                    if(File.Exists(targetFilePath))
                    {
                        //string message = $"文件 {sourceFileInfo.GetMD5Name()} 已经存在于目标地址，跳过复制";
                        //LogHelper.WriteLog(message, now);
                        continue;
                    }
                    else
                    {
                        targetFileInfo = new(targetFilePath);
                    }
                }

                // 判断文件大小是否小于限制，如果小于则跳过该文件
                long sourceFileSize = sourceFileInfo.Length;
                if(sourceFileSize < fileSizeLimit)
                {
                    //string message = $"文件 {sourceFileInfo.Name} 小于限制大小，跳过复制";
                    //LogHelper.WriteLog(message, now);
                    continue;
                }

                // 判断文件修改时间是否比限制时间新，如果新则进行复制
                DateTime lastTime = new DateTime[]
                {
                    sourceFolderInfo.LastAccessTime,
                    sourceFileInfo.LastWriteTime
                }
                .OrderByDescending(t => t)
                .First();
                if(lastTime <= timeLimit)
                {
                    //string message = $"文件 {sourceFileInfo.Name} 修改时间早于限制时间，跳过复制";
                    //LogHelper.WriteLog(message, now);
                    continue;
                }

                #endregion 条件判断

                //复制
                stopwatch.Restart();
                File.Copy(sourceFilePath, targetFilePath);//复制
                File.SetLastWriteTime(targetFilePath, lastTime);//设置时间为最新（因为qb下载时间复制出来时不会更新）
                stopwatch.Stop();
                count++;

                #region 复制后

                double elapsedSec = stopwatch.ElapsedMilliseconds / 1000.0;
                double fileSizeMb = (new FileInfo(sourceFilePath)).Length / 1024.0 / 1024.0;
                double speed = fileSizeMb / elapsedSec;

                string successMessage = $"成功复制文件 {sourceFileInfo.Name},速度: {speed:F2} MiB/s,用时 {elapsedSec} 秒";
                LogHelper.WriteLog(successMessage, now);

                // 更新最新复制文件的修改时间为当前文件的修改时间
                if(lastModifiedTime < lastTime)
                {
                    lastModifiedTime = lastTime;
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

                string updateTimeMessage = $"复制完成，成功更新{count}个文件,成功更新配置文件，最新处理时间为 {lastModifiedTime:yyyy-MM-dd HH:mm:ss}";
                LogHelper.WriteLog(updateTimeMessage, now);
            }
            else
            {
                string updateTimeMessage = $"复制结束，未更新文件";
                LogHelper.WriteLog(updateTimeMessage, now);
            }

            LogHelper.WriteLog(separatorMsg, now); //输出分割符
            LogHelper.CloseLog();

            #endregion 复制后的处理
        }
    }
}