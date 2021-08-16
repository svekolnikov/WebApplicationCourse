using System;

namespace Timesheets.Models
{
    public class BaseEntity : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
    }
}
