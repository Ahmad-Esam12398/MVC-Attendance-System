﻿using Attendance_Management_System.Models;

namespace Attendance_Management_System.ViewModels
{
    public class AttendanceViewData
    {
        public DateOnly Date { get; set; }

        public TimeOnly Time_in { get; set; }
        public TimeOnly Time_out { get; set; }

        public string Status { get; set; }

        public override string ToString()
        {
            return $"{Date}:{Time_in}:{Time_out}:{Status}";
        }
    }
}
