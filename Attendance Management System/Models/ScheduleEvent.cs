namespace Attendance_Management_System.Models
{
    public class ScheduleEvent
    {
        #region Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        #endregion

        #region Navigation Properties
        // 1-M relationship between ScheduleEvent and Schedule
        public int ScheduleId { get; set; }
        public Schedule Schedule { get; set; }
        #endregion
    }
}
