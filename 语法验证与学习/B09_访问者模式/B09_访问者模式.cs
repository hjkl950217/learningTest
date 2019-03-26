using System;
using Verification.Core;

namespace 语法验证与学习.B09_访问者模式
{
    public class B09_访问者模式 : IVerification
    {
        //原始代码摘抄至：https://www.codeproject.com/Articles/375166/Functional-programming-in-Csharp?msg=4246973#xx4246973xx
        public VerificationTypeEnum VerificationType => VerificationTypeEnum.B09_访问者模式;

        public void Start(string[] args)
        {
            new Code1().Run();

            Console.WriteLine();
            new Code2().Run();
        }
    }
}