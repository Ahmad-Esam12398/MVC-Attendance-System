using System.ComponentModel.DataAnnotations;

namespace Attendance_Management_System.Models
{
    public enum JobTitle
    {
        Security,
        StudentsAffairs,
    }
    public class Employee : User
    {
        public JobTitle JobTitle { get; set; }
    }
}
