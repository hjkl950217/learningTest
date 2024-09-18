using linux文件复制工具.BaseTool.Executer;
using linux文件复制工具.BaseTool.LogHlper;

namespace linux文件复制工具.AppCommand
{
    public abstract class BaseRunner
    {
        protected readonly ActionExecuter actionExecuter;

        protected BaseRunner()
        {
            this.actionExecuter = ActionExecuter.Init();
        }

        public void Run()
        {
            LogHelper.WriteLog($"========任务开始:[{this.GetType().Name}]========");
            this.InternalRun();
            LogHelper.WriteLog($"========任务完成:[{this.GetType().Name}]========");
        }

        protected abstract void InternalRun();
    }
}