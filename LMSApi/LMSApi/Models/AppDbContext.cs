using Microsoft.EntityFrameworkCore;

namespace LMSApi.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<LeavePeriods> LeavePeriods { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<LeaveTypes> LeaveTypes { get; set; }
        public DbSet<UserLeaveBalances> UserLeaveBalances { get; set; }
        public DbSet<LeaveApplications> LeaveApplications { get; set; }
    }
}
