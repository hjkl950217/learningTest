using System.Collections.Generic;
using System.Linq;
using CkTools.Helper;
using Xunit;

namespace CkTools.Test.Helper
{
    public static class TestHelperTest
    {
        public class MockArrayTest
        {
            [Fact]
            public void NoError()
            {
                KeyValuePair<int, int>[]? source = TestHelper.MockArray<KeyValuePair<int, int>>(5);

                int result = source.Select(t => t.GetHashCode()).Distinct().Count();
                Assert.Equal(5, result);
            }
        }

        public class MocklListTest
        {
            [Fact]
            public void NoError()
            {
                List<KeyValuePair<int, int>>? source = TestHelper.MockList<KeyValuePair<int, int>>(5);

                int result = source.Select(t => t.GetHashCode()).Distinct().Count();
                Assert.Equal(5, result);
            }
        }

        public class MockTest
        {
            [Fact]
            public void NoException()
            {
                _ = TestHelper.Mock<KeyValuePair<int, int>>();
            }
        }
    }
}