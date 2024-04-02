namespace Attendance_Management_System.Models
{
    public class Track
    {
        public string Name { get; set; }
        public virtual ICollection<Student> Students { get; set; } = new HashSet<Student>();
    }
}
