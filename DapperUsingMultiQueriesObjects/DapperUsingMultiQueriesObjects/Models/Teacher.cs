using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DapperUsingMultiQueriesObjects.Models
{
    public class Teacher
    {
        public int TeacherId { get; set; }
        public string FullName { get; set; }
        public string SubjectName { get; set; }
        public string Message { get; set; }
    }
}
