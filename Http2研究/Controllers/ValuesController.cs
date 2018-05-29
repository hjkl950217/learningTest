using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Http2研究.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("t{id}")]
        public string Get(int id,string name)
        {
            return $"id: {id}";
        }

        // POST api/values
        [HttpPost("ttt")]
        public string Post([FromBody]TestIn value,[FromQuery] int num)
        {
            return $"POST Value: {value?.value}   int:{num}";
        }




        //// PUT api/values/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/values/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}



    }


    public class TestIn
    {
        public string value { get; set; }
    }
}
