using Attendance_Management_System.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Attendance_Management_System.Data
{
    public interface IitiContext
    {
        List<Supervisor> Supervisors { get; set; }
        List<Instructor> Instructors { get; set; }
        List<Intake> Intakes { get; set; }
      
        DbSet<Student> Students { get; set; }
        DbSet<Track> Tracks { get; set; }
        DbSet<ITIProgram> Programs { get; set; }
        DbSet<Permission> Permissions { get; set; }
        DbSet<Schedule> Schedules { get; set; }
        DbSet<Attendance> Attendances { get; set; }
        DbSet<AttendanceDegree> AttendanceDegrees { get; set; }
        DbSet<ScheduleEvent> ScheduleEvents { get; set; }
        DbSet<TrackIntake> TrackIntakes { get; set; }
      

        int SaveChanges();
        EntityEntry Update(object entity);
    }
}
