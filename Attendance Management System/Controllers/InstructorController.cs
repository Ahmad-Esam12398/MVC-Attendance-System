using Attendance_Management_System.Dtos;
using Attendance_Management_System.Models;
using Attendance_Management_System.Repos;
using Microsoft.AspNetCore.Mvc;

namespace Attendance_Management_System.Controllers
{
    public class InstructorController : Controller
    {
        IInstructorRepo InstructorRepo;
        public InstructorController(IInstructorRepo _InstructorRepo)
        {
            InstructorRepo = _InstructorRepo;
        }
        public IActionResult Index()
        {
            ViewData["IsSuperVisor"] = false;

            // Get Current User
            var user = InstructorRepo.GetCurrentUser();
            if (user == null)
            {
                return Redirect("/Identity/Account/Login");

            }
            if (user is not Instructor)
            {
                return RedirectToAction("Index", "Home");
            }
            if (user is Supervisor)
            {
                ViewData["IsSuperVisor"] = true;
            }
            ViewData["Name"] = user.UserName;
            return View();
        }
        public async Task<IActionResult> Permissions()
        {
            // Add Dummy Instructors to the Database if there are no Instructors
            await InstructorRepo.AddDummyInstructors();
            // Get Current User
            var user = InstructorRepo.GetCurrentUser();
            if (user == null)
            {
                return Redirect("/Identity/Account/Login");
                
            }
            if (user is not Supervisor)
            {
                return RedirectToAction("Index", "Instructor");
            }
            if (user is not Instructor)
            {
                return RedirectToAction("Index", "Home");
            }
            int trackID = (user as Supervisor).SupTrackId;
            // Get the list of permissions from the database
            var Permissions = await InstructorRepo.GetPendingPermissionsByTrackID(trackID);
            // Convert the list of permissions to a list of PermissionDto
            List<PermissionDto> PermissionsDtos = new List<PermissionDto>();
            foreach (var permission in Permissions)
            {
                PermissionsDtos.Add(new PermissionDto(permission));
            }
            ViewData["Name"] = user.UserName;
            return View(PermissionsDtos);
        }
        public  IActionResult Schedule()
        {
            // Get Current User
            var user = InstructorRepo.GetCurrentUser();
            if (user == null)
            {
                return Redirect("/Identity/Account/Login");

            }
            if (user is not Supervisor)
            {
                return RedirectToAction("Index", "Instructor");
            }
            if (user is not Instructor)
            {
                return RedirectToAction("Index", "Home");
            }
            int trackID = (user as Supervisor).SupTrackId;
            // Get the list of schedules from the database
            var Schedules = InstructorRepo.getSchedulesByTrackID(trackID);
            // Convert the list of schedules to a list of ScheduleDto
            List<ScheduleDto> SchedulesDtos = new List<ScheduleDto>();
            foreach (var schedule in Schedules)
            {
                SchedulesDtos.Add(new ScheduleDto(schedule));
            }
            ViewData["Name"] = user.UserName;
            return View(SchedulesDtos);
        }



        #region API Calls
        #region Permissions
        [HttpPost]
        public int Accept(int id)
        {
            try
            {
                InstructorRepo.AcceptPermission(id);

                return 1;
            }
            catch (Exception)
            {
                return 0;
            }
        }
        [HttpPost]
        public int Reject(int id)
        {
            try
            {
                InstructorRepo.RefusePermission(id);

                return 1;
            }
            catch (Exception)
            {
                return 0;
            }
        }
        #endregion
        #region Schedule
        [HttpPost]
        public IActionResult AddSchedule(Schedule Schedule)
        {
             InstructorRepo.AddSchedule(Schedule);
             return RedirectToAction("Schedule");

        }
        [HttpPost]
        public int Delete(int id)
        {
            try
            {
                InstructorRepo.DeleteSchedule(id);

                return 1;
            }
            catch (Exception)
            {
                return 0;
            }
        }
        [HttpPost]
        public IActionResult UpdateSchedule(Schedule Schedule)
        {
          InstructorRepo.UpdateSchedule(Schedule);
          return RedirectToAction("Schedule");

         }
        #endregion
        #endregion
    }
}
