using System.ComponentModel.DataAnnotations.Schema;

namespace Attendance_Management_System.Models
{
    public class Supervisor : Instructor
    {
        public int TrackId { get; set; }

        //navigation
        [ForeignKey("TrackId")]
        public Track Track { get; set; }
    }
}
