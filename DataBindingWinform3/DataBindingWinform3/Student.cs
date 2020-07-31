using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBindingWinform3
{
    class Student
    {
        public string StudentName { get; set; }
        public string StudentAddress { get; set; }
        public Student(string studentName, string studentAddress)
        {
            StudentName = studentName;
            StudentAddress = studentAddress;
        }
    }
}
