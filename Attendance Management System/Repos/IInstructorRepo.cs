using Attendance_Management_System.Models;

namespace Attendance_Management_System.Repos
{
    public interface IInstructorRepo
    {
        void AcceptPermission(int id);
        void RefusePermission(int id);
        List<Permission> getAllPermissions();
        List<Permission> getPendingPermissions();
    }
}
