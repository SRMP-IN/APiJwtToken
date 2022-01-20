using APiJwtToken.Configuration;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
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
        private readonly UserManager<IdentityUser> userManager;
        private readonly Configuration.JwtConfig jwtConfig;

        public TokenController(UserManager<IdentityUser> _userManager, IOptionsMonitor<Configuration.JwtConfig> _jwtConfig)
        {
            jwtConfig = _jwtConfig.CurrentValue;
            userManager = _userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            string EmailId = "Test@test.com";
            string Id = "231093212";
            var IdentityUser = new IdentityUser() { Email = EmailId, UserName = EmailId, Id = Id };

            return Ok(IdentityUser);
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