using System;
using Xunit;

namespace CKTools.BaseExtensions.Test.Extensions.BaseType
{
    public class ByteExtensionsTest
    {
        public class BytesToHexstring
        {
            public static string expectStr = "06 E6 9D 8E E5 9B 9B 0A E6 9D 8E 00 14 E5 9B 9B 00";
            public static byte[] testBytes = new byte[] { 6, 230, 157, 142, 229, 155, 155, 10, 230, 157, 142, 0, 20, 229, 155, 155, 0 };

            [Fact]
            public void NoError()
            {
                string result = ByteExtensions.BytesToHexstring(array: testBytes, separator: " ".AsSpan(), uppercase: true);
                Assert.Equal(expectStr, result);
            }

            [Fact]
            public void WhenLowerWithNoError()
            {
                string result = ByteExtensions.BytesToHexstring(array: testBytes, separator: " ".AsSpan(), uppercase: false);
                Assert.Equal(expectStr.ToLower(), result);
            }

            [Fact]
            public void WhenNoExistEmptyWithNoError()
            {
                string result = ByteExtensions.BytesToHexstring(array: testBytes, separator: ReadOnlySpan<char>.Empty, uppercase: true);
                Assert.Equal(expectStr.Replace(" ", ""), result);
            }
        }
    }
}