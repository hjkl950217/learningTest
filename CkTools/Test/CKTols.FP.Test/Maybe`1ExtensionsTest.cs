#pragma warning disable CS8600 // 将 null 文本或可能的 null 值转换为不可为 null 类型。
#pragma warning disable CS8604 // 可能的 null 引用参数。

using System;
using Xunit;

namespace CKTols.FP.Test
{
    public class Maybe_1ExtensionsTest
    {
        #region 基础扩展

        public class IsNothingTest
        {
            [Fact]
            public void Nothing_WithFalse()
            {
                Maybe<string> a = Maybe<string>.Nothing();

                Assert.False(a.IsNothing());
            }

            [Fact]
            public void ExistsValue_WithTrue()
            {
                Maybe<string> a = "";

                Assert.True(a.IsNothing());
            }
        }

        #endregion 基础扩展

        #region 函数式扩展

        public class FmapTest
        {
            [Fact]
            public void ExistsValue_Maped_WithNoError()
            {
                Maybe<int> t1 = 7;
                Func<int, bool> func = x => (x & 1) == 1;

                Assert.True(t1.Fmap(func).Value);
            }

            [Fact]
            public void ExistsValue_Maped_WithNothing()
            {
                Maybe<int> t2 = Maybe<int>.Nothing();
                Func<int, bool> func = x => (x & 1) == 1;

                Assert.False(t2.Fmap(func).HasValue);
            }
        }

        public class ApplyTest
        {
            [Fact]
            public void ExistsValue_Applyed_WithNoError()
            {
                Maybe<int> t1 = 7;
                Maybe<Func<int, bool>> func = new Maybe<Func<int, bool>>(x => (x & 1) == 1);

                Assert.True(t1.Apply(func).Value);
            }

            [Fact]
            public void ExistsValueAndMapfuncIsNothing_Applyed_WithNoError()
            {
                Maybe<int> t1 = 7;
                Maybe<Func<int, bool>> func = Maybe<Func<int, bool>>.Nothing();

                Assert.False(t1.Apply(func).HasValue);
            }

            [Fact]
            public void ExistsValueAndMapfuncIsNull_Applyed_WithNoError()
            {
                Maybe<int> t1 = 7;
                Maybe<Func<int, bool>> func = null;

                Assert.False(t1.Apply(func).HasValue);
            }

            [Fact]
            public void Nothing_Applyed_WithNothing()
            {
                Maybe<int> t2 = Maybe<int>.Nothing();
                Maybe<Func<int, bool>> func = new Maybe<Func<int, bool>>(x => (x & 1) == 1);

                Assert.False(t2.Apply(func).HasValue);
            }

            [Fact]
            public void InputIsNull_Applyed_WithNothing()
            {
                Maybe<int> t2 = Maybe<int>.Nothing();
                Maybe<Func<int, bool>> func = new Maybe<Func<int, bool>>(x => (x & 1) == 1);

                Assert.False(t2.Apply(func).HasValue);
            }

            [Fact]
            public void NothingAndMapfuncIsNothing_Applyed_WithNothing()
            {
                Maybe<int> t2 = Maybe<int>.Nothing();
                Maybe<Func<int, bool>> func = Maybe<Func<int, bool>>.Nothing();

                Assert.False(t2.Apply(func).HasValue);
            }

            [Fact]
            public void AllNull_Applyed_WithNothing()
            {
                Maybe<int> t2 = null;

                Maybe<Func<int, bool>> func = null;

                Assert.False(t2.Apply(func).HasValue);
            }
        }

        public class BindTest
        {
            [Fact]
            public void ExistsValue_Binded_WithNoError()
            {
                Maybe<int> t1 = 7;
                Func<int, Maybe<bool>> func = x => (x & 1) == 1;

                Assert.True(t1.Bind(func).Value);
            }

            [Fact]
            public void ExistsValueBindfuncIsNull_Binded_WithNoError()
            {
                Maybe<int> t1 = 7;
                Func<int, Maybe<bool>> func = null;

                Assert.False(t1.Bind(func).HasValue);
            }

            [Fact]
            public void InPutIsNull_Binded_WithNoError()
            {
                Maybe<int> t1 = null;
                Func<int, Maybe<bool>> func = x => (x & 1) == 1;

                Assert.False(t1.Bind(func).HasValue);
            }

            [Fact]
            public void AllNull_Binded_WithNoError()
            {
                Maybe<int> t1 = null;
                Func<int, Maybe<bool>> func = x => (x & 1) == 1;

                Assert.False(t1.Bind(func).HasValue);
            }
        }

        #endregion 函数式扩展
    }
}

#pragma warning restore CS8604 // 可能的 null 引用参数。
#pragma warning restore CS8600 // 将 null 文本或可能的 null 值转换为不可为 null 类型。