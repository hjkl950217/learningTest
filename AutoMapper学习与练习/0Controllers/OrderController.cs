using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AutoMapper学习与练习.Orders.DTO;
using AutoMapper学习与练习.Role;

namespace AutoMapper学习与练习.Orders
{
    public class OrderController : Controller
    {
        private IOrderServices OrderServices;

        public OrderController( IOrderServices orderServices )
        {
            this.OrderServices = orderServices;
        }

        // GET api/Order
        [Route( "api/[controller]" )]
        [HttpGet]
        public IEnumerable<OrderOut> GetOrder( )
        {
            return this.OrderServices.GetAllOrder( );
        }

        // GET api/Order/1000
        [Route( "api/[controller]/{orderNumber:int}" )]
        [HttpGet]
        public OrderOut GetOrder( [FromRoute]OrderIn orderIn )
        {
            return this.OrderServices.GetOrder( orderIn.OrderNumber );
        }

        // GET api/OrderAmount/1000?
        [Route( "api/[controller]Amount/{orderNumber:int}" )]
        [HttpGet]
        public OrderAmountOut GetOrderAmount( [FromRoute]OrderIn orderIn )
        {
            return this.OrderServices.GetAmountByOrder( orderIn.OrderNumber );
        }

        // GET api/OrderPeole/1000?
        [Route( "api/[controller]People/{orderNumber:int}" )]
        [HttpGet]
        public OrderPeopleOut GetPeople( [FromRoute]OrderIn orderIn )
        {
            return this.OrderServices.GetPeopleByOrder( orderIn.OrderNumber );
        }


    }
}