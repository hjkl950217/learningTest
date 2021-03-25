using System;
using Xunit;

namespace CKTols.FP.Test
{
    public class FpObjectDoExtensionTest
    {
        #region 单独验证

        public void ObjectDoText()
        {
            int a = 1;
            int b = 0;

            int result = FpObjectDoExtensions.Do(a, t => { b = t; });
            Assert.Equal(1, result);
        }

        #endregion 单独验证
    }
}