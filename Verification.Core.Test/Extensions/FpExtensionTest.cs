using System;

namespace Verification.Core.Test.Extensions
{
    public class FpExtensionTest
    {
        #region 测试用基本函数

        private Func<string, int> strToInt = t => 1;
        private Func<int, bool> intToBool = t => true;
        private Action<int> doInt1 = t => { };
        private Action<int> doInt2 = t => { };
        private Action<int> doInt3 = t => { };
        private Action<int> doInt4 = t => { };
        private Func<bool, double> boolToDouble = t => 1.2;

        private Action<bool> doBool1 = t => { };
        private Action<bool> doBool2 = t => { };
        private Action<bool> doBool3 = t => { };
        private Action<bool> doBool4 = t => { };

        #endregion 测试用基本函数

        //这个方法是用来测试类型识别的，所以不用考虑具体的函数逻辑
        //只要编译通过不报错就OK
        public void FPExtension_GenericFind()
        {
            #region 单独验证

            //a->b->c  => (a->c)
            Func<string, double> result1 = strToInt
                .Pipe(intToBool)
                .Pipe(boolToDouble);

            //a->b->void  => (a->void)
            Action<string> result2 = strToInt.Pipe(doInt1);

            //a->...->void  => (a->void)
            Action<int> result3 = doInt1.Pipe(doInt2, doInt3, doInt4);

            #endregion 单独验证

            #region 复合验证

            //a->b->c => a->c  |>  (a->c)->..->void => a->void
            Action<string> complex_Result = strToInt
                .Pipe(intToBool)
                .Pipe(doBool1, doBool2, doBool3, doBool4);

            #endregion 复合验证
        }
    }
}