/*using Attendance_Management_System.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;


namespace Attendance_Management_System.Data
{
   public class itiDummy : IdentityDbContext<IdentityUser>, IitiContext
   {
       public List<Student> Students { get; set; }
       public List<User> Users { get; set; }
       public List<Track> Tracks { get; set; }
       public List<ITIProgram> Programs { get; set; }
       public List<Schedule> Schedules { get; set; }
       public List<Attendance> Attendances { get; set; }
        public List<Permission> Permissions { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DbSet<AttendanceDegree> AttendanceDegrees { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DbSet<ScheduleEvent> ScheduleEvents { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DbSet<TrackIntake> TrackIntakes { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public itiDummy(DbContextOptions<itiDummy> options) : base(options)
       {
           Seed();
       }
       #region Seed Initial Data
       private void Seed()
       {
           var roles = new List<IdentityRole>
           {
               new IdentityRole { Id = "1", Name = "Admin", NormalizedName = "ADMIN" },
               new IdentityRole { Id = "2", Name = "Student", NormalizedName = "STUDENT" },
               new IdentityRole { Id = "3", Name = "Instructor", NormalizedName = "INSTRUCTOR" },
               new IdentityRole { Id = "4", Name = "Employee", NormalizedName = "EMPLOYEE" }
           };

           // Seed users
           var users = new List<User>
           {
               new User
               {
                   Id = 1,
                   UserName = "admin@example.com",
                   NormalizedUserName = "ADMIN@EXAMPLE.COM",
                   Email = "admin@example.com",
                   NormalizedEmail = "ADMIN@EXAMPLE.COM",
                   EmailConfirmed = true,
                   PasswordHash = new PasswordHasher<User>().HashPassword(null, "Admin@123")
               },
               new User
               {
                   Id = 1,
                   UserName = "student@example.com",
                   NormalizedUserName = "STUDENT@EXAMPLE.COM",
                   Email = "student@example.com",
                   NormalizedEmail = "STUDENT@EXAMPLE.COM",
                   EmailConfirmed = true,
                   PasswordHash = new PasswordHasher<User>().HashPassword(null, "Student@123")
               }
           };

           // Seed user roles
           var userRoles = new List<IdentityUserRole<string>>
           {
               new IdentityUserRole<string> { RoleId = "1", UserId = "1" }, // Admin user
               new IdentityUserRole<string> { RoleId = "2", UserId = "2" } // Student user
           };
           #region Programs
           Programs = new List<ITIProgram>()
           {
               new ITIProgram()
               {
                   Id = 1,
                   Name = "PTP",
                   Description = "Professional Training Program",
                   IsActive = true,
               },
               new ITIProgram()
               {
                   Id = 2,
                   Name = "ITP",
                   Description = "Intensive Training Program",
                   IsActive = true,
               },
               new ITIProgram()
               {
                   Id = 3,
                   Name = "LDP",
                   Description = "Leadership Development Program",
                   IsActive = true,
               },
               new ITIProgram()
               {
                   Id = 4,
                   Name = "ST",
                   Description = "Summer Training",
                   IsActive = true,
               }
           };
           #endregion
           #region Tracks
           Tracks = new List<Track>()
           {
               new Track()
               {
                   Id = 1,
                   Name = "PD",
                   IsActive = true,
                   Program = Programs[0],
               },
               new Track()
               {
                   Id = 2,
                   Name = "OS",
                   IsActive = true,
                   Program = Programs[0]
               },
               new Track()
               {
                   Id = 3,
                   Name = "AI",
                   IsActive = true,
                   Program = Programs[1]
               },
               new Track()
               {
                   Id = 4,
                   Name = "MERN",
                   IsActive = true,
                   Program = Programs[1]
               },
               new Track()
               {
                   Id = 5,
                   Name = "MEAN",
                   IsActive = true,
                   Program = Programs[1]
               },
           };
           #endregion
           #region Students
           Students = new List<Student>()
           {
               new Student()
               {
                   Id = 1,
                   NationalId = "29803121600573",
                   UserName = "AhmadEsam",
                   Email = "Ahmad.esam1231998@gmail.com",
                   Phone = "01015328933",
                   Gender = 'M',
                   Password = "12345678",
                   University = "Mansoura",
                   Faculty = "Engineering",
                   Track = Tracks[0]
               },
               new Student()
               {
                   Id = 2,
                   NationalId = "29803151800654",
                   UserName = "AliEmad",
                   Email = "ali@example.com",
                   Phone = "01115328933",
                   Gender = 'M',
                   Password = "12345678",
                   University = "Mansoura",
                   Faculty = "CS",
                   Track = Tracks[0]
               },
               new Student()
               {
                   Id = 3,
                   NationalId = "32006485523654",
                   UserName = "AhmedAbdallah",
                   Email = "AhmadL3swy@example.com",
                   Phone = "01215328933",
                   Gender = 'M',
                   Password = "12345678",
                   University = "Cairo",
                   Faculty = "Engineering",
                   Track = Tracks[0]
               },
               new Student()
               {
                   Id = 4,
                   NationalId = "42557896652148",
                   UserName = "Raheek",
                   Email = "Raheek@gmail.com",
                   Phone = "01015328933",
                   Gender = 'F',
                   Password = "12345678",
                   University = "AinShams",
                   Faculty = "Engineering",
                   Track = Tracks[1]
               },
               new Student()
               {
                   Id = 5,
                   NationalId = "53665485772015",
                   UserName = "Nada",
                   Email = "Nada@yahoo.com",
                   Phone = "01015328933",
                   Gender = 'F',
                   Password = "12345678",
                   University = "Tanta",
                   Faculty = "CS",
                   Track = Tracks[1]
               }
           };
           #region randomize Students data
           List<string> Universities = new List<string> { "Mansoura", "Tanta", "Cairo", "AinShams", "Zagazig" };
           List<string> Faculties = new List<string> { "Engineering", "CS", "IS", "Accounting" };
           List<char> Genders = new List<char> { 'M', 'F' };
           List<char> Digits = new List<char> { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
           Random random = new Random();
           char[] id = new char[14];
           for (int i = 6; i < 100; i++)
           {
               for (int j = 0; j < 14; j++)
               {
                   if (j == 0)
                   {
                       id[j] = Digits[random.Next(1, 9)];
                   }
                   else
                   {
                       id[j] = Digits[random.Next(0, 9)];
                   }

               }
               Students.Add(new Student()
               {
                   Id = i,
                   NationalId = new string(id),
                   UserName = "Student" + i,
                   Email = "Student" + i + "@example.com",
                   Phone = "01015328933",
                   Gender = Genders[random.Next(Genders.Count)],
                   Password = "12345678",
                   University = Universities[random.Next(Universities.Count)],
                   Faculty = Faculties[random.Next(Faculties.Count)],
                   Track = Tracks[random.Next(Tracks.Count)]
               });
           }
           #endregion
           #endregion
           #region Schedule
           Schedules = new List<Schedule>()
           {
               new Schedule()
               {
                   Id = 1,
                   Date = DateOnly.FromDateTime(DateTime.Now),
                   StartTime = TimeOnly.Parse("09:00"),
                   EndTime = TimeOnly.Parse("22:00"),
                   Track = Tracks[0],
               },
               new Schedule()
               {
                   Id = 2,
                   Date = DateOnly.FromDateTime(DateTime.Now.AddDays(1)),
                   StartTime = TimeOnly.Parse("11:00"),
                   EndTime = TimeOnly.Parse("22:00"),
                   Track = Tracks[1],
               }
           };
           Tracks[0].Students = Students.Where(s => s.Track == Tracks[0]).ToList();
           Tracks[1].Students = Students.Where(s => s.Track == Tracks[1]).ToList();
           #endregion
           Attendances = new List<Attendance>();
       }
       #endregion
   }
}
*/