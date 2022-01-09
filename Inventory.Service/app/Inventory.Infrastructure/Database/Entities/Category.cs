using System;
using Inventory.Infrastructure.Interfaces;

namespace Inventory.Infrastructure.Database.Entities
{
    public class Category : IAuditable
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public DateTimeOffset? CreatedAt { get; set; }
        public DateTimeOffset? ModifiedAt { get; set; }
        public bool IsDeleted { get; set; }
    }
}