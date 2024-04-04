using Attendance_Management_System.Models;

namespace Attendance_Management_System.Data
{
    public interface IitiContext
    {
        List<Student> students { get; set; }
        List<Track> Tracks { get; set; }
        List<ITIProgram> Programs { get; set; }
        List<Schedule> Schedules { get; set; }
        List<Attendance> Attendances { get; set; }

    }
}
