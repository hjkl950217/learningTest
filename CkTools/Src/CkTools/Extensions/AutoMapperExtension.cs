using AutoMapper;

namespace System
{

    public static class AutoMapperExtension
    {
#pragma warning disable S2436 // 做兼容处理,用委托转一下。直接写时不支持?.这种写法


/*

万能映射
            this.CreateMap<WaterPatrolSetUp, WaterPatrolSetUpListDto>()
                .ForMember(dest => dest.WeekArrange, opt => opt.ResolveUsing((a, b, c, ctx) =>
                {
                    int aa = ctx.Mapper.Map<object, int>(a.IsWeekArrange);
                    return 1;
                }));



*/

        /// <summary>
        /// 访问源和目标对象，使用自定义函数映射目标成员。
        /// </summary>
        /// <typeparam name="TSource"></typeparam>
        /// <typeparam name="TDestination"></typeparam>
        /// <typeparam name="TMember"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="mapConfig">Map配置</param>
        /// <param name="mappingFunction">对目标成员的映射委托</param>
        public static void MapFrom<TSource, TDestination, TMember, TResult>(
           this IMemberConfigurationExpression<TSource, TDestination, TMember> mapConfig,
           Func<TSource, TResult> mappingFunction)
#pragma warning restore S2436 // Classes and methods should not have too many generic parameters
        {
            mapConfig.MapFrom<TResult>((src, d) => mappingFunction(src));

            //只是帮包装方法，翻译如下：
            // Func<TSource, TDestination, TResult> map = (src, d) => mappingFunction(src);
        }

#pragma warning disable S2436 // 兼容代码，新版不使用ResolveUsing了，为避免升级库时大规模修改代码才写的

        /// <summary>
        /// 访问源和目标对象，使用自定义函数映射目标成员。<para></para>
        /// 推荐使用<see cref="MapFrom{TSource, TDestination, TMember, TResult}(IMemberConfigurationExpression{TSource, TDestination, TMember}, Func{TSource, TResult})"/>扩展方法
        /// </summary>
        /// <typeparam name="TSource"></typeparam>
        /// <typeparam name="TDestination"></typeparam>
        /// <typeparam name="TMember"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="mapConfig"></param>
        /// <param name="mappingFunction"></param>
        [Obsolete("请参考说明使用新方法")]
        public static void ResolveUsing<TSource, TDestination, TMember, TResult>(
#pragma warning restore S2436 // Classes and methods should not have too many generic parameters
          this IMemberConfigurationExpression<TSource, TDestination, TMember> mapConfig,
          Func<TSource, TResult> mappingFunction)
        {
            mapConfig.MapFrom(mappingFunction);
        }
    }
}