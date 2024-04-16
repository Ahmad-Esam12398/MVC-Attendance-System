using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Attendance_Management_System.Models
{
    public class Track
    {
        //navigation
        public int Id { get; set; }
        public string Name { get; set; }
        public int ProgramId { get; set; }
        public bool IsActive { get; set; }
        public string SupervisorId { get; set; }
      
        #region Navigation Properties
        // 1-M relationship between Track and Schedule
        public List<Schedule> Schedules { get; set; } = new List<Schedule>();
        [ForeignKey("ProgramId")]
        public ITIProgram Program { get; set; }
        public ICollection<Student> Students { get; set; }
        [ForeignKey("SupervisorId")]
        public Instructor Supervisor { get; set; }
        #endregion
    }
}
