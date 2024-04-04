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
        public string Reason { get; set; }



        public string BodyOfDescription { get; set; }

        public PermissionStatus Status { get; set; } = PermissionStatus.Pending;


        [ForeignKey(nameof(Student))]
        public string StudentId { get; set; }
        public virtual Student Student { get; set; }

        public DateOnly Date { get; set; }
        public int trackId { get; set; }



    }
}
