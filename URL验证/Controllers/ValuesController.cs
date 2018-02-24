using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace URL验证.Controllers
{
    // [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        #region 测试api/[controller]Get这种

        // GET api/values/5
        [HttpGet()]
        [Route( "api/[controller]" )]
        public string GetA( int id )
        {
            return "A";
        }

        // GET api/values/5
        [HttpGet()]
        [Route( "api/[controller]Get" )]
        public string GetB( int id )
        {
            return "B";
        }

        #endregion 测试api/[controller]Get这种
    }
}