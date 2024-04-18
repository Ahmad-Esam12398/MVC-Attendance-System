using Attendance_Management_System.Models;
using Attendance_Management_System.ViewData;

namespace Attendance_Management_System.Repos
{
    public interface IStudentRepo
    {
       Student GetStudentById(int id);
        List<AttendanceViewData> Get_Student_Attendances_By_Id(int StdID);



        List<Permission> Get_Student_Permissions_By_Id(int StdID);



         void CreatePermission(Permission permission);

         void UpdatePermission(Permission permission);

         void DeletePermission(int stdID, DateTime permissionDate);

         Permission PermissionDetails(int stdID, DateTime permissionDate);


        List<Schedule> getSchedules(int stdID);
        List<ScheduleEvent> GetScheduleEvents(int stdID, int scheduleId);


        User GetCurrentUser();
        Task AddDummyStudent();


    }
}
