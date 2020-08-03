using Catalog.Domain.Entities;
using Catalog.Domain.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace Catalog.Domain.Mappers
{
    public class ItemMapper : IItemMapper
    {
        public ItemResponse Map(Item request)
        {
            if (request == null) return null;

            var response = new ItemResponse
            {
                Id = request.Id,
                Name = request.Name,
                Description = request.Description,
            };

            return response;
        }
    }
}
