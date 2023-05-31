using System.Text;

namespace linux文件复制工具
{
    /// <summary>
    /// 数据集帮助类
    /// </summary>
    public static class DataSetHelper
    {
        public const string separator = ",";
 

        /// <summary>
        /// 获取数据文件信息
        /// </summary>
        /// <param name="settings"></param>
        /// <param name="runDateTime"></param>
        public static  void GenerateDataset(AppSettings settings, DateTime runDateTime)
        { 
            //获取原始文件信息
            LogHelper.StartLoad("开始生成数据集文件", LogTypeEnum.Debug);
            var sourceFiles = new DirectoryInfo(settings.Source)
                .GetFiles("*", SearchOption.AllDirectories);
            LogHelper.StopLoad("原始文件信息获取完毕", LogTypeEnum.Debug);
            
            //获取目标文件信息
            Dictionary<string, FileInfo> targetFileDic = new DirectoryInfo(settings.Target)
               .GetFiles("*", SearchOption.AllDirectories)
               .Where(t => settings.AllowedExtensions.Contains(t.Extension.Trim().ToLower()[1..]))
               .ToDictionary(t => t.Name, t => t);

            #region 准备数据

            StringBuilder sb = new StringBuilder();

            //插入表头
            sb.Append($"SourceName{separator}");
            sb.Append($"SourceCreatetime{separator}");
            sb.Append($"SourceLastAccessTime{separator}");
            sb.Append($"SourceLastWriteTime{separator}");
            sb.Append($"SourceFullName{separator}");
            sb.Append($"SourceFolderName{separator}");
            sb.Append($"SourceFileLength{separator}");

            sb.Append($"IsTarget{separator}");
            sb.Append($"TimeLimit{separator}");

            sb.Append($"TargetName{separator}");
            sb.Append($"TargetCreatetime{separator}");
            sb.Append($"TargetLastAccessTime{separator}");
            sb.Append($"TargetLastWriteTime{separator}");
            sb.Append($"TargetFullName{separator}");
            sb.Append($"TargetFolderName{separator}");

            sb.AppendLine();

            //插入数据
            foreach(FileInfo sourceInfo in sourceFiles)
            {
                FileInfo targetFileInfo = targetFileDic.GetValueOrDefault(sourceInfo.Name);

                sb.Append($"\"{sourceInfo.Name}\"{separator}");  
                sb.Append($"\"{sourceInfo.CreationTime.GetString()}\"{separator}");
                sb.Append($"\"{sourceInfo.LastAccessTime.GetString()}\"{separator}");
                sb.Append($"\"{sourceInfo.LastWriteTime.GetString()}\"{separator}");
                sb.Append($"\"{sourceInfo.FullName}\"{separator}");
                sb.Append($"\"{sourceInfo.DirectoryName}\"{separator}");
                sb.Append($"\"{sourceInfo.Length}\"{separator}");

                if(targetFileInfo == null)
                {
                    sb.Append($"False{separator}");
                    sb.Append($"\"{settings.TimeLimit.GetString()}\"{separator}");

                    sb.Append("无" + separator);
                    sb.Append("无" + separator);
                    sb.Append("无" + separator);
                    sb.Append("无" + separator);
                    sb.Append("无" + separator);
                    sb.Append('无');
                }
                else
                {
                    sb.Append($"True{separator}");
                    sb.Append($"\"{settings.TimeLimit.GetString()}\"{separator}");

                    sb.Append($"\"{targetFileInfo.Name}\"{separator}");
                    sb.Append($"\"{targetFileInfo.CreationTime.GetString()}\"{separator}");
                    sb.Append($"\"{targetFileInfo.LastAccessTime.GetString()}\"{separator}");
                    sb.Append($"\"{targetFileInfo.LastWriteTime.GetString()}\"{separator}");
                    sb.Append($"\"{targetFileInfo.FullName}\"{separator}");
                    sb.Append($"\"{targetFileInfo.DirectoryName}\"");
                 
                }

                sb.AppendLine();
            }

            //删除最后一个换行符
            sb.Remove(sb.ToString().LastIndexOf(Environment.NewLine), Environment.NewLine.Length);

            #endregion 准备数据

            File.WriteAllText("dataset.csv", sb.ToString(), Encoding.UTF8);
        }
    }
}