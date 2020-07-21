using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetNote.Models
{
    public interface ITechRepository
    {
        void AddTech(Tech model);//입력
        List<Tech> GetTechs();//출력
    }
}
