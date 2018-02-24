using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using 链式编程在业务逻辑上的研究.Order.DTO;

namespace 链式编程在业务逻辑上的研究.Order
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
        public async Task<IEnumerable<OrderOut>> GetOrder( [FromRoute]int orderNumber )
        {
            return await this.OrderServices.GetAllOrder();
        }

        // GET api/Order/100
        [HttpGet( "{orderNumber:int}" )]
        public dynamic GetOrder2( [FromRoute]int orderNumber )
        {
            return this.OrderServices.GetOrder( orderNumber );
        }
    }
}