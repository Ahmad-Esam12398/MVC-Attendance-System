using System.ComponentModel.DataAnnotations.Schema;

namespace Attendance_Management_System.Models
{
    public class Supervisor : Instructor
    {
        public int SupTrackId { get; set; }
        //navigation
        [ForeignKey("SupTrackId")]
        public Track? Track { get; set; }
    }
}
