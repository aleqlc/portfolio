using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ConvertToDapper.Model;

namespace ConvertToDapper.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly EmployeeRepository employeeRepository;

        public EmployeeController()
        {
            employeeRepository = new EmployeeRepository();
        }
        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            return employeeRepository.GetAll();
        }
        [HttpGet("{id}")]
        public Employee Get(int id)
        {
            return employeeRepository.GetById(id);
        }
        [HttpPost]
        public void Post([FromBody] Employee prod)
        {
            if (ModelState.IsValid)
                employeeRepository.Add(prod);
        }
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Employee prod)
        {
            prod.EmpId = id;
            if (ModelState.IsValid)
                employeeRepository.Update(prod);
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            employeeRepository.Delete(id);
        }
    }
}
