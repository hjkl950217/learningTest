using Verification.Core;

namespace 语法验证与学习
{
    public class Program
    {
        public static void Main(string?[] args)
        {
            System.Linq.Enumerable.Aggregate(
                source: new int[] { 1, 2, 3, 4 },
                seed: 10,
                func: (a, b) => a * b,
                resultSelector: a => a
                );

            //开始验证
            VerificationHelp.StartVerification(VerificationTypeEnum.B12_Switch_In_80, args);
        }
    }
}