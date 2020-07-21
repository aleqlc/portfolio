using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DapperUsingMultiQueriesObjects.Models
{
    public class School
    {
        public Student Student { get; set; }
        public Teacher Teacher { get; set; }
    }
}
