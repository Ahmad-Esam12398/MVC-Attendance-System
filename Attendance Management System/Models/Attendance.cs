using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Attendance_Management_System.Models
{
    public class Attendance
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(Student))]
        public int StudentId { get; set; }

        public DateOnly Date { get; set; } = new DateOnly(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day);
        public TimeOnly? Time_in { get; set; } = TimeOnly.FromDateTime(DateTime.Now);
        public TimeOnly? Time_out { get; set; }
        public Student Student { get; set; }
    }
}
