using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Attendance_Management_System.Models
{
    public enum PermissionStatus
    {
        Pending,
        Accepted,
        Refused
    }
    public class Permission
    {
        public int ID { get; set; }
        [MaxLength(20)]
        public string Reason { get; set; }
        [MaxLength(50)]
        public string BodyOfDescription { get; set; }
        public DateOnly Date { get; set; }
        public PermissionStatus Status { get; set; } = PermissionStatus.Pending;

        [ForeignKey(nameof(Student))]

        public int StudentId { get; set; } 
        public Student Student { get; set; }

        public DateOnly Date { get; set; } // Added DateOnly

    }
}
