using System.Threading;
using System.Threading.Tasks;
using Verification.Core;

namespace 技术点验证
{
    [VerifcationType(VerificationTypeEnum.A35_ConfigureAwait配置True或是False)]
    public class A35_ConfigureAwait配置True或是False : IVerification
    {
        public void Start(string[]? args)
        {
            var a = new Task(() => { }).GetAwaiter();
            var b = new Task(() => { }).ConfigureAwait(false).GetAwaiter();

            var a1 = new Task(() => { }).ContinueWith(t => { }).GetAwaiter();

            var taskScheduler = TaskScheduler.Current;

            var b1 = new Task(() => { }).ContinueWith(t => { }, TaskScheduler.FromCurrentSynchronizationContext())
                .GetAwaiter();
        }

        public void Teest(Task task, Task nextTask)
        {
            var currentSyncContext = SynchronizationContext.Current;

            return task.ContinueWith(() =>
            {
                if (currentSyncContext == null)
                {
                    return nextTask;
                }
                else
                {
                    currentSyncContext.Post(() => nextTask, null);
                }
            }, TaskScheduler.Current);
        }
    }
}