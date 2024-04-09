using System.ComponentModel.DataAnnotations.Schema;

namespace Attendance_Management_System.Models
{
    public class TrackIntake
    {
        [ForeignKey("Intake")]
        public int IntakeId { get; set; }
        [ForeignKey("Track")]
        public int TrackId { get; set; }
        public Intake Intake { get; set; }
        public Track Track { get; set; }
    }
}
