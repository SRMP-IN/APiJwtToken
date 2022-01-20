using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APiJwtToken.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TokenController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value2ss", "value2" };
        }
    }
}

//https://dev.to/moe23/asp-net-core-5-rest-api-authentication-with-jwt-step-by-step-140d

//// GET api/<TokenController>/5
//[HttpGet("{id}")]
//public string Get(int id)
//{
//    return "value";
//}

//// POST api/<TokenController>
//[HttpPost]
//public void Post([FromBody] string value)
//{
//}

//// PUT api/<TokenController>/5
//[HttpPut("{id}")]
//public void Put(int id, [FromBody] string value)
//{
//}

//// DELETE api/<TokenController>/5
//[HttpDelete("{id}")]
//public void Delete(int id)
//{
//}