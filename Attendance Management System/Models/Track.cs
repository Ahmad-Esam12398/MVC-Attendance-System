namespace Attendance_Management_System.Models
{
    public class Track
    {
        public int Id { get; set; }
        public string Name { get; set; }

        #region Navigation Properties
        // 1-M relationship between Track and Schedule
        public List<Schedule> Schedules { get; set; } = new List<Schedule>();
        #endregion
    }
}
