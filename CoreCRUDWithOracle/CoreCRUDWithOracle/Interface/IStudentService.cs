using CoreCRUDWithOracle.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreCRUDWithOracle.Interface
{
    public interface IStudentService
    {
        IEnumerable<Student> GetAllStudent();

        Student GetStudentById(int stuId);

        void AddStudent(Student stu);

        void EditStudent(Student stu);

        void DeleteStudent(Student stu);
    }
}
