using Attendance_Management_System.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Attendance_Management_System.Data
{
    public interface IitiContext
    {
        DbSet<Student> Students { get; set; }
        DbSet<Attendance> Attendances { get; set; }
        DbSet<AttendanceDegree> AttendanceDegrees { get; set; }
        DbSet<Schedule> Schedules { get; set; }
        DbSet<ScheduleEvent> ScheduleEvents { get; set; }
        DbSet<Track> Tracks { get; set; }
        DbSet<ITIProgram> Programs { get; set; }
        DbSet<Permission> Permissions { get; set; }
        DbSet<TrackIntake> TrackIntakes { get; set; }
        int SaveChanges();
        EntityEntry Update(object entity);
    }
}
