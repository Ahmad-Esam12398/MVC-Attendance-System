using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Attendance_Management_System.Models
{
    public class Track
    {
        #region Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public int ProgramId { get; set; }
        public bool IsActive { get; set; } = true;
        #endregion

        #region Navigation Properties
        // 1-M relationship between Track and Schedule
        public List<Schedule> Schedules { get; set; } = new List<Schedule>();

        // 1-M relationship between Track and Program
        [ForeignKey("ProgramId")]
        public ITIProgram Program { get; set; }
        // 1-1 relationship between Track and Supervisor
        [ForeignKey("SupervisorId")]
        public string SupervisorId { get; set; }
        [NotMapped]
        public Instructor Supervisor { get; set; }
        // M-M relationship between Track and Student
        public virtual ICollection<Student> Students { get; set; } = new HashSet<Student>();
        // M-M relationship between Track and Instructor
        public virtual ICollection<Instructor> Instructors { get; set; } = new HashSet<Instructor>();

        #endregion
    }
}
