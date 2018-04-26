using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Text;

namespace ManufacturerReuqestSubscriber.Controllers
{
    [Produces("application/json")]
    //[Route("api/Test")]
    public class TestController : Controller
    {
        private readonly IHttpContextAccessor httpAccessor;

        public TestController(IHttpContextAccessor httpAccessor)
        {
            this.httpAccessor = httpAccessor;
        }

        //[HttpGet]
        //[Route(template: "api/[controller]-request")]
        //public string TestGet()
        //{
        //    return "Get方法";
        //}

        [HttpGet]
        [Route(template: "api/[controller]-request")]
        public dynamic TestGet()
        {

            ////32位
            //string aaa = "aaaa";
            //string result = EncryptProvider.Md5(aaa, MD5Length.L16);

            //return new
            //{
            //    value = result,
            //    Length = result.Length,
            //};
            return null;
        }

        [HttpPost]
        [Route(template: "api/[controller]-request")]
        public string TestPost(string prar)
        {
            return $"Post方法-{prar}";
        }

        [HttpDelete]
        [Route(template: "api/[controller]-request")]
        public string TestDelete(string prar)
        {
            return $"Delete方法-{prar}";
        }

        [HttpPut]
        [Route(template: "api/[controller]-request")]
        public string TestPut(string prar)
        {
            return $"Put方法-{prar}";
        }
    }
}