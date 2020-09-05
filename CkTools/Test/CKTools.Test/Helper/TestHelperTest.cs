using CkTools.Helper;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace CkTools.Test.Helper
{
    public static class TestHelperTest
    {
        public class MockArrayTest
        {
            public void NoError()
            {
                var source = TestHelper.MockArray<KeyValuePair<int, int>>(5);

                int result = source.Select(t => t.GetHashCode()).Distinct().Count();
                Assert.Equal(5, result);
            }
        }

        public class MocklListTest
        {
            public void NoError()
            {
                var source = TestHelper.MockList<KeyValuePair<int, int>>(5);

                int result = source.Select(t => t.GetHashCode()).Distinct().Count();
                Assert.Equal(5, result);
            }
        }

        public class MockTest
        {
            public void NoException()
            {
                _ = TestHelper.Mock<KeyValuePair<int, int>>();
            }
        }
    }
}