using Xunit;
using System;
using System.Threading;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace CKTools.BaseExtensions.Test.Extensions.BaseType
{
    public class StringEntensionTest
    {
        public class ToDateTimeOffset
        {
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
            [MemberData(nameof(ToDateTimeOffsetUTData.Utc), MemberType = typeof(ToDateTimeOffsetUTData))]
            public void ToUtcDateTimeOffsetTest(string source, string expected)
            {
                DateTimeOffset result = source.ToUtcDateTimeOffset();
                Assert.Equal(expected, result.ToString("O"));
            }

            [Theory]
            [MemberData(nameof(ToDateTimeOffsetUTData.UtcMilliseconds), MemberType = typeof(ToDateTimeOffsetUTData))]
            public void ToUtcDateTimeOffsetByMillisecondsTest(string source, string expected)
            {
                DateTimeOffset result = source.ToUtcDateTimeOffsetByMilliseconds();
                Assert.Equal(expected, result.ToString("O"));
            }

            [Theory]
            [MemberData(nameof(ToDateTimeOffsetUTData.Local), MemberType = typeof(ToDateTimeOffsetUTData))]
            public void ToLocalDateTimeOffsetTest(string source, string expected)
            {
                DateTimeOffset result = source.ToLocalDateTimeOffset();
                Assert.Equal(expected, result.ToString("O"));
            }

            [Theory]
            [MemberData(nameof(ToDateTimeOffsetUTData.LocalMilliseconds), MemberType = typeof(ToDateTimeOffsetUTData))]
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
            [MemberData(nameof(ToDateTimeOffsetUTData.TryUtc), MemberType = typeof(ToDateTimeOffsetUTData))]
            public void TryToUtcDateTimeOffsetTest(string source, string expected)
            {
                DateTimeOffset result = source.TryToUtcDateTimeOffset();
                Assert.Equal(expected, result.ToString("O"));
            }

            [Theory]
            [MemberData(nameof(ToDateTimeOffsetUTData.TryUtcMilliseconds), MemberType = typeof(ToDateTimeOffsetUTData))]
            public void TryToUtcDateTimeOffsetByMillisecondsTest(string source, string expected)
            {
                DateTimeOffset result = source.TryToUtcDateTimeOffsetByMilliseconds();
                Assert.Equal(expected, result.ToString("O"));
            }

            [Theory]
            [MemberData(nameof(ToDateTimeOffsetUTData.TryLocal), MemberType = typeof(ToDateTimeOffsetUTData))]
            public void TryToLocalDateTimeOffsetTest(string source, string expected)
            {
                DateTimeOffset result = source.TryToLocalDateTimeOffset();
                Assert.Equal(expected, result.ToString("O"));
            }

            [Theory]
            [MemberData(nameof(ToDateTimeOffsetUTData.TryLocalMilliseconds), MemberType = typeof(ToDateTimeOffsetUTData))]
            public void TryToLocalDateTimeOffsetByMillisecondsTest(string source, string expected)
            {
                DateTimeOffset result = source.TryToLocalDateTimeOffsetByMilliseconds();
                Assert.Equal(expected, result.ToString("O"));
            }
        }
    }

    public class ToDateTimeOffsetUTData
    {
        //todo :弄好偏移字符串后 local的数据处理下时区
        public static string OffsetStr = TimeZoneInfo.Local.GetOffsetString();

        public static IEnumerable<object[]> Utc()
        {
            yield return new object[] { "2020-10-16T11:36:56+08:00", "2020-10-16T03:36:56.0000000+00:00" };
            yield return new object[] { "1602819416", "2020-10-16T03:36:56.0000000+00:00" };
            yield return new object[] { "0", "1970-01-01T00:00:00.0000000+00:00" };
        }

        public static IEnumerable<object[]> UtcMilliseconds()
        {
            yield return new object[] { "2020-10-16T11:36:56+08:00", "2020-10-16T03:36:56.0000000+00:00" };
            yield return new object[] { "1602819416001", "2020-10-16T03:36:56.0010000+00:00" };
            yield return new object[] { "0", "1970-01-01T00:00:00.0000000+00:00" };
        }

        public static IEnumerable<object[]> Local()
        {
            yield return new object[] { "2020-10-16T11:36:56+08:00", $"2020-10-16T11:36:56.0000000{OffsetStr}" };
            yield return new object[] { "1602819416", $"2020-10-16T11:36:56.0000000{OffsetStr}" };
            yield return new object[] { "0", $"1970-01-01T08:00:00.0000000{OffsetStr}" };
        }

        public static IEnumerable<object[]> LocalMilliseconds()
        {
            yield return new object[] { "2020-10-16T11:36:56+08:00", $"2020-10-16T11:36:56.0000000{OffsetStr}" };
            yield return new object[] { "1602819416001", $"2020-10-16T11:36:56.0010000{OffsetStr}" };
            yield return new object[] { "0", $"1970-01-01T08:00:00.0000000{OffsetStr}" };
        }

        public static IEnumerable<object[]> TryUtc()
        {
            return ToDateTimeOffsetUTData.Utc()
                .Concat(new object[] { "", "0001-01-01T00:00:00.0000000+00:00" }.AsToEnumerable());
        }

        public static IEnumerable<object[]> TryUtcMilliseconds()
        {
            return ToDateTimeOffsetUTData.UtcMilliseconds()
                .Concat(new object[] { "", "0001-01-01T00:00:00.0000000+00:00" }.AsToEnumerable());
        }

        public static IEnumerable<object[]> TryLocal()
        {
            return ToDateTimeOffsetUTData.Local()
                .Concat(new object[] { "", $"0001-01-01T08:00:00.0000000{OffsetStr}" }.AsToEnumerable());
        }

        public static IEnumerable<object[]> TryLocalMilliseconds()
        {
            return ToDateTimeOffsetUTData.LocalMilliseconds()
                .Concat(new object[] { "", $"0001-01-01T08:00:00.0000000{OffsetStr}" }.AsToEnumerable());
        }
    }
}