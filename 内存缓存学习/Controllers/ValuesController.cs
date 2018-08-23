using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace 内存缓存学习.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
    

        public ValuesController()
        {
         
        }

       
        [HttpGet]
        public dynamic Get()
        {
         


            return "";
        }

    }
}
