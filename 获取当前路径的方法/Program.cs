using System;

namespace 获取当前路径的方法
{
    class Program
    {
        static void Main(string[] args)
        {
           //按情况复制下面的7行代码到你的项目中，测试后再确定使用那一个
           /* 但下面的方法暂时不能解决这种问题：
            * 
            * 如果用donet cli 扩展工具在命令行中运行，工具会把项目的dll用反射加载的话。
            * 下面的方法都获取的是工具的地址
            * 
            * 
            */

            ////获取模块的完整路径。
            //string path1 = System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName;
            ////获取和设置当前目录(该进程从中启动的目录)的完全限定目录
            //string path2 = System.Environment.CurrentDirectory;
            ////获取应用程序的当前工作目录
            //string path3 = System.IO.Directory.GetCurrentDirectory();
            ////获取程序的基目录
            //string path4 = System.AppDomain.CurrentDomain.BaseDirectory;
            ////获取和设置包括该应用程序的目录的名称
            //string path5 = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase;
            ////获取启动了应用程序的可执行文件的路径
            //string path6 = System.Windows.Forms.Application.StartupPath;
            ////获取启动了应用程序的可执行文件的路径及文件名
            //string path7 = System.Windows.Forms.Application.ExecutablePath;

            Console.ReadLine();
        }
    }
}
