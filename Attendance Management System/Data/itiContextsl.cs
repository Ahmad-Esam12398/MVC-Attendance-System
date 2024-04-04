using Attendance_Management_System.Models;
using Microsoft.EntityFrameworkCore;

namespace Attendance_Management_System.Data
{
    public class itiContextSl : DbContext
    {
        #region DbSets
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Attendance> Attendances { get; set; }

        public DbSet<AttendanceDegree> AttendanceDegrees { get; set; }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Instructor> Instructors { get; set; }

        public DbSet<Intake> Intakes { get; set; }
   
        public DbSet<ITIProgram> ItiPrograms { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<ScheduleEvent> ScheduleEvents { get; set; }
        public DbSet<Student> Students { get; set; }

        public DbSet<Track> Tracks { get; set; }
        #endregion

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
               .UseSqlite("Filename=data.db")
               .LogTo(Console.WriteLine, LogLevel.Information) // remove in production
               .EnableSensitiveDataLogging()                   // remove in production
               ;
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
        public void Initialise()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }
    }
}
