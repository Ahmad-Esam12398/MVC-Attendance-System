using Attendance_Management_System.Data;
using Attendance_Management_System.Models;
using Attendance_Management_System.Repos;
using Moq;
using Moq.EntityFramework.Helpers;
namespace TestProject
{
    [TestClass]
    public class EmployeeRepoTest
    {
        private static Mock<itiContext> context;
        private static EmployeeRepo employeeRepo;
        static List<Student> students { get; set; }
        static List<Track> Tracks { get; set; }
        static List<ITIProgram> Programs { get; set; }
        static List<Schedule> Schedules { get; set; }
        static List<Attendance> Attendances { get; set; }
        static List<AttendanceDegree> AttendanceDegrees { get; set; }
        static List<Intake> Intakes { get; set; }
        public static List<TrackIntake> TrackIntakes { get; set; }
        [ClassInitialize]
        public static void DataInitializer() 
        {
            context = new Mock<itiContext>();
            employeeRepo = new EmployeeRepo(context.Object);
        }
        [TestInitialize]
        public void TestInitialize()
        {
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
                    ID = 1,
                    NationalId = "29803121600573",
                    UserName = "AhmadEsam",
                    Email = "Ahmad.esam1231998@gmail.com",
                    Phone = "01015328933",
                    Gender = 'M',
                    Password = "12345678",
                    University = "Mansoura",
                    Faculty = "Engineering",
                    TrackID = Tracks[0].Id
                },
                new Student()
                {
                    ID = 2,
                    NationalId = "29803151800654",
                    UserName = "AliEmad",
                    Email = "ali@example.com",
                    Phone = "01115328933",
                    Gender = 'M',
                    Password = "12345678",
                    University = "Mansoura",
                    Faculty = "CS",
                    TrackID = Tracks[0].Id
                },
                new Student()
                {
                    ID = 3,
                    NationalId = "32006485523654",
                    UserName = "AhmedAbdallah",
                    Email = "AhmadL3swy@example.com",
                    Phone = "01215328933",
                    Gender = 'M',
                    Password = "12345678",
                    University = "Cairo",
                    Faculty = "Engineering",
                    TrackID = Tracks[1].Id
                },
                new Student()
                {
                    ID = 4,
                    NationalId = "42557896652148",
                    UserName = "Raheek",
                    Email = "Raheek@gmail.com",
                    Phone = "01015328933",
                    Gender = 'F',
                    Password = "12345678",
                    University = "AinShams",
                    Faculty = "Engineering",
                    TrackID = Tracks[1].Id
                },
                new Student()
                {
                    ID = 5,
                    NationalId = "53665485772015",
                    UserName = "Nada",
                    Email = "Nada@yahoo.com",
                    Phone = "01015328933",
                    Gender = 'F',
                    Password = "12345678",
                    University = "Tanta",
                    Faculty = "CS",
                    TrackID = Tracks[2].Id
                }
            };
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
        }
        [TestMethod]
        public void ReadAllStudents_ExistingStudents_GetStudentsList()
        { 
        }
    }
}