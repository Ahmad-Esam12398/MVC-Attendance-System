using Attendance_Management_System.Data;
using Attendance_Management_System.IRepos;
using Attendance_Management_System.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace Attendance_Management_System.Repos
{
    public class InstructorRepo : IInstructorRepo
    {
        itiContext db;
        //UserManger Instance
        private readonly UserManager<User> _userManager;
        private readonly ClaimsPrincipal _userPrincipal; // Add a field to store the user principal

        public InstructorRepo(itiContext _db, UserManager<User> userManager, ClaimsPrincipal userPrincipal)
        {
            db = _db;
            _userManager = userManager;
            _userPrincipal = userPrincipal; // Assign the user principal to the field
        }

        public List<Permission> getAllPermissions()
        {
            return db.Permissions.ToList();
        }

        public void AcceptPermission(int id)
        {
            var permission = db.Permissions.FirstOrDefault(p => p.ID == id);
            permission.Status = PermissionStatus.Accepted;
            db.SaveChanges();
        }

        public void RefusePermission(int id)
        {
            var permission = db.Permissions.FirstOrDefault(p => p.ID == id);
            permission.Status = PermissionStatus.Refused;
            db.SaveChanges();
        }

        public void RefusePermissionsNotToday()
        {
            var permissions = db.Permissions.Where(p => p.Date < DateOnly.FromDateTime(DateTime.Now)).ToList();
            foreach (var permission in permissions)
            {
                permission.Status = PermissionStatus.Refused;
            }
            db.SaveChanges();
        }

        public async Task<List<Permission>> GetPendingPermissionsByTrackID(int trackID)
        {
            // Add Dummy Instructors to the Database if there are no Instructors
            await AddDummyInstructors();
            var user = GetCurrentUser();
            
            RefusePermissionsNotToday();
            return db.Permissions.Include(p => p.Student).Where(p => p.Status == PermissionStatus.Pending && p.Student.TrackID == trackID).ToList();
        }

        public List<Schedule> getSchedulesByTrackID(int TrackID)
        {
            return db.Schedules.Where(s => s.TrackId == TrackID).ToList();
        }

        public void AddSchedule(Schedule Schedule)
        {
            Schedule.TrackId = 1;
            db.Schedules.Add(Schedule);
            db.SaveChanges();
        }

        public void DeleteSchedule(int id)
        {
            var Schedule = db.Schedules.Find(id);
            db.Schedules.Remove(Schedule);
            db.SaveChanges();
        }

        public void UpdateSchedule(Schedule schedule)
        {
            var Schedule = db.Schedules.FirstOrDefault(s => s.Id == schedule.Id);
            Schedule.Date = schedule.Date;
            Schedule.StartTime = schedule.StartTime;
            Schedule.EndTime = schedule.EndTime;
            db.SaveChanges();
        }

        public User GetCurrentUser()
        {
            return _userManager.GetUserAsync(_userPrincipal).Result; // Get the current user using the user principal
        }
        // Add Dummy Instructors to the Database if there are no Instructors using UserManager and RoleManager
        public async Task AddDummyInstructors()
        {

            await _userManager.CreateAsync(new Instructor { UserName = "Account", NationalId = "1000", Email = "Ahmed@gmail.com" }, "123456aA!");
            await _userManager.CreateAsync(new Supervisor { UserName = "Account2", NationalId = "1001", Email = "Ahmed2@gmail.com" , SupTrackId=1 }, "123456aA!");
  
        }

        public List<Student> getStudentsByTrackID(int trackID)
        {
            return db.Students.Where(s => s.TrackID == trackID).ToList();
        }

        public void DeleteStudent(int id)
        {
            var student = db.Students.FirstOrDefault(s => s.Id == id);
            db.Students.Remove(student);
            db.SaveChanges();
        }
        public async Task AddStudent(Student student , int trackID)
        {
            var user = new Student { UserName = student.UserName, NationalId = student.NationalId, Email = student.Email, TrackID = trackID , University = student.University, Faculty = student.Faculty };
            await _userManager.CreateAsync(user, "123456aA!");
        }
        public async Task EditStudent(Student student)
        {
            var user = db.Students.FirstOrDefault(s => s.Id == student.Id);
            user.UserName = student.UserName;
            user.Email = student.Email;
            await _userManager.UpdateAsync(user);
        }

    }
}
