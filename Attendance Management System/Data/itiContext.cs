﻿using Microsoft.EntityFrameworkCore;
using Attendance_Management_System.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace Attendance_Management_System.Data
{
    public class itiContext : IdentityDbContext<User, IdentityRole<int>, int>
    {
        #region DbSets
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Attendance> Attendances { get; set; }
        public virtual DbSet<AttendanceDegree> AttendanceDegrees { get; set; }
        public virtual DbSet<Schedule> Schedules { get; set; }
        public virtual DbSet<ScheduleEvent> ScheduleEvents { get; set; }
        public virtual DbSet<Track> Tracks { get; set; }
        public virtual DbSet<Supervisor> Supervisors { get; set; }
        public virtual DbSet<Instructor> Instructors { get; set; }

        public virtual DbSet<Intake> Intake { get; set; }
        public virtual DbSet<ITIProgram> Programs { get; set; }
        public virtual DbSet<Permission> Permissions { get; set; }
        public virtual DbSet<TrackIntake> TrackIntakes { get; set; }
        #endregion

        public readonly IConfiguration Configuration;
        public itiContext()
        {
            Configuration.GetConnectionString("DefaultConnection");
        }
        public itiContext(DbContextOptions<itiContext> options, IConfiguration _configuration) : base(options)
        {
            Configuration = _configuration;
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
        //    base.OnConfiguring(optionsBuilder);
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>()
                .ToTable("Users");
            modelBuilder.Entity<Student>()
                .ToTable("Students");
            modelBuilder.Entity<Instructor>()
                .ToTable("Instructors");
            modelBuilder.Entity<IdentityUserRole<int>>()
                .ToTable("UsersRoles");
            modelBuilder.Entity<IdentityRole<int>>()
                .ToTable("Roles");

            modelBuilder.Seed();
            // Congifure inheritance To Table Per Hierarchy
            //modelBuilder.Entity<User>()
            //    .HasDiscriminator<string>("UserType")
            //    .HasValue<Student>("Student");
            //modelBuilder.Entity<User>()
            //    .HasDiscriminator<string>("UserType")
            //    .HasValue<Instructor>("Instructor");
            //modelBuilder.Entity<User>()
            //    .HasDiscriminator<string>("UserType")
            //    .HasValue<Admin>("Admin");




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
            // Make Key ID instead of Id (Identity Default)
            modelBuilder.Entity<User>()
                .HasKey(s => s.Id);

            // 1-M relation between Student and AttendanceDegrees
            modelBuilder.Entity<Student>()
                .HasMany(s => s.AttendanceDegrees)
                .WithOne(ad => ad.Student)
                .HasForeignKey(ad => ad.StudentId);
            // 1-M relation between Student and Track
            modelBuilder.Entity<Student>()
                .HasOne(s => s.Track)
                .WithMany(t => t.Students)
                .HasForeignKey(s => s.TrackID)
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Student>()
                .HasIndex(s => s.NationalId)
                .IsUnique();
            #endregion

            #region Track Intake
            modelBuilder.Entity<TrackIntake>()
                .HasKey(ti => new { ti.TrackId, ti.IntakeId });
            #endregion

            #region ScheduleEvent Relations and Validations
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

        }
        public DbSet<Attendance_Management_System.Models.Instructor> Instructor { get; set; } = default!;
    }
}
