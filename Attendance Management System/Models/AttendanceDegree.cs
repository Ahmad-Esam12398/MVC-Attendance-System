using System.ComponentModel.DataAnnotations.Schema;

namespace Attendance_Management_System.Models
{
    public class AttendanceDegree
    {
        public int StudentId { get; set; }
        public DateOnly UntilDate { get; set; }

        public int AbsenceDegree { get; set; }
        [ForeignKey("StudentId")]
        public Student Student { get; set; }
    }
}
