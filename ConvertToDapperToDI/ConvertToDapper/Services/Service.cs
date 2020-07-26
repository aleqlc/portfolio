using ConvertToDapper.Model;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace ConvertToDapper.Services
{
    public class Service : IService
    {
        private string connectionString;
        public Service()
        {
            connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=EmployeeAPIDB;Integrated Security=True";
        }
        public IDbConnection Connection
        {
            get
            {
                return new SqlConnection(connectionString);
            }
        }
        public void Add(Employee prod)
        {
            using (IDbConnection dbConnection = Connection)
            {
                string sQuery = @"INSERT INTO EmployeeInfos (EmpId, EmpName, Designation, Department) VALUES (@EmpId, @EmpName, @Designation, @Department)";
                dbConnection.Open();
                dbConnection.Execute(sQuery, prod);
            }
        }

        public void Delete(int id)
        {
            using (IDbConnection dbConnection = Connection)
            {
                string sQuery = @"DELETE FROM EmployeeInfos Where EmpId=@Id";
                dbConnection.Open();
                dbConnection.Execute(sQuery, new { Id = id });
            }
        }

        public IEnumerable<Employee> GetAll()
        {
            using (IDbConnection dbConnection = Connection)
            {
                string sQuery = @"SELECT * FROM EmployeeInfos";
                dbConnection.Open();
                return dbConnection.Query<Employee>(sQuery);
            }
        }

        public Employee GetById(int id)
        {
            using (IDbConnection dbConnection = Connection)
            {
                string sQuery = @"SELECT * FROM EmployeeInfos Where EmpId=@Id";
                dbConnection.Open();
                return dbConnection.Query<Employee>(sQuery, new { Id = id }).FirstOrDefault();
            }
        }

        public void Update(Employee prod)
        {
            using (IDbConnection dbConnection = Connection)
            {
                string sQuery = @"UPDATE EmployeeInfos SET EmpId=@EmpId, EmpName=@EmpName, Designation=@Designation, Department=@Department Where EmpId=@EmpId";
                dbConnection.Open();
                dbConnection.Query(sQuery, prod);
            }
        }
    }
}
