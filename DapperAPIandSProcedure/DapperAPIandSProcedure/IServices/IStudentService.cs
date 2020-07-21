using DapperAPIandSProcedure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DapperAPIandSProcedure.IServices
{
    public interface IStudentService
    {
        Student Save(Student oStudent);
        List<Student> Gets();
        Student Get(int studentId);
        string Delete(int studentId);
        Student Update(Student oStudent);
    }
}
