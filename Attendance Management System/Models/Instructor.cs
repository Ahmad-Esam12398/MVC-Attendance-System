using System.ComponentModel.DataAnnotations;

namespace Attendance_Management_System.Models
{
    public class Instructor : User
    {
        //navigation
        public ICollection<Track> Tracks { get; set; }
        public Track SupervisedTrack { get; set; }
    }
}
