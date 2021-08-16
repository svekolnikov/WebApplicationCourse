using Timesheets.Models.Base;

namespace Timesheets.Models
{
    public class JobEmployee : BaseEntity
    {
        public Job Job { get; set; }
        public int JobId { get; set; }

        public Employee Employee { get; set; }
        public int EmployeeId { get; set; }
    }
}
