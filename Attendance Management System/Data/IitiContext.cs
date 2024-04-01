using Attendance_Management_System.Models;

namespace Attendance_Management_System.Data
{
    public interface IitiContext
    {
        List<Student> students { get; set; }
    }
}
