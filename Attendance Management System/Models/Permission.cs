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
        [Required(ErrorMessage ="*")]
        public string Reason { get; set; }
        [Required(ErrorMessage = "*")]

        public string BodyOfDescription { get; set; }
        public DateOnly Date { get; set; }
        public PermissionStatus Status { get; set; } = PermissionStatus.Pending;
        [Required(ErrorMessage = "*")]

        public DateTime DateCreated { get; set; }

        [ForeignKey(nameof(Student))]
        public int StudentId { get; set; }
        public virtual Student? Student { get; set; }


    }
}
