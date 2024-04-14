using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Attendance_Management_System.Models
{
    public class Track
    {
        //navigation
        public int Id { get; set; }
        [MaxLength(20)]
        public string Name { get; set; }
        public int ProgramId { get; set; }
        public int SuperVisorId { get; set; }
        public bool IsActive { get; set; } = true;
        #region Navigation Properties
        // 1-M relationship between Track and Schedule
        public ICollection<Schedule> Schedules { get; set; } = new HashSet<Schedule>();
        [ForeignKey("ProgramId")]
        public ITIProgram Program { get; set; }
        [ForeignKey("SuperVisorId")]
        public Supervisor Supervisor { get; set; }
        public ICollection<Student> Students { get; set; } = new HashSet<Student>();
        public ICollection<TrackIntake> Intakes { get; set; } = new HashSet<TrackIntake>();
        #endregion
    }
}
