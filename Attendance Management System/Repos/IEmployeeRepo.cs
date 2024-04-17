using Attendance_Management_System.Models;

namespace Attendance_Management_System.Repos
{
    public interface IEmployeeRepo
    {
        List<Student> ReadAllStudents();
        List<Track> ReadAllTracks();
        List<Student> ReadTodaysStudents();
        int SetAttendance(int id, DateTime dateTime, string type);
        List<Schedule> ReadSchedules();
        List<AttendanceDegree> ReadAttendanceDegrees();
    }
}
