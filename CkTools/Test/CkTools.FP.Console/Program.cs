using System;
using static CkTools.FP.CkFunctions;

namespace ConsoleApp1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            #region 传统方式

            //string host = FtpHelper.GetHostFromConfig();

            //DownArg downArg = FtpHelper.SetDownlodArg(host, "/1.doc");
            //FtpHelper.Download(downArg);

            #endregion 传统方式

            #region Fp方式

            //var setFunc = Currying(FtpHelper.SetDownlodArg);//柯里化后方便函数处理-原生函数式风格不需要这一步
            //var downLoad = Currying(FtpHelper.Download);//柯里化后方便函数处理-原生函数式风格不需要这一步

            //var buildArg = Compose(
            //     setFunc,
            //     FtpHelper.GetHostFromConfig);//组合出构建参数的函数

            //var downFunction = Compose(downLoad, buildArg);//组合出下载函数

            //downFunction("/1.doc");//执行

            #endregion Fp方式

            #region FP方式-添加Try

            var setFunc2 = Currying(FtpHelper.SetDownlodArg);//柯里化后方便函数处理-原生函数式风格不需要这一步
            var downLoad2 = Currying(FtpHelper.Download);//柯里化后方便函数处理-原生函数式风格不需要这一步

            Action<Exception> showError = ex => Console.WriteLine("获取host异常");//准备异常时的处理函数
            Func<string> tryGetHostFromConfig = Try2<string>(showError)(FtpHelper.GetHostFromConfig);//添加异常时的处理
            //Func<string> tryGetHostFromConfig2 = TryWithThrow2<string>(showError)(FtpHelper.GetHostFromConfig);//处理完会抛出异常的版本

            var buildArg2 = Compose(
                 setFunc2,
                 tryGetHostFromConfig);

            var tryDownFunction = Compose(downLoad2, buildArg2);//组合出下载函数

            tryDownFunction("/1.doc");//执行

            #endregion FP方式-添加Try

            Console.WriteLine("End");
            Console.ReadLine();
        }
    }

    public class DownArg
    {
        public string Host { get; set; }
        public string Url { get; set; }
    }

    public static class FtpHelper
    {
        //为了演示方便，这里改为委托的形式

        //public static Func<string> GetHostFromConfig = () => "localhost";//假设从配置文件中读取host
        public static Func<string> GetHostFromConfig = () => throw new Exception("error");//模拟异常

        public static Func<string, string, DownArg> SetDownlodArg =
            (host, url) => new DownArg()
            {
                //通常情况下还有其它属性设置操作,这里简略了
                Host = host,
                Url = url
            };

        public static Func<DownArg, bool> Download =
            downArg =>
          {
              Console.WriteLine("开始下载,host:" + downArg.Host);
              Console.WriteLine("开始下载,url:" + downArg.Url);

              //... 假设这里是下载文件
              Console.WriteLine("下载完成");

              return true;
          };
    }
}