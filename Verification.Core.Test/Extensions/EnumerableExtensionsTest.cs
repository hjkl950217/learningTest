using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Verification.Core.Test.Extensions
{
    public class EnumerableExtensionsTest
    {
        private static class MockHelper
        {
            public static Func<UserInfo, UserInfo, bool> EqualFunc = (a, b) => a.UserName == b.UserName;
            public static Func<UserInfo, int> HashCodeFunc = (a) => a.UserID;
        }

        #region Distinct

        public class DistinctTest
        {
            [Fact]
            public void Source_Null()
            {
                List<SellerInfo> testData = null;
                Func<SellerInfo, SellerInfo, bool> func = (a, b) => a.UserName == b.UserName;

                var ex = Assert.Throws<ArgumentNullException>(() => testData.Distinct(func));

                Assert.NotNull(ex);
                Assert.Equal("source", ex.ParamName);
            }

            [Fact]
            public void Func_Null()
            {
                List<SellerInfo> testData = new List<SellerInfo>();
                Func<SellerInfo, SellerInfo, bool> func = null;

                var ex = Assert.Throws<ArgumentNullException>(() => testData.Distinct(func));

                Assert.NotNull(ex);
                Assert.Equal("predicate", ex.ParamName);
            }

            [Fact]
            public void Func_Null2()
            {
                List<SellerInfo> testData = new List<SellerInfo>();
                Func<SellerInfo, int> func = null;

                var ex = Assert.Throws<ArgumentNullException>(() => testData.DistinctBy(func));

                Assert.NotNull(ex);
                Assert.Equal("predicate", ex.ParamName);
            }

            [Fact]
            public void Distinct_True()
            {
                List<SellerInfo> testData = ComparerTestData.TestListA;
                var func = MockHelper.EqualFunc;

                var result = testData.Distinct(func)
                    .ToList();

                Assert.NotEmpty(result);
                Assert.Equal(2, result.Count);
            }

            [Fact]
            public void Distinct_True2()
            {
                List<SellerInfo> testData = ComparerTestData.TestListA;
                var func = MockHelper.HashCodeFunc;

                var result = testData.DistinctBy(func)
                    .ToList();

                Assert.NotEmpty(result);
                Assert.Equal(2, result.Count);
            }

            [Fact]
            public void Distinct_NoRepeat()
            {
                List<UserInfo> testData = new List<UserInfo>();
                testData.AddRange(ComparerTestData.TestListC);
                testData.AddRange(ComparerTestData.TestListD);
                var func = MockHelper.HashCodeFunc;

                var result = testData.DistinctBy(func)
                    .ToList();

                Assert.NotEmpty(result);
                Assert.Equal(2, result.Count);
            }
        }

        #endregion Distinct

        #region Except

        public class ExceptTest
        {
            [Fact]
            public void Source_Null()
            {
                List<SellerInfo> testData = null;
                Func<SellerInfo, SellerInfo, bool> func = (a, b) => a.UserName == b.UserName;

                var ex = Assert.Throws<ArgumentNullException>(() =>
                    testData.Except(ComparerTestData.TestListB, func)
                    );

                Assert.NotNull(ex);
                Assert.Equal("first", ex.ParamName);
            }

            [Fact]
            public void Func_Null()
            {
                List<SellerInfo> testData = new List<SellerInfo>();
                Func<SellerInfo, SellerInfo, bool> func = null;

                var ex = Assert.Throws<ArgumentNullException>(() =>
                    testData.Except(ComparerTestData.TestListB, func)
                    );

                Assert.NotNull(ex);
                Assert.Equal("predicate", ex.ParamName);
            }

            [Fact]
            public void Func_Null2()
            {
                List<SellerInfo> testData = new List<SellerInfo>();
                Func<SellerInfo, int> func = null;

                var ex = Assert.Throws<ArgumentNullException>(() =>
                    testData.ExceptBy(ComparerTestData.TestListB, func)
                    );

                Assert.NotNull(ex);
                Assert.Equal("predicate", ex.ParamName);
            }

            [Fact]
            public void Except_True()
            {
                List<SellerInfo> testData = ComparerTestData.TestListA;
                var func = MockHelper.EqualFunc;

                var result = testData.Except(ComparerTestData.TestListB, func)
                    .ToList();

                Assert.NotEmpty(result);
                Assert.Equal(2, result.Count);
                Assert.Equal("2", result.First(t => t.UserID == 2).UserName);
            }

            [Fact]
            public void Except_True2()
            {
                List<SellerInfo> testData = ComparerTestData.TestListA;
                var func = MockHelper.HashCodeFunc;

                var result = testData.ExceptBy(ComparerTestData.TestListB, func)
                    .ToList();

                Assert.NotEmpty(result);
                Assert.Single(result);
                Assert.Equal("2", result.First().UserName);
            }

            [Fact]
            public void Except_NoDifferenceSet()
            {
                List<UserInfo> testData = ComparerTestData.TestListB
                    .Select(t => t as UserInfo)
                    .ToList();
                var func = MockHelper.HashCodeFunc;

                var result = testData.ExceptBy(ComparerTestData.TestListC, func)
                    .ToList();

                Assert.Empty(result);//因为使用UserID去比较，所以应该没有差集
            }
        }

        #endregion Except

        #region Intersect

        public class IntersectTest
        {
            [Fact]
            public void Source_Null()
            {
                List<SellerInfo> testData = null;
                Func<SellerInfo, SellerInfo, bool> func = (a, b) => a.UserName == b.UserName;

                var ex = Assert.Throws<ArgumentNullException>(() =>
                    testData.Intersect(ComparerTestData.TestListB, func)
                    );

                Assert.NotNull(ex);
                Assert.Equal("first", ex.ParamName);
            }

            [Fact]
            public void Func_Null()
            {
                List<SellerInfo> testData = new List<SellerInfo>();
                Func<SellerInfo, SellerInfo, bool> func = null;

                var ex = Assert.Throws<ArgumentNullException>(() =>
                    testData.Intersect(ComparerTestData.TestListB, func)
                    );

                Assert.NotNull(ex);
                Assert.Equal("predicate", ex.ParamName);
            }

            [Fact]
            public void Func_Null2()
            {
                List<SellerInfo> testData = new List<SellerInfo>();
                Func<SellerInfo, int> func = null;

                var ex = Assert.Throws<ArgumentNullException>(() =>
                    testData.IntersectBy(ComparerTestData.TestListB, func)
                    );

                Assert.NotNull(ex);
                Assert.Equal("predicate", ex.ParamName);
            }

            [Fact]
            public void Intersect_True()
            {
                List<UserInfo> testData = ComparerTestData.TestListC;
                var func = MockHelper.EqualFunc;

                var result = testData.Intersect(ComparerTestData.TestListD, func)
                    .ToList();

                Assert.NotNull(result);
                Assert.Single(result);
            }

            [Fact]
            public void Intersect_True2()
            {
                List<SellerInfo> testData = ComparerTestData.TestListA;
                var func = MockHelper.HashCodeFunc;

                var result = testData.IntersectBy(ComparerTestData.TestListB, func)
                    .ToList();

                Assert.NotEmpty(result);
                Assert.Single(result);
                Assert.Equal("1", result.First().UserName);
            }

            [Fact]
            public void Intersect_NoIntersection()
            {
                List<SellerInfo> testData = ComparerTestData.TestListA;
                var func = MockHelper.EqualFunc;

                var result = testData.Intersect(ComparerTestData.TestListB, func)
                    .ToList();

                Assert.NotNull(result);//因为使用UserName去比较，所以应该没有交集
                Assert.Empty(result);
            }
        }

        #endregion Intersect
    }
}