using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DotNetNote.Models;

namespace DotNetNote.Controllers
{
    [Produces("application/json")]
    //[Route("api/[controller]")]
    [Route("api/TechesApi")]
    //[ApiController]
    public class TechesApiController : ControllerBase
    {
        private ITechRepository _repo;

        //의존성 주입
        public TechesApiController(ITechRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IEnumerable<Tech> GetTech()
        {
            return _repo.GetTechs();
        }

        [HttpPost]
        public Tech PostTech([FromBody] Tech tech)
        {
            _repo.AddTech(tech);
            return tech;
        }
    }
}
