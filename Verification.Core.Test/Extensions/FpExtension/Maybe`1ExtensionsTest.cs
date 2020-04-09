using System;
using Xunit;

namespace Verification.Core.Test.Extensions.FpExtension
{
    public class Maybe_1ExtensionsTest
    {
        #region 基础扩展

        public class IsNothingTest
        {
            [Fact]
            public void Fmap_ImplicitOperator_WithNoError()
            {
            }
        }

        #endregion 基础扩展

        public class FmapTest
        {
            [Fact]
            public void Fmap_ImplicitOperator_WithNoError()
            {
                Maybe<int> a1 = 1;
                int b1 = a1;

                Maybe<string> a2 = "";
                string b2 = a2;
            }

            [Fact]
            public void Fmap_WorkTest_WithNoError()
            {
                Maybe<int> t1 = 7;
                Maybe<int> t2 = Maybe<int>.Nothing();
                Func<int, bool> func = x => (x & 1) == 1;

                Assert.True(t1.Fmap(func));
                Assert.False(t2.Fmap(func));
            }
        }
    }
}