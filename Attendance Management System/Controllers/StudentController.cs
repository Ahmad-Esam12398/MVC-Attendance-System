using Attendance_Management_System.Data;
using Attendance_Management_System.Dtos;
using Attendance_Management_System.Models;
using Attendance_Management_System.Repos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Attendance_Management_System.Controllers
{
    [Authorize(Roles = RolesValues.Student)]
    public class StudentController : Controller
    {
        IStudentRepo StudentRepo;
        private readonly UserManager<User> _userManager;
        public StudentController(IStudentRepo _StudentRepo, UserManager<User> userManager)
        {
            StudentRepo = _StudentRepo;
            _userManager = userManager;
        }
       


        public async Task< IActionResult> Attendance()
        
        
        {


            //await StudentRepo.AddDummyStudent();

            int id;
                var user = StudentRepo.GetCurrentUser();
                if (user == null)
                {
                    return Redirect("/Identity/Account/Login");

                }


                else if (user is Student)
                {
                    id = StudentRepo.GetCurrentUser().Id;


                }
                else
                {
                    return RedirectToAction("Index", "Home");
                }
            

            var attendList =StudentRepo.Get_Student_Attendances_By_Id(id);
            ViewBag.id = id;
            return View(attendList);

        }

        public IActionResult Permission() {
            int id;
                var user = StudentRepo.GetCurrentUser();
                if (user == null)
                {
                    return Redirect("/Identity/Account/Login");

                }


                else if (user is Student)
                {
                    id = StudentRepo.GetCurrentUser().Id;


                }
                else
                {
                    return RedirectToAction("Index", "Home");
                }
            
            var permissionList = StudentRepo.Get_Student_Permissions_By_Id(id);
            ViewBag.id = id;
            return View(permissionList);
        }




        [HttpGet]
        public IActionResult CreatePermission()
        {
            int id;
                var user = StudentRepo.GetCurrentUser();
                if (user == null)
                {
                    return Redirect("/Identity/Account/Login");

                }


                else if (user is Student)
                {
                    id = StudentRepo.GetCurrentUser().Id;


                }
                else
                {
                    return RedirectToAction("Index", "Home");
                }
            
            ViewBag.StudentId = id;
            return View("Create Permission");
        }

        [HttpPost]
        public IActionResult CreatePermission( Permission permission)
        {
            int id;
                var user = StudentRepo.GetCurrentUser();
                if (user == null)
                {
                    return Redirect("/Identity/Account/Login");

                }


                else if (user is Student)
                {
                    id = StudentRepo.GetCurrentUser().Id;


                }
                else
                {
                    return RedirectToAction("Index", "Home");
                }
            
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
            if (id == null || id == 0)
            {
                var user = StudentRepo.GetCurrentUser();
                if (user == null)
                {
                    return Redirect("/Identity/Account/Login");

                }


                else if (user is Student)
                {
                    id = StudentRepo.GetCurrentUser().Id;

                    return RedirectToAction("Index", "Account");

                }
                else
                {
                    return RedirectToAction("Index", "Home");
                }
            }
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
                return RedirectToAction("Permission");
            }
            return View(permission);
        }



        // Delete a permission
        public IActionResult DeletePermission( DateTime permissionDate)
        {
            int id;
                 var user = StudentRepo.GetCurrentUser();
                if (user == null)
                {
                    return Redirect("/Identity/Account/Login");

                }


                else if (user is Student)
                {
                    id = StudentRepo.GetCurrentUser().Id;


                }
                else
                {
                    return RedirectToAction("Index", "Home");
                }
            
            StudentRepo.DeletePermission(id, permissionDate);
            return RedirectToAction("Permission", new { id });
        }

        public IActionResult Schedules()
        {
            int id;

            // Get the current date
            DateTime currentDate = DateTime.Now;

            // Get the last day of the previous week (Saturday)
            DateTime lastSaturday = currentDate.AddDays(-(int)currentDate.DayOfWeek);

            // Get the first day of the current week (Saturday)
            DateTime firstDayOfWeek = lastSaturday.AddDays(-1);

           

            var user = StudentRepo.GetCurrentUser();
                if (user == null)
                {
                    return Redirect("/Identity/Account/Login");

                }


                else if (user is Student)
                {
                    id = StudentRepo.GetCurrentUser().Id;


                }
                else
                {
                    return RedirectToAction("Index", "Home");
                }
            
            var schedules = StudentRepo.getSchedules(id);
            ViewBag.id = id;

            List<ScheduleDto> SchedulesDtos = new List<ScheduleDto>();
            foreach (var schedule in schedules)
            {
                SchedulesDtos.Add(new ScheduleDto(schedule));
            }
            return View(SchedulesDtos.OrderByDescending(item => item.Date));
        }


        public IActionResult ScheduleEvents( int scheduleId)
        {
            int stdId;
                var user = StudentRepo.GetCurrentUser();
                if (user == null)
                {
                    return Redirect("/Identity/Account/Login");

                }


                else if (user is Student)
                {
                    stdId = StudentRepo.GetCurrentUser().Id;


                }
                else
                {
                    return RedirectToAction("Index", "Home");
                }
            
            var schedulesEvents = StudentRepo.GetScheduleEvents(stdId, scheduleId);
            ViewBag.id = stdId;
            return View(schedulesEvents);
        }
    }
}
