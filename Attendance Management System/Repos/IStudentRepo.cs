using Attendance_Management_System.Models;

namespace Attendance_Management_System.Repos
{
    public interface IStudentRepo
    {
        public List<Attendance> Get_Student_Attendances_By_Id(string id);



        public List<Permission> Get_Student_Permissions_By_Id(string StdID);



        public void CreatePermission(Permission permission);

        public void UpdatePermission(Permission permission);

        public void DeletePermission(string stdID, DateTime permissionDate);

        public Permission PermissionDetails(string stdID, DateTime permissionDate);







    }
}
