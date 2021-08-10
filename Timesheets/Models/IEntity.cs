using System;

namespace Timesheets.Models
{
    public interface IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
    }
}
