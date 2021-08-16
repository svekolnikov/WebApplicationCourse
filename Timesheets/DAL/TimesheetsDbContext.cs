using Microsoft.EntityFrameworkCore;
using Timesheets.Models;

namespace Timesheets.DAL
{
    public class TimesheetsDbContext : DbContext
    {
        public TimesheetsDbContext(DbContextOptions<TimesheetsDbContext> options)
            :base(options)
        {}

        public DbSet<Employee> Employees { get; set; }
    }
}
