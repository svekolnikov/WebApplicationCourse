using System;
using Timesheets.Models.Base;

namespace Timesheets.Models
{
    public class Invoice : BaseEntity
    {
        public int ContractId { get; set; }
        public DateTimeOffset Date { get; set; }
    }
}
