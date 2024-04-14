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
       
        #endregion
        public readonly IConfiguration Configuration;
        public itiContext(IConfiguration _configuration ,DbContextOptions<itiContext>options):base(options)
        {
            Configuration = _configuration;
        }

        List<Student> IitiContext.Students { get; set; } 
        public List<ITIProgram> Programs { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        List<Track> IitiContext.Tracks { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        List<Permission> IitiContext.Permissions { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        List<Schedule> IitiContext.Schedules { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        List<Attendance> IitiContext.Attendances { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        //List<Student> IitiContext.Students { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        // ********** Added List Of Permissions ********** //

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
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
            #region Attendance Relation
            modelBuilder.Entity<Attendance>()
              .HasKey(a => new { a.StudentId, a.Date });

            // If you want to add the ForeignKey constraint explicitly, you can do it like this:
            modelBuilder.Entity<Attendance>()
                .HasOne(a => a.Student)
                .WithMany(s => s.Attendances)
                .HasForeignKey(a => a.StudentId);
            #endregion

            #region Attendance Degree
            modelBuilder.Entity<AttendanceDegree>()
             .HasKey(ad => new { ad.StudentId, ad.AttendanceDegrees });

            // If you want to add the ForeignKey constraint explicitly, you can do it like this:
            modelBuilder.Entity<AttendanceDegree>()
                .HasOne(ad => ad.Student)
                .WithMany(s => s.AttendanceDegrees)
                .HasForeignKey(ad => ad.StudentId);
            #endregion
            #region TrackIntake
            modelBuilder.Entity<TrackIntake>()
                .HasKey(ti => new { ti.IntakeId, ti.TrackId });

            // If you want to add the ForeignKey constraints explicitly, you can do it like this:
            modelBuilder.Entity<TrackIntake>()
                .HasOne(ti => ti.Intake)
                .WithMany(i => i.Tracks)
                .HasForeignKey(ti => ti.IntakeId);

            modelBuilder.Entity<TrackIntake>()
                .HasOne(ti => ti.Track)
                .WithMany(t => t.Intakes)
                .HasForeignKey(ti => ti.TrackId);

            #endregion
            base.OnModelCreating(modelBuilder);
        }

    }
}
