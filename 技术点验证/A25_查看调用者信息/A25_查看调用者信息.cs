using System.Runtime.CompilerServices;
using Verification.Core;

namespace 技术点验证.A25_查看调用者信息
{
    [VerifcationType(VerificationTypeEnum.A24_使用高阶函数)]
    public class A25_查看调用者信息 : IVerification
    {
        public void Start(string?[] args)
        {
            throw new System.NotImplementedException();
        }

        public static void TraceMessage(string? message,
            [CallerMemberName]string? memberName = "",
            [CallerFilePath]string? sourceFilePath = "",
            [CallerLineNumber]int sourceLineNumber = 0)
        {
            System.Diagnostics.Trace.Indent();
            System.Diagnostics.Trace.Listeners.Add(new System.Diagnostics.TextWriterTraceListener(System.Console.Out));
            System.Diagnostics.Trace.WriteLine("message: " + message);
            System.Diagnostics.Trace.WriteLine("member name: " + memberName);
            System.Diagnostics.Trace.WriteLine("source file path: " + sourceFilePath);
            System.Diagnostics.Trace.WriteLine("source line number: " + sourceLineNumber);
            System.Diagnostics.Trace.Unindent();

            System.Console.WriteLine("debug end");
        }
    }
}