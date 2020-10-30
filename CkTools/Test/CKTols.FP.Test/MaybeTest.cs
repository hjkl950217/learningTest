using System;
using Xunit;

namespace CKTols.FP.Test
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
                Assert.Equal(2, a.Value);
            }

            [Fact]
            public void Reference_Null_WithNothing()
            {
#pragma warning disable CS8714 // 类型不能用作泛型类型或方法中的类型参数。类型参数的为 Null 性与 "notnull" 约束不匹配。
#pragma warning disable CS8619 // 值中的引用类型的为 Null 性与目标类型不匹配。
                Maybe<object> a = Maybe.Pure(value: (object?)null);
#pragma warning restore CS8619 // 值中的引用类型的为 Null 性与目标类型不匹配。
#pragma warning restore CS8714 // 类型不能用作泛型类型或方法中的类型参数。类型参数的为 Null 性与 "notnull" 约束不匹配。

                Assert.False(a.HasValue);
                Assert.False(a.IsNothing());

                InvalidOperationException? ex = Assert.Throws<InvalidOperationException>(() => _ = a.Value);
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