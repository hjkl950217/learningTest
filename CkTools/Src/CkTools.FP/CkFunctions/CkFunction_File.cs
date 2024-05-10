#pragma warning disable CS8602 // 解引用可能出现空引用。

using System;
using System.IO;
using System.Threading.Tasks;
using CkTools.FP.Extensions.ObjectExtensions;

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
        /// <summary>
        /// 判断文件是否为带路径的文件名，true为带路径
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static bool IsFullFileName(string? fileName)
        {
            return fileName != null
                && fileName.Length > 0
                //&& Path.IsPathRooted(fileName)
                && Path.IsPathFullyQualified(fileName);
        }

        /// <summary>
        /// 传递一个文件名,尝试创建文件<para></para>
        /// 不包含地址: 使用程序基地址<para></para>
        /// 不存在目标文件夹: 创建文件夹<para></para>
        /// </summary>
        public static bool TryCreateFile(string? fileName)
        {
            //为空时直接返回
            if(CkFunctions.IsNullOrEmpty(fileName))
            {
                return false;
            }

            //补全地址
            bool isFull = CkFunctions.IsFullFileName(fileName);
            if(!isFull)
            {
#pragma warning disable CS8604 // 引用类型参数可能为 null。
                fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);
#pragma warning restore CS8604 // 引用类型参数可能为 null。
            }

            //存在直接返回
            if(File.Exists(fileName))
            {
                return false;
            }

            string? dirPath = Path.GetDirectoryName(fileName);
            if(dirPath.IsNullOrEmpty())
            {
                return false;
            }

            lock(fileName)
            {
                //尝试创建文件夹
                if(!Directory.Exists(dirPath))
                {
#pragma warning disable CS8604 // 引用类型参数可能为 null。
                    Directory.CreateDirectory(dirPath);
#pragma warning restore CS8604 // 引用类型参数可能为 null。
                }

                //创建空白文件
                File.Create(fileName).Close();
            }
            return true;
        }

        /// <summary>
        /// 传递一个文件名,尝试删除文件<para></para>
        /// 不包含地址: 使用程序基地址<para></para>
        /// </summary>
        public static bool TryDeleteFile(string? fileName)
        {
            //为空时直接返回
            if(CkFunctions.IsNullOrEmpty(fileName))
            {
                return false;
            }

            //补全地址
            bool isFull = CkFunctions.IsFullFileName(fileName);
            if(!isFull)
            {
#pragma warning disable CS8604 // 引用类型参数可能为 null。
                fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);
#pragma warning restore CS8604 // 引用类型参数可能为 null。
            }

            //不存在直接返回
            if(!File.Exists(fileName))
            {
                return false;
            }

            #region 尝试删除文件，3次后抛出异常

            int attempts = 0;
            while(attempts < 3)
            {
                try
                {
                    lock(fileName)
                    {
                        //删除文件
                        File.Delete(fileName);
                    }

                    break;//直接跳出循环
                }
                catch(IOException)
                {
#pragma warning disable IDE0059 // 不需要赋值
                    attempts++;
#pragma warning restore IDE0059 // 不需要赋值
                    Task.Delay(500).Wait();
                    break;//尝试3次后跳出循环
                }
            }
            return true;

            #endregion 尝试删除文件，3次后抛出异常
        }
    }
}

#pragma warning restore CS8602 // 解引用可能出现空引用。