using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InotifyPracticeWinform2_2
{
    class University
    {
        public String UnivAcronym { get; set; }//두문자어
        public String UnivName { get; set; }
        public String UnivAddress { get; set; }

        public University(string univAcronym, string univName, string univAddress)
        {
            UnivAcronym = univAcronym;
            UnivName = univName;
            UnivAddress = univAddress;
        }
    }
}
