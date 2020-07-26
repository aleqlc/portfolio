using ConvertToDapper.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConvertToDapper.Services
{
    public interface IService
    {
        void Add(Employee prod);
        IEnumerable<Employee> GetAll();
        Employee GetById(int id);
        void Delete(int id);
        void Update(Employee prod);
    }
}
