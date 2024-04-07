using Attendance_Management_System.Models;
using Attendance_Management_System.ViewData;

namespace Attendance_Management_System.Repos
{
    public interface IStudentRepo
    {
        public Student GetStudentById(int id);
        public List<AttendanceViewData> Get_Student_Attendances_By_Id(int StdID);



        public List<Permission> Get_Student_Permissions_By_Id(int StdID);



        public void CreatePermission(Permission permission);

        public void UpdatePermission(Permission permission);

        public void DeletePermission(int stdID, DateTime permissionDate);

        public Permission PermissionDetails(int stdID, DateTime permissionDate);







    }
}
