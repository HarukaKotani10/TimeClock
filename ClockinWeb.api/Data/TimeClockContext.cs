using TimeClockLibrary;
using Microsoft.EntityFrameworkCore;

namespace TimeClock.api.Data
{
    public class TimeClockContext:DbContext
    {
        public TimeClockContext(DbContextOptions<TimeClockContext> opt) : base(opt)
        {

        }

        public DbSet<User> User { get; set; }
        public DbSet<Record> Record { get; set; }
        public DbSet<Branch> Branch { get; set; }
    }
}
