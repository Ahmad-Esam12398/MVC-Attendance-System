using Attendance_Management_System.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace Attendance_Management_System.Data
{
    public interface IitiContext
    {
        DbSet<Schedule> Schedules { get; set; }
        DbSet<ScheduleEvent> ScheduleEvents { get; set; }
        DbSet<Track> Tracks { get; set; }
        DbSet<User> Users { get; set; } 

        List<Student> students { get; set; }
        List<ITIProgram> Programs { get; set; }
        List<Attendance> Attendances { get; set; }

    }
}
