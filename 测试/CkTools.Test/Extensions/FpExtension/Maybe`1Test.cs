using System;
using Xunit;

namespace CkTools.Test.Test.Extensions.FpExtension
{

    public class Maybe_1Test
    {
        public class ConstructorTest
        {
            [Fact]
            public void NoParameter_WithHasValueIsfalse()
            {
                Maybe<int> a = Maybe<int>.Nothing();

                Assert.False(a.HasValue);
                var ex = Assert.Throws<InvalidOperationException>(() => _ = a.Value);
                Assert.NotNull(ex);
            }

            [Fact]
            public void ParameterIsExists_WithHasValueIsTrue()
            {
                Maybe<int> a = new Maybe<int>(5);

                Assert.True(a.HasValue);
                Assert.Equal(5, (int)a);
            }

            [Fact]
            public void ParameterIsNull_WithHasValueIsFalse()
            {
                Maybe<object> a = new Maybe<object>((object)null);

                Assert.False(a.HasValue);
                var ex = Assert.Throws<InvalidOperationException>(() => _ = a.Value);
                Assert.NotNull(ex);
            }

            [Fact]
            public void MaybeParameterExists_WithHasValueIsTrue()
            {
                Maybe<int> a = new Maybe<int>(5);
                Maybe<int> b = new Maybe<int>(a);

                Assert.True(b.HasValue);
                Assert.Equal(5, (int)b);
            }

            [Fact]
            public void MaybeParameterIsNull_WithHasValueIsFalse()
            {
                Maybe<object> a = new Maybe<object>((Maybe<object>)null);

                Assert.False(a.HasValue);
                var ex = Assert.Throws<InvalidOperationException>(() => _ = a.Value);
                Assert.NotNull(ex);
            }

            [Fact]
            public void MaybeParameterIsHasValueIsFalse_WithHasValueIsFalse()
            {
                Maybe<object> a = Maybe<object>.Nothing();
                Maybe<object> b = new Maybe<object>(a);

                Assert.False(a.HasValue);
                var ex = Assert.Throws<InvalidOperationException>(() => _ = a.Value);
                Assert.NotNull(ex);
            }
        }

        public class ImplicitOperatorTest
        {
            [Fact]
            public void ImplicitOperator_WithNoError()
            {
                Maybe<int> a1 = 1;
                int b1 = a1;

                Maybe<string> a2 = "";
                string b2 = a2;
            }
        }

        public class ToStringTest
        {
            [Fact]
            public void HasValueIsTrue_Withabc()
            {
                Maybe<string> a = "abc";
                Assert.Equal("abc", a.ToString());
            }

            [Fact]
            public void HasValueIsFalse_WithNothing()
            {
                Maybe<string> a = Maybe<string>.Nothing();
                Assert.Equal("Nothing", a.ToString());
            }
        }

        public class NothingTest
        {
            [Fact]
            public void NothingWork()
            {
                Maybe<string> a = Maybe<string>.Nothing();

                Assert.False(a.HasValue);
                var ex = Assert.Throws<InvalidOperationException>(() => _ = a.Value);
                Assert.NotNull(ex);
            }
        }
    }
}