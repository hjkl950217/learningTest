using System.Collections.Generic;
using AutoFixture;

namespace CkTools.Helper
{
    public static class TestHelper
    {
        public static Fixture fixture = new Fixture();

        public static T[] MockArray<T>(int count = 3)
        {
            T[] result = new T[count];
            for (int i = 0 ; i < result.Length ; i++)
            {
                result[i] = fixture.Create<T>();
            }

            return result;
        }

        public static List<T> MockList<T>(int count = 3)
        {
            List<T> result = new List<T>();
            result.Add(fixture.Create<T>());
            return result;
        }

        public static T Mock<T>()
        {
            return TestHelper.MockArray<T>(1)[0];
        }
    }
}