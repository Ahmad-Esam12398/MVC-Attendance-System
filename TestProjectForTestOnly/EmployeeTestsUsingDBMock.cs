using Attendance_Management_System.Data;
using Attendance_Management_System.Models;
using Attendance_Management_System.Repos;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Moq.EntityFrameworkCore;

namespace TestProjectForTestOnly
{
    [TestClass]
    public class EmployeeTestsUsingDBMock
    {
#nullable disable
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
            db = new Mock<itiContext>();
        }
        [TestInitialize]
        public void TestInitialize()
        {
            // Create your list of students
            students = new List<Student>{
                new Student()
                {
                    Id = 1,
                    UserName = "Ahmad",
                    Email = "Ahmad@examlpe.com",
                    Faculty = "Engineering",
                    NationalId = "12333434534",
                    University = "Mansoura",
                    TrackID = 1
                },
                new Student()
                {
                    Id = 2,
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
        }
        [TestMethod]
        public void ReadAllStudents_WhenCalled_returnAllStudentsInList()
        {
            // Arrange
            db.Setup(s => s.Students).ReturnsDbSet(students);
            EmployeeRepo employeeRepo = new(db.Object);
            // Act
            var target = employeeRepo.ReadAllStudents();
            // Assert
            CollectionAssert.AreEquivalent(target, students);
        }
        [TestMethod]
        public void ReadAllTracks_WhenCalled_GetAllTracks()
        {
            // Arrange
            db.Setup(d=> d.Tracks).ReturnsDbSet(tracks);
            EmployeeRepo employeeRepo = new(db.Object);
            // Act
            var target = employeeRepo.ReadAllTracks();
            var expected = tracks;
            // Assert
            CollectionAssert.AreEquivalent(target, expected);
        }
        [TestMethod]
        public void ReadAllTracks_InactiveTracksNotIncluded_NotIncludedTrack()
        {
            // Arrange
            Track inActiveOne = new Track()
            {
                IsActive = false
            };
            tracks.Add(inActiveOne);
            db.Setup(s => s.Tracks).ReturnsDbSet(tracks);
            EmployeeRepo employeeRepo = new(db.Object);
            // Act
            var returnedTracks = employeeRepo.ReadAllTracks();
            // Assert
            CollectionAssert.DoesNotContain(returnedTracks, inActiveOne);
        }
        [TestMethod]
        public void ReadTodaysStudents_GetTodaysTrackStudent_returnPDStudents()
        {
            // Arrange
            var todaysDate = DateTime.Now;
            var todaysTrack = new Track() { Id = 1 };
            var notTodaysTrack = new Track() { Id= 2 };

            var todaysSchedule = new Schedule() { Date = DateOnly.FromDateTime(todaysDate), Track = todaysTrack };
            var schedules = new List<Schedule> { todaysSchedule };

            var todaysStudent = new Student() { Track = todaysTrack };
            var notTodaysStudent = new Student() { Track = notTodaysTrack };
            var students = new List<Student> { todaysStudent, notTodaysStudent };
            db.Setup(d => d.Schedules).ReturnsDbSet(schedules);
            db.Setup(d => d.Students).ReturnsDbSet(students);
            EmployeeRepo employeeRepo = new(db.Object);
            // Act
            //var expected = students.Where(s => s.TrackID == 1).ToList();
            var actual = employeeRepo.ReadTodaysStudents();
            // Assert
            Assert.AreEqual(actual.Count, 1);
            CollectionAssert.Contains(actual, todaysStudent);
            CollectionAssert.DoesNotContain(actual, notTodaysStudent);
        }
        [TestMethod]
        public void ReadSchedules_ShouldReturnAllSchedules_ReturnAllSchedules()
        {
            // Arrange
            db.Setup(d => d.Schedules).ReturnsDbSet(schedules);
            EmployeeRepo employeeRepo = new(db.Object);
            // Act
            var target = employeeRepo.ReadSchedules();
            // Assert
            CollectionAssert.AreEquivalent(target, schedules);
        }
        [TestMethod]
        public void SetAttendance_StudentNotFound_Return1()
        {
            // Arrange
            db.Setup(s => s.Students).ReturnsDbSet(new List<Student>());
            EmployeeRepo employeeRepo = new(db.Object);
            // Act
            int result = employeeRepo.SetAttendance(100, DateTime.Now, "type");
            // Assert
            Assert.AreEqual(result, 1);
        }
        [TestMethod]
        public void SetAttendance_CheckedInBefore_Return2()
        {
            // Arrange
            Attendance attendance = new Attendance()
            {
                StudentId = 1,
                Date = DateOnly.FromDateTime(DateTime.Now),
                Time_in = TimeOnly.FromDateTime(DateTime.Now)
            };
            List<Attendance> attendancesnew = new List<Attendance>() { attendance };
            db.Setup(d => d.Students).ReturnsDbSet(students);
            db.Setup(d => d.Attendances).ReturnsDbSet(attendancesnew);
            EmployeeRepo employeeRepo = new(db.Object);
            // Act
            int result = employeeRepo.SetAttendance(1, DateTime.Now, "in");
            // Assert
            Assert.AreEqual(2, result);
        }
        [TestMethod]
        public void SetAttendance_DidntCheckInBefore_Return3()
        {
            // Arrange
            Attendance attendance = new Attendance()
            {
                StudentId = 1,
                Date = DateOnly.FromDateTime(DateTime.Now),
                Time_in = null
            };
            List<Attendance> attendancesnew = new List<Attendance>() { attendance };
            db.Setup(d => d.Students).ReturnsDbSet(students);
            db.Setup(d => d.Attendances).ReturnsDbSet(attendancesnew);
            EmployeeRepo employeeRepo = new(db.Object);
            // Act
            int result = employeeRepo.SetAttendance(1, DateTime.Now, "out");
            // Assert
            Assert.AreEqual(3, result);
        }
        [TestMethod]
        public void SetAttendance_ValidCheckInAndOut_Return0AndSetAttendance()
        {
            // Arrange
            List<Attendance> attendancesnew = new List<Attendance>();
            db.Setup(d => d.Students).ReturnsDbSet(students);
            db.Setup(d => d.Attendances).ReturnsDbSet(attendancesnew);
            EmployeeRepo employeeRepo = new(db.Object);
            // Act
            int result = employeeRepo.SetAttendance(1, DateTime.Now, "in");
            int result1 = employeeRepo.SetAttendance(1, DateTime.Now, "out");
            var timeIn = db.Object.Attendances.FirstOrDefault()?.Time_in;
            // Assert
            Assert.AreEqual(0, result);
            Assert.AreEqual(0, result1);
            //Assert.IsNotNull(timeIn);
        }
        [TestMethod]
        public void CalculateReducedScoreForAbscenceWithPermission_AllCases_returnRightValues()
        {
            // Arrange
            EmployeeRepo employeeRepo = new(db.Object);
            // Act
            // Assert
            Assert.AreEqual(employeeRepo.CalculateReducedScoreForAbscenceWithPermission(1, 3), 0);
            Assert.AreEqual(employeeRepo.CalculateReducedScoreForAbscenceWithPermission(2, 3), 5);
            Assert.AreEqual(employeeRepo.CalculateReducedScoreForAbscenceWithPermission(4, 3), 15);
            Assert.AreEqual(employeeRepo.CalculateReducedScoreForAbscenceWithPermission(6, 3), 35);
            Assert.AreEqual(employeeRepo.CalculateReducedScoreForAbscenceWithPermission(10, 3), 90);
            Assert.AreEqual(employeeRepo.CalculateReducedScoreForAbscenceWithPermission(15, 3), 200);
        }
    }
}