using Attendance_Management_System.Models;

namespace Attendance_Management_System.Dtos
{
    public class ScheduleDto
    {
        public int Id { get; set; }
        public string Date { get; set; }
        public TimeOnly StartTime { get; set; }
        public TimeOnly EndTime { get; set; }
        public int TrackId { get; set; }

        public ScheduleDto(Schedule schedule)
        {
            Id = schedule.Id;
            Date = ConvertDate(schedule.Date);
            StartTime = schedule.StartTime;
            EndTime = schedule.EndTime;
            TrackId = schedule.TrackId;
        }

        public string ConvertDate(DateOnly date)
        {
            return date.ToString("yyyy-MM-dd");

        }
    }
}
