using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Attendance_Management_System.Models
{
    public class Track
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int ProgramId { get; set; }
        public bool IsActive { get; set; }
        public string SupervisorId { get; set; }

        //navigation
        [ForeignKey("ProgramId")]
        public Program Program { get; set; }
        public ICollection<Student> Students { get; set; }
        [ForeignKey("SupervisorId")]
        public Instructor Supervisor { get; set; }
    }
}
