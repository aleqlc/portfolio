using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using CreateJWT.Shared;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CreateJWT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : Controller
    {
        [HttpGet]
        public string Get(string user, string pass)
        {
            if (user == "sa")
            {
                return AuthenticationConfig.GenerateJSONWebToken(user);
            }
            else
            {
                return "";
            }
        }

        [Authorize]
        [HttpPost]
        public string Post()
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;
            IEnumerable<Claim> claim = identity.Claims;
            var UserName = claim.Where(c => c.Type == "UserName").Select(c => c.Value).SingleOrDefault();
            return "Welcome to " + UserName + "!";
        }
    }
}
