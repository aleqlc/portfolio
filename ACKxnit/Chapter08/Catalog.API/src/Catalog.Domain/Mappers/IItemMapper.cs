using Catalog.Domain.Entities;
using Catalog.Domain.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace Catalog.Domain.Mappers
{
    public interface IItemMapper
    {
        ItemResponse Map(Item request);
    }
}
