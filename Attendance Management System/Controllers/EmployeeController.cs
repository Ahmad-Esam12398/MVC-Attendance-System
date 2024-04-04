using Attendance_Management_System.Repos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.DotNet.Scaffolding.Shared.Messaging;

namespace Attendance_Management_System.Controllers
{
    public class EmployeeController : Controller
    {
        public int Tolerance = 15;
        IEmployeeRepo EmployeeRepo;
        public EmployeeController(IEmployeeRepo _EmployeeRepo)
        {
            EmployeeRepo = _EmployeeRepo;
        }
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
        public IActionResult SetAttendance()
        {
            var tracks = EmployeeRepo.ReadAllTracks();
            var todaysStudents = EmployeeRepo.ReadTodaysStudents();
            ViewBag.Tracks = tracks;
            return View(todaysStudents);
        }
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
    }
}
