using Microsoft.EntityFrameworkCore;
using Attendance_Management_System.Models;
using Microsoft.Extensions.Configuration;

namespace Attendance_Management_System.Data
{
    public class itiContext : DbContext, IitiContext
    {
        #region DbSets
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<ScheduleEvent> ScheduleEvents { get; set; }
        public DbSet<Track> Tracks { get; set; }
        public DbSet<User> Users { get; set; }
        public List<Student> students { get; set; }
        public List<ITIProgram> Programs { get; set; }
        public List<Attendance> Attendances { get; set; }
        #endregion
        public readonly IConfiguration Configuration;

        public itiContext(DbContextOptions<itiContext> options, IConfiguration _configuration) : base(options)
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
            #region Schedule Relations and Validations
            //  1-M relationship between Schedule and Track
            modelBuilder.Entity<Schedule>()
                .HasOne(s => s.Track)
                .WithMany(t => t.Schedules)
                .HasForeignKey(s => s.TrackId);

            // Property validations for Schedule entity
            modelBuilder.Entity<Schedule>()
                .Property(s => s.Date)
                .IsRequired();

            modelBuilder.Entity<Schedule>()
                .Property(s => s.StartTime)
                .IsRequired();

            modelBuilder.Entity<Schedule>()
                .Property(s => s.EndTime)
                .IsRequired();
            #endregion
            #region ScheduleEvent Relations and Validations
            // 1-M relationship between ScheduleEvent and Schedule
            modelBuilder.Entity<ScheduleEvent>()
                .HasOne(se => se.Schedule)
                .WithMany(s => s.ScheduleEvents)
                .HasForeignKey(se => se.ScheduleId);

            // Property validations for ScheduleEvent entity
            modelBuilder.Entity<ScheduleEvent>()
                .Property(se => se.Name)
                .IsRequired();
            modelBuilder.Entity<Schedule>()
                .Property(se => se.StartTime)
                .IsRequired();
            modelBuilder.Entity<Schedule>()
                .Property(se => se.EndTime)
                .IsRequired();
            #endregion
            // Configure the relationship between Track and Instructor
            modelBuilder.Entity<Track>()
                .HasOne(t => t.Supervisor)
                .WithMany()
                .HasForeignKey(t => t.SupervisorId);
            // Define primary key for Attendance entity
            modelBuilder.Entity<Attendance>()
                .HasKey(a => a.Id);

            base.OnModelCreating(modelBuilder);
        }

    }
}
