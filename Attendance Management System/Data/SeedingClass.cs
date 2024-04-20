using Attendance_Management_System.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;

namespace Attendance_Management_System.Data
{
    static public class SeedingClass
    {
        public static List<Student> students { get; set; }
        public static List<Track> Tracks { get; set; }
        public static List<ITIProgram> Programs { get; set; }
        public static List<Schedule> Schedules { get; set; }
        public static List<Attendance> Attendances { get; set; }
        public static List<AttendanceDegree> AttendanceDegrees { get; set; }
        public static List<Intake> Intakes { get; set; }
        public static List<TrackIntake> TrackIntakes { get; set; }
        public static List<Permission> Permissions { get; set; }
        static SeedingClass()
        {
            MakeLists();
        }
        public static void MakeLists()
        {
            #region Intakes
            Intakes = new List<Intake>()
            {
                new Intake()
                {
                    Id = 1,
                    Number = 44,
                    StartDate = DateOnly.Parse("2023-09-01"),
                    EndDate = DateOnly.Parse("2024-09-01"),
                },
            };
            #endregion
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
                    ProgramId = Programs[0].Id,
                },
                new Track()
                {
                    Id = 2,
                    Name = "OS",
                    IsActive = true,
                    ProgramId = Programs[0].Id,
                },
                new Track()
                {
                    Id = 3,
                    Name = "AI",
                    IsActive = true,
                    ProgramId = Programs[1].Id,
                },
                new Track()
                {
                    Id = 4,
                    Name = "MERN",
                    IsActive = true,
                    ProgramId = Programs[1].Id,
                },
                new Track()
                {
                    Id = 5,
                    Name = "MEAN",
                    IsActive = true,
                    ProgramId = Programs[1].Id,
                },
            };
            #endregion
            #region Students
            students = new List<Student>()
            {
                new Student()
                {
                    NationalId = "29803121600573",
                    UserName = "AhmadEsam",
                    Email = "Ahmad.esam1231998@gmail.com",
                    PhoneNumber = "01015328933",
                    Gender = 'M',
                    University = "Mansoura",
                    Faculty = "Engineering",
                    TrackID = Tracks[0].Id
                },
                new Student()
                {
                    NationalId = "29803151800654",
                    UserName = "AliEmad",
                    Email = "ali@example.com",
                    PhoneNumber = "01115328933",
                    Gender = 'M',
                    University = "Mansoura",
                    Faculty = "CS",
                    TrackID = Tracks[0].Id
                },
                new Student()
                {
                    NationalId = "32006485523654",
                    UserName = "AhmedAbdallah",
                    Email = "AhmadL3swy@example.com",
                    PhoneNumber = "01215328933",
                    Gender = 'M',
                    University = "Cairo",
                    Faculty = "Engineering",
                    TrackID = Tracks[1].Id
                },
                new Student()
                {
                    NationalId = "42557896652148",
                    UserName = "Raheek",
                    Email = "Raheek@gmail.com",
                    PhoneNumber = "01015328933",
                    Gender = 'F',
                    University = "AinShams",
                    Faculty = "Engineering",
                    TrackID = Tracks[1].Id
                },
                new Student()
                {
                    NationalId = "53665485772015",
                    UserName = "Nada",
                    Email = "Nada@yahoo.com",
                    PhoneNumber = "01015328933",
                    Gender = 'F',
                    University = "Tanta",
                    Faculty = "CS",
                    TrackID = Tracks[2].Id
                }
            };
            #region randomize students data
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
                students.Add(new Student()
                {
                    NationalId = new string(id),
                    UserName = "AboEsam" + i,
                    Email = "AboEsam" + i + "@example.com",
                    PhoneNumber = "01015328933",
                    Gender = Genders[random.Next(Genders.Count)],
                    University = Universities[random.Next(Universities.Count)],
                    Faculty = Faculties[random.Next(Faculties.Count)],
                    TrackID = Tracks[random.Next(Tracks.Count)].Id
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
                    TrackId = 1,
                },
                new Schedule()
                {
                    Id = 2,
                    Date = DateOnly.FromDateTime(DateTime.Now.AddDays(1)),
                    StartTime = TimeOnly.Parse("11:00"),
                    EndTime = TimeOnly.Parse("22:00"),
                    TrackId = 2,
                }
            };
            //Tracks[0].Students = students.Where(s => s.Track == Tracks[0]).ToList();
            //Tracks[1].Students = students.Where(s => s.Track == Tracks[1]).ToList();
            #endregion
            #region Intake Tracks
            TrackIntakes = new List<TrackIntake>()
            {
                new TrackIntake()
                {
                    TrackId = 1,
                    IntakeId = 1
                },
                new TrackIntake()
                {
                    TrackId = 2,
                    IntakeId = 1
                },
                new TrackIntake()
                {
                    TrackId = 3,
                    IntakeId = 1
                },
                new TrackIntake()
                {
                    TrackId = 4,
                    IntakeId = 1
                },
                new TrackIntake()
                {
                    TrackId = 5,
                    IntakeId = 1
                }
            };
            #endregion
            #region Attendances
            Attendances = new List<Attendance>();
            #endregion
            #region AttendanceDegrees
            AttendanceDegrees = new List<AttendanceDegree>();
            #endregion
            #region Permissions
            Permissions = new List<Permission>()
            {
              new Permission { ID = 1, StudentId = 1, Status = PermissionStatus.Pending ,Reason="1", BodyOfDescription="1", Date=DateOnly.FromDateTime(DateTime.Now), DateCreated=DateTime.Now},
              new Permission { ID = 2, StudentId = 2, Status = PermissionStatus.Pending ,Reason="2", BodyOfDescription="2", Date=DateOnly.FromDateTime(DateTime.Now), DateCreated=DateTime.Now},
              new Permission { ID = 3, StudentId = 3, Status = PermissionStatus.Pending ,Reason="3", BodyOfDescription="3", Date=DateOnly.FromDateTime(DateTime.Now), DateCreated=DateTime.Now},
              new Permission { ID = 4, StudentId = 4, Status = PermissionStatus.Pending ,Reason="4", BodyOfDescription="4", Date=DateOnly.FromDateTime(DateTime.Now), DateCreated=DateTime.Now},
              new Permission { ID = 5, StudentId = 5, Status = PermissionStatus.Pending ,Reason="5", BodyOfDescription="5", Date=DateOnly.FromDateTime(DateTime.Now), DateCreated=DateTime.Now},
            };
            #endregion
        }
        public async static Task Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Intake>().HasData(Intakes);
            modelBuilder.Entity<ITIProgram>().HasData(Programs);
            modelBuilder.Entity<Track>().HasData(Tracks);
            //modelBuilder.Entity<Student>().HasData(students);
            modelBuilder.Entity<Schedule>().HasData(Schedules);
            modelBuilder.Entity<TrackIntake>().HasData(TrackIntakes);
            //Seed Permissions
            modelBuilder.Entity<Permission>().HasData(Permissions);
        }
    }
}
