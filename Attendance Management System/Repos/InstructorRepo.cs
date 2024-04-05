using Attendance_Management_System.Data;
using Attendance_Management_System.Models;
using Microsoft.EntityFrameworkCore;

namespace Attendance_Management_System.Repos
{
    public class InstructorRepo : IInstructorRepo
    {
        IitiContext db;
        public InstructorRepo(IitiContext _db)
        {
            db = _db;
        }
        public List<Permission> getAllPermissions()
        {
            return db.Permissions.ToList();
        }
        public void AcceptPermission(int id)
        {
            var permission = db.Permissions.Find(u => u.ID == id);
            permission.Status = PermissionStatus.Accepted;
        }
        public void RefusePermission(int id)
        {
            var permission = db.Permissions.Find(u => u.ID == id);
            permission.Status = PermissionStatus.Refused;
        }
        public List<Permission> getPendingPermissions()
        {
            return db.Permissions.Where(u => u.Status == PermissionStatus.Pending).ToList();
        }
    }
}
