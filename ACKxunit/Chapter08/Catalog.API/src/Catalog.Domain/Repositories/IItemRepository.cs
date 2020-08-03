using Catalog.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Domain.Repositories
{
    public interface IItemRepository
    {
        Task<IEnumerable<Item>> GetAsync();
    }
}
