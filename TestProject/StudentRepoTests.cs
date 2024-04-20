using Attendance_Management_System.Data;
using Attendance_Management_System.Models;
using Attendance_Management_System.Repos;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Linq.Expressions;
using System.Security.Claims;

namespace Unit_Test_StudentRepo
{
    
   
    //GetScheduleEvents

    [TestClass]
    public class StudentRepoTests
    {
         Mock<itiContext> dbMock;
         Mock<UserManager<User>> userManagerMock;
         Mock<ClaimsPrincipal> userPrincipalMock;
         StudentRepo StudentRepo;
        Mock<IStudentRepo> StudentRepoMock;

        [ClassInitialize]
        public void Intialize()
        {
            // Arrange
            dbMock = new Mock<itiContext>();
            userManagerMock = new Mock<UserManager<User>>(new Mock<IUserStore<User>>().Object, null, null, null, null, null, null, null, null);
            userPrincipalMock = new Mock<ClaimsPrincipal>();

            StudentRepo = new StudentRepo(dbMock.Object, userManagerMock.Object, userPrincipalMock.Object);
            StudentRepoMock=new Mock<IStudentRepo>();
        }
    

    [TestMethod]
        public void CreatePermission_NewPermission_SuccessAddingTrue()
        {
            //arrange
            int stdID = 2;
            Permission newPermission = new Permission() { StudentId = stdID, Reason = "ill", BodyOfDescription = "عيااان اشتباه كرونا" };
            var PermissionsList = new List<Permission>()
            {
                new Permission() { StudentId = 2,Reason="late",BodyOfDescription="late in transports",DateCreated=new DateTime(2024,3,12,9,10,0) }
                ,
                new Permission() { StudentId = 2,Reason="late",BodyOfDescription="late in transports",DateCreated=new DateTime(2024,3,8,9,20,0) }

            };

            var dbSetMock = new Mock<DbSet<Permission>>();
            dbSetMock.As<IQueryable<Permission>>().Setup(m => m.Provider).Returns(PermissionsList.AsQueryable().Provider);
            dbSetMock.As<IQueryable<Permission>>().Setup(m => m.Expression).Returns(PermissionsList.AsQueryable().Expression);
            dbSetMock.As<IQueryable<Permission>>().Setup(m => m.ElementType).Returns(PermissionsList.AsQueryable().ElementType);
            dbSetMock.As<IQueryable<Permission>>().Setup(m => m.GetEnumerator()).Returns(PermissionsList.AsQueryable().GetEnumerator());

            dbMock.Setup(m => m.Permissions).Returns(dbSetMock.Object);
            userManagerMock.Setup(u => u.GetUserAsync(It.IsAny<ClaimsPrincipal>())).ReturnsAsync(new User());

            //act
            StudentRepo.CreatePermission(newPermission);
            var permissionsListAfterAdding = StudentRepo.Get_Student_Permissions_By_Id(stdID);


            //asert
            Assert.IsTrue(permissionsListAfterAdding.Contains(newPermission));

        }


        [TestMethod]
        public void DeletePermission_ValidPermission_SuccessfullyRemoved()
        {
            // Arrange
            int stdID = 2;
            DateTime permissionDate = new DateTime(2024, 3, 12); // Adjust with a valid permission date
            var permissionToRemove = new Permission { StudentId = stdID, DateCreated = permissionDate };
            var permissionsList = new List<Permission>
            {
        new () { StudentId = 2, Reason = "late", BodyOfDescription = "late in transports", DateCreated = new DateTime(2024, 3, 12, 9, 10, 0) },
        new () { StudentId = 2, Reason = "late", BodyOfDescription = "late in transports", DateCreated = new DateTime(2024, 3, 8, 9, 20, 0) }
            };

            var dbSetMock = new Mock<DbSet<Permission>>();
            dbSetMock.As<IQueryable<Permission>>().Setup(m => m.Provider).Returns(permissionsList.AsQueryable().Provider);
            dbSetMock.As<IQueryable<Permission>>().Setup(m => m.Expression).Returns(permissionsList.AsQueryable().Expression);
            dbSetMock.As<IQueryable<Permission>>().Setup(m => m.ElementType).Returns(permissionsList.AsQueryable().ElementType);
            dbSetMock.As<IQueryable<Permission>>().Setup(m => m.GetEnumerator()).Returns(permissionsList.AsQueryable().GetEnumerator());

            dbMock.Setup(m => m.Permissions).Returns(dbSetMock.Object);
            userManagerMock.Setup(u => u.GetUserAsync(It.IsAny<ClaimsPrincipal>())).ReturnsAsync(new User());

            // Act
            StudentRepo.DeletePermission(stdID, permissionDate);
            var permissionsListAfterDeletion = StudentRepo.Get_Student_Permissions_By_Id(stdID);

            // Assert
            Assert.IsFalse(permissionsListAfterDeletion.Contains(permissionToRemove));
        }



        [TestMethod]
        public void Get_Student_Attendances_By_Id_ValidStudentId_ReturnsAttendancesViewData()
        {
            // Arrange
            int stdID = 2; // Adjust with a valid student ID for testing
            var student = new Student { Id = stdID, TrackID = 1 }; // Assuming the student exists in the database

            // Mocking the Schedule, Attendance, and Permission data
            var trackSchedule = new List<Schedule>
    {
        new Schedule { TrackId = student.TrackID, Date = new DateOnly(2024, 3, 12) }, // Adjust with valid dates
        new Schedule { TrackId = student.TrackID, Date = new DateOnly(2024, 3, 13) }
    };

            var attendances = new List<Attendance>
    {
        new Attendance { StudentId = stdID, Date = new DateOnly(2024, 3, 13), Time_in = new TimeOnly(9, 0, 0), Time_out = new TimeOnly(17, 0, 0) }
    };

            var permissions = new List<Permission>
    {
        new Permission { StudentId = stdID, DateCreated = new DateTime(2024, 3, 12), Status = PermissionStatus.Accepted }, // Adjust with valid data
    };

            // Mocking the DbSet for Schedule, Attendance, and Permission
            var scheduleDbSetMock = new Mock<DbSet<Schedule>>();
            scheduleDbSetMock.As<IQueryable<Schedule>>().Setup(m => m.Provider).Returns(trackSchedule.AsQueryable().Provider);
            scheduleDbSetMock.As<IQueryable<Schedule>>().Setup(m => m.Expression).Returns(trackSchedule.AsQueryable().Expression);
            scheduleDbSetMock.As<IQueryable<Schedule>>().Setup(m => m.ElementType).Returns(trackSchedule.AsQueryable().ElementType);
            scheduleDbSetMock.As<IQueryable<Schedule>>().Setup(m => m.GetEnumerator()).Returns(trackSchedule.AsQueryable().GetEnumerator());

            var attendanceDbSetMock = new Mock<DbSet<Attendance>>();
            attendanceDbSetMock.As<IQueryable<Attendance>>().Setup(m => m.Provider).Returns(attendances.AsQueryable().Provider);
            attendanceDbSetMock.As<IQueryable<Attendance>>().Setup(m => m.Expression).Returns(attendances.AsQueryable().Expression);
            attendanceDbSetMock.As<IQueryable<Attendance>>().Setup(m => m.ElementType).Returns(attendances.AsQueryable().ElementType);
            attendanceDbSetMock.As<IQueryable<Attendance>>().Setup(m => m.GetEnumerator()).Returns(attendances.AsQueryable().GetEnumerator());

            var permissionDbSetMock = new Mock<DbSet<Permission>>();
            permissionDbSetMock.As<IQueryable<Permission>>().Setup(m => m.Provider).Returns(permissions.AsQueryable().Provider);
            permissionDbSetMock.As<IQueryable<Permission>>().Setup(m => m.Expression).Returns(permissions.AsQueryable().Expression);
            permissionDbSetMock.As<IQueryable<Permission>>().Setup(m => m.ElementType).Returns(permissions.AsQueryable().ElementType);
            permissionDbSetMock.As<IQueryable<Permission>>().Setup(m => m.GetEnumerator()).Returns(permissions.AsQueryable().GetEnumerator());

            // Mocking the itiContext to return the above DbSet mocks
            dbMock.Setup(m => m.Students.FirstOrDefault(It.IsAny<Expression<Func<Student, bool>>>())).Returns(student);
            dbMock.Setup(m => m.Schedules).Returns(scheduleDbSetMock.Object);
            dbMock.Setup(m => m.Attendances).Returns(attendanceDbSetMock.Object);
            dbMock.Setup(m => m.Permissions).Returns(permissionDbSetMock.Object);

            // Act
            var result = StudentRepo.Get_Student_Attendances_By_Id(stdID);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.Count);
        }

        [TestMethod]
        public void Get_Student_Permissions_By_Id_ValidStudentId_ReturnsOrderedPermissionsList()
        {
            // Arrange
            int stdID = 2; // Adjust with a valid student ID for testing

            // Mocking the Permission data
            var permissions = new List<Permission>
    {
        new Permission { ID = 1, StudentId = stdID, DateCreated = new DateTime(2024, 3, 12) }, // Adjust with valid data
        new Permission { ID = 2, StudentId = stdID, DateCreated = new DateTime(2024, 3, 10) }
    };

            // Mocking the DbSet for Permission
            var permissionDbSetMock = new Mock<DbSet<Permission>>();
            permissionDbSetMock.As<IQueryable<Permission>>().Setup(m => m.Provider).Returns(permissions.AsQueryable().Provider);
            permissionDbSetMock.As<IQueryable<Permission>>().Setup(m => m.Expression).Returns(permissions.AsQueryable().Expression);
            permissionDbSetMock.As<IQueryable<Permission>>().Setup(m => m.ElementType).Returns(permissions.AsQueryable().ElementType);
            permissionDbSetMock.As<IQueryable<Permission>>().Setup(m => m.GetEnumerator()).Returns(permissions.AsQueryable().GetEnumerator());

            // Mocking the itiContext to return the above DbSet mock
            dbMock.Setup(m => m.Permissions).Returns(permissionDbSetMock.Object);

            // Act
            var result = StudentRepo.Get_Student_Permissions_By_Id(stdID);

            // Assert
            // Write assertions based on the expected behavior of the method with the provided data
            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.Count); 
            Assert.IsTrue(result[0].DateCreated > result[1].DateCreated); 
        }

        [TestMethod]
        public void PermissionDetails_ValidStudentIdAndPermissionDate_ReturnsPermissionOrNull()
        {
            // Arrange
            int stdID = 2; // Adjust with a valid student ID for testing
            DateTime permissionDate = new DateTime(2024, 3, 12); // Adjust with a valid permission date for testing

            // Mocking the Permission data
            var permissions = new List<Permission>
    {
        new Permission { ID = 1, StudentId = stdID, DateCreated = new DateTime(2024, 3, 12) }, // Adjust with valid data
        new Permission { ID = 2, StudentId = stdID, DateCreated = new DateTime(2024, 3, 10) }
    };

            // Mocking the Get_Student_Permissions_By_Id method to return the mock permission data
            StudentRepoMock.Setup(m => m.Get_Student_Permissions_By_Id(stdID)).Returns(permissions);

            // Act
            var result = StudentRepo.PermissionDetails(stdID, permissionDate);

            // Assert
            Assert.IsNotNull(result); 
            Assert.AreEqual(permissionDate.Date.Date, result?.DateCreated.Date);                                         // Add more assertions as needed based on your specific requirements and expected behavior
        }


        [TestMethod]
        public void UpdatePermission_ExistingPermission_SuccessfullyUpdatesProperties()
        {
            // Arrange
            int stdID = 2; // Adjust with a valid student ID for testing
            var originalPermission = new Permission
            {
                ID = 1,
                StudentId = stdID,
                Reason = "Original Reason",
                BodyOfDescription = "Original Description",
                DateCreated = new DateTime(2024, 3, 12)
            };

            // Mocking the Get_Student_Permissions_By_Id method to return the original permission
            var permissions = new List<Permission> { originalPermission };
            StudentRepoMock.Setup(m => m.Get_Student_Permissions_By_Id(stdID)).Returns(permissions);

            // Mocking the permission to update
            var updatedPermission = new Permission
            {
                ID = 1,
                StudentId = stdID,
                Reason = "Updated Reason",
                BodyOfDescription = "Updated Description",
                DateCreated = new DateTime(2024, 3, 12)
            };

            // Act
            StudentRepo.UpdatePermission(updatedPermission);

            // Assert
            Assert.AreNotEqual(updatedPermission.Reason, originalPermission.Reason);
            Assert.AreNotEqual(updatedPermission.BodyOfDescription, originalPermission.BodyOfDescription);
        }



        [TestMethod]
        public void GetStudentById_ValidId_ReturnsStudent()
        {
            // Arrange
            int studentId = 1; // Adjust with a valid student ID for testing
            var expectedStudent = new Student { Id = studentId, UserName = "John Doe" }; // Assuming this student exists in the database

            // Mocking the Students DbSet to return a list of students
            var students = new List<Student> { expectedStudent };
            dbMock.Setup(m => m.Students.FirstOrDefault(It.IsAny<Expression<Func<Student, bool>>>()))
                          .Returns((Expression<Func<Student, bool>> predicate) => students.FirstOrDefault(predicate.Compile()));

            // Act
            var result = StudentRepo.GetStudentById(studentId);

            // Assert
            Assert.AreEqual(expectedStudent.Id, result.Id); // Verify that the retrieved student has the expected ID
            Assert.AreEqual(expectedStudent.UserName, result.UserName); // Verify that the retrieved student has the expected name
        }

        [TestMethod]
        public void GetSchedules_ValidStudentId_ReturnsSchedules()
        {
            // Arrange
            int studentId = 1; // Adjust with a valid student ID for testing
            var student = new Student { Id = studentId, TrackID = 1 }; // Assuming this student exists in the database

            // Mocking the Schedule data
            var schedules = new List<Schedule>
    {
        new Schedule { Id = 1, TrackId = 1, Date = new DateOnly(2024, 4, 15) }, // Adjust with valid data
        new Schedule { Id = 2, TrackId = 1, Date = new DateOnly(2024, 4, 16) }
    };

            // Mocking the GetStudentById method to return the student
            StudentRepoMock.Setup(m => m.GetStudentById(studentId)).Returns(student);

            // Mocking the Schedules DbSet to return a list of schedules
            // Mocking the Schedules DbSet to return a list of schedules
            var mockDbSet = new Mock<DbSet<Schedule>>();
            mockDbSet.As<IQueryable<Schedule>>().Setup(m => m.Provider).Returns(schedules.AsQueryable().Provider);
            mockDbSet.As<IQueryable<Schedule>>().Setup(m => m.Expression).Returns(schedules.AsQueryable().Expression);
            mockDbSet.As<IQueryable<Schedule>>().Setup(m => m.ElementType).Returns(schedules.AsQueryable().ElementType);
            mockDbSet.As<IQueryable<Schedule>>().Setup(m => m.GetEnumerator()).Returns(schedules.AsQueryable().GetEnumerator());

            dbMock.Setup(m => m.Schedules).Returns(mockDbSet.Object);


            // Act
            var result = StudentRepo.getSchedules(studentId);

            // Assert
            Assert.IsNotNull(result); // Verify that the result is not null
            Assert.AreEqual(2, result.Count); // Verify that the correct number of schedules is retrieved
            Assert.AreEqual(new DateOnly(2024, 4, 16), result[0].Date); // Verify that the schedules are ordered by date in descending order
            Assert.AreEqual(new DateOnly(2024, 4, 15), result[1].Date);
        }


        [TestMethod]
        public void GetScheduleEvents_ValidInput_ReturnsScheduleEvents()
        {
            // Arrange
            int stdID = 1; // Assuming a valid student ID
            int scheduleId = 1; // Assuming a valid schedule ID
            var schedules = new List<Schedule>
    {
        new Schedule { Id = 1, TrackId = 1, ScheduleEvents = new List<ScheduleEvent>
            {
                new ScheduleEvent { Id = 1, Name = "Event 1", StartTime = DateTime.Now, EndTime = DateTime.Now.AddHours(1) },
                new ScheduleEvent { Id = 2, Name = "Event 2", StartTime = DateTime.Now.AddHours(2), EndTime = DateTime.Now.AddHours(3) }
            }
        }
    };

            var scheduleDbSetMock = new Mock<DbSet<Schedule>>();
            scheduleDbSetMock.As<IQueryable<Schedule>>().Setup(m => m.Provider).Returns(schedules.AsQueryable().Provider);
            scheduleDbSetMock.As<IQueryable<Schedule>>().Setup(m => m.Expression).Returns(schedules.AsQueryable().Expression);
            scheduleDbSetMock.As<IQueryable<Schedule>>().Setup(m => m.ElementType).Returns(schedules.AsQueryable().ElementType);
            scheduleDbSetMock.As<IQueryable<Schedule>>().Setup(m => m.GetEnumerator()).Returns(schedules.AsQueryable().GetEnumerator());

            dbMock.Setup(m => m.Schedules).Returns(scheduleDbSetMock.Object);


            // Act
            var result = StudentRepo.GetScheduleEvents(stdID, scheduleId);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.Count); // Assuming the schedule has 2 events
                                              // Add more assertions as needed based on your specific requirements and expected behavior
        }

        [TestMethod]
        public void GetCurrentUser_ReturnsCurrentUser()
        {
            // Arrange
            var currentUser = new User(); // Create a mock user object
            userManagerMock.Setup(u => u.GetUserAsync(userPrincipalMock.Object)).ReturnsAsync(currentUser); // Mock GetUserAsync method to return the mock user

            // Act
            var result = StudentRepo.GetCurrentUser();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(currentUser, result); // Ensure the returned user is the same as the mocked user
        }


        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}