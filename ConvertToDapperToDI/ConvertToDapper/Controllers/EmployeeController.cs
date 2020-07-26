using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ConvertToDapper.Model;
using ConvertToDapper.Services;

namespace ConvertToDapper.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private IService _service;
        public EmployeeController(IService service)
        {
            _service = service;
        }


        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            return _service.GetAll();
        }
        [HttpGet("{id}")]
        public Employee Get(int id)
        {
            return _service.GetById(id);
        }
        [HttpPost]
        public void Post([FromBody] Employee prod)
        {
            if (ModelState.IsValid)
                _service.Add(prod);
        }
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Employee prod)
        {
            prod.EmpId = id;
            if (ModelState.IsValid)
                _service.Update(prod);
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _service.Delete(id);
        }
    }
}
