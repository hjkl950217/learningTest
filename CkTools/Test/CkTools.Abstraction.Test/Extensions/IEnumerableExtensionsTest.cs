﻿#pragma warning disable CS8625 // 无法将 null 文本转换为不可为 null 的引用类型。
#pragma warning disable CS8600 // 将 null 文本或可能的 null 值转换为不可为 null 类型。
#pragma warning disable CS8604 // 可能的 null 引用参数。

using System;
using System.Collections.Generic;
using System.Linq;
using CkTools.Helper;
using CKTools.BaseExtensions.Test.Extensions.TestModel;
using Xunit;

namespace CKTools.BaseExtensions.Test.Extensions.BaseType
{
    public class IEnumerableExtensionsTest
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

                ArgumentNullException? ex = Assert.Throws<ArgumentNullException>(() => testData.Distinct(func));

                Assert.NotNull(ex);
                Assert.Equal("source", ex.ParamName);
            }

            [Fact]
            public void Func_Null()
            {
                List<SellerInfo> testData = new List<SellerInfo>();
                Func<SellerInfo, SellerInfo, bool> func = null;

                ArgumentNullException? ex = Assert.Throws<ArgumentNullException>(() => testData.Distinct(func));

                Assert.NotNull(ex);
                Assert.Equal("predicate", ex.ParamName);
            }

            [Fact]
            public void Func_Null2()
            {
                List<SellerInfo> testData = new List<SellerInfo>();
                Func<SellerInfo, int> func = null;

                ArgumentNullException? ex = Assert.Throws<ArgumentNullException>(() => testData.DistinctBy(func));

                Assert.NotNull(ex);
                Assert.Equal("predicate", ex.ParamName);
            }

            [Fact]
            public void Distinct_True()
            {
                List<SellerInfo> testData = ComparerTestData.TestListA;
                Func<UserInfo, UserInfo, bool>? func = MockHelper.EqualFunc;

                List<UserInfo>? result = testData.Distinct(func)
                    .ToList();

                Assert.NotEmpty(result);
                Assert.Equal(2, result.Count);
            }

            [Fact]
            public void Distinct_True2()
            {
                List<SellerInfo> testData = ComparerTestData.TestListA;
                Func<UserInfo, int>? func = MockHelper.HashCodeFunc;

                List<UserInfo>? result = testData.DistinctBy(func)
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
                Func<UserInfo, int>? func = MockHelper.HashCodeFunc;

                List<UserInfo>? result = testData.DistinctBy(func)
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

                ArgumentNullException? ex = Assert.Throws<ArgumentNullException>(() =>
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

                ArgumentNullException? ex = Assert.Throws<ArgumentNullException>(() =>
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

                ArgumentNullException? ex = Assert.Throws<ArgumentNullException>(() =>
                    testData.ExceptBy(ComparerTestData.TestListB, func)
                    );

                Assert.NotNull(ex);
                Assert.Equal("predicate", ex.ParamName);
            }

            [Fact]
            public void Except_True()
            {
                List<SellerInfo> testData = ComparerTestData.TestListA;
                Func<UserInfo, UserInfo, bool>? func = MockHelper.EqualFunc;

                List<UserInfo>? result = testData.Except(ComparerTestData.TestListB, func)
                    .ToList();

                Assert.NotEmpty(result);
                Assert.Equal(2, result.Count);
                Assert.Equal("2", result.First(t => t.UserID == 2).UserName);
            }

            [Fact]
            public void Except_True2()
            {
                List<SellerInfo> testData = ComparerTestData.TestListA;
                Func<UserInfo, int>? func = MockHelper.HashCodeFunc;

                List<UserInfo>? result = testData.ExceptBy(ComparerTestData.TestListB, func)
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
                Func<UserInfo, int>? func = MockHelper.HashCodeFunc;

                List<UserInfo>? result = testData.ExceptBy(ComparerTestData.TestListC, func)
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
                List<SellerInfo>? testData = null;
                Func<SellerInfo, SellerInfo, bool> func = (a, b) => a.UserName == b.UserName;

                ArgumentNullException? ex = Assert.Throws<ArgumentNullException>(() =>
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

                ArgumentNullException? ex = Assert.Throws<ArgumentNullException>(() =>
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

                ArgumentNullException? ex = Assert.Throws<ArgumentNullException>(() =>
                    testData.IntersectBy(ComparerTestData.TestListB, func)
                    );

                Assert.NotNull(ex);
                Assert.Equal("predicate", ex.ParamName);
            }

            [Fact]
            public void Intersect_True()
            {
                List<UserInfo> testData = ComparerTestData.TestListC;
                Func<UserInfo, UserInfo, bool>? func = MockHelper.EqualFunc;

                List<UserInfo>? result = testData.Intersect(ComparerTestData.TestListD, func)
                    .ToList();

                Assert.NotNull(result);
                Assert.Single(result);
            }

            [Fact]
            public void Intersect_True2()
            {
                List<SellerInfo> testData = ComparerTestData.TestListA;
                Func<UserInfo, int>? func = MockHelper.HashCodeFunc;

                List<UserInfo>? result = testData.IntersectBy(ComparerTestData.TestListB, func)
                    .ToList();

                Assert.NotEmpty(result);
                Assert.Single(result);
                Assert.Equal("1", result.First().UserName);
            }

            [Fact]
            public void Intersect_NoIntersection()
            {
                List<SellerInfo> testData = ComparerTestData.TestListA;
                Func<UserInfo, UserInfo, bool>? func = MockHelper.EqualFunc;

                List<UserInfo>? result = testData.Intersect(ComparerTestData.TestListB, func)
                    .ToList();

                Assert.NotNull(result);//因为使用UserName去比较，所以应该没有交集
                Assert.Empty(result);
            }
        }

        #endregion Intersect

        #region SelectMap

        public class SelectMapTest
        {
            [Fact]
            public void SourceIsNull_WithException()
            {
                List<SellerInfo> testData = null;
                ArgumentNullException? ex = Assert.Throws<ArgumentNullException>(() =>
                    testData.SelectMap(c => c.ToJsonExt())
                );

                Assert.NotNull(ex);
            }

            [Fact]
            public void SourceNotNull_WithNoException()
            {
                List<SellerInfo> testData = TestHelper.MockArray<SellerInfo>(5).ToList();

                _ = testData.SelectMap(c => c.ToJsonExt());
            }
        }

        #endregion SelectMap

        #region RemoveNull

        public class RemoveNullTest
        {
            #region Object

            [Fact]
            public void SourceIsNull_WithException()
            {
                List<SellerInfo> testData = null;

                ArgumentNullException? ex = Assert.Throws<ArgumentNullException>(() =>
                    testData.RemoveNull()
                );

                Assert.NotNull(ex);
            }

            [Fact]
            public void SourceIsNull_WithException2()
            {
                List<SellerInfo> testData = null;
                ArgumentNullException? ex = Assert.Throws<ArgumentNullException>(() =>

                    testData.RemoveNullBy(t => t.SellerID)

                );

                Assert.NotNull(ex);
            }

            [Fact]
            public void SourceNotNull_WithNoException()
            {
                List<SellerInfo> testData = TestHelper.MockArray<SellerInfo>(5).ToList();
                testData.Add(null);

                SellerInfo[]? result = testData.RemoveNull().ToArray();
                Assert.Equal(5, result.Length);
            }

            [Fact]
            public void SourceNotNull_WithNoException2()
            {
                List<SellerInfo> testData = TestHelper.MockArray<SellerInfo>(5).ToList();
                testData[0].IDCard = null;

                SellerInfo[]? result = testData.RemoveNullBy(t => t.IDCard).ToArray();
                Assert.Equal(4, result.Length);
            }

            #endregion Object

            #region String

            [Fact]
            public void StringSourceIsNull_WithException()
            {
                List<string> testData = null;
                ArgumentNullException? ex = Assert.Throws<ArgumentNullException>(() =>
                    testData.RemoveNull()
                );

                Assert.NotNull(ex);
            }

            [Fact]
            public void StringSourceIsNull_WithException2()
            {
                List<SellerInfo> testData = null;
                ArgumentNullException? ex = Assert.Throws<ArgumentNullException>(() =>
                    testData.RemoveNullBy(t => t.SellerID)
                );

                Assert.NotNull(ex);
            }

            [Fact]
            public void StringSourceNotNull_WithNoException()
            {
                List<string> testData = TestHelper.MockArray<string>(5).ToList();
                testData.Add(null);

                string[]? result = testData.RemoveNull().ToArray();
                Assert.Equal(5, result.Length);
            }

            [Fact]
            public void StringSourceNotNull_WithNoException2()
            {
                List<SellerInfo> testData = TestHelper.MockArray<SellerInfo>(5).ToList();

                testData[0].SellerID = null;

                SellerInfo[]? result = testData.RemoveNullBy(t => t.SellerID).ToArray();
                Assert.Equal(4, result.Length);
            }

            #endregion String
        }

        #endregion RemoveNull

        #region To集合

        public class ToArray
        {
            [Fact]
            public void SourceIsNull_WithNoException()
            {
                List<SellerInfo> testData = null;
                _ = testData.ToArray(t => t);
            }

            [Fact]
            public void SourceIsNull_WithNoExceptionAndDefault()
            {
                List<SellerInfo> testData = null;
                SellerInfo[]? result = testData.ToArray(t => t);

                Assert.NotNull(result);
            }

            [Fact]
            public void SourceNotNull_WithNoException()
            {
                List<SellerInfo> testData = TestHelper.MockList<SellerInfo>();
                string[]? result = testData.ToArray(t => t.SellerID);

                Assert.NotNull(result);
                Assert.Equal(testData.Count, result.Length);
            }
        }

        public class ToList
        {
            [Fact]
            public void SourceIsNull_WithNoException()
            {
                List<SellerInfo> testData = null;
                _ = testData.ToList(t => t);
            }

            [Fact]
            public void SourceIsNull_WithNoExceptionAndDefault()
            {
                List<SellerInfo> testData = null;
                List<SellerInfo>? result = testData.ToList(t => t);

                Assert.NotNull(result);
            }

            [Fact]
            public void SourceNotNull_WithNoException()
            {
                List<SellerInfo> testData = TestHelper.MockList<SellerInfo>();
                List<string>? result = testData.ToList(t => t.SellerID);

                Assert.NotNull(result);
                Assert.Equal(testData.Count, result.Count);
            }
        }

        #endregion To集合
    }
}

#pragma warning restore CS8604 // 可能的 null 引用参数。
#pragma warning restore CS8600 // 将 null 文本或可能的 null 值转换为不可为 null 类型。
#pragma warning restore CS8625 // 无法将 null 文本转换为不可为 null 的引用类型。