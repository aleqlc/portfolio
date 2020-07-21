using Dapper;
using DapperUsingMultiQueriesObjects.Common;
using DapperUsingMultiQueriesObjects.IServices;
using DapperUsingMultiQueriesObjects.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace DapperUsingMultiQueriesObjects.Services
{
    public class SchoolService : ISchoolService
    {
        public string Delete(int studentId, int teacherId)
        {
            try
            {
                using (IDbConnection con = new SqlConnection(Global.ConnectionString))
                {
                    if (con.State == ConnectionState.Closed) con.Open();

                    string query = @"DELETE FROM Student WHERE StudentId = " + studentId + ";" +
                                    "DELETE FROM Teacher WHERE TeacherId = " + teacherId;

                    con.QueryMultiple(query);

                    return "Deleted";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public object Get(int studentId, int teacherId)
        {
            dynamic obj = new ExpandoObject();
            using (IDbConnection con = new SqlConnection(Global.ConnectionString))
            {
                if (con.State == ConnectionState.Closed) con.Open();

                string query = @"SELECT * FROM Student WHERE StudentId = " + studentId + ";" +
                                "SELECT * FROM Teacher WHERE TeacherId = " + teacherId;

                using (var multi = con.QueryMultiple(query, null))
                {
                    obj.Student = multi.Read<Student>().ToList();
                    obj.Teacher = multi.Read<Teacher>().ToList();
                }
            }
            return obj;
        }

        public object Gets()
        {
            dynamic obj = new ExpandoObject();
            using (IDbConnection con = new SqlConnection(Global.ConnectionString))
            {
                if (con.State == ConnectionState.Closed) con.Open();

                string query = @"SELECT * FROM Student;SELECT * FROM Teacher";

                using (var multi = con.QueryMultiple(query, null))
                {
                    obj.Students = multi.Read<Student>().ToList();
                    obj.Teachers = multi.Read<Teacher>().ToList();
                }
            }
            return obj;
        }

        public object Save(Student oStudent, Teacher oTeacher)
        {
            dynamic obj = new ExpandoObject();
            try
            {
                using (IDbConnection con = new SqlConnection(Global.ConnectionString))
                {
                    if (con.State == ConnectionState.Closed) con.Open();

                    string query = @"EXEC SP_Student @StudentId, @Name, @Roll;
                                    EXEC SP_Teacher @TeacherId, @FullName, @SubjectName";

                    using (var multi = con.QueryMultiple(query, new
                    {
                       oStudent.StudentId,
                       oStudent.Name,
                       oStudent.Roll,
                       oTeacher.TeacherId,
                       oTeacher.FullName,
                       oTeacher.SubjectName
                    }))
                    {
                        obj.Student = multi.Read<Student>().ToList();
                        obj.Teacher = multi.Read<Teacher>().ToList();
                    }
                }
                return obj;
            }
            catch (Exception ex)
            {

                obj.Message = ex.Message;
            }
            return obj;
        }

        public object Update(Student oStudent, Teacher oTeacher)
        {
            dynamic obj = new ExpandoObject();
            try
            {
                using (IDbConnection con = new SqlConnection(Global.ConnectionString))
                {
                    if (con.State == ConnectionState.Closed) con.Open();

                    string query = @"UPDATE Student SET Name=@Name, Roll=@Roll Where StudentId=@StudentId;
                                     UPDATE Teacher SET FullName=@FullName, SubjectName=@SubjectName Where TeacherId=@TeacherId";

                    using (var multi = con.QueryMultiple(query, new
                    {
                        oStudent.StudentId,
                        oStudent.Name,
                        oStudent.Roll,
                        oTeacher.TeacherId,
                        oTeacher.FullName,
                        oTeacher.SubjectName
                    }))
                    {
                        obj.Student = multi.Read<Student>().ToList();
                        obj.Teacher = multi.Read<Teacher>().ToList();
                    }
                }
                return obj;
            }
            catch (Exception ex)
            {
                obj.Message = ex.Message;
            }
            return obj;
        }
    }
}
