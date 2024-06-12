using System;
using Xunit;

namespace CkTools.Abstraction.Test.Extensions
{
    public class DateTimeOffsetExtensionTest
    {
        public class AddOffset
        {
            public static int testOffsetHour = 5;
            public static TimeSpan testOffset = TimeSpan.FromHours(testOffsetHour);
            public static DateTimeOffset testTime = DateTimeOffset.FromUnixTimeSeconds(0);

            [Fact]
            public void AddTest()
            {
                DateTimeOffset result = testTime.AddOffset(testOffset);

                Assert.Equal(testOffsetHour, result.Hour);
                Assert.Equal(testOffset, result.Offset);
            }

            [Fact]
            public void SubtractionTest()
            {
                DateTimeOffset result = testTime.AddOffset(-testOffset);

                Assert.Equal(24 - testOffsetHour, result.Hour);
                Assert.Equal(-testOffset, result.Offset);
            }
        }
    }
}