﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Attendance_Management_System.Models
{
    public class AttendanceDegree
    {
        public int StudentId { get; set; }
        public DateOnly UntilDate { get; set; }
        public int AbscenceDays { get; set; }
        public int Let { get; set; }
        public int Five { get; set; }
        public int Ten { get; set; }
        public int Fifteen { get; set; }
        public int twenty { get; set; }
        public int TwentFive { get; set; }
        public int WithoutPermission { get; set; }
        public int WithPermission { get; set; }
        public int ReducedDueToAbsenceWithPermission { get; set; }
        public int AttendanceDegrees { get; set; }
        [ForeignKey(nameof(StudentId))]
        public Student Student { get; set; }
    }
}
