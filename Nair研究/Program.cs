using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using NairSDK.Core;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace Nair研究
{
    /*
     * ConfigurationBuilder需要添加包："Microsoft.Extensions.Configuration"
     *
     * AddJsonFile需要添加包："Microsoft.Extensions.Configuration.Json"
     *
     * DI-ServiceCollection需要添加包： "Microsoft.Extensions.DependencyInjection"
     *
     * AddOptions需要添加包： "Microsoft.Extensions.Options.ConfigurationExtensions"
     *
     */

    public class NairHelper
    {


    }

    internal class Program
    {
        private static void Main( string[ ] args )
        {
          
            //创建配置
            IConfiguration config = new ConfigurationBuilder()
                .AddInMemoryCollection()//将配置文件的数据加载到内存中
                .SetBasePath( Directory.GetCurrentDirectory() )//设置配置文件所在目录
                                                               //.AddJsonFile( "nairConfig.json" , optional: true , reloadOnChange: true )//指定加载的配置文件
                .AddJsonFile( "appsettingsTTT.json" , optional: true , reloadOnChange: true )
                .Build(); //编译成对象

            /*
             * 
             * var tt = config.GetSection( "NairSDKSettings" );//读取不到
             * var t2 = config.GetSection( "NairSDKSettings:DefaultCluster" );//有值
             * var t3 = config[ "NairSDKSettings" ];//读取不到
             * 
             * 默认会按层级读取，所以上面有层级关系的可以读取
             * 要按对象读取请按：（以下是nair库里的）
             *  config.GetSection("NairSDKSettings").Bind(Settings);
             *  
             *  把数据绑定到Settings这个字段上，修改文件后，Settings也会更新
             */

            //创建DI
            var di = new ServiceCollection()
                .AddOptions() //注入IOptions<T>，这样就可以在DI容器中获取IOptions<T>了
                //.Configure<NairOption>( config )//注入配置数据
                .AddSingleton<IConfiguration>( config )
               // .AddSingleton<INairFactory >(new NairFactory( config ) )//添加Nair的IOC关系
                .AddSingleton<INairFactory,NairFactory>(  )
                .BuildServiceProvider();//编译








            //显示获取的配置
            //var nairOption = di.GetService<IOptions<NairOption>>();
            //  Console.WriteLine( nairOption.Value.NairSDKSettings.DefaultCluster );
            // Console.WriteLine("配置获取成功");


            //获取Nair客户端
     
            var client = di.GetService<INairFactory>().GetNairClient();

            //写入
            //存在则执行修改，否则新增
            string testA = "AAAA";
            var testB = new { Name = "BBBB" };
            client.Put( "TestDB" , "TestA" , testA,30 );
            client.Put( "TestDB" , "TestB" , testB , 30 );
            Console.WriteLine("写入完成");

            Thread.Sleep( 10 * 1000 );

            //读取
            string strA = client.Get( "TestDB" , "TestA" );
            var objB= client.Get( "TestDB" , "TestB" );

            Console.WriteLine( strA );
            Console.WriteLine( "对象："+objB?.ToString() );
            Console.WriteLine( "读取完成" );


            //删除
            client.Remove( "TestDB" , "TestA" );
            client.Remove( "TestDB" , "TestB" );


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine( "程序执行完毕" );
            Console.ReadLine();
        }
    }
}