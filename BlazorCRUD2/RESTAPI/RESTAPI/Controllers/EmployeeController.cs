using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RESTAPI.Data;
using RESTAPI.Service;

namespace RESTAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        EmployeeServiceDapper empService = new EmployeeServiceDapper();
        
        [HttpGet]
        public async Task<IEnumerable<EmployeeInfo>> GetEmployees()
        {
            return await empService.GetEmployee();
        }

        [HttpGet]
        [Route("GetById/{id}")]
        public EmployeeInfo GetEmployeeById(int id)
        {
            return empService.GetEmployeeById(id);
        }

        [HttpPost]
        public void Create(EmployeeInfo emp)
        {
            empService.Create(emp);
        }

        [HttpPut]
        public void UpdateEmployee(EmployeeInfo objEmployee)
        {
            empService.UpdateEmployee(objEmployee);
        }

        [HttpDelete]
        [Route("DeleteById/{id}")]
        public void DeleteEmpInfo(int id)
        {
            empService.DeleteEmpInfo(id);
        }
    }
}
