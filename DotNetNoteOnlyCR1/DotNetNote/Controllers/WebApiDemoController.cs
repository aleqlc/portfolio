using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Net;

namespace DotNetNote.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WebApiDemoController : Controller
    {
        [HttpGet]
        public JsonResult Get()
        {
            return Json(new { Name = "홍길동" });
        }

        [HttpPost]
        public JsonResult Post([FromBody]WebApiDemoClass name)
        {
            if (ModelState.IsValid)
            {
                Response.StatusCode = (int)HttpStatusCode.Created;
                return Json(true);
            }
            Response.StatusCode = (int)HttpStatusCode.BadRequest;
            return Json("실패");
        }
    }

    public class WebApiDemoClass
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50, MinimumLength =3, ErrorMessage ="3자 이상")]
        public string Name { get; set; }
    }
}
