using CoreCRUDWithOracle.Interface;
using CoreCRUDWithOracle.Models;
using Microsoft.Extensions.Configuration;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreCRUDWithOracle.Services
{
    public class StudentService : IStudentService
    {
        private readonly string _connectionString;
        public StudentService(IConfiguration _configuration)
        {
            _connectionString = _configuration.GetConnectionString("OracleDBConnection");
        }
        public IEnumerable<Student> GetAllStudent()
        {
            List<Student> stuList = new List<Student>();

            using (OracleConnection con = new OracleConnection(_connectionString))
            {
                using (OracleCommand cmd = new OracleCommand())
                {
                    con.Open();
                    cmd.BindByName = true;
                    cmd.CommandText = "Select ID, Name, Email from Student";
                    OracleDataReader rdr = cmd.ExecuteReader();
                    
                    while (rdr.Read())
                    {
                        Student student = new Student
                        {
                            Id = Convert.ToInt32(rdr["Id"]),
                            Name = rdr["Name"].ToString(),
                            Email = rdr["Email"].ToString()
                        };
                        stuList.Add(student);
                    }
                }
            }

            return stuList;
        }

        public Student GetStudentById(int stuId)
        {
            Student student = new Student();
            using (OracleConnection con = new OracleConnection(_connectionString))
            {
                using (OracleCommand cmd = new OracleCommand())
                {
                    con.Open();
                    cmd.BindByName = true;
                    cmd.CommandText = "Select ID, Name, Email from Student Where Id=" + stuId +"";
                    OracleDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        student.Id = Convert.ToInt32(rdr["Id"]);
                        student.Name = rdr["Name"].ToString();
                        student.Email = rdr["Email"].ToString();
                    }
                }
                return student;
            }
        }

        public void AddStudent(Student stu)
        {
            try
            {
                using (OracleConnection con = new OracleConnection(_connectionString))
                {
                    using (OracleCommand cmd = new OracleCommand())
                    {
                        con.Open();
                        cmd.CommandText = "Insert into Student(Id, Name, Email) Values(" + stu.Id + ",'" + stu.Name + "','" + stu.Email + "')";

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void EditStudent(Student stu)
        {
            try
            {
                using (OracleConnection con = new OracleConnection(_connectionString))
                {
                    using (OracleCommand cmd = new OracleCommand())
                    {
                        con.Open();
                        cmd.CommandText = "Update Student Set Name='"+stu.Name+"', Email='"+stu.Email+"' where Id="+stu.Id+"";

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void DeleteStudent(Student stu)
        {
            try
            {
                using (OracleConnection con = new OracleConnection(_connectionString))
                {
                    using (OracleCommand cmd = new OracleCommand())
                    {
                        con.Open();
                        cmd.CommandText = "Delete from Student where Id="+stu.Id+"";

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
