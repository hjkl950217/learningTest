﻿using System.Collections.Generic;
using System.Linq;
using CkTools.Abstraction.Comparer;
using Xunit;

namespace CkTools.Abstraction.Test.TestModel
{
    public class HashCodeComparerTest
    {
        [Fact]
        public void List_Distinct()
        {
            //利用比较器去重
            List<UserInfo> result = ComparerTestData.TestListA
                .Distinct(MockHelper.IdComparer)
                .ToList();

            Assert.NotEmpty(result);
            Assert.Equal(2, result.Count);
        }

        [Fact]
        public void List_OnlyOneEques()
        {
            //利用比较器取差集
            //找出不在 MockHelper.TestListB 中的元素

            List<UserInfo> result = ComparerTestData.TestListA
                .Except(ComparerTestData.TestListB, MockHelper.IdComparer)
                .ToList();

            Assert.NotEmpty(result);

            Assert.Equal(2, result.FirstOrDefault()?.UserID);
        }

        [Fact]
        public void List_CheckInherit()
        {
            bool result = ComparerTestData.TestListC
                .Contains(ComparerTestData.TestListA.FirstOrDefault(), MockHelper.IdComparer);

            Assert.True(result);
        }

        private static class MockHelper
        {
            public static IEqualityComparer<UserInfo> IdComparer = new HashCodeComparer<UserInfo>(t => t.UserID);
        }
    }
}