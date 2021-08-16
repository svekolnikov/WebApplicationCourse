namespace Timesheets.Models
{
    public class InvoiceJob
    {
        public Job Job { get; set; }
        public int JobId { get; set; }

        public Invoice Invoice { get; set; }
        public int InvoiceId { get; set; }
    }
}
