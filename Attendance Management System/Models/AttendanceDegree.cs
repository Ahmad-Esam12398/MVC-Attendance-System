using System.ComponentModel.DataAnnotations.Schema;

namespace Attendance_Management_System.Models
{
    public class AttendanceDegree
    {
        public int StudentId { get; set; }
        public DateOnly UntilDate { get; set; }
        public int AbscenceDays { get; set; }
        public int AttendanceDegrees { get; set; }
        public Student Student { get; set; }
    }
}
