using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TaskManagementApp.Application.Interfaces;
using Oracle.ManagedDataAccess.Client;
using Dapper;
using System.Linq;
using System.Data;

namespace TaskManagementApp.Infrastructure.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        private readonly IConfiguration _configuration;
        public TaskRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task<int> Add(core.Entities.Task entity)
        {
            entity.DateCreated = DateTime.Now;
            OracleConnection con = new OracleConnection("DATA SOURCE=localhost:1521/xe;USER ID=tami;PASSWORD=tami;DBA PRIVILEGE=SYSDBA;");
            var sql = "INSERT INTO Tasks (Name, Description, Status, DueDate, DateCreated) Values (@Name, @Description, @Status, @DueDate, @DateCreated);";
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = sql;
            //CommandType = CommandType.Text;
            using (var connection = con)
            {
                connection.Open();
                cmd.ExecuteNonQuery();
                var affectedRows = await connection.ExecuteAsync(sql, entity);
                return affectedRows;
            }
            
        }

        public async Task<int> Delete(int id)
        {
            OracleConnection con = new OracleConnection("DATA SOURCE=localhost:1521/xe;USER ID=tami;PASSWORD=tami;DBA PRIVILEGE=SYSDBA;");
            var sql = "DELETE FROM Tasks WHERE Id = @Id;";
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = sql;
            using (var connection = con)
            {
                connection.Open();
                cmd.ExecuteNonQuery();
                var affectedRows = await connection.ExecuteAsync(sql, new { Id = id });
                return affectedRows;
            }
        }

        public async Task<core.Entities.Task> Get(int id)
        {
            OracleConnection con = new OracleConnection("DATA SOURCE=localhost:1521/xe;USER ID=tami;PASSWORD=tami;DBA PRIVILEGE=SYSDBA;");
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            var sql = "SELECT * FROM Tasks WHERE Id = @Id;";
            cmd.CommandText = sql;
            
            using (var connection = con)
            {
                connection.Open();
                cmd.ExecuteReader();
                var result = await connection.QueryAsync<core.Entities.Task>(sql, new { Id = id });
                return result.FirstOrDefault();
            }
        }

        public async Task<IEnumerable<core.Entities.Task>> GetAll()
        {
            OracleConnection con = new OracleConnection("DATA SOURCE=localhost:1521/xe;USER ID=tami;PASSWORD=tami;DBA PRIVILEGE=SYSDBA;");
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            var sql = "SELECT * FROM Tasks;";
            cmd.CommandText = sql;
            using (var connection = con)
            {
                connection.Open();
                cmd.ExecuteReader();
                var result = await connection.QueryAsync<core.Entities.Task>(sql);
                return result;
            }
        }

        public async Task<int> Update(core.Entities.Task entity)
        {
            entity.DateModified = DateTime.Now;
            OracleConnection con = new OracleConnection("DATA SOURCE=localhost:1521/xe;USER ID=tami;PASSWORD=tami;DBA PRIVILEGE=SYSDBA;");
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            var sql = "UPDATE Tasks SET Name = @Name, Description = @Description, Status = @Status, DueDate = @DueDate, DateCreated = @DateCreated, DateModified = @DateModified WHERE Id = @Id;";
            cmd.CommandText = sql;
            using (var connection = new OracleConnection("DATA SOURCE=localhost:1521/xe;USER ID=tami;PASSWORD=tami;DBA PRIVILEGE=SYSDBA;"))
            {
                connection.Open();
                cmd.ExecuteNonQuery();
                var affectedRows = await connection.ExecuteAsync(sql, entity);
                return affectedRows;
            }
        }
    }
}
