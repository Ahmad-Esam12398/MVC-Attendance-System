using System.ComponentModel.DataAnnotations;

namespace Attendance_Management_System.Models
{
    public class ITIProgram
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
       

        //navigation
        public ICollection<Track> Tracks { get; set; }
        public ICollection<Intake> Intakes { get; set; }
    }
}
