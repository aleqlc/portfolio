using DapperUsingMultiQueriesObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DapperUsingMultiQueriesObjects.IServices
{
    public interface ISchoolService
    {
        object Save(Student oStudent, Teacher oTeacher);
        object Gets();

        object Get(int studentId, int teacherId);
        string Delete(int studentId, int teacherId);
        object Update(Student oStudent, Teacher oTeacher);
    }
}
