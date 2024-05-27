using System.Collections.Generic;
using System.Linq;
using CKTools.BaseExtensions.Test.Extensions.TestModel;
using Xunit;

namespace CkTools.Test.Extensions.TestModel
{
    public class EqualComparerTest
    {
        private static class MockHelper
        {
            public static IEqualityComparer<UserInfo> IdComparer = new EqualComparer<UserInfo>(
                (a, b) => a.UserID == b.UserID);
        }

        [Fact]
        public void List_Distinct()
        {
            //利用比较器去重
            List<UserInfo> result = ComparerTestData.TestListA
                .Distinct(MockHelper.IdComparer)
                .ToList();

            Assert.NotNull(result);
            Assert.NotEmpty(result);
            Assert.Equal(2, result.Count);
        }

        [Fact]
        public void List_OnlyOneEqual()
        {
            //利用比较器取差集
            //找出不在 MockHelper.TestListB 中的元素

            List<UserInfo> result = ComparerTestData.TestListA
                .Except(ComparerTestData.TestListB, MockHelper.IdComparer)
                .ToList();

            Assert.NotNull(result);
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
    }
}