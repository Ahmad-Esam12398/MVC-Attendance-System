using Microsoft.EntityFrameworkCore;

namespace Attendance_Management_System.Data
{
    public class itiContext : DbContext, IitiContext
    {
        public readonly IConfiguration Configuration;
        public itiContext(IConfiguration _configuration)
        {
            Configuration = _configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}
