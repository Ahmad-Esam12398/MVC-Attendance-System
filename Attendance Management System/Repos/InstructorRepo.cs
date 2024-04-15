using Attendance_Management_System.Data;
using Attendance_Management_System.Models;
using Microsoft.EntityFrameworkCore;

namespace Attendance_Management_System.Repos
{
    public class InstructorRepo : IInstructorRepo
    {
        itiContext db;
        public InstructorRepo(itiContext _db)
        {
            db = _db;
        }
        public List<Permission> getAllPermissions()
        {
            return db.Permissions.ToList();
        }
        public void AcceptPermission(int id)
        {
            var permission = db.Permissions.Find( id);
            permission.Status = PermissionStatus.Accepted;
        }
        public void RefusePermission(int id)
        {
            var permission = db.Permissions.Find(id);
            permission.Status = PermissionStatus.Refused;
        }
        public List<Permission> getPendingPermissions()
        {
            return db.Permissions.Where(u => u.Status == PermissionStatus.Pending).ToList();
        }

        public List<Schedule> getSchedules()
        {
            return db.Schedules.ToList();
        }

        public void AddSchedule(Schedule Schedule)
        {
            Schedule.TrackId = 1;
            db.Schedules.Add(Schedule);
        }
        public void DeleteSchedule(int id)
        {
            var Schedule = db.Schedules.Find(id);
            db.Schedules.Remove(Schedule);
        }

        public void UpdateSchedule(Schedule schedule)
        {
            var index = db.Schedules.Find(schedule.Id);
            index = schedule;   
        }
    }
}
