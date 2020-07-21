using System;
using System.Collections.Generic;
using System.Text;
using TaskManagementApp.core.Entities;

namespace TaskManagementApp.Application.Interfaces
{
    public interface ITaskRepository : IGenericRepository<Task>
    {
    }
}
