using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Verification.Core.Test.VerificationCore
{
    public static class VerificationHelperTest
    {
        public class MockArrayTest
        {
            public void NoError()
            {
                var source = VerificationHelper.MockArray<KeyValuePair<int, int>>(5);

                int result = source.Select(t => t.GetHashCode()).Distinct().Count();
                Assert.Equal(5, result);
            }
        }

        public class MocklListTest
        {
            public void NoError()
            {
                var source = VerificationHelper.MockList<KeyValuePair<int, int>>(5);

                int result = source.Select(t => t.GetHashCode()).Distinct().Count();
                Assert.Equal(5, result);
            }
        }

        public class MockTest
        {
            public void NoException()
            {
                _ = VerificationHelper.Mock<KeyValuePair<int, int>>();
            }
        }
    }
}