using System;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Verification.Core;

namespace 技术点验证
{
    public class Program
    {
        public static void Main(string[]? args)
        {
            //开始验证
            VerificationHelper.StartVerification(VerificationTypeEnum.A31_快速转换枚举为字典, args);
        }
    }

    public class TestObj
    {
        public int Add1(int a)
        {
            return a + 1 + 5;
        }

        public Task<int> Add222(Task<int> a)
        {
            return a.PipeAsync(t => t + 1)
                .PipeAsync(t => t + 5);
        }

        public async Task<int> Add10(Task<int> a)
        {
            int x = await a;
            return x + 10;
        }

        public Task<int> Add20(Task<int> a)
        {
            return a.ContinueWith(t => t.Result + 20, TaskContinuationOptions.OnlyOnRanToCompletion);
        }
    }
}