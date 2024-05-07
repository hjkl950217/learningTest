using System;
using System.Collections.Generic;
using CkTools.Nova.Entity;
using CkTools.Nova.Factory;
using CkTools.Nova.Helper;

namespace Microsoft.Extensions.DependencyInjection
{
    /// <summary>
    /// 逻辑链扩展
    /// </summary>
    public static class LogicChainExtension
    {
        /// <summary>
        /// 注册逻辑链服务
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddNova(this IServiceCollection services)
        {
            //扫描并注册程序集中所有带标签的实现
            List<StepEntity> taskList = LogicalChainHelper.FindAllTaskEntity();
            foreach(StepEntity item in taskList)
            {
                ServiceDescriptor serviceDescriptor = new ServiceDescriptor(
                    item.StepType,
                    item.StepType,
                    item.Attribute.Lifetime);

                services.Add(serviceDescriptor);
            }

            //注册工厂接口
            services.AddSingleton<INovaFactory>(t =>
            {
                return new NovaFactory(t.GetService<IServiceProvider>(), taskList);
            });

            return services;
        }
    }
}