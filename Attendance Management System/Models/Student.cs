using System.ComponentModel.DataAnnotations.Schema;

namespace Attendance_Management_System.Models
{
    public class Student : User
    {
        
        public string University { get; set; }
        public string Faculty { get; set; }
        public string Specialization { get; set; }
        public int GraduationYear { get; set; }

        [ForeignKey(nameof(Intake))]
        public int IntakeID { get; set; }

        public Intake Intake { get; set; }

        [ForeignKey(nameof(Track))]
        public int TrackID { get; set; }
        public Track? Track { get; set; }

        public ICollection<Permission> Permissions { get; set; } = new HashSet<Permission>();
        public ICollection<Attendance> Attendances { get; set; } = new HashSet<Attendance>();

        //the attendance degree not applied yet .... i guess the student have only one attandance degree not many 

   
    }
}
