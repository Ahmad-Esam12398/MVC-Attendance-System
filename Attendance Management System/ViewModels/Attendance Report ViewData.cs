namespace Attendance_Management_System.ViewModels
{
    public class Attendance_Report_ViewData
    {
        public int StudentId { get; set; }
        public int AbsenceDays { get; set; }
        public int AttendanceDegree { get; set; }
        public int Let { get; set; }
        public int Five { get; set; }
        public int Ten { get; set; }
        public int Fifteen { get; set; }
        public int twenty { get; set; }
        public int TwentFive { get; set; }
        public int WithoutPermission { get; set; }
        public int WithPermission { get; set; }
        public int ReducedDueToAbsenceWithPermission { get; set; }
    }
}
