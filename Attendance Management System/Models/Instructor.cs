using System.ComponentModel.DataAnnotations;

namespace Attendance_Management_System.Models
{
    public class Instructor : User
    {
        #region Properties

        #endregion
        public ICollection<Track> Tracks { get; set; }
    }
}
