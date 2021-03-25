using CkTools.Helper;
using System;
using Xunit;

namespace CKTools.BaseExtensions.Test.Helper.EnumHelper
{
    public class EnumHelperTest
    {
        public class GetAllEnumAttributeData
        {
            [Fact]
            public void GetAllEnumAttributeData_NoError()
            {
                EnumAttributeData[] result = CkTools.Helper.EnumHelper.Instance.GetAllEnumAttributeData(typeof(TestEnumMps));

                Assert.NotNull(result);
                Assert.NotEmpty(result);
                Assert.Equal(6, result.Length);
            }

            [Fact]
            public void GetAllEnumAttributeData_Error()
            {
                ArgumentException ex = Assert.Throws<ArgumentException>(() =>
                  {
                      _ = CkTools.Helper.EnumHelper.Instance.GetAllEnumAttributeData(typeof(object));
                  });

                Assert.NotNull(ex);
            }
        }
    }
}