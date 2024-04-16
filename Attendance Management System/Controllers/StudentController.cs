using Attendance_Management_System.Dtos;
using Attendance_Management_System.Models;
using Attendance_Management_System.Repos;
using Microsoft.AspNetCore.Mvc;

namespace Attendance_Management_System.Controllers
{
    public class StudentController : Controller
    {
        IStudentRepo StudentRepo;
        public StudentController(IStudentRepo _StudentRepo)
        {
            StudentRepo = _StudentRepo;
        }
        public IActionResult Index(int id)
        {
            var std=StudentRepo.GetStudentById(id);
            ViewBag.id = id;

            return View("testView",std);
        }


        public IActionResult Attendance(int id)
        
        
        {
            
            var attendList=StudentRepo.Get_Student_Attendances_By_Id(id);
            ViewBag.id = id;
            return View(attendList);

        }

        public IActionResult Permission(int id) {
           var permissionList= StudentRepo.Get_Student_Permissions_By_Id(id);
            ViewBag.id = id;
            return View(permissionList);
        }




        [HttpGet]
        public IActionResult CreatePermission(int id)
        {
            ViewBag.StudentId = id;
            return View("Create Permission");
        }

        [HttpPost]
        public IActionResult CreatePermission(int id, Permission permission)
        {
            if (ModelState.IsValid)
            {
                permission.StudentId = id;
                permission.DateCreated = DateTime.Now;
                StudentRepo.CreatePermission(permission);
                return RedirectToAction("Permission", new { id });
            }
            ViewBag.StudentId = id;
            return View(permission);
        }

        // Edit a permission
        [HttpGet]
        public IActionResult EditPermission(int id, DateTime permissionDate)
        {
            var permission = StudentRepo.PermissionDetails(id, permissionDate);
            if (permission == null)
            {
                return NotFound();
            }
            return View(permission);
        }

        [HttpPost]
        public IActionResult EditPermission(Permission permission)
        {
            if (ModelState.IsValid)
            {
                StudentRepo.UpdatePermission(permission);
                return RedirectToAction("Permission", new { id = permission.StudentId });
            }
            return View(permission);
        }



        // Delete a permission
        public IActionResult DeletePermission(int id, DateTime permissionDate)
        {
            StudentRepo.DeletePermission(id, permissionDate);
            return RedirectToAction("Permission", new { id });
        }

        public IActionResult Schedules(int id)
        {
            var schedules = StudentRepo.getSchedules(id);
            ViewBag.id = id;

            List<ScheduleDto> SchedulesDtos = new List<ScheduleDto>();
            foreach (var schedule in schedules)
            {
                SchedulesDtos.Add(new ScheduleDto(schedule));
            }
            return View(SchedulesDtos);
        }


        public IActionResult ScheduleEvents(int stdId, int scheduleId)
        {
            var schedulesEvents = StudentRepo.GetScheduleEvents(stdId, scheduleId);
            ViewBag.id = stdId;
            return View(schedulesEvents);
        }
    }
}
