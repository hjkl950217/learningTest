# .net coreָ��
[toc]

Ŀǰ���ĵ�ֻ���.net core 2.0��netstandard2.0

## .net core ��������ģʽ
Ŀǰ.net coreֻ������ģʽ��

1.����̨ģʽ
2.asp.net core����

�ӱ�������˵��asp.net coreҲ�ǿ���̨�������ڻ�������̨ģʽ��������asp.net core�Ŀ⣬Ȼ������ó���webӦ�á�������������һ������̨����

## .net core��netstandard�Ĺ�ϵ

.net core����Կ��ļ�
netstandard����Կ��ļ���**��׼**

Ŀǰ�������õ�������`Microsoft.NETCore.App` Ҳ�����������ص�.net core 2.0 SDK(�û������϶�Ӧ��������ʱ)�����ǶԿ�������˵�������netstandard�����ı�׼����ơ�`.net core 2.0 SDK`��Ӧ�ľ���`netstandard 2.0`�����׼������Ժ�SDK���µ�3.0 Ҳ��Ҫ��Ӧ�ı�׼��������netstandard 3.0Ҳ��һ������

����ʲô���أ���Ҫ�ǽ�����¼��ݵ����⡣�������ڿ�����Ŀʱ�����õ�`AutoMapper`����⣬����`Nuget`��������д�������ģ�

>������Ҫ����ͼƬ

����û�У�����ͬʱ��`FrameWork`��`netstandard` ��������֧��`netstandard 1.1`���ϵİ汾(ֻ�ǻ���`netstandard`�Ļ�����һЩ�⣬������`FrameWork`���ܶ��ṩ)��

����㿪����Ŀ��ͼ�졣=>��VS������Ŀʱѡ��`.Net Core`����ģ������SDK����
����㿪����Ŀ��ͼ�����٣���㡣=>��VS������Ŀʱѡ��`.Net Standard`����ģ������Standard������Ȼ���ֶ�����������Ҫ�Ŀ⡣
������ǿ�����=>��VS������Ŀʱѡ��`.Net Standard`����ģ������Standard����

##asp.net core����������ģʽ

.net core��������Ŀ��`Program.cs`�ļ��е�`Main`������������

``` csharp
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder( args )
            //ָ��Kestrel��ΪWeb����ʹ�õķ�������
            .UseKestrel( )
            .UseIISIntegration()
            //ָ��Web����ʹ�õ����ݸ�Ŀ¼��
            .UseContentRoot( Directory.GetCurrentDirectory( ) )
            //����������Ӧ�������ļ�
            .ConfigureAppConfiguration( ( hostingContext , config ) =>
            {
                var env = hostingContext.HostingEnvironment;
                config.AddJsonFile( "appsettings.json" , optional: false , reloadOnChange: true )
                      .AddJsonFile( $"appsettings.{env.EnvironmentName}.json" , optional: true , reloadOnChange: true );
                config.AddEnvironmentVariables( );
            } )
            //����ʱ-��־����
            .ConfigureLogging( ( hostingContext , logging ) =>
            {
                logging.AddConfiguration( hostingContext.Configuration.GetSection( "Logging" ) );
                logging.AddConsole( );
                logging.AddDebug( );
            } )
            //ָ��Web����ʹ�õ���������
            .UseStartup<Startup>( )
            //ָ��web�����󶨵ĵ�ַ��˿�
            .UseUrls("http://*:8048")
            //����һ��web����
            .Build( );
```
���ϴ�������Ĭ�����ɵ���Ŀ�������㿴�ģ�������2�д������Һ���ӵģ�����ὲ���Ǹ����
``` csharp

            .UseIISIntegration()
  
            //ָ��web�����󶨵ĵ�ַ��˿�
            .UseUrls("http://*:8048")
           
```

Ĭ�����ɵĳ���������`web api`Ϊ������
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

������3�δ����Ŀ����Ҫ��Ϊ��˵������.
```
 .UseKestrel( )
 .UseIISIntegration()
```

��һ������.net core**��ƽ̨**�Ļ��������ǻ���[libuv](https://github.com/libuv/libuv)��һ����ƽ̨�첽 I/O �⣩,Ȼ��Kestrel �ǻ���������һ�� [ASP.NET Core Web ������](https://docs.microsoft.com/zh-cn/aspnet/core/fundamentals/servers/kestrel?tabs=aspnetcore2x)��ֻҪ.net core֧�ֵ�ƽ̨������֧������������� ֧�ֵ�ƽ̨���Ե�[����](https://docs.microsoft.com/zh-cn/dotnet/core/rid-catalog)�鿴.

���ڶ������Ǵ�ͳ��iis������û��ʹ�ù�������Ͳ�ϸ˵�ˡ�

Ŀǰ����ģʽ���������֡�

## asp.net core ����ע��

��web��Ŀ��һ�������һ��`Setup.cs`�ļ�������㲻ϲ��Ҳ�����Լ���һ������һ��Ҫ������˵����������������**���������ܱ�**�������������`ConfigureServices`������ע������������Ҫ�ķ���

``` csharp
        public void ConfigureServices( IServiceCollection services )
        {
            //�����д���ֻ��Ϊ����ʾ����ʾ���м������Զ��������
            //var userDefinedFilter = new xxxFilter( );
            //services.AddMvc( x => x.Filters.Add( userDefinedFilter ) );

            //���MVC����
            services.AddMvc( opt =>
                {
                    //���û���
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
                    //ʹ��Newtonsoft.Json���enumת����
                    opt.SerializerSettings.Converters.Add(new Newtonsoft.Json.Converters.StringEnumConverter());
                    //���Կ�ֵ
                    opt.SerializerSettings.NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore;
                });


        }


```

����ֻ���г��˲��֣������ʲô������Ҫ����ֻ��Ҫ������
``` csharp
        public void ConfigureServices( IServiceCollection services )
        {
            //���MVC����
            services.AddMvc();
	     }
```

�����Ҫ��Ӹ��࣬��ʵ��ʹ���������Ӿ��С�һ����˵����������������`services`.

����㿴����Ҫע����񣬼ǵ�����������о��С�

��Ҫ**ע��**���ǣ�ͨ������� `services.AddMvc();`��`services.AddMvcCore(/*...*/);`����ע��MVC�Ĵ��룬���ڷ��������һ��ִ��λ�ã����Ƿ����������һ����������Ϊע�����ʱ��ע�᷽��һ�㲻��ȥ�����������񣬵���ʱ����һЩ��������֮ǰע��ķ��񣨱������Լ���IConfiguration�ж�ȡ���ã�����ʱ�ͻ���**�Ⱥ�˳�������**��

Ȼ������һ����Ҫ�ķ���`Configure`,��һ�㳤������ӣ�
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

�����������������HTTP����ܵ���������ˮ�ߣ��ģ�����Ĵ�����Ҫ**�ϸ�ע���Ⱥ�˳��**������Ϊʲô�أ� ��������ˮ�Ӻӵ����������Ҫ�����ܳ���·�������`app.UseMvc();`�������ˮ��ͷһ������������ˮ����ˮ����ˮ�ܡ���ѹ���ȵ�`�м��`�ſ���ʹ�á�������`app.UseMvc();`������������ĵ�һ�У��൱��ֱ�Ӱ�ˮ��ͷ��װ��ˮԴ���ˡ�������֪��û�д���Ĺ���ˮ���޷�ֱ�����õģ�ԭʼ����Ͷ�����������

����Ҿ�����Ҫ�ǰ�������ص�һЩ��������web�����а��������������־��Ȩ�޼�顢�쳣�������紦���¸�ʽ������Щ����������`�м��`�ķ�ʽ������`app.UseMvc();`֮ǰ����ôҵ����루Controllers�����¶��ǣ��Ͳ���Ҫ֪����Щ�������������ǵ�ҵ�񿪷��Ϳ��Ը��Ӵ��⡣

���м���ķ�ʽ����ĺô�������������`�첽`�ģ�һ����򵥵��м����������
``` csharp
            //.net core�������첽˵��
            app.Use( async ( context , next ) =>
            {
                //����ʱ�Լ��Ĳ���
                await next.Invoke( );//������һ���м��
                //��ȥʱ�Լ��Ĳ���
            } );

```

���м���Ŀ������淶�������첽�ģ�
``` csharp
    /// <summary>
    /// IP��¼�м��
    /// </summary>
    public class RequestIPMiddleware
    {
        /// <summary>
        /// ��һ���м��ί��
        /// </summary>
        private readonly RequestDelegate nextMiddleware;
        /// <summary>
        /// ��־��¼��
        /// </summary>
        private readonly ILogger logger;

        public RequestIPMiddleware( RequestDelegate next , ILoggerFactory loggerFactory )
        {
            this.nextMiddleware = next ?? throw new ArgumentNullException( nameof( next ) );
            this.logger = loggerFactory.CreateLogger<RequestIPMiddleware>( );
        }

        /// <summary>
        /// ��ʼִ���м���߼�
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public async Task Invoke( HttpContext context )
        {
            //����м������Ϊ�˼�¼IP

            //1.�Լ��Ĳ���
            string ipStr = context.Connection.RemoteIpAddress.ToString( );
            this.logger.LogInformation( "\r\nUser IP: " + ipStr + "\r\n");

            //2.������һ���м��
            await this.nextMiddleware.Invoke( context );

            //3.����Ĵ���ִ�к�ĺ�������
            if( context.Response.StatusCode == 204 )
            {
                string logStr = $"IPΪ:{ipStr}�Ŀͻ��˷�����һ����Ч��ѯ����";
                this.logger.LogWarning( LoggingEvents.GetRequest , logStr );
            }

            return;
        }

    }

```

����`.net core`������web���������ϻ��м�����߾���������web�к�ʱ���ϵ�����IO�ϵ����ġ������첽�����������������ʼ���ͻ������`web���߳�`���뿪����`web���߳�`ר�ĸ�Ӵ�������

## IOC��DI

`IOC`������ע�룬����IOC�ĺô��кܶ࣬��ҿ����Լ���������������`DI`������IOCģʽ���ṩ�����һ�������������������еķ�����ֻҪ������`I��ͷ`�ģ�����ͨ��DI��ȡʵ���ġ�

.net core�Դ�DI������Ŀǰ֧������ģʽ��

1.��ʱ����----AddTransient����
2.��������������������---AddScoped����
3.����---AddSingleton����

ע�᷽ʽ����`Setup.cs`���е�`ConfigureServices`�����е��ã�
``` csharp
services.AddScoped<IEmailService , EmailDAL>( );
```

��Ҳ���Ե���дһ��������ֻҪ`ConfigureServices`���������õ��Ϳ����ˡ�

ͨ��IOC�󣬳��򼫴�Ľ������Դ����ߡ�����.net core��ʹ��IOC������ô�򵥡�

PS��
1.IOC�ж���ע�뷽ʽ�����Ƽ����췽��ע�룬��ʽд��������ϵ��
2. .net core�е�DIҲ��ͨ������ע��ģ������ʹ�ÿ���̨�����������ʹ�ã�

``` csharp
            //��������
            IConfiguration config = new ConfigurationBuilder()
                .AddInMemoryCollection()//�������ļ������ݼ��ص��ڴ���
                .SetBasePath( Directory.GetCurrentDirectory() )//���������ļ�����Ŀ¼
                .AddJsonFile( "appsettings.json" , optional: true , reloadOnChange: true )
                .Build(); //����ɶ���

             //����DI
             var di = new ServiceCollection()
                .AddOptions() //ע��IOptions<T>�������Ϳ�����DI�����л�ȡIOptions<T>��
                //.Configure<NairOption>( config )//ע����������
                .AddSingleton<IConfiguration>( config )
               // .AddSingleton<INairFactory >(new NairFactory( config ) )//���Nair��IOC��ϵ
                .AddSingleton<INairFactory,NairFactory>()
                .BuildServiceProvider();//����
              
              
            //��ȡNair�ͻ���
            var client = di.GetService<INairFactory>().GetNairClient();

```


## asp.net core ����


��`Framework`�У�webӦ����ͨ��web.config�����õġ�������`.net core`�У�������Ҫ�����¼������ֹ��ɣ�

1.ע�����ʱ������
2.��http����ܵ�������
3.ͨ�������ļ�

�������ļ�Ҳ������Ǹ����÷���ʹ�õġ�����ʹ�ÿ������������£��кܶࡣ����Ͳ�ϸ˵�ˡ�

PS��`Setup.cs`����һ�����Խ�`public IConfiguration Configuration { get; }`���`IConfiguration`��һ���ӿڣ���ȡ�õ����ö����������������ô������ȡ�ģ�������`Configuration ["���������"]`������ȡ��Ĭ�ϻ�ȡ��һ������ʱ���û���������

������ŵ���һ�������ṩ�ߵ�ʵ������һ�������ṩ�ߵĽӿڣ�ֻҪ��ʵ��������ӿڣ���Ҳ�������������������á����Ϊ��**����ط���ȡ����**�ṩ�˿��ܡ�



## .net core��Ŀ�ļ��ͼ��±�����

��VS 2017�Ͽ���.net core��Ŀʱ����������������

>������Ҫ����ͼƬ

ֱ�Ӷ���Ŀ�ļ������޸ģ�Ȼ��Ϳ��Դﵽ��Ŀ���� �޸���Ŀ��һЩ�����ˡ���������VS��**�ܵ���Ĺ���**����������ͨ���������ã�VS���޸���Ŀ����Ҳ����޸�д�����ļ��С�

������VS code������������`.net core`��Ŀ�������������ʱ�����в����VS����ֱ��ͨ���޸��ļ�+����������㶨��

## .net CLI����

>������Ҫ����ͼƬ


��ͼ��ʾ��.net coreҲ����ͨ��������������һЩ���������緢�������롢��ԭ���ȵȡ�VS��������ɵ�`��Ŀ����`�Ĺ��ܣ����ﶼ����ͨ�������и㶨��һ�ּ��±�+�����в����������գ�
���������ʹ�ã����[����](https://docs.microsoft.com/zh-cn/dotnet/core/tools/?tabs=netcore2x)�鿴��

## ������

>������Ҫ����ͼƬ

��ͼ��ʾ����ǰ��`Framework`�У�����ֻ��һ�������ڱ���ֳ��˺ܶ����Ҳ��������˵���ģ��������`NetStandard`�Ļ����ϴ�0��ӿ����ﵽ������С��Ч����

����ǰ��`Framework`�У����°汾�ǳ����׵�����Ŀ�����⡣������`.net core`�У��㲻�õ���������⣬���ڿ���������������`NetStandard 1.0`����Ŀ��ء�ֻҪ��Ŀ�����еĿ�Ͷ�Ӧ�İ汾��`Nuget`���У�����ȫ���õ��ġ����潲 `.net core��netstandard�Ĺ�ϵ`ʱҲ�ᵽ�������

ֻҪ��д����Ҫ�İ汾�����������⽻��`Nuget`�㶨~��






