using System.ComponentModel.DataAnnotations.Schema;

namespace Attendance_Management_System.Models
{
    public class Supervisor : Instructor
    {
        public int Id { get; set; }
        public int InstructorId { get; set; }
        public int TrackId { get; set; }

        //navigation
        [ForeignKey("InstructorId")]
        public Instructor Instructor { get; set; }
        [ForeignKey("TrackId")]
        public Track Track { get; set; }

    }
}
