using System;
using CkTools.Abstraction.Model;
using Xunit;

namespace CkTools.Abstraction.Test.Helper.EnumHelper
{
    public class EnumHelperTest
    {
        public class GetAllEnumAttributeData
        {
            [Fact]
            public void GetAllEnumAttributeData_NoError()
            {
                EnumValueData[]? result = CkTools.Helper.EnumHelper.Instance.GetOrAddEnumCache(typeof(TestEnumMps)).EnumValueDataArray;

                Assert.NotNull(result);
                Assert.NotEmpty(result);
                Assert.Equal(6, result.Length);
            }

            [Fact]
            public void GetAllEnumAttributeData_Error()
            {
                ArgumentException ex = Assert.Throws<ArgumentException>(() =>
                  {
                      _ = CkTools.Helper.EnumHelper.Instance.GetOrAddEnumCache(typeof(object));
                  });

                Assert.NotNull(ex);
            }
        }
    }
}