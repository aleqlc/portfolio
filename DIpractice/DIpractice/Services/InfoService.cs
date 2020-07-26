using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIpractice.Services
{
    public class InfoService : IInfoService
    {
        public string GetUrl()
        {
            return "http://www.gilbut.co.kr";
        }
    }
}
