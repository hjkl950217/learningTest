using System;
using Xunit;

namespace Nova.LogicChain.Test.Extensions
{
    public class ObjectExtensionsTest
    {
        [Fact]
        public void CheckNull_True()
        {
            object obj = null;
            var ex = Assert.Throws<ArgumentNullException>(() => obj.CheckNull("test"));

            Assert.NotNull(ex);
        }
    }
}