using Attendance_Management_System.Data;
using Attendance_Management_System.Dtos;
using Attendance_Management_System.IRepos;
using Attendance_Management_System.Models;
using Attendance_Management_System.Repos;
using ExcelDataReader;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NuGet.DependencyResolver;
using NuGet.Protocol.Plugins;
using System.Text;

namespace Attendance_Management_System.Controllers
{
    //[Authorize(Roles = RolesValues.InstructorRole)]
    public class InstructorController : Controller
    {
        IInstructorRepo InstructorRepo;
        private readonly UserManager<User> _userManager;
        public InstructorController(IInstructorRepo _InstructorRepo, UserManager<User> userManager)
        {
            InstructorRepo = _InstructorRepo;
            _userManager = userManager;
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
        public IActionResult Students()
        {
            //get the current user
            var user = InstructorRepo.GetCurrentUser();
            if (user == null)
            {
                return Redirect("/Identity/Account/Login");

            }
            if (user is not Supervisor)
            {
                return RedirectToAction("Index", "Home");
            }
            int trackID = (user as Supervisor).SupTrackId;
            // get the list of students from the database
            List<Student> students = InstructorRepo.getStudentsByTrackID(trackID);
             
            //ViewData["Name"] = user.UserName;
            return View(students);

        }
        //Delete Student
        [HttpPost]
        public int DeleteStudent(int id)
        {
            try
            {
                InstructorRepo.DeleteStudent(id);

                return 1;
            }
            catch (Exception)
            {
                return 0;
            }
        }
        //Add Student
        [HttpPost]
        public async Task<IActionResult> AddStudent(Student student)
        {
            var user = InstructorRepo.GetCurrentUser();
            int trackID = (user as Supervisor).SupTrackId;
            await InstructorRepo.AddStudent(student, trackID);
            return RedirectToAction("Students");
        }
        //Edit Student
        [HttpPost]
        public async Task<IActionResult> EditStudent(Student student)
        {
            await InstructorRepo.EditStudent(student);
            return RedirectToAction("Students");
        }
        private async Task<User> GetCurrentUser()
        {
            return await _userManager.GetUserAsync(User);
        }
        public IActionResult UploadExcel()
        {
            return View();
        }
        // Upload Excel File
        [HttpPost]
        public async Task<IActionResult> UploadExcel(IFormFile file)
        {
            var user = InstructorRepo.GetCurrentUser();
            int trackID = (user as Supervisor)?.SupTrackId ?? 1; // If the trackID is null, use 1 as the default value for testing purposes to be removed
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            if (file != null && file.Length > 0)
            {
                var uploadsFolder = $"{Directory.GetCurrentDirectory()}\\wwwroot\\Uploads\\";

                if (!Directory.Exists(uploadsFolder))
                {
                    Directory.CreateDirectory(uploadsFolder);
                }

                var timeStamp = DateTime.Now.ToString("yyyyMMddHHmmss");
                var fileName = Path.GetFileNameWithoutExtension(file.FileName) + timeStamp + Path.GetExtension(file.FileName);


                var filePath = Path.Combine(uploadsFolder, fileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }

                using (var stream = System.IO.File.Open(filePath, FileMode.Open, FileAccess.Read))
                {
                    using (var reader = ExcelReaderFactory.CreateReader(stream))
                    {
                        do
                        {
                            bool isHeaderSkipped = false;

                            while (reader.Read())
                            {
                                if (!isHeaderSkipped)
                                {
                                    isHeaderSkipped = true;
                                    continue;
                                }

                                Student student = new Student
                                {
                                    UserName = reader.GetValue(0).ToString(),
                                    NationalId = reader.GetValue(1).ToString(),
                                    Email = reader.GetValue(2).ToString(),
                                    University = reader.GetValue(3).ToString(),
                                    Faculty = reader.GetValue(4).ToString(),
                                    TrackID = trackID,
                                };

                                await InstructorRepo.AddStudent(student, trackID);
                            }
                        } while (reader.NextResult());

                        ViewBag.Message = "success";
                    }
                }
            }
            else
                ViewBag.Message = "empty";
            return View();
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
