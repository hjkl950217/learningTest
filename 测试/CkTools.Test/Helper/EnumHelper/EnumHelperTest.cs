using System;
using CkTools.Helper;
using CkTools.Test.Helper;
using Xunit;

namespace CkTools.Test.Test.Helper
{
    public class EnumHelperTest
    {
        public class GetAllEnumAttributeData
        {
            [Fact]
            public void GetAllEnumAttributeData_NoError()
            {
                EnumAttributeData[] result = EnumHelper.Instance.GetAllEnumAttributeData(typeof(TestEnumMps));

                Assert.NotNull(result);
                Assert.NotEmpty(result);
                Assert.Equal(6, result.Length);
            }

            [Fact]
            public void GetAllEnumAttributeData_Error()
            {
                ArgumentException ex = Assert.Throws<ArgumentException>(() =>
                  {
                      _ = EnumHelper.Instance.GetAllEnumAttributeData(typeof(object));
                  });

                Assert.NotNull(ex);
            }
        }
    }
}