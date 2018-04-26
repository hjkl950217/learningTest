using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IDAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Model;

namespace ManufacturerReuqestSubscriber.Controllers
{
    //[EnableCors( "any" )]
    //[Route("api/[controller]")]  
    [Produces( "application/json" )]//声明控制器的操作支持返回application/json类型的数据
    public class ManufacturerController : Controller
    {
        public ManufacturerController( IManufacturerRequestService manufacturerRequest ,
       ILoggerFactory loggerFactory )
        {


            //从IOC中拿到DAL实例与日志记录器
            this.manufacturerRequestSer = manufacturerRequest;

            this.logger = loggerFactory.CreateLogger( "ManufacturerController" );

            //this.logger = loggerFactory.CreateLogger <ManufacturerController>();
            //这是使用控制器的完全限定名：ManufacturerReuqestSubscriber.Controllers.ManufacturerController

        }

        #region 接口实例区

        /// <summary>
        /// 厂家请求DAL接口
        /// </summary>
        private readonly IManufacturerRequestService manufacturerRequestSer;
        /// <summary>
        /// 日志记录器
        /// </summary>      
        private readonly ILogger logger;


        #endregion

        #region 属性区

        #endregion



        #region API方法区

        #region GET方法

        //[ResponseCache(VaryByHeader ="User-Agent",Duration =30)]
        /*todo:缓存问题
         * 应该将程序配置为：应该在DAL与真实数据库之间加上缓存。如果有则直接从缓存返回，没有则处理后放到或更新到缓存中，再从缓存中读取，具体实现还没有思路
         * 为了在读取与数据一致性上取得一致，可以在这个实现之后，在缓存上加互斥锁。然后锁配置超时时间，写操作超过这个时间这后，放弃写入，数据还原。
         * 
         * 
         */

        // GET api/Manufacturer-request/5
        /// <summary>
        /// 获取所有请求信息
        /// </summary>
        /// <param name="id">要查询的单个请求ID</param>
        /// <returns></returns>
        [HttpGet]
        [Route( template: "api/[controller]-request" )]
        [ApiExplorerSettings( GroupName = "v1" )]
        public dynamic GetRequestInfo( [FromQuery] int id )
        {
            this.logger.LogInformation( LoggingEvents.GetRequest , $"收到请求：查询所有Manufacturer-request信息,ID为{id}\r\n--------" );


            if( id == 1 )
            {
                var result= this.manufacturerRequestSer.GetAllManfactureRequest( );

                if( result.Count == 0 )
                    //模拟日志域功能。这里事件ID会与上面的一致，方便定位问题
                    this.logger.LogWarning( LoggingEvents.GetRequest , "数据库中没有数据了" );
                return result;
            }
            else
            {
                return this.manufacturerRequestSer.GetManfactureRequest( id );
            }

          


        }

        #endregion


        #region Put方法


        //PUT api/Manufacturer-request
        /// <summary>
        /// 审批请求
        /// </summary>
        /// <param name="requestList">审批的请求ID列表</param>
        /// <returns></returns>
        [HttpPut]
        [Route( template: "api/[controller]-request" )]
        [ApiExplorerSettings( GroupName = "v1" , IgnoreApi = false )]
        public bool ApproRequest( [FromBody]List<int> requestList )
        {
            /*审批设计
             * 只实现了添加、查找与审批
             * 
             * 把这个看成一个审批堆，
             * 新增请求是把请求添加到这个堆
             * 修改请求是在堆里找到这个数据（用ID），然后修改
             * 删除与审批共用一个思路，都是在堆中删除
             * 不同之处：删除是满足删除的条件，审批是满足审批的条件
             * 
             * 
             * 查就是直接在堆里查询
             * 新说明：不应该是移除，而且是修改审批状态
             * 这样就可以避免歧义：找不到时到底是删除了还是本来就不存在
             */
            if( requestList.Count == 0 ) return false;



            return this.manufacturerRequestSer.AuditManfactureRequest( requestList );


        }

        #endregion


        #region Post方法


        //Post api/Manufacturer-request
        /// <summary>
        /// 添加请求信息
        /// </summary>
        /// <remarks>
        /// 添加一条售卖申请到数据库中
        /// </remarks>
        /// <param name="requestIn">添加请求的信息对象</param>
        /// <returns></returns>
        [HttpPost]
        [Route( template: "api/[controller]-request" )]
        [ApiExplorerSettings( GroupName = "v2" )]
        [ProducesResponseType( typeof( bool ) , 201 )]
        [ProducesResponseType( typeof( bool ) , 402 )]
        public async Task<bool> AddNewRequest( [FromBody]ManfactureRequestIn requestIn )
        {

            bool isNull = requestIn == null || requestIn.GetHashCode( ) == 0;
            if( isNull == true ) return false;//判断空值的情况


            try
            {
                bool result = await this.manufacturerRequestSer.AddManfactureRequestAsync( requestIn );

                if( result == false ) this.HttpContext.Response.StatusCode = 402;
                else this.HttpContext.Response.StatusCode = 201;

                this.Response.Headers.Add( "Test" , "TTT" );
                return result;

            }
            catch( Exception )
            {

                return false;
            }

        }


        #region 展示区

        //Post api/Manufacturer-request
        /// <summary>
        /// 添加请求信息
        /// </summary>
        /// <remarks>
        /// 添加一条售卖申请到数据库中
        /// </remarks>
        /// <param name="requestIn">添加请求的信息对象</param>
        /// <returns></returns>
        [HttpPost]
        [Route( template: "api/[controller]-requestV2" )]
        [ApiExplorerSettings( GroupName = "v2" )]
        [ProducesResponseType( typeof( bool ) , 201 )]
        [ProducesResponseType( typeof( bool ) , 402 )]
        public async Task<ActionResult> AddNewRequestV2( [FromBody]ManfactureRequestIn requestIn )
        {

            bool isNull = requestIn == null || requestIn.GetHashCode( ) == 0;
            //if( isNull == true ) return false;//判断空值的情况



            try
            {
                bool result = await this.manufacturerRequestSer.AddManfactureRequestAsync( requestIn );

                if( result == false ) this.HttpContext.Response.StatusCode = 402;
                else this.HttpContext.Response.StatusCode = 201;

                this.Response.Headers.Add( "Test" , "TTT" );
                return this.Json( result );

            }
            catch( Exception )
            {

                return this.Json( false );
            }

        }

        #endregion


        #endregion


        #endregion





    }


}
