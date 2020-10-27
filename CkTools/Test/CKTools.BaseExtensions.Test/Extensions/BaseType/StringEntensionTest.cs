using Xunit;
using System;
using System.Threading;
using System.Globalization;

namespace CKTools.BaseExtensions.Test.Extensions.BaseType
{
    public class StringEntensionTest
    {
        public class ToDateTimeOffset : IDisposable
        {
            public ToDateTimeOffset()
            {
                Thread.CurrentThread.CurrentCulture = new CultureInfo("zh-CN", false);
            }

            public void Dispose()
            {
                Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            }

            [Fact]
            public void ToDateTimeOffsetTest()
            {
                DateTimeOffset result = "2020-10-16T11:36:56+08:00".ToDateTimeOffset();

                Assert.Equal("2020-10-16T11:36:56.0000000+08:00", result.ToString("O"));
            }

            [Fact]
            public void ToDateTimeOffsetTest_Exception()
            {
                FormatException? ex = Assert.Throws<FormatException>(() => _ = "1602819416".ToDateTimeOffset());
                Assert.NotNull(ex);
            }

            [Theory]
            [InlineData("2020-10-16T11:36:56+08:00", "2020-10-16T03:36:56.0000000+00:00")]
            [InlineData("1602819416", "2020-10-16T03:36:56.0000000+00:00")]
            [InlineData("0", "1970-01-01T00:00:00.0000000+00:00")]
            public void ToUtcDateTimeOffsetTest(string source, string expected)
            {
                DateTimeOffset result = source.ToUtcDateTimeOffset();
                Assert.Equal(expected, result.ToString("O"));
            }

            [Theory]
            [InlineData("2020-10-16T11:36:56+08:00", "2020-10-16T03:36:56.0000000+00:00")]
            [InlineData("1602819416000", "2020-10-16T03:36:56.0000000+00:00")]
            [InlineData("0", "1970-01-01T00:00:00.0000000+00:00")]
            public void ToUtcDateTimeOffsetByMillisecondsTest(string source, string expected)
            {
                DateTimeOffset result = source.ToUtcDateTimeOffsetByMilliseconds();
                Assert.Equal(expected, result.ToString("O"));
            }

            [Theory]
            [InlineData("2020-10-16T11:36:56+08:00", "2020-10-16T11:36:56.0000000+08:00")]
            [InlineData("1602819416", "2020-10-16T11:36:56.0000000+08:00")]
            [InlineData("0", "1970-01-01T08:00:00.0000000+08:00")]
            public void ToLocalDateTimeOffsetTest(string source, string expected)
            {
                DateTimeOffset result = source.ToLocalDateTimeOffset();
                Assert.Equal(expected, result.ToString("O"));
            }

            [Theory]
            [InlineData("2020-10-16T11:36:56+08:00", "2020-10-16T11:36:56.0000000+08:00")]
            [InlineData("1602819416000", "2020-10-16T11:36:56.0000000+08:00")]
            [InlineData("0", "1970-01-01T08:00:00.0000000+08:00")]
            public void ToLocalDateTimeOffsetByMillisecondsTest(string source, string expected)
            {
                DateTimeOffset result = source.ToLocalDateTimeOffsetByMilliseconds();
                Assert.Equal(expected, result.ToString("O"));
            }
        }

        public class TryToDateTimeOffset : IDisposable
        {
            public TryToDateTimeOffset()
            {
                Thread.CurrentThread.CurrentCulture = new CultureInfo("zh-CN", false);
            }

            public void Dispose()
            {
                Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            }

            [Fact]
            public void TryToDateTimeOffsetTest()
            {
                DateTimeOffset result = "2020-10-16T11:36:56+08:00".TryToDateTimeOffset();
                Assert.Equal("2020-10-16T11:36:56.0000000+08:00", result.ToString("O"));
            }

            [Fact]
            public void TryToDateTimeOffsetTest_Exception()
            {
                DateTimeOffset result = "1602819416".TryToDateTimeOffset();
                Assert.Equal("0001-01-01T00:00:00.0000000+00:00", result.ToString("O"));
            }

            [Theory]
            [InlineData("2020-10-16T11:36:56+08:00", "2020-10-16T03:36:56.0000000+00:00")]
            [InlineData("1602819416", "2020-10-16T03:36:56.0000000+00:00")]
            [InlineData("0", "1970-01-01T00:00:00.0000000+00:00")]
            [InlineData("", "0001-01-01T00:00:00.0000000+00:00")]
            public void TryToUtcDateTimeOffsetTest(string source, string expected)
            {
                DateTimeOffset result = source.TryToUtcDateTimeOffset();
                Assert.Equal(expected, result.ToString("O"));
            }

            [Theory]
            [InlineData("2020-10-16T11:36:56+08:00", "2020-10-16T03:36:56.0000000+00:00")]
            [InlineData("1602819416000", "2020-10-16T03:36:56.0000000+00:00")]
            [InlineData("0", "1970-01-01T00:00:00.0000000+00:00")]
            [InlineData("", "0001-01-01T00:00:00.0000000+00:00")]
            public void TryToUtcDateTimeOffsetByMillisecondsTest(string source, string expected)
            {
                DateTimeOffset result = source.TryToUtcDateTimeOffsetByMilliseconds();
                Assert.Equal(expected, result.ToString("O"));
            }

            [Theory]
            [InlineData("2020-10-16T11:36:56+08:00", "2020-10-16T11:36:56.0000000+08:00")]
            [InlineData("1602819416", "2020-10-16T11:36:56.0000000+08:00")]
            [InlineData("0", "1970-01-01T08:00:00.0000000+08:00")]
            [InlineData("", "0001-01-01T08:00:00.0000000+08:00")]
            public void TryToLocalDateTimeOffsetTest(string source, string expected)
            {
                DateTimeOffset result = source.TryToLocalDateTimeOffset();
                Assert.Equal(expected, result.ToString("O"));
            }

            [Theory]
            [InlineData("2020-10-16T11:36:56+08:00", "2020-10-16T11:36:56.0000000+08:00")]
            [InlineData("1602819416000", "2020-10-16T11:36:56.0000000+08:00")]
            [InlineData("0", "1970-01-01T08:00:00.0000000+08:00")]
            [InlineData("", "0001-01-01T08:00:00.0000000+08:00")]
            public void TryToLocalDateTimeOffsetByMillisecondsTest(string source, string expected)
            {
                DateTimeOffset result = source.TryToLocalDateTimeOffsetByMilliseconds();
                Assert.Equal(expected, result.ToString("O"));
            }
        }
    }

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