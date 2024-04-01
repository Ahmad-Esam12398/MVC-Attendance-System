using System.ComponentModel.DataAnnotations;

namespace Attendance_Management_System.Models
{
    public class Instructor : User
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        //navigation
        public ICollection<Track> Tracks { get; set; }
        public ICollection<Supervisor> SupervisedTracks { get; set; }
    }
}
