using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using RESTAPI.Data;
using Dapper;

namespace RESTAPI.Service
{
    public class EmployeeServiceDapper
    {
        private string connectionString = "";
        public EmployeeServiceDapper()
        {
            connectionString = @"Persist Security Info=False;User ID=sa;password=sa;Initial Catalog=BLAZORREMPDB; Data Source=DESKTOP-A5HOU30;Connection Timeout=100000;";

        }

        public IDbConnection Connection
        {
            get
            {
                return new SqlConnection(connectionString);
            }
        }

        public void Create(EmployeeInfo emp)
        {
            using (IDbConnection dbConnection = Connection)
            {
                string sQuery = @"INSERT INTO EMPLOYEES (Name,City,Country,Gender) VALUES (@Name,@City,@Country,@Gender)";
                dbConnection.Open();
                dbConnection.Execute(sQuery, emp);
            }
        }

        public async Task<IEnumerable<EmployeeInfo>> GetEmployee()
        {
            try
            {
                using (IDbConnection dbConnection = Connection)
                {
                    dbConnection.Open();
                    return await dbConnection.QueryAsync<EmployeeInfo>("SELECT * FROM Employees");
                }
            }
            catch (Exception)

            {
                throw;
            }
        }

    

        public EmployeeInfo GetEmployeeById(int id)
        {
            using (IDbConnection dbConnection = Connection)
            {
                    string sQuery = @"SELECT * FROM Employees Where EmployeeId=@Id";
                    dbConnection.Open();
                    return dbConnection.Query<EmployeeInfo>(sQuery, new { Id = id }).FirstOrDefault();
            }
        }

        public void UpdateEmployee(EmployeeInfo objEmployee)
        {
            using (IDbConnection dbConnection = Connection)
            {
                string sQuery = @"UPDATE Employees SET Name=@Name, City=@City, Country=@Country, Gender=@Gender Where EmployeeId=@EmployeeId";
                dbConnection.Open();
                dbConnection.Query(sQuery, objEmployee);
            }
        }

        public void DeleteEmpInfo(int id)
        {
            using (IDbConnection dbConnection = Connection)
            {
                string sQuery = @"DELETE * FROM Employees WHERE EmployeeId=@Id";
                dbConnection.Open();
                dbConnection.Execute(sQuery, new { Id = id });
            }
        }
    }
}
