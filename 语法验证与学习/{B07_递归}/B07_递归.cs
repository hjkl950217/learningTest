using System;
using System.Linq;
using Verification.Core;

namespace 语法验证与学习
{
    public class B07_递归 : IVerification
    {
        public VerificationTypeEnum VerificationType => VerificationTypeEnum.B07_递归;
        /*
         * 递推：从小到大,如:1+2+3
         * 递归：从大小到,如:(3-0)+(3-1)+(3-2)
         * 动态规划：一种找最优路线的思路。比如从昆明到北京有很多种路线，最优一定会经过成都，然后再找成都到北京的最优路线，依次找下去，最后组合成一套完整的出行方案。
         *
         * 动态规划个人理解是递归的一种，是分段去确定最优解
         *
         */

        public void Start(string[] args)
        {
            // 1. 递推与递归
            //都是以阶乘为例子
            int a = this.Iterative(5);
            int b = this.Recursive(5);
            Console.WriteLine($"递推与递归\t递推{a}\t递归{b}");

            // 2. 结算货币找零有多少种方式
            int money = 63;
            //int[] coins = new int[] { 1, 2, 5, 10, 20, 50, 100 };
            int[] coins = new int[] { 1, 5, 10, 50 };
            int result = this.CountChange_Greedy(money, coins);
            Console.WriteLine($"结算货币找零有多少种方式: {result}种");

            //贪心算法与动态规划的性能对比

            int monay_A = 7;
            int[] coins_A = new int[] { 1, 2, 5 };
            int result_A = this.CountChange_DynamicPlan(monay_A, coins_A);
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

        //贪心算法版本
        private int GreedyNum = 0;

        public int CountChange_Greedy(int money, int[] coins)
        {
            this.GreedyNum++;
            if (money == 1)
            {
                return 1;
            }
            if (coins.Length == 0 || money <= 0)
            {
                return 0;
            }

            //第一个：先找出一个，然后把剩余的在所有方式中查找
            //第二个：所有方式中，跳过第一个，然后找所有的

            return this.CountChange_Greedy(money - coins.First(), coins)
                + this.CountChange_Greedy(money, coins.Skip(1).ToArray());
        }

        //动态规划版本
        private int DynamicPlanNum = 0;

        public int CountChange_DynamicPlan(int money, int[] coins, int[] ways = null)
        {
            if (ways == null) ways = new int[money + 1];//这里都是整数，所以这样计算。其实是每一块钱都需要存下

            // 3   1-2

            //遍历金额，找出每种金额对应的找零方式
            for (int i = 1 ; i < ways.Length + 1 ; i++)//第一层：金额
            {
                int minMoney = i;//临时变量
                foreach (var item in coins)//第二层：找零方式
                {
                    if (i >= item)
                    {
                        int temp_Money = ways[i - item] + 1;
                        if (temp_Money < minMoney) minMoney = temp_Money;
                    }
                }

                ways[i] = minMoney;//把每种金额的找零方式，存起来
            }

            return ways[money];//
        }

        //ways[i - item]: 先把他自己前面的全部找到。比如5块钱去找， ways[5 - 4] 就找出4块钱对应的方式。

        #endregion 结算货币找零有多少种方式
    }
}