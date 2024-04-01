using System.ComponentModel.DataAnnotations.Schema;

namespace Attendance_Management_System.Models
{
    public class Student : User
    {
        public string University { get; set; }
        public string Faculty { get; set; }
        public string Specialization { get; set; }
        public int GraduationYear { get; set; }
        public int TrackId { get; set; }
        public int IntakeId { get; set; }

        //navigation
        [ForeignKey("TrackId")]
        public Track Track { get; set; }
        [ForeignKey("IntakeId")]
        public Intake Intake { get; set; }
    }
}
