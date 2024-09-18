using linux文件复制工具.BaseTool.Config;

namespace linux文件复制工具.AppCommand.RsyncToQb
{
    public class RsyncToQbRunner : BaseRunner
    {
        private readonly AppSettings appSettings;
        private readonly RsyncToQbSetting rsyncToQbSetting;

        private string[] folder_115Down = Array.Empty<string>();
        private string[] folder_qb = Array.Empty<string>();

        public RsyncToQbRunner(AppSettings appSettings, RsyncToQbSetting rsyncToQbSetting)
        {
            this.appSettings = appSettings;
            this.rsyncToQbSetting = rsyncToQbSetting;

            // base.actionExecuter
            //.Pipe(this.复制文件);
        }

        protected override void InternalRun()
        {
            base.actionExecuter.Execute();
        }

        private void 获取所有文件夹名称()
        {
            this.folder_115Down = Directory.GetDirectories(this.appSettings.RsyncToQb.SourceAddr_115Down);
            this.folder_qb = Directory.GetDirectories(this.appSettings.RsyncToQb.TargetAddr_QbUndone);
        }

        private void 删除Qb中同名的文件夹()
        {
            string sourceFolder = this.appSettings.RsyncToQb.SourceAddr_115Down;
            string targetFolder = this.appSettings.RsyncToQb.TargetAddr_QbUndone;

            foreach(string sourceSubFolder in this.folder_115Down)
            {
                DirectoryInfo sourceDirInfo = new(
                    Path.Combine(
                        this.appSettings.RsyncToQb.SourceAddr_115Down,
                        Path.GetFileName(sourceSubFolder)));

                //同名文件夹，且时间新，则删除
                if(this.folder_qb.Contains(sourceSubFolder))
                {
                    DirectoryInfo targetDirInfo = new(
                     Path.Combine(
                         this.appSettings.RsyncToQb.TargetAddr_QbUndone,
                         Path.GetFileName(sourceSubFolder)));
                    if(sourceDirInfo.LastWriteTime > targetDirInfo.LastWriteTime)
                    {
                        Directory.Delete(targetDirInfo.FullName);
                    }
                }

                //复制
            }
        }

        private void 整体复制文件夹()
        {
            #region 获取所有源文件

            Directory.GetFiles(this.appSettings.RsyncToQb.SourceAddr_115Down, "*.*", SearchOption.AllDirectories);

            #endregion 获取所有源文件
        }

        /*
         *
 整体复制文件思路，从A复制到B：
 1. 扫描A文件夹下所有的文件（包括子文件夹中的文件）
 2. 根据文件名分组，路径层级相同的在一组（统计路径分割符的数量）
 3. 将组名排序，数字小的排在前面
 4. 按顺序执行，每一组内可以并行执行复制
 5. 复制前获取文件名中的路径，判断文件夹是否存在，不存在则创建一个
 6. 然后再复制文件
         *
         */
    }
}