﻿using System;
using Xunit;

#pragma warning disable CS8625 // 无法将 null 文本转换为不可为 null 的引用类型。

namespace CKTools.BaseExtensions.Test.Extensions
{
    public class OperatorExtensionsTest
    {
        public class TestEntity
        {
            public int A { get; set; } = 10;
            public string? B { get; set; }
        }

        public class GetDataOrDefaultTest
        {
            #region 两个委托的版本

            [Fact]
            public void Two_Work_WithNoException()
            {
                TestEntity testEntity = new TestEntity();
                int hashCode = testEntity.GetHashCode();
                TestEntity? result = testEntity.GetDataOrDefault(getData: t => t, defaultValueFunc: () => new TestEntity());

                Assert.Equal(hashCode, result.GetHashCode());
            }

            [Fact]
            public void Two_DataIsNull_WithNoException()
            {
                TestEntity? testEntity = null;
                TestEntity? result = testEntity.GetDataOrDefault(getData: t => t, defaultValueFunc: () => new TestEntity());

                Assert.NotNull(result);
            }

            [Fact]
            public void Two_DataIsNullAndIntPropertyIsNull_WithNoException()
            {
                TestEntity? testEntity = null;
                int result = testEntity.GetDataOrDefault(getData: t => t.A, defaultValueFunc: () => 1);
            }

            [Fact]
            public void Two_DataIsNullAndStringPropertyIsNull_WithNoException()
            {
                TestEntity? testEntity = null;
                string? result = testEntity.GetDataOrDefault(getData: t => t.B, defaultValueFunc: () => string.Empty);

                Assert.NotNull(result);
            }

            [Fact]
            public void Two_GetDataIsNull_WithException()
            {
                TestEntity testEntity = new TestEntity();

                ArgumentNullException? ex = Assert.Throws<ArgumentNullException>(() =>
                {
                    _ = testEntity.GetDataOrDefault(getData: null, defaultValueFunc: () => new TestEntity());
                });

                Assert.NotNull(ex);
            }

            [Fact]
            public void Two_DefaultValueFunc_WithException()
            {
                TestEntity testEntity = new TestEntity();

                ArgumentNullException? ex = Assert.Throws<ArgumentNullException>(() =>
                {
                    _ = testEntity.GetDataOrDefault(getData: t => t, defaultValueFunc: null);
                });

                Assert.NotNull(ex);
            }

            #endregion 两个委托的版本

            #region 一个委托的版本

            [Fact]
            public void One_DataIsNull_WithNoException()
            {
                TestEntity? testEntity = null;
                _ = testEntity.GetDataOrDefault(getData: t => t, defaultValue: new TestEntity());
            }

            [Fact]
            public void One_GetDataIsNull_WithException()
            {
                TestEntity testEntity = new TestEntity();

                ArgumentNullException? ex = Assert.Throws<ArgumentNullException>(() =>
                {
                    _ = testEntity.GetDataOrDefault(getData: null, defaultValue: new TestEntity());
                });

                Assert.NotNull(ex);
            }

            #endregion 一个委托的版本
        }
    }
}

#pragma warning restore CS8625 // 无法将 null 文本转换为不可为 null 的引用类型。