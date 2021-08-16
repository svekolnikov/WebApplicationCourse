using Timesheets.Models.Base;

namespace Timesheets.Models
{
    public class Contract : BaseEntity
    {
        public Customer Customer { get; set; }
        public int CustomerId { get; set; }
    }
}
