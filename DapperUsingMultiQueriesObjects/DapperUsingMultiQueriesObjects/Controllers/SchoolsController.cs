using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DapperUsingMultiQueriesObjects.IServices;
using DapperUsingMultiQueriesObjects.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DapperUsingMultiQueriesObjects.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SchoolsController : ControllerBase
    {
        private ISchoolService _oSchoolService;
        public SchoolsController(ISchoolService oSchoolService)
        {
            _oSchoolService = oSchoolService;
        }
        // GET: api/Schools
        [HttpGet]
        public object Get()
        {
            return _oSchoolService.Gets();
        }

        // GET api/Schools/5/2
        [HttpGet("{studentId}/{teacherId}", Name ="Get")]
        public object Get(int studentId, int teacherId)
        {
            return _oSchoolService.Get(studentId, teacherId);
        }

        // POST api/Schools
        [HttpPost]
        public object Post([FromBody] School oSchool)
        {
            if (ModelState.IsValid) return _oSchoolService.Save(oSchool.Student, oSchool.Teacher);
            return null;
        }

        // DELETE api/Schools/5/3
        [HttpDelete("{studentId}/{teacherId}")]
        public string Delete(int studentId, int teacherId)
        {
            return _oSchoolService.Delete(studentId, teacherId);
        }

        [HttpPut("{studentId}/{teacherId}")]
        public object Put([FromBody] School oSchool)
        {
            if (ModelState.IsValid) return _oSchoolService.Update(oSchool.Student, oSchool.Teacher);
            return null;
        }
    }
}
