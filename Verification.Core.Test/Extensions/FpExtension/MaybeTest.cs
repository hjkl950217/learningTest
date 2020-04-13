using System;
using Xunit;

namespace Verification.Core.Test.Extensions.FpExtension
{

    public class MaybeTest
    {
        public class IsNothingTest
        {
            [Fact]
            public void Struct_Nothing_WithFalse()
            {
                Maybe<int> a = Maybe<int>.Nothing();

                Assert.False(a.HasValue);
                Assert.False(a.IsNothing());
            }

            [Fact]
            public void Struct_ExistsValue_WithTrue()
            {
                Maybe<int> a = 2;

                Assert.True(a.HasValue);
                Assert.True(a.IsNothing());
            }

            [Fact]
            public void Reference_Nothing_WithFalse()
            {
                Maybe<object> a = Maybe<object>.Nothing();

                Assert.False(a.HasValue);
                Assert.False(a.IsNothing());
            }

            [Fact]
            public void Reference_ExistsValue_WithTrue()
            {
                Maybe<object> a = 2;

                Assert.True(a.HasValue);
                Assert.True(a.IsNothing());
            }
        }

        public class PureTest
        {
            [Fact]
            public void Struct_ExistsValue_WithTrue()
            {
                Maybe<int> a = Maybe.Pure(2);

                Assert.True(a.HasValue);
                Assert.True(a.IsNothing());
                Assert.Equal(2, (int)a.Value);
            }

            [Fact]
            public void Reference_Null_WithNothing()
            {
                Maybe<object> a = Maybe.Pure((object)null);

                Assert.False(a.HasValue);
                Assert.False(a.IsNothing());

                var ex = Assert.Throws<InvalidOperationException>(() => _ = a.Value);
                Assert.NotNull(ex);
            }

            [Fact]
            public void Reference_ExistsValue_WithTrue()
            {
                Maybe<object> a = Maybe.Pure(new object());

                Assert.True(a.HasValue);
                Assert.True(a.IsNothing());
                Assert.NotNull(a.Value);
            }
        }
    }
}