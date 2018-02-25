using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AutoMapper学习与练习.Orders.DTO;
using AutoMapper学习与练习.Role;

namespace AutoMapper学习与练习.Orders
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
        public IEnumerable<OrderOut> GetOrder(
            [FromRoute]int orderNumber ,
            [FromQuery] string sellerID )
        {
        }

        // GET api/Order/100
        [HttpGet( "{orderNumber:int}" )]
        public dynamic GetOrder2( [FromRoute]int orderNumber )
        {
            // return this.OrderServices.GetOrder( orderNumber );

            RoleEnum? boss = RoleEnum.Boss;
            RoleEnum? devBoss = RoleEnum.DevBoss;

            return new
            {
                isInterA = boss.IsInternal( ).IsDevBoss( ).IsNormal( ).IsCheckSuccess( ) ,
                isInterB = devBoss.IsInternal( ).IsCheckSuccess( )
            };
        }
    }
}