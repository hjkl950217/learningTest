using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Verification.Core.Test.VerificationCore
{
    public static class VerificationHelperTest
    {
        public class MockArrayTest
        {
            public class MockArray
            {
                public void TestDistinct()
                {
                    var source = TestHelper.MockArray<KeyValuePair<int, int>>(5);

                    int result = source.Select(t => t.GetHashCode()).Distinct().Count();
                    Assert.Equal(5, result);
                }
            }

            public class Mock
            {
                public void NoException()
                {
                    _ = TestHelper.Mock<KeyValuePair<int, int>>();
                }
            }
        }
    }
}