# .net core指南
[toc]

目前本文档只针对.net core 2.0和netstandard2.0

## .net core 程序运行模式
目前.net core只有两种模式：

1.控制台模式
2.asp.net core程序

从本质上来说，asp.net core也是控制台程序。是在基础控制台模式上引入了asp.net core的库，然后就配置成了web应用。运行起来还是一个控制台程序

## .net core与netstandard的关系

.net core是针对库文件
netstandard是针对库文件的**标准**

目前开发中用的最多的是`Microsoft.NETCore.App` 也就是网上下载的.net core 2.0 SDK(用户电脑上对应的是运行时)。但是对开发库来说，会基于netstandard这样的标准来设计。`.net core 2.0 SDK`对应的就是`netstandard 2.0`这个标准。如果以后SDK更新到3.0 也需要对应的标准（可能是netstandard 3.0也不一定）。

这有什么用呢？主要是解决向下兼容的问题。比如现在开发项目时，会用到`AutoMapper`这个库，他在`Nuget`上是这样写明依赖的：

>这里需要补充图片

发现没有？可以同时在`FrameWork`和`netstandard` ！！而且支持`netstandard 1.1`以上的版本(只是基于`netstandard`的会引入一些库，而基于`FrameWork`则框架都提供)。

如果你开发项目，图快。=>在VS创建项目时选择`.Net Core`里面的，会基于SDK创建
如果你开发项目，图依赖少，轻便。=>在VS创建项目时选择`.Net Standard`里面的，会基于Standard创建，然后手动慢慢用入你要的库。
如果你是开发库=>在VS创建项目时选择`.Net Standard`里面的，会基于Standard创建

##asp.net core的两种运行模式

.net core都会在项目的`Program.cs`文件中的`Main`方法中启动。

``` csharp
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder( args )
            //指定Kestrel作为Web主机使用的服务器。
            .UseKestrel( )
            .UseIISIntegration()
            //指定Web主机使用的内容根目录。
            .UseContentRoot( Directory.GetCurrentDirectory( ) )
            //按环境加载应用配置文件
            .ConfigureAppConfiguration( ( hostingContext , config ) =>
            {
                var env = hostingContext.HostingEnvironment;
                config.AddJsonFile( "appsettings.json" , optional: false , reloadOnChange: true )
                      .AddJsonFile( $"appsettings.{env.EnvironmentName}.json" , optional: true , reloadOnChange: true );
                config.AddEnvironmentVariables( );
            } )
            //启动时-日志配置
            .ConfigureLogging( ( hostingContext , logging ) =>
            {
                logging.AddConfiguration( hostingContext.Configuration.GetSection( "Logging" ) );
                logging.AddConsole( );
                logging.AddDebug( );
            } )
            //指定Web主机使用的启动类型
            .UseStartup<Startup>( )
            //指定web主机绑定的地址与端口
            .UseUrls("http://*:8048")
            //构建一个web主机
            .Build( );
```
从上代码是我默认生成的项目解析给你看的，其中有2行代码是我后面加的（后面会讲这是干嘛）：
``` csharp

            .UseIISIntegration()
  
            //指定web主机绑定的地址与端口
            .UseUrls("http://*:8048")
           
```

默认生成的长这样（以`web api`为例）：
``` csharp
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
```

我贴这3段代码的目的主要是为了说这两个.
```
 .UseKestrel( )
 .UseIISIntegration()
```

第一个就是.net core**跨平台**的基础。他是基于[libuv](https://github.com/libuv/libuv)（一个跨平台异步 I/O 库）,然后Kestrel 是基于这个库的一个 [ASP.NET Core Web 服务器](https://docs.microsoft.com/zh-cn/aspnet/core/fundamentals/servers/kestrel?tabs=aspnetcore2x)。只要.net core支持的平台，都会支持这个服务器。 支持的平台可以点[这里](https://docs.microsoft.com/zh-cn/dotnet/core/rid-catalog)查看.

而第二个就是传统的iis部署。我没有使用过，这里就不细说了。

目前运行模式就是这两种。

## asp.net core 服务注册

在web项目中一般会生成一个`Setup.cs`文件（如果你不喜欢也可以自己搞一个，但一定要有里面说到的两个方法，且**方法名不能变**！）。在这里的`ConfigureServices`方法中注册与配置你需要的服务：

``` csharp
        public void ConfigureServices( IServiceCollection services )
        {
            //下两行代码只是为了演示，演示向中间件添加自定义过滤器
            //var userDefinedFilter = new xxxFilter( );
            //services.AddMvc( x => x.Filters.Add( userDefinedFilter ) );

            //添加MVC服务
            services.AddMvc( opt =>
                {
                    //配置缓存
                    opt.CacheProfiles.Add( "Default" , new CacheProfile( ) { Duration = 60 } );
                    opt.CacheProfiles.Add( 
                        "TemplateCache" ,
                        new CacheProfile( )
                        {
                            Duration = 12 * 3600 ,
                            VaryByHeader = "User-Agent"
                        } );
                } )
                .AddJsonOptions(opt =>
                {
                    //使用Newtonsoft.Json里的enum转换器
                    opt.SerializerSettings.Converters.Add(new Newtonsoft.Json.Converters.StringEnumConverter());
                    //忽略空值
                    opt.SerializerSettings.NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore;
                });


        }


```

这里只是列出了部分，如果你什么都不需要，你只需要这样：
``` csharp
        public void ConfigureServices( IServiceCollection services )
        {
            //添加MVC服务
            services.AddMvc();
	     }
```

如果需要添加更多，在实际使用中慢慢加就行。一般来说，方法参数都会是`services`.

如果你看到需要注册服务，记得在这个方法中就行。

需要**注意**的是：通常情况下 `services.AddMvc();`或`services.AddMvcCore(/*...*/);`这样注册MVC的代码，放在方法的最后一个执行位置（就是方法里面最后一行啦）。因为注册服务时，注册方法一般不会去调用其他服务，但有时会有一些服务依赖之前注册的服务（比如它自己从IConfiguration中读取配置），这时就会有**先后顺序的问题**。

然后是另一个重要的方法`Configure`,它一般长这个样子：
``` csharp
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }

```

这个方法是用来配置HTTP请求管道（请求流水线）的，这里的代码需要**严格注意先后顺序**！！！为什么呢？ 就像自来水从河到你家里面需要经过很长的路，上面的`app.UseMvc();`就像你的水龙头一样，你必须得让水经过水厂、水管、加压器等等`中间件`才可以使用。如果你把`app.UseMvc();`放在这个方法的第一行，相当于直接把水龙头安装到水源上了。但我们知道没有处理的过的水是无法直接饮用的（原始请求就二进制流）。

这个我觉得主要是把请求相关的一些东西，从web方法中剥离出来。比如日志、权限检查、异常处理（比如处理下格式），这些东西可以以`中间件`的方式配置在`app.UseMvc();`之前，那么业务代码（Controllers及以下都是）就不需要知道这些东西。这样我们的业务开发就可以更加纯粹。

而中间件的方式更大的好处是它天生就是`异步`的！一个最简单的中间件长这样：
``` csharp
            //.net core服务器异步说明
            app.Use( async ( context , next ) =>
            {
                //进来时自己的操作
                await next.Invoke( );//调用下一个中间件
                //出去时自己的操作
            } );

```

而中间件的开发按规范来都是异步的：
``` csharp
    /// <summary>
    /// IP记录中间件
    /// </summary>
    public class RequestIPMiddleware
    {
        /// <summary>
        /// 下一个中间件委托
        /// </summary>
        private readonly RequestDelegate nextMiddleware;
        /// <summary>
        /// 日志记录器
        /// </summary>
        private readonly ILogger logger;

        public RequestIPMiddleware( RequestDelegate next , ILoggerFactory loggerFactory )
        {
            this.nextMiddleware = next ?? throw new ArgumentNullException( nameof( next ) );
            this.logger = loggerFactory.CreateLogger<RequestIPMiddleware>( );
        }

        /// <summary>
        /// 开始执行中间件逻辑
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public async Task Invoke( HttpContext context )
        {
            //这个中间件就是为了记录IP

            //1.自己的操作
            string ipStr = context.Connection.RemoteIpAddress.ToString( );
            this.logger.LogInformation( "\r\nUser IP: " + ipStr + "\r\n");

            //2.调用下一个中间件
            await this.nextMiddleware.Invoke( context );

            //3.上面的代码执行后的后续工作
            if( context.Response.StatusCode == 204 )
            {
                string logStr = $"IP为:{ipStr}的客户端发送了一次无效查询请求";
                this.logger.LogWarning( LoggingEvents.GetRequest , logStr );
            }

            return;
        }

    }

```

所以`.net core`开发的web在吞吐量上会有极大提高就是这样。web中耗时最上的是在IO上的消耗。采用异步后，请求进到控制器开始，就会从珍贵的`web主线程`中离开，让`web主线程`专心搞接待工作。

## IOC与DI

`IOC`是依赖注入，采用IOC的好处有很多，大家可以自己从网上搜索。而`DI`就是是IOC模式中提供服务的一个容器。本文章中所有的方法，只要参数是`I开头`的，都是通过DI获取实例的。

.net core自带DI容器，目前支持三种模式：

1.临时服务----AddTransient方法
2.存在整个请求生命周期---AddScoped方法
3.单例---AddSingleton方法

注册方式是在`Setup.cs`类中的`ConfigureServices`方法中调用：
``` csharp
services.AddScoped<IEmailService , EmailDAL>( );
```

你也可以单独写一个方法，只要`ConfigureServices`方法中引用到就可以了。

通过IOC后，程序极大的解耦，灵活性大大提高。而在.net core中使用IOC就是这么简单。

PS：
1.IOC有多种注入方式，但推荐构造方法注入，显式写明依赖关系。
2. .net core中的DI也是通过服务注入的，如果你使用控制台，你可以这样使用：

``` csharp
            //创建配置
            IConfiguration config = new ConfigurationBuilder()
                .AddInMemoryCollection()//将配置文件的数据加载到内存中
                .SetBasePath( Directory.GetCurrentDirectory() )//设置配置文件所在目录
                .AddJsonFile( "appsettings.json" , optional: true , reloadOnChange: true )
                .Build(); //编译成对象

             //创建DI
             var di = new ServiceCollection()
                .AddOptions() //注入IOptions<T>，这样就可以在DI容器中获取IOptions<T>了
                //.Configure<NairOption>( config )//注入配置数据
                .AddSingleton<IConfiguration>( config )
               // .AddSingleton<INairFactory >(new NairFactory( config ) )//添加Nair的IOC关系
                .AddSingleton<INairFactory,NairFactory>()
                .BuildServiceProvider();//编译
              
              
            //获取Nair客户端
            var client = di.GetService<INairFactory>().GetNairClient();

```


## asp.net core 配置


在`Framework`中，web应用是通过web.config来配置的。但是在`.net core`中，配置主要由以下几个部分构成：

1.注册服务时的配置
2.在http请求管道中配置
3.通过配置文件

而配置文件也大多数是给配置服务使用的。具体使用可以网上搜索下，有很多。这里就不细说了。

PS：`Setup.cs`中有一个属性叫`public IConfiguration Configuration { get; }`这个`IConfiguration`是一个接口，读取好的配置都会放在这里。不过配置从那里读取的，都可以`Configuration ["你的配置名"]`这样读取，默认会取第一个（有时配置会重名）。

而里面放的是一堆配置提供者的实例，有一个配置提供者的接口，只要你实现了这个接口，你也可以向里面灌入你的配置。这就为从**多个地方读取配置**提供了可能。



## .net core项目文件和记事本开发

在VS 2017上开发.net core项目时，可以这样操作：

>这里需要补充图片

直接对项目文件进行修改，然后就可以达到项目配置 修改项目的一些处理了。几乎你在VS上**能点击的功能**都能在这里通过代码配置，VS上修改项目后，它也会把修改写到个文件中。

有人用VS code或其他来开发`.net core`项目，秘密在这里。有时开发中不想打开VS，就直接通过修改文件+命令编译来搞定。

## .net CLI工具

>这里需要补充图片


如图所示，.net core也可以通过命令行来进行一些操作，比如发布、编译、还原包等等。VS中你能完成的`项目级别`的功能，这里都可以通过命令行搞定。一手记事本+命令行操作，岂不美哉？
关于命令的使用，点击[这里](https://docs.microsoft.com/zh-cn/dotnet/core/tools/?tabs=netcore2x)查看。

## 包管理

>这里需要补充图片

如图所示，以前在`Framework`中，包就只有一个，现在被拆分成了很多个。也就是上面说到的，你可以在`NetStandard`的基础上从0添加库来达到依赖最小的效果。

在以前的`Framework`中，更新版本非常容易导致项目出问题。但是在`.net core`中，你不用担心这个问题，我在开发还遇到过引用`NetStandard 1.0`级别的库呢。只要项目依赖中的库和对应的版本在`Nuget`上有，就完全不用担心。上面讲 `.net core与netstandard的关系`时也提到了这个。

只要你写对你要的版本，依赖的问题交给`Nuget`搞定~！






