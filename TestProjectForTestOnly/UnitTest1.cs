using Attendance_Management_System.Data;
using Attendance_Management_System.Models;
using Attendance_Management_System.Repos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.InMemory.Internal;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Moq.EntityFrameworkCore;

namespace TestProjectForTestOnly
{
    [TestClass]
    public class EmployeeRepoTests
    {
        #nullable disable
        private static EmployeeRepo employeeRepo;
        private static itiContext itiContext;
        private static Dictionary<int, int> AbsenceDayswithPermission;
        private static List<Student> students;
        private static List<Track> tracks;
        private static List<ITIProgram> programs;
        private static List<Schedule> schedules;
        private static List<Attendance> attendances;
        private static Mock<itiContext> db;
        #nullable enable

        private static int initialAbsenceDegrees = 500;

        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            // Create your list of students
            students = new List<Student>{
                new Student()
                {
                    UserName = "Ahmad",
                    Email = "Ahmad@examlpe.com",
                    Faculty = "Engineering",
                    NationalId = "12333434534",
                    University = "Mansoura",
                    TrackID = 1
                },
                new Student()
                {
                    UserName = "Mohamed",
                    Email = "Mohamed@example.com",
                    Faculty = "Engineering",
                    NationalId = "122412313",
                    University = "Fayoum",
                    TrackID = 2

                }
            };
            tracks = new List<Track>()
            {
                new Track()
                {
                    Name = "PD",
                    ProgramId = 1,
                    IsActive = true,
                },
                new Track()
                {
                    Name = "Os",
                    ProgramId = 2,
                    IsActive = true,
                }
            };
            programs = new List<ITIProgram>()
            {
                new ITIProgram()
                {
                    Name = "PTP",
                    Description = "Professional Training Program",
                    IsActive = true
                },
                new ITIProgram()
                {
                    Name = "ITP",
                    Description = "Intensive Training Program",
                    IsActive = true
                }
            };
            schedules = new List<Schedule>()
            {
                new Schedule()
                {
                    Date = DateOnly.FromDateTime(DateTime.Now),
                    StartTime = TimeOnly.FromTimeSpan(TimeSpan.FromMinutes(0)),
                    EndTime = TimeOnly.FromTimeSpan(TimeSpan.FromMinutes(100)),
                    TrackId = 1
                }
            };
            attendances = new List<Attendance>()
            {
                new Attendance()
                {
                    StudentId = 1,
                    Date = DateOnly.FromDateTime(DateTime.Now)
                }
            };
            db = new Mock<itiContext>();

        }
        [TestInitialize]
        public void TestInitialize()
        {
            // Create a unique name for the in-memory database
            var _databaseName = Guid.NewGuid().ToString();

            // Create options for DbContext
            var options = new DbContextOptionsBuilder<itiContext>()
                .UseInMemoryDatabase(databaseName: _databaseName) // Use In-Memory database
                .Options;

            // Create a new instance of DbContext
            var configuration = new ConfigurationBuilder().Build();
            itiContext = new itiContext(options, configuration);

            // Add students to DbContext
            itiContext.Students.AddRange(students);
            itiContext.Programs.AddRange(programs);
            itiContext.Tracks.AddRange(tracks);
            itiContext.Schedules.AddRange(schedules);
            itiContext.Attendances.AddRange(attendances);

            itiContext.SaveChanges();
            // Use context for your repository
            employeeRepo = new EmployeeRepo(itiContext);

        }
        [TestMethod]
        public void ReadAllStudents_ReturnStudentsList_returnAllStudentsInList()
        {
            // Arrange
            // Act
            var target = employeeRepo.ReadAllStudents();
            // Assert
            CollectionAssert.AreEquivalent(target, students);
        }
        [TestMethod]
        public void ReadAllTracks_hasTracks_GetAllTracks()
        {
            // Arrange
            // Act
            var target = employeeRepo.ReadAllTracks();
            var expected = tracks.ToList();
            // Assert
            CollectionAssert.AreEquivalent(target, expected);
        }
        [TestMethod]
        public void ReadAllTracks_InactiveTracksNotIncluded_NotIncludedTrack()
        {
            // Arrange
            Track target = itiContext.Tracks.FirstOrDefault();
            // Act
            target.IsActive = false;
            itiContext.SaveChanges();
            var tracks = employeeRepo.ReadAllTracks();
            // Assert
            CollectionAssert.DoesNotContain(tracks, target);
        }
        [TestMethod]
        public void ReadTodaysStudents_GetTodaysTrackStudent_returnPDStudents()
        {
            // Arrange
            var OsStudents = itiContext.Students.Where(s=> s.TrackID == 2).ToList();
            // Act
            var students = employeeRepo.ReadTodaysStudents();
            // Assert
            CollectionAssert.DoesNotContain(students, OsStudents);
        }
        [TestMethod]
        public void ReadSchedules_ShouldReturnAllSchedules_ReturnAllSchedules()
        {
            // Arrange
            // Act
            var target = employeeRepo.ReadSchedules();
            // Assert
            CollectionAssert.AreEquivalent(target, schedules);
        }
        [TestMethod]
        public void SetAttendance_StudentNotFound_Return1()
        {
            // Arrange
            db.Setup<DbSet<Student>>(s => s.Students).ReturnsDbSet(new List<Student>());
            var student = db.Object.Students.FirstOrDefault();
            // Act
            int result = employeeRepo.SetAttendance(100, DateTime.Now, "type");
            // Assert

        }
    }
}