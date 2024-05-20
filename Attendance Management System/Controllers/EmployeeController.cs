using Attendance_Management_System.Data;
using Attendance_Management_System.IRepos;
using Attendance_Management_System.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Attendance_Management_System.Controllers
{
    [Authorize(Roles = RolesValues.SecurityRole + "," + RolesValues.StudentsAffairs)]
    public class EmployeeController : Controller
    {
        public int Tolerance = 15;
        IEmployeeRepo EmployeeRepo;
        UserManager<User> _userManager;
        public EmployeeController(IEmployeeRepo _EmployeeRepo, UserManager<User> userManager)
        {
            EmployeeRepo = _EmployeeRepo;
            _userManager = userManager;
        }
        [Authorize(Roles = RolesValues.StudentsAffairs)]
        public IActionResult Index()
        {
            var students = EmployeeRepo.ReadAllStudents();
            var tracks = EmployeeRepo.ReadAllTracks();
            //var todaysStudents = EmployeeRepo.ReadTodaysStudents();
            var schedules = EmployeeRepo.ReadSchedules();
            ViewBag.Tracks = tracks;
            ViewBag.Tolerance = Tolerance;
            ViewBag.Schedules = schedules;
            return View(students);
        }
        [Authorize(Roles = RolesValues.SecurityRole)]
        public IActionResult SetAttendance()
        {
            var tracks = EmployeeRepo.ReadAllTracks();
            var todaysStudents = EmployeeRepo.ReadTodaysStudents();
            ViewBag.Tracks = tracks;
            return View(todaysStudents);
        }
        [Authorize(Roles = RolesValues.SecurityRole)]
        [HttpPost]
        public IActionResult SetAttendance(int id, string type)
        {
            switch(EmployeeRepo.SetAttendance(id, DateTime.Now, type))
            {
                case 0:
                    return Json(new { success = true, Message = "Attendance Marked!" });
                case 1:
                    return Json(new { success = false, Message = "Invalid Student!" });
                case 2:
                    return Json(new { success = false, Message = "Checked In Before" });
                case 3:
                    return Json(new { success = false, Message = "Check In First" });
            }
            return Json(new { success = false, Message = "Invalid Data" });
        }
        [Authorize(Roles = RolesValues.StudentsAffairs)]
        public IActionResult Reports()
        {
            var tracks = EmployeeRepo.ReadAllTracks();
            ViewBag.Tracks = tracks;
            var attendanceDegrees = EmployeeRepo.ReadAttendanceDegrees();
            return View(attendanceDegrees);
        }
        private async Task<User> GetCurrentUser()
        {
            return await _userManager.GetUserAsync(User);
        }
    }
}
