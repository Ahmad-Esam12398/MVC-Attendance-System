using Attendance_Management_System.Models;

namespace Attendance_Management_System.Dtos
{
    public class ScheduleEventDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public TimeOnly StartTime { get; set; }
        public TimeOnly EndTime { get; set; }

        public ScheduleEventDto(ScheduleEvent schedule)
        {
            Id = schedule.Id;
            StartTime = TimeOnly.FromDateTime(schedule.StartTime);
            EndTime = TimeOnly.FromDateTime(schedule.EndTime);
            Name = schedule.Name;
        }

    }
}
