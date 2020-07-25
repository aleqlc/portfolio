using EmployeeManager.Api.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManager.Api.Repositories
{
    public class EmployeeSqlRepository : IEmployeeRepository
    {
        private readonly AppDbContext db = null;

        public EmployeeSqlRepository(AppDbContext db)
        {
            this.db = db;
        }

        public List<Employee> SelectAll()
        {
            List<Employee> data = db.Employees.FromSqlRaw("SELECT EmployeeID, FirstName, LastName, Title, BirthDate, HireDate, Country FROM Employees ORDER BY EmployeeID ASC").ToList();
            return data;                 
        }
    }
}
