using Verification.Core;
using Verification.Core.VerificationCore;

namespace 语法验证与学习
{
    public class Program
    {
        public static void Main(string[]? args)
        {
            //Type type = typeof(B21_Task的Wait方法是否任务级暂停);
            //Type[]? gifs = type.GetInterfaces();

            //bool ttt = gifs.Any(t => t.GetGenericTypeDefinition() == typeof(IVerification<>));
            //bool t1 = gifs[0].GetGenericTypeDefinition() == typeof(IVerification<>);
            //bool t2 = gifs[1].IsGenericType && gifs[1].GetGenericTypeDefinition() == typeof(IVerification<>);

            //Type[]? gArgs = gifs[0].GetGenericArguments();
            //bool isTag = type == gArgs[0];

            //开始验证
            VerificationHelper.StartVerification(VerificationTypeEnum.B19_字符串驻留池, args);
        }
    }
}