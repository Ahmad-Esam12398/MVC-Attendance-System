using System.ComponentModel.DataAnnotations.Schema;

namespace Attendance_Management_System.Models
{
    public class Attendance
    {
        [ForeignKey(nameof(Student))]
        public int StudentId { get; set; }
        public DateOnly Date { get; set; } = new DateOnly(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day);

        public virtual Student? Student { get; set; }
        public TimeOnly? Time_in { get; set; }= TimeOnly.FromDateTime(DateTime.Now);
        public TimeOnly? Time_out { get; set; }
    }
}
