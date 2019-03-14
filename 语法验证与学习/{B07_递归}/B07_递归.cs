using System;
using System.Linq;
using Verification.Core;

namespace 语法验证与学习
{
    public class B07_递归 : IVerification
    {
        public VerificationTypeEnum VerificationType => VerificationTypeEnum.B07_递归;

        public void Start(string[] args)
        {
            // 1. 递推与递归
            //都是以阶乘为例子
            int a = this.Iterative(5);
            int b = this.Recursive(5);
            Console.WriteLine($"递推与递归\t递推{a}\t递归{b}");

            // 2. 结算货币找零有多少种方式
            int money = 51;
            int[] coins = new int[] { 1, 2, 3, 5, 10, 20, 50, 100 };
        }

        #region 递推与递归

        //下面2个函数是阶乘的不同写法

        /// <summary>
        /// 递推（也有地方叫迭代）
        /// </summary>
        public int Iterative(int n)
        {
            int acc = 1;//递推需要使用一个累积器保存中间结果
            for (int i = 1 ; i <= n ; i++)
            {
                acc = acc * i;
            }
            return acc;
        }

        /// <summary>
        /// 递归
        /// </summary>
        public int Recursive(int n)
        {
            if (n == 0) return 1;
            return n * this.Recursive(n - 1);//把递归调用写在函数的最末尾，叫尾递归
        }

        #endregion 递推与递归

        #region 结算货币找零有多少种方式

        public int CountChange(int money, int[] coins)
        {
            if (money == 0)
            {
                return 1;
            }
            if (coins.Length == 0 || money < 0)
            {
                return 0;
            }

            return this.CountChange(money, coins.Skip(1).ToArray())
                + this.CountChange(money - coins.First(), coins);
        }

        #endregion 结算货币找零有多少种方式
    }
}