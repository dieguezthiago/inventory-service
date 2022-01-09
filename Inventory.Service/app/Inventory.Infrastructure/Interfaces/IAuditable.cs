using System;

namespace Inventory.Infrastructure.Interfaces
{
    public interface IAuditable
    {
        DateTimeOffset? CreatedAt { get; set; }
        DateTimeOffset? ModifiedAt { get; set; }
        public bool IsDeleted { get; set; }
    }
}