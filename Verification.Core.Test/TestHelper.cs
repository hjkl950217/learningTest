using AutoFixture;

namespace Verification.Core.Test
{
    public static class TestHelper
    {
        public static Fixture fixture = VerificationHelper.fixture;

        public static T[] MockArray<T>(int count = 1)
        {
            //    T[] result = new T[count];
            //    for (int i = 0 ; i < result.Length ; i++)
            //    {
            //        result[i] = fixture.Create<T>();
            //    }

            //    return result;

            return VerificationHelper.MockArray<T>(count);
        }

        public static T Mock<T>()
        {
            return VerificationHelper.Mock<T>();
        }
    }
}