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
using 链式编程在业务逻辑上的研究.Orders.DTO;
using 链式编程在业务逻辑上的研究.Orders;
using 链式编程在业务逻辑上的研究.Role;

namespace 链式编程在业务逻辑上的研究
{
    public class Startup
    {
        public Startup( IConfiguration configuration )
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        /// <summary>
        /// 添加Mapper映射关系
        /// </summary>
        /// <param name="services"></param>
        public static void AddMapper( IServiceCollection services )
        {
            var config = new AutoMapper.MapperConfiguration( cfg =>
            {
                cfg.AddProfile( new OrderMapFile() );
            } );

            var mapper = config.CreateMapper();
            services.AddSingleton( mapper );
        }

        public static void AddIoc( IServiceCollection services )
        {
            services.AddScoped<IOrderServices , OrderServices>();


            services.AddSingleton<ICheckRole , CheckRole>( );
        }





        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices( IServiceCollection services )
        {
            AddMapper( services );
            AddIoc( services );

            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure( IApplicationBuilder app , IHostingEnvironment env )
        {
            if( env.IsDevelopment() )
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}