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

        public List<Schedule> getSchedules()
        {
            return db.Schedules;
        }

        public void AddSchedule(Schedule Schedule)
        {
            Schedule.TrackId = 1;
            db.Schedules.Add(Schedule);
        }
        public void DeleteSchedule(int id)
        {
            var Schedule = db.Schedules.Find(u => u.Id == id);
            db.Schedules.Remove(Schedule);
        }

        public void UpdateSchedule(Schedule schedule)
        {
            var index = db.Schedules.FindIndex(u => u.Id == schedule.Id);
            db.Schedules[index] = schedule;   
        }
    }
}
