using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBindingWinform3
{
    class Department : List<Student>
    {
        public string DepartmentName { get; set; }

        public Department(string departmentName)
        {
            DepartmentName = departmentName;
        }

        public List<Student> Members
        {
            get { return this; }
        }
    }
}
