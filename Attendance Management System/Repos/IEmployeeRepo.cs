using Attendance_Management_System.Models;

namespace Attendance_Management_System.Repos
{
    public interface IEmployeeRepo
    {
        List<Student> ReadAllStudents();
        List<Track> ReadAllTracks();
    }
}
