using Attendance_Management_System.Models;

namespace Attendance_Management_System.Data
{
    public interface IitiContext
    {
        List<Student> students { get; set; }
        List<ITIProgram> programs { get; set; }
        List<Intake> intakes { get; set; }
        List<Track> tracks { get; set; }
        List<Instructor> instructors { get; set; }
    }
}
