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
            var permission = db.Permissions.FirstOrDefault(p => p.ID == id);
            permission.Status = PermissionStatus.Accepted;
            db.SaveChanges();

        }
        public void RefusePermission(int id)
        {
            var permission = db.Permissions.FirstOrDefault(p => p.ID == id);
            permission.Status = PermissionStatus.Refused;
            db.SaveChanges();
        }
        public void RefusePermissionsNotToday()
        {
            var permissions = db.Permissions.Where(p => p.Date < DateOnly.FromDateTime(DateTime.Now)).ToList();
            foreach (var permission in permissions)
            {
                permission.Status = PermissionStatus.Refused;
            }
            db.SaveChanges();
        }
        public List<Permission> getPendingPermissionsByTrackID(int TrackID)
        {
            RefusePermissionsNotToday();
            return db.Permissions.Include(p => p.Student).Where(p => p.Status == PermissionStatus.Pending && p.Student.TrackID == TrackID).ToList();
        }

        public List<Schedule> getSchedulesByTrackID(int TrackID)
        {
            return db.Schedules.Where(s => s.TrackId == TrackID).ToList();
        }

        public void AddSchedule(Schedule Schedule)
        {
            Schedule.TrackId = 1;
            db.Schedules.Add(Schedule);
            db.SaveChanges();
        }
        public void DeleteSchedule(int id)
        {
            var Schedule = db.Schedules.Find(id);
            db.Schedules.Remove(Schedule);
            db.SaveChanges();
        }

        public void UpdateSchedule(Schedule schedule)
        {
            var Schedule = db.Schedules.FirstOrDefault(s => s.Id == schedule.Id);
            Schedule.Date = schedule.Date;
            Schedule.StartTime= schedule.StartTime;
            Schedule.EndTime = schedule.EndTime;
            db.SaveChanges();
        }
    }
}
