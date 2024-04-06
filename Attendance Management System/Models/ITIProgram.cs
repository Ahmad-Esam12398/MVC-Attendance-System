using System.ComponentModel.DataAnnotations;

namespace Attendance_Management_System.Models
{
    public class ITIProgram
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(20)]
        public string Name { get; set; }
        [MaxLength(50)]
        public string Description { get; set; }
        public bool IsActive { get; set; }
        //navigation
        public ICollection<Track> Tracks { get; set; } = new HashSet<Track>();
    }
}
