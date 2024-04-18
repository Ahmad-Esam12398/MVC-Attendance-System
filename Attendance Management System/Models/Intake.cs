using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Attendance_Management_System.Models
{
    public class Intake
    {
        [Key]
        public int Id { get; set; }
        [Range(1, 200)]
        public byte Number { get; set; }
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }
        //navigation
        public ICollection<TrackIntake> Tracks { get; set; }
        public int ProgramId { get;  set; }
        //public ICollection<Student> Students { get; set; } = new HashSet<Student>();


    }
}
