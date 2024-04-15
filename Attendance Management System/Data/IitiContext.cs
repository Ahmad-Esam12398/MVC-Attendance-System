using Attendance_Management_System.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Attendance_Management_System.Data
{
    public interface IitiContext
    {
        List<Student> Students { get; set; }
        List<Track> Tracks { get; set; }
        List<ITIProgram> Programs { get; set; }
        List<Permission> Permissions { get; set; }
        List<Schedule> Schedules { get; set; }
        List<Attendance> Attendances { get; set; }
        DbSet<AttendanceDegree> AttendanceDegrees { get; set; }
        DbSet<ScheduleEvent> ScheduleEvents { get; set; }
        DbSet<TrackIntake> TrackIntakes { get; set; }
        int SaveChanges();
        EntityEntry Update(object entity);
    }
}
