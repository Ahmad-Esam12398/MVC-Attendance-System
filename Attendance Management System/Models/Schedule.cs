using System.ComponentModel.DataAnnotations;

namespace Attendance_Management_System.Models
{
    public class Schedule 
    {
        #region Properties 
        public int Id { get; set; }
        public DateOnly Date { get; set; }
        public TimeOnly StartTime { get; set; }
        public TimeOnly EndTime { get; set; }
        #endregion

        #region Navigation Properties
        // 1-M relationship between Schedule and Track
        public int TrackId { get; set; }
        public Track Track { get; set; }

        // 1-M relationship between Schedule and ScheduleEvent
        public List<ScheduleEvent> ScheduleEvents { get; set; } = new List<ScheduleEvent>();
        #endregion

    }
}
