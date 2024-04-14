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
            var permission = db.Permissions.FirstOrDefault(u => u.ID == id);
            permission.Status = PermissionStatus.Accepted;
        }
        public void RefusePermission(int id)
        {
            var permission = db.Permissions.FirstOrDefault(u => u.ID == id);
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
            var Schedule = db.Schedules.FirstOrDefault(u => u.Id == id);
            db.Schedules.Remove(Schedule);
        }

        public void UpdateSchedule(Schedule schedule)
        {
            var targetschedule = db.Schedules.FirstOrDefault(u => u.Id == schedule.Id);
            if(targetschedule != null)
            {
                db.Schedules.Update(targetschedule);
            }
            //db.Schedules[index] = schedule;   
        }
    }
}
