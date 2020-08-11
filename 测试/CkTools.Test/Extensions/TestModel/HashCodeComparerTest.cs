using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace CkTools.Test.Test.Extensions
{
    public class HashCodeComparerTest
    {
        private static class MockHelper
        {
            public static IEqualityComparer<UserInfo> IdComparer = new HashCodeComparer<UserInfo>(t => t.UserID);
        }

        [Fact]
        public void List_Distinct()
        {
            //利用比较器去重
            var result = ComparerTestData.TestListA
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

            var result = ComparerTestData.TestListA
                .Except(ComparerTestData.TestListB, MockHelper.IdComparer)
                .ToList();

            Assert.NotEmpty(result);

            Assert.Equal(2, result.FirstOrDefault()?.UserID);
        }

        [Fact]
        public void List_CheckInherit()
        {
            var result = ComparerTestData.TestListC
                .Contains(ComparerTestData.TestListA.FirstOrDefault(), MockHelper.IdComparer);

            Assert.True(result);
        }
    }
}