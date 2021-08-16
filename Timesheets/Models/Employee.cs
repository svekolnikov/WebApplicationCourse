using Timesheets.Models.Base;

namespace Timesheets.Models
{
    public class Employee : BaseEntity
    {
        public decimal Rate { get; set; }
    }
}
