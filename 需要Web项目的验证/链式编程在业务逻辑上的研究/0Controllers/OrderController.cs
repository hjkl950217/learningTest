using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using 链式编程在业务逻辑上的研究.Orders.DTO;
using 链式编程在业务逻辑上的研究.Role;

namespace 链式编程在业务逻辑上的研究.Orders
{
    [Route( "api/[controller]" )]
    public class OrderController : Controller
    {
        private IOrderServices OrderServices;

        public OrderController( IOrderServices orderServices )
        {
            this.OrderServices = orderServices;
        }

        // GET api/Order
        [HttpGet( "{orderNumber=0:int}" )]
        public async Task<IEnumerable<OrderOut>> GetOrder(
            [FromRoute]int orderNumber ,
            [FromQuery] string sellerID )
        {
            return await this.OrderServices.GetAllOrder( sellerID );
        }

        // GET api/Order/100
        [HttpGet( "{orderNumber:int}" )]
        public dynamic GetOrder2( [FromRoute]int orderNumber )
        {
            // return this.OrderServices.GetOrder( orderNumber );

            RoleEnum? boss = RoleEnum.Boss;
            RoleEnum? devBoss = RoleEnum.DevBoss;
            RoleEnum? roleNull = null;

            return new
            {
                isInterA = boss.IsInternal( ).IsDevBoss( ).IsNormal( ).IsCheckSuccess( ) ,
                isInterB = boss
                    .CheckRole( RoleEnum.DevBoss )
                    .CheckRole( RoleEnum.InternalSeller )
                    .IsCheckSuccess( ) ,
                //isInterB = devBoss.IsNormal( ).IsDevBoss().IsCheckSuccess( ),
                //isNull=roleNull.IsInternal().IsCheckSuccess()
            };
        }
    }
}