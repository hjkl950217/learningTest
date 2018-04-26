using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

using DAL;
using IDAL;
using Model;
using Swashbuckle.AspNetCore.Swagger;
using System.IO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace ManufacturerReuqestSubscriber
{
    public class Startup
    {
        #region 总配置区

        public Startup( IConfiguration configuration )
        {
            this.Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        //配置服务
        public void ConfigureServices( IServiceCollection services )
        {

            //添加IOC关系对应
            this.AddIocService( services );

            //下面这行代码是模拟服务扩展
           //services.TryAddSingleton<IResponseProvider , ResponseProvider>( );

            //向中间件添加与配置Swagger
            this.AddSwaggerService( services );


            //配置-跨域服务
            //services.AddCors( options =>
            //{
            //    options.AddPolicy( "any" , builder =>
            //    {
            //        builder.AllowAnyOrigin( )
            //               .AllowAnyMethod( )
            //               .AllowAnyHeader( );

            //    } );
            //} );


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
                })



                ;

            ////增加API版本控制
            //services.AddApiVersioning(opt =>
            //{
            //    //返回时，头部显示API版本
            //    opt.ReportApiVersions = true;
            //    //版本不明确时使用默认版本
            //    opt.AssumeDefaultVersionWhenUnspecified = true;

            //    /*
            //     * //指定默认版本用
            //     * opt.DefaultApiVersion = new ApiVersion( 1 , 0 )
            //     */

            //    //路由规则中的版本参数名
            //    opt.ApiVersionReader = new QueryStringApiVersionReader(parameterName: "version");
            //});

            //.AddControllersAsServices( ); /* 将控制器注册成服务*/





        }

        //配置HTTP请求管道上的中间件
        public void Configure( IApplicationBuilder app , IHostingEnvironment env )
        {
            if( env.IsDevelopment( ) == true )
            {
                //当前环境是开发环境时，启用错误响应页面
                app.UseDeveloperExceptionPage( );
            }


            //配置-记录IP
            app.UseRequestIP( );

            //配置-Swagger请求
            this.AddSwaggerApp( app , env );

            //.net core服务器异步说明
            app.Use( async ( context , next ) =>
            {
                //进来时自己的操作


                await next.Invoke( );//调用下一个中间件

                //出去时自己的操作
            } );

            //配置-静态文件
            app.UseStaticFiles( );

            //配置-MVC
            app.UseMvc( );


        }

        #endregion


        #region IOC对应配置

        /// <summary>
        /// 配置IOC对应关系
        /// </summary>
        /// <param name="services"></param>
        public void AddIocService( IServiceCollection services )
        {


            //临时服务
            //services.AddTransient<IManufacturerRequestService , ManufacturerRequestDAL>( );
            //services.AddTransient<IEmailService , EmailDAL>( );

            //存在整个请求生命周期
            services.AddScoped<IManufacturerRequestService , ManufacturerRequestDAL>( );
            services.AddScoped<IEmailService , EmailDAL>( );
            //单例
            //services.AddSingleton<IManufacturerRequestService , ManufacturerRequestDAL>( );
        }

        #endregion

        #region Swagger配置


        /// <summary>
        /// 配置Swagger请求
        /// </summary>
        /// <param name="app"></param>
        /// <param name="env"></param>
        public void AddSwaggerApp( IApplicationBuilder app , IHostingEnvironment env )
        {
            // 使中间件能够将生成的API信息作为JSON端点。
            //app.UseSwagger();
            app.UseSwagger( c =>
            {
                c.RouteTemplate = "apiDoc/{documentName}/swagger.json";

                //c.PreSerializeFilters.Add( ( swagger , httpReq ) => swagger.Host = httpReq.Host.Value );
            } );

            //允许中间件使用swagger-ui（HTML，JS，CSS等），指定SwaggerUI所需要的JSON文件端点。
            //地址不能与控制器的路由重复
            app.UseSwaggerUI( c =>
            {
                c.RoutePrefix = "apiDoc";
                c.SwaggerEndpoint( "/apiDoc/v1/swagger.json" , "MyApiDoc" );
                c.SwaggerEndpoint( "/apiDoc/v2/swagger.json" , "MyApiDocV2" );
                c.SwaggerEndpoint("/apiDoc/v3/swagger.json", "MyApiDocV3");
            } );
        }

        /// <summary>
        /// 向中间件中添加Swagger并配置
        /// </summary>
        /// <param name="services"></param>
        public void AddSwaggerService( IServiceCollection services )
        {
            services.AddSwaggerGen( options =>
            {
                options.SwaggerDoc( "v1" , new Info { Title = "MyApiDoc" , Version = "v1" } );
                options.SwaggerDoc( "v2" , new Info {
                    Title = "MyApiDocV2" ,
                    Version = "v2",
                    Description="第二版API",
                    TermsOfService="服务条款：巴拉巴拉巴拉...",
                    Contact=new Contact( ) {Name="lynn",Email="lnn@newegg.com",Url="http://none.com" }
                } );
                options.SwaggerDoc("v3", new Info { Title = "MyApiDocV3", Version = "v3" });

               // options.TagActionsBy( api => api.RelativePath );//API分组显示

                //用生成的XML注释文档增强SwaggerUI
                string basePath = AppContext.BaseDirectory;
                string xmlPath = Path.Combine( basePath , "ManufacturerReuqestSubscriber.xml" );
                options.IncludeXmlComments( xmlPath );

                //是否忽略没有标记HTTP动词的方法
                //options.DocInclusionPredicate( ( docName , apiDesc ) =>
                //{
                //    if( apiDesc.HttpMethod == null ) return false;
                //    return true;
                //} );
            } );
        }

        #endregion




    }


}
