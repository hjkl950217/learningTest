using System.Runtime.CompilerServices;
using Verification.Core;

namespace 技术点验证
{
    public class Program
    {
        private static void Main(string?[] args)
        {
            //开始验证
            VerificationHelp.StartVerification(VerificationTypeEnum.A24_使用高阶函数, args);
            // TraceMessage("testMsg", "testMember", "testFilePath", 20);
        }

        public static void TraceMessage(string? message,
            [CallerMemberName]string? memberName = "",
            [CallerFilePath]string? sourceFilePath = "",
            [CallerLineNumber]int sourceLineNumber = 0)
        {
            System.Diagnostics.Trace.WriteLine("message: " + message);
            System.Diagnostics.Trace.WriteLine("member name: " + memberName);
            System.Diagnostics.Trace.WriteLine("source file path: " + sourceFilePath);
            System.Diagnostics.Trace.WriteLine("source line number: " + sourceLineNumber);

            System.Console.ReadKey();
        }
    }
}