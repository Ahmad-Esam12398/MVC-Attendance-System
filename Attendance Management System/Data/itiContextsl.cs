using Attendance_Management_System.Models;
using Microsoft.EntityFrameworkCore;

namespace Attendance_Management_System.Data
{
    public class itiContextSl : DbContext, IitiContext
    {
        #region DbSets
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<ScheduleEvent> ScheduleEvents { get; set; }
        public DbSet<Track> Tracks { get; set; }
        #endregion
        public readonly IConfiguration Configuration;
        public itiContextSl(IConfiguration _configuration)
        {
            Configuration = _configuration;
        }

        public List<Student> students { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        List<Track> IitiContext.Tracks { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<ITIProgram> Programs { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

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

    }
}
