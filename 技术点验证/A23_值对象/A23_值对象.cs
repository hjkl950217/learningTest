using System;
using Verification.Core;

namespace 技术点验证
{
    public class A23_值对象 : IVerification
    {
        public VerificationTypeEnum VerificationType => VerificationTypeEnum.A23_值对象;

        public void Start(string[] args)
        {
            //Show只是执行方法  try方法报错时会输出错误信息
            //这里这样写是为了方便复制+快速切换

            #region 演示值类型

            this.Show(() => _ = new IdCard("012345678912345678"));
            this.Show(() => _ = new IdCard("01234567891234567X"));
            this.TryShow(() => _ = new IdCard("01234567891234567x"));
            this.TryShow(() => _ = new IdCard("01234567891234567-"));

            this.Show(() => _ = new Age(25));
            this.TryShow(() => _ = new Age(18));
            this.TryShow(() => _ = new Age(-1));

            #endregion 演示值类型

            #region 延迟枚举

            this.Show(() => _ = MemberType.Create(500));
            this.TryShow(() => _ = MemberType.Create(-500));

            #endregion 延迟枚举

            #region 演示快速创建嵌套的值对象

            /*
             * 未引入值对象:   int-> 枚举
             * 引入值对象:   int -> int值对象 -> 枚举值对象
             *
             *
             *
             */

            this.TryShow(() => _ = MemberType.Create(new IdCardNo(255)));

            #endregion 演示快速创建嵌套的值对象
        }

        public void Show(Action action) => action();

        public void TryShow(Action action)
        {
            try
            {
                action();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /* 我的值对象设计理念：
         * 值对象中的数据不可为null
         * 值对象中的数据是业务正确的
         * 使用起来尽量简单
         *
         *
         */
    }
}