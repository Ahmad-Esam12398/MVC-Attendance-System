using Attendance_Management_System.Data;
using Attendance_Management_System.Dtos;
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
    [Authorize(Roles = RolesValues.InstructorRole)]
    public class InstructorController : Controller
    {
        IInstructorRepo InstructorRepo;
        private readonly UserManager<User> _userManager;
        public InstructorController(IInstructorRepo _InstructorRepo, UserManager<User> userManager)
        {
            InstructorRepo = _InstructorRepo;
            _userManager = userManager;
        }
        // Allow Instructor to access the Index Page
        public IActionResult Index()
        {
            ViewData["IsSuperVisor"] = true;

            // Get Current User
            var user = InstructorRepo.GetCurrentUser();
            //if (user == null)
            //{
            //    return Redirect("/Identity/Account/Login");

            //}
            //if (user is not Instructor)
            //{
            //    return RedirectToAction("Index", "Home");
            //}
            //if (user is Supervisor)
            //{
            //    ViewData["IsSuperVisor"] = true;
            //}
            ViewData["Name"] = user.UserName ?? "Instructor";
            return View();
        }
        [Authorize(Roles = RolesValues.SuperVisorRole)]

        public async Task<IActionResult> Permissions()
        {
            // Add Dummy Instructors to the Database if there are no Instructors
            await InstructorRepo.AddDummyInstructors();
            // Get Current User
            var user = InstructorRepo.GetCurrentUser();
            //if (user == null)
            //{
            //    return Redirect("/Identity/Account/Login");
                
            //}
            //if (user is not Supervisor)
            //{
            //    return RedirectToAction("Index", "Instructor");
            //}
            //if (user is not Instructor)
            //{
            //    return RedirectToAction("Index", "Home");
            //}
            int trackID = (user as Supervisor).SupTrackId;
            // Get the list of permissions from the database
            var Permissions = await InstructorRepo.GetPendingPermissionsByTrackID(trackID);
            // Convert the list of permissions to a list of PermissionDto
            List<PermissionDto> PermissionsDtos = new List<PermissionDto>();
            foreach (var permission in Permissions)
            {
                PermissionsDtos.Add(new PermissionDto(permission));
            }
            ViewData["Name"] = user.UserName ?? "Instructor";
            return View(PermissionsDtos);
        }
        [HttpGet("Instructor/Schedule")]
        [Authorize(Roles = RolesValues.SuperVisorRole)]

        public IActionResult Schedule()
        {
            // Get Current User
            var user = InstructorRepo.GetCurrentUser();
            int trackID = (user as Supervisor)?.SupTrackId ?? 1; // If the trackID is null, use 1 as the default value for testing purposes to be removed
            // Get the list of schedules from the database
            var Schedules = InstructorRepo.getSchedulesByTrackID(trackID);
            // Convert the list of schedules to a list of ScheduleDto
            List<ScheduleDto> SchedulesDtos = new List<ScheduleDto>();
            foreach (var schedule in Schedules)
            {
                SchedulesDtos.Add(new ScheduleDto(schedule));
            }
            ViewData["Name"] = user.UserName ?? "Instructor";
            return View(SchedulesDtos);
        }
        [HttpGet("Instructor/Schedule/{Id}")]
        [Authorize(Roles = RolesValues.SuperVisorRole)]

        public IActionResult Schedule(int Id)
        {
            
            var scheduleEvents = InstructorRepo.getSchedulesEventsByScheduleId(Id);
            List<ScheduleEventDto> scheduleEventDtos = new List<ScheduleEventDto>();
            foreach (var scheduleEvent in scheduleEvents)
            {
                scheduleEventDtos.Add(new ScheduleEventDto(scheduleEvent));
            }

            // add the schedule id to the view data
            ViewData["ScheduleId"] = Id;

            return View("ScheduleEvents",scheduleEventDtos);
        }
        [Authorize(Roles = RolesValues.SuperVisorRole)]

        public IActionResult Students()
        {
            //get the current user
            var user = InstructorRepo.GetCurrentUser();

            int trackID = (user as Supervisor)?.SupTrackId ?? 1; // If the trackID is null, use 1 as the default value for testing purposes to be removed
            // get the list of students from the database
            List<Student> students = InstructorRepo.getStudentsByTrackID(trackID);
             
            //ViewData["Name"] = user.UserName;
            return View(students);

        }
        [Authorize(Roles = RolesValues.SuperVisorRole)]

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
        [Authorize(Roles = RolesValues.SuperVisorRole)]

        public async Task<IActionResult> AddStudent(Student student)
        {
            var user = InstructorRepo.GetCurrentUser();
            int trackID = (user as Supervisor)?.SupTrackId ?? 1; // If the trackID is null, use 1 as the default value for testing purposes to be removed
            await InstructorRepo.AddStudent(student, trackID);
            return RedirectToAction("Students");
        }
        //Edit Student
        [HttpPost]
        [Authorize(Roles = RolesValues.SuperVisorRole)]

        public async Task<IActionResult> EditStudent(Student student)
        {
            await InstructorRepo.EditStudent(student);
            return RedirectToAction("Students");
        }
        [Authorize(Roles = RolesValues.SuperVisorRole)]

        private async Task<User> GetCurrentUser()
        {
            return await _userManager.GetUserAsync(User);
        }
        [Authorize(Roles = RolesValues.SuperVisorRole)]

        public IActionResult UploadExcel()
        {
            return View();
        }
        // Upload Excel File
        [HttpPost]
        [Authorize(Roles = RolesValues.SuperVisorRole)]

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
        [Authorize(Roles = RolesValues.SuperVisorRole)]

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
        [Authorize(Roles = RolesValues.SuperVisorRole)]
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
        [Authorize(Roles = RolesValues.SuperVisorRole)]

        public IActionResult AddSchedule(Schedule Schedule)
        {
            var user = InstructorRepo.GetCurrentUser();
            int trackID = (user as Supervisor)?.SupTrackId ?? 1; // If the trackID is null, use 1 as the default value for testing purposes to be removed
            InstructorRepo.AddSchedule(Schedule, trackID);
             return RedirectToAction("Schedule");

        }
        [HttpPost]
        [Authorize(Roles = RolesValues.SuperVisorRole)]

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
        [Authorize(Roles = RolesValues.SuperVisorRole)]

        public IActionResult UpdateSchedule(Schedule Schedule)
        {
          InstructorRepo.UpdateSchedule(Schedule);
          return RedirectToAction("Schedule");

         }
        #endregion
        #region ScheduleEvent
        [HttpPost]
        [Authorize(Roles = RolesValues.SuperVisorRole)]

        public IActionResult DeleteScheduleEvent(int id)
        {
            int Id = int.Parse(Request.Path.Value.Split("/").Last());
            InstructorRepo.DeleteScheduleEvent(id);
            return Redirect($"/Instructor/Schedule/{Id}");
        }
        [HttpPost]
        [Authorize(Roles = RolesValues.SuperVisorRole)]

        public IActionResult AddScheduleEvent(ScheduleEvent scheduleEvent)
        {
            // Get Id from the URL not the request Path
            int Id = int.Parse(Request.Path.Value.Split("/").Last());
            ScheduleEvent scheduleEventN = new ScheduleEvent()
            {
                Name = scheduleEvent.Name,
                StartTime = scheduleEvent.StartTime,
                EndTime = scheduleEvent.EndTime,
                ScheduleId = Id

            };             
            scheduleEvent.ScheduleId = Id;
            InstructorRepo.AddScheduleEvent(scheduleEventN);
            return Redirect($"/Instructor/Schedule/{Id}");

        }
        [HttpPost]
        [Authorize(Roles = RolesValues.SuperVisorRole)]

        public IActionResult UpdateScheduleEvent(ScheduleEvent scheduleEvent)
        {
            int Id = int.Parse(Request.Path.Value.Split("/").Last());

            InstructorRepo.UpdateScheduleEvent(scheduleEvent);
            return Redirect($"/Instructor/Schedule/{Id}");

        }
        #endregion
        #endregion
    }
}
