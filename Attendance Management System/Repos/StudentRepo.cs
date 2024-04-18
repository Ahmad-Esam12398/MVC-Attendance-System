using Attendance_Management_System.Data;
using Attendance_Management_System.Models;
using Attendance_Management_System.ViewData;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NuGet.DependencyResolver;
using System.Security;
using System.Security.Claims;

namespace Attendance_Management_System.Repos
{
    public class StudentRepo : IStudentRepo
    {
        itiContext db;
        private readonly UserManager<User> _userManager;
        private readonly ClaimsPrincipal _userPrincipal; // Add a field to store the user principal

        public StudentRepo(itiContext _db, UserManager<User> userManager, ClaimsPrincipal userPrincipal)
        {
            db = _db;
            _userManager = userManager;
            _userPrincipal = userPrincipal; // Assign the user principal to the field

        }

        public void CreatePermission(Permission permission)
        {
           db.Permissions.Add(permission);
           // db.SaveChanges();
        }

        public void DeletePermission(int stdID,DateTime permissionDate)
        {
            var permission=PermissionDetails(stdID,permissionDate);
            db.Permissions.Remove(permission);
        }

        public List<AttendanceViewData> Get_Student_Attendances_By_Id(int stdID)
        {
            var student = db.Students.FirstOrDefault(x => x.Id == stdID);
            List<AttendanceViewData> attendances_for_view = new List<AttendanceViewData>();

            if (student!=null)
            {


                var track_Schedule = db.Schedules.Where(sc => sc.TrackId == student.TrackID).ToHashSet();
                var attendances=db.Attendances.Where(at=>at.StudentId==stdID).ToHashSet();
                var permissions=db.Permissions.Where(p=>p.StudentId==stdID).ToHashSet();

        
                
                foreach (var item in track_Schedule)
                {
                    
                   

                    var check_the_attendance=attendances.FirstOrDefault(at=>at.Date==item.Date);
                    if (check_the_attendance != null)
                    {
                        AttendanceViewData att = new AttendanceViewData()
                        {
                            Date = check_the_attendance.Date,
                            Time_in = (TimeOnly)check_the_attendance.Time_in,
                            Time_out = (TimeOnly)check_the_attendance.Time_out,
                            Status = "Attend"


                        };
                        attendances_for_view.Add(att);
                    }
                    else {
                        var check_the_permission = permissions.FirstOrDefault(p => new DateOnly(p.DateCreated.Year,p.DateCreated.Month,p.DateCreated.Day)== item.Date);

                        if(check_the_permission != null&&check_the_permission.Status== PermissionStatus.Accepted)
                        {

                            AttendanceViewData att = new AttendanceViewData()
                            {
                                Date = new DateOnly(check_the_permission.DateCreated.Year,check_the_permission.DateCreated.Month,check_the_permission.DateCreated.Day),
                                Time_in = new TimeOnly(9,0),
                                Time_out = new TimeOnly(22,0),
                                Status = "Permission"


                            };
                            attendances_for_view.Add(att);
                        }
                        else
                        {
                            AttendanceViewData att = new AttendanceViewData()
                            {
                                Date = item.Date,
                                Time_in = new TimeOnly(9, 0),
                                Time_out = new TimeOnly(22, 0),
                                Status = "Absent"


                            };
                            attendances_for_view.Add(att);
                        }
                    }

                }
            }







            var result =attendances_for_view.OrderByDescending(at => at.Date).ToList();

            return result ;
        }

        public List<Permission> Get_Student_Permissions_By_Id(int StdID)
        {
            return db.Permissions.Where(x=>x.StudentId==StdID).OrderByDescending(per=>per.DateCreated).ToList();
        }

            public Permission PermissionDetails(int stdID, DateTime permissionDate)
        { var studentPermissions=Get_Student_Permissions_By_Id(stdID);
             var res=studentPermissions.FirstOrDefault(x=> x.DateCreated.Date == permissionDate.Date);
            return res;
        }


            public void UpdatePermission(Permission permission)
        {
            var studentPermissions = Get_Student_Permissions_By_Id(permission.StudentId);
            var permission_In_Data = studentPermissions.FirstOrDefault(x => x.DateCreated.Date == permission.DateCreated.Date);
            if (permission_In_Data != null)
            {
                permission_In_Data.BodyOfDescription = permission.BodyOfDescription;
                permission_In_Data.Reason = permission.Reason;
            }
            
        }

            public  Student GetStudentById(int id)
        {
           return db.Students.FirstOrDefault(s=>s.Id==id);

        }

        public List<Schedule> getSchedules(int stdID)
        {
            var student=GetStudentById(stdID);
            var trackId=student.TrackID;
           
            return db.Schedules.Where(s => s.TrackId == trackId).OrderByDescending(sc => sc.Date).ToList();

        }

        public List<ScheduleEvent>GetScheduleEvents(int stdID, int scheduleId)
        {
            return getSchedules(stdID).FirstOrDefault(sc => sc.Id == scheduleId).ScheduleEvents;
        }

        public User GetCurrentUser()
        {
            return _userManager.GetUserAsync(_userPrincipal).Result; // Get the current user using the user principal
        }

        public async Task AddDummyStudent()
        {
            await _userManager.CreateAsync(new Student { UserName = "Ali", NationalId = "1000", Email = "Ali@gmail.com" ,TrackID=1}, "123456aA!");
            await _userManager.CreateAsync(new Student { UserName = "Ahmed", NationalId = "1001", Email = "Ahmed@gmail.com", TrackID = 1 }, "123456aA!");
        }
    }
}
