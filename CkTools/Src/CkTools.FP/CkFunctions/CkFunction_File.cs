#pragma warning disable CS8602 // 解引用可能出现空引用。

using System;
using System.IO;
using System.Threading.Tasks;

namespace CkTools.FP
{
    /// <summary>
    /// 函数式功能-文件
    /// </summary>
    /// <remarks>
    /// 定义文件相关的函数式函数或表达式
    /// </remarks>
    public static partial class CkFunctions
    {
        public static Func<string?, bool> IsFullFileName => fileName => Path.IsPathRooted(fileName)
        && Path.IsPathFullyQualified(fileName);

        /// <summary>
        /// 传递一个文件名,尝试创建文件<para></para>
        /// 不包含地址: 使用程序基地址<para></para>
        /// 不存在目标文件夹: 创建文件夹<para></para>
        /// </summary>
        public static Action<string?> TryCreateFile =
            fileName =>
            {
                //为空时直接返回
                if(CkFunctions.IsNullOrEmpty(fileName))
                {
                    return;
                }

                //补全地址
                bool isFull = CkFunctions.IsFullFileName(fileName);
                if(!isFull)
                {
                    fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);
                }

                //存在直接返回
                if(File.Exists(fileName))
                {
                    return;
                }

                lock(fileName)
                {
                    //尝试创建文件夹
                    string dirPath = Path.GetDirectoryName(fileName);
                    if(!Directory.Exists(dirPath))
                    {
                        Directory.CreateDirectory(dirPath);
                    }

                    //创建空白文件
                    File.Create(fileName);
                }
            };

        /// <summary>
        /// 传递一个文件名,尝试删除文件<para></para>
        /// 不包含地址: 使用程序基地址<para></para>
        /// </summary>
        public static Action<string?> TryDeleteFile =
            fileName =>
        {
            //为空时直接返回
            if(CkFunctions.IsNullOrEmpty(fileName))
            {
                return;
            }

            //补全地址
            bool isFull = CkFunctions.IsFullFileName(fileName);
            if(!isFull)
            {
                fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);
            }

            //不存在直接返回
            if(!File.Exists(fileName))
            {
                return;
            }

            #region 尝试删除文件，3次后抛出异常

            int attempts = 0;
            while(true)
            {
                try
                {
                    lock(fileName)
                    {
                        //删除文件
                        File.Delete(fileName);
                    }

                    break;
                }
                catch(IOException)
                {
                    if(++attempts == 3)
                    {
                        throw;
                    }
                    Task.Delay(500).Wait();
                }
            }

            #endregion 尝试删除文件，3次后抛出异常
        };
    }
}

#pragma warning restore CS8602 // 解引用可能出现空引用。