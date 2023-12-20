using System;
using System.IO;
using CkTools.FP;
using Xunit;

namespace CKTools.FP.Test
{
    public class File_文件
    {
        [Theory]
        [InlineData(null, false)]
        [InlineData("", false)]
        [InlineData("a", false)]
        [InlineData("a.a", false)]
        [InlineData(@"c:\a.a", true)]
        public void 带路径文件名判断(string? file, bool expected)
        {
            Assert.Equal(expected, CkFunctions.IsFullFileName(file));
        }

        [Theory]
        [InlineData(null, false)]
        [InlineData("", false)]
        public void 尝试创建文件_失败(string? file, bool expected)
        {
            bool isSucess = CkFunctions.TryCreateFile(file);

            Assert.Equal(expected, isSucess);
        }

        [Fact]
        public void 尝试创建文件_已存在的文件()
        {
            string fn = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "CkTools.FP.xml");

            Assert.False(CkFunctions.TryCreateFile(fn));
        }

        [Fact]
        public void 尝试创建文件_成功()
        {
            string fn = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "创建文件.test");

            Assert.True(CkFunctions.TryCreateFile(fn));
            Assert.True(File.Exists(fn));
            File.Delete(fn);
        }

        [Theory]
        [InlineData(null, false)]
        [InlineData("", false)]
        public void 尝试删除文件_失败(string? file, bool expected)
        {
            bool isSucess = CkFunctions.TryDeleteFile(file);

            Assert.Equal(expected, isSucess);
        }

        [Fact]
        public void 尝试删除文件_不存在的文件()
        {
            string fn = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "删除文件.text");

            Assert.False(CkFunctions.TryDeleteFile(fn));
        }

        [Fact]
        public void 尝试删除文件_成功()
        {
            string fn = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "尝试删除文件.test");
            File.Create(fn).Close();

            Assert.True(CkFunctions.TryDeleteFile(fn));
            Assert.False(File.Exists(fn));
        }
    }
}