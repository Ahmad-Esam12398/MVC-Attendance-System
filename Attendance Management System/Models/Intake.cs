namespace Attendance_Management_System.Models
{
    public class Intake
    {
        public virtual ICollection<Student> Students { get; set; }=new HashSet<Student>();
    }
}
