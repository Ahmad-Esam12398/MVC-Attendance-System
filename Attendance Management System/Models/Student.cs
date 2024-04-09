using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Attendance_Management_System.Models
{
    public class Student : User
    {
        [MaxLength(20)]
        public string University { get; set; }
        [MaxLength(20)]
        public string Faculty { get; set; }
        [MaxLength(20)]
        public string? Specialization { get; set; }
        [Range(2010, 2030)]
        public int GraduationYear { get; set; }

        //[ForeignKey(nameof(Intake))]
        //public int IntakeID { get; set; }

        //public Intake Intake { get; set; }

        [ForeignKey(nameof(Track))]
        public int TrackID { get; set; }
        public Track Track { get; set; }

        public ICollection<Permission> Permissions { get; set; } = new HashSet<Permission>();
        public ICollection<Attendance> Attendances { get; set; } = new HashSet<Attendance>();
        public ICollection<AttendanceDegree> AttendanceDegrees { get; set; } = new HashSet<AttendanceDegree>();
    }
}
