using Microsoft.EntityFrameworkCore;
using Attendance_Management_System.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Attendance_Management_System.Data
{
    public class itiContext : DbContext, IitiContext
    {
        #region DbSets
        public DbSet<Student> Students { get; set; }
        public DbSet<Attendance> Attendances { get; set; }
        public DbSet<AttendanceDegree> AttendanceDegrees { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<ScheduleEvent> ScheduleEvents { get; set; }
        public DbSet<Track> Tracks { get; set; }
        public DbSet<ITIProgram> Programs { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<TrackIntake> TrackIntakes { get; set; }
        public DbSet<User> Users { get; set; }

        #endregion
        public readonly IConfiguration Configuration;

        public itiContext(DbContextOptions<itiContext> options, IConfiguration _configuration) : base(options)
        {
            Configuration = _configuration;
        }


        List<Track> IitiContext.Tracks { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<ITIProgram> Programs { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        List<Schedule> IitiContext.Schedules { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        List<Attendance> IitiContext.Attendances { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        List<Track> IitiContext.Tracks { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<ITIProgram> Programs { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        List<Schedule> IitiContext.Schedules { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        List<Attendance> IitiContext.Attendances { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        List<Track> IitiContext.Tracks { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<ITIProgram> Programs { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        List<Schedule> IitiContext.Schedules { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        List<Attendance> IitiContext.Attendances { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
            #region Schedule Relations and Validations
            //  1-M relationship between Schedule and Track

            // Property validations for Schedule entity
            modelBuilder.Entity<Schedule>()
                .Property(s => s.Date)
                .IsRequired();

            modelBuilder.Entity<Schedule>()
                .Property(s => s.StartTime)
                .IsRequired();

            modelBuilder.Entity<Schedule>()
                .Property(s => s.EndTime)
            #region Permissions
            modelBuilder.Entity<Permission>()
                .HasKey(p => new { p.StudentId, p.Date });
            #endregion
            #region Attendance
            modelBuilder.Entity<Attendance>()
                .HasKey(a => new { a.StudentId, a.Date });
            #endregion
            #region AttendanceDegree
            modelBuilder.Entity<AttendanceDegree>()
                .HasKey(ad => new { ad.StudentId, ad.UntilDate });
            #endregion
            #region Student
            modelBuilder.Entity<Student>()
                .HasIndex(s => s.NationalId)
                .IsUnique();
            #endregion
            #region Track Intake
            modelBuilder.Entity<TrackIntake>()
                .HasKey(ti => new { ti.TrackId, ti.IntakeId });
            #endregion
            #endregion
            #region ScheduleEvent Relations and Validations
            // Configure the relationship between Track and Instructor
            modelBuilder.Entity<Track>()
                .HasOne(t => t.Supervisor)
                .WithMany()
                .HasForeignKey(t => t.SupervisorId);
            // Define primary key for Attendance entity
            modelBuilder.Entity<Attendance>()
                .HasKey(a => a.Id);

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
