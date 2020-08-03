using System;
using System.Collections.Generic;
using System.Text;

namespace Catalog.Domain.Responses
{
    public class ItemResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
