using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreJwtExample.IServices;
using CoreJwtExample.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CoreJwtExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserInfosController : ControllerBase
    {
        private IUserInfoService _userInfoService;
        public UserInfosController(IUserInfoService userInfoService)
        {
            _userInfoService = userInfoService;
        }

        //Post : api/UserInfos/Authenticate
        [HttpPost("authenticate")]
        public IActionResult Authenticate([FromBody]AuthenticationModel model)
        {
            var user = _userInfoService.Authenticate(model.Username, model.Password);
            if (user == null) return BadRequest(new { message = "Username and password incorrect" });
            return Ok(user);
        }


        private readonly EmployeeRepository employeeRepository = new EmployeeRepository();

        // GET: api/<UserInfosController>
        [Authorize]
        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            return employeeRepository.GetAll();
        }

        [Authorize]
        [HttpGet("{id}")]
        public Employee Get(int id)
        {
            return employeeRepository.GetById(id);
        }

        // POST api/<UserInfosController>
        [Authorize]
        [HttpPost]
        public void Post([FromBody] Employee prod)
        {
            if (ModelState.IsValid)
                employeeRepository.Add(prod);
        }

        // PUT api/<UserInfosController>/5
        [Authorize]
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Employee prod)
        {
            prod.EmpId = id;
            if (ModelState.IsValid)
                employeeRepository.Update(prod);
        }

        // DELETE api/<UserInfosController>/5
        [Authorize]
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            employeeRepository.Delete(id);
        }
    }
}
