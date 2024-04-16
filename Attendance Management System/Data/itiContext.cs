using Attendance_Management_System.Models;
using Microsoft.EntityFrameworkCore;

namespace Attendance_Management_System.Data
{
    public class itiContext : DbContext, IitiContext
    {
        #region DbSets
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<ScheduleEvent> ScheduleEvents { get; set; }
        public DbSet<Track> Tracks { get; set; }
        public DbSet<ITIProgram> Programs { get; set; }
        public DbSet<Intake> Intakes { get; set; }
      //  public DbSet<Instructor> instructors { get; set; }
        #endregion
        public readonly IConfiguration Configuration;
        public itiContext(IConfiguration _configuration)
        {
            Configuration = _configuration;
        }

        public List<Student> students { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<ITIProgram> programs { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<Intake> intakes { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<Track> tracks { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<Instructor> instructors { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<Supervisor> supervisors { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

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

            base.OnModelCreating(modelBuilder);
        }

    }
}
