using System.Collections.Generic;
using AutoFixture;

namespace Verification.Core.Test
{
    public static class TestHelper
    {
        public static Fixture fixture = VerificationHelper.fixture;

        public static T[] MockArray<T>(int count = 3)
        {
            return VerificationHelper.MockArray<T>(count);
        }

        public static List<T> MockList<T>(int count = 3)
        {
            return VerificationHelper.MockList<T>(count);
        }

        public static T Mock<T>()
        {
            return VerificationHelper.Mock<T>();
        }
    }
}