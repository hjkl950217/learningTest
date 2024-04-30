using System;
using System.IO;
using CkTools.FP;
using Xunit;

namespace CKTools.FP.Test
{
    public class 基础函数_File_文件
    {
        [Theory]
        [InlineData(null, false)]
        [InlineData("", false)]
        [InlineData("a", false)]
        [InlineData("a.a", false)]
        public void 带路径文件名判断(string? file, bool expected)
        {
            Assert.Equal(expected, CkFunctions.IsFullFileName(file));
        }

        [Fact]
        public void 带路径文件名判断_区分OS()
        {
            PlatformID platformID = Environment.OSVersion.Platform;
            string fileName = platformID switch
            {
                PlatformID.Win32S => "C:\\a.txt",
                PlatformID.Win32Windows => "C:\\a.txt",
                PlatformID.Win32NT => "C:\\a.txt",
                PlatformID.WinCE => "C:\\a.txt",
                PlatformID.Unix => "/tmp/tt/a.txt",
                _ => "a.txt"
            };

            Assert.True(CkFunctions.IsFullFileName(fileName));
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