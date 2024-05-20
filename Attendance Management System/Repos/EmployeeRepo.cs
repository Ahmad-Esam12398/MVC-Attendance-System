using Attendance_Management_System.Data;
using Attendance_Management_System.IRepos;
using Attendance_Management_System.Models;
using Attendance_Management_System.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace Attendance_Management_System.Repos
{
    public class EmployeeRepo : IEmployeeRepo
    {
        itiContext db;
        private int initialAbsenceDegrees = 250;
        public Dictionary<int, int> AbsenceDayswithPermission { get; set; }
        public EmployeeRepo(itiContext _db)
        {
            db = _db;
        }
        public List<Student> ReadAllStudents()
        {
            
            return db.Students.Include(s => s.Attendances).ToList();
        }
        public List<Track> ReadAllTracks()
        {
            return db.Tracks.Where(t=> t.IsActive == true).Include(t=> t.Program).ToList();
        }

        public List<Student> ReadTodaysStudents()
        {
            var todayDate = DateTime.Now;
            var todaysTracks = db.Schedules.Where(s => s.Date == DateOnly.FromDateTime(todayDate)).Select(s=> s.Track).ToList();
            var todaysStudents = db.Students.Include(s => s.Attendances).Where(s => todaysTracks.Contains(s.Track)).ToList();
            return todaysStudents;
        }
        public List<Schedule> ReadSchedules()
        {
            return db.Schedules.Include(s=> s.Track).ThenInclude(t => t.Students).ToList();
        }
        public int SetAttendance(int id, DateTime dateTime, string type)
        {
            var student = db.Students.FirstOrDefault(s=> s.Id == id);
            if(student == null)
            {
                return 1;
            }
            var checkIn = db.Attendances.FirstOrDefault(a => a.StudentId == id && a.Date == DateOnly.FromDateTime(dateTime))?.Time_in;
            //var checkOut = db.Attendances.FirstOrDefault(a => a.StudentId == id && a.Date == DateOnly.FromDateTime(dateTime))?.Time_out;
            if (type == "in" && checkIn != null)
                return 2;
            if(type == "out" && checkIn == null)
                return 3;
            if(type == "in")
            {
                Attendance attendance = new Attendance()
                {
                    StudentId = id,
                    Date = DateOnly.FromDateTime(dateTime),
                    Time_in = TimeOnly.FromDateTime(dateTime)
                };
                db.Attendances.Add(attendance);
                //student.Attendances.Add(attendance);
            }
            else if(type == "out")
            {
                var attendance = db.Attendances.FirstOrDefault(a => a.StudentId == id && a.Date == DateOnly.FromDateTime(dateTime));
                attendance.Time_out = TimeOnly.FromDateTime(dateTime);
                student.Attendances.Single(s => s.Date == DateOnly.FromDateTime(dateTime)).Time_out = TimeOnly.FromDateTime(dateTime);
            }
            db.SaveChanges();
            return 0;
        }
        public void CalculateAttendanceDegrees()
        {
            List<Attendance_Report_ViewData> attendanceReportsData = new();
            var students = db.Students.Include(s=> s.AttendanceDegrees).Where(s => s.AttendanceDegrees.Max(ad => ad.UntilDate) != DateOnly.FromDateTime(DateTime.Now)).ToList();
            foreach(var student in students)
            {
                var totalDays = db.Schedules.Where(s => s.Track == student.Track && s.Date < DateOnly.FromDateTime(DateTime.Now)).Select(s=> s.Date).Distinct();
                var totalStudentsdays = db.Attendances.Where(a => a.StudentId == student.Id).Select(a=> a.Date).Distinct();
                List<DateOnly> absentDates = totalDays.Except(totalStudentsdays).Distinct().ToList();
                List<DateOnly> approvedPermissions = db.Permissions.Where(p => p.StudentId == student.Id && p.Status == PermissionStatus.Accepted).Select(p => p.Date).Distinct().ToList();
                List<DateOnly> absentWithPermissions = absentDates.Intersect(approvedPermissions).Distinct().ToList();
                List<DateOnly> absentWithoutPermission = absentDates.Except(absentWithPermissions).Distinct().ToList();
                AttendanceDegree attDegree = CalculateReducedScoreForAbscenceWithPermission(absentWithPermissions.Count, 3);
                attDegree.StudentId = student.Id;
                attDegree.WithoutPermission = absentWithoutPermission.Count;
                attDegree.WithPermission = absentWithPermissions.Count;
                attDegree.TwentFive += absentWithoutPermission.Count;
                attDegree.AbscenceDays = absentDates.Count;
                attDegree.AttendanceDegrees = initialAbsenceDegrees - attDegree.ReducedDueToAbsenceWithPermission - CalculateReducedScoreForAbscenceWithoutPermission(absentWithoutPermission.Count);
                attDegree.UntilDate = DateOnly.FromDateTime(DateTime.Now);
                db.AttendanceDegrees.Add(attDegree);
            }
            db.SaveChanges();
        }
        public int  CalculateReducedScoreForAbscenceWithoutPermission(int n)
        {
            return n * 25;
        }
        public AttendanceDegree CalculateReducedScoreForAbscenceWithPermission(int n, int repetitions)
        {
            AttendanceDegree report = new();
            int sum = 0;
            if (n > 0)
            {
                n -= 1;
                report.Let = 1;
                if (n <= repetitions)
                {
                    sum += n * 5;
                    report.Five = n;
                }
                else
                {
                    sum += repetitions * 5;
                    report.Five = repetitions;
                }
            }
            if(n > repetitions)
            {
                if(n <= repetitions * 2)
                {
                    sum += (n - repetitions) * 10;
                    report.Ten = n - repetitions;
                }
                else
                {
                    sum += repetitions * 10;
                    report.Ten = repetitions;
                }
            }
            if(n > repetitions * 2)
            {
                if(n <= repetitions * 3)
                {
                    sum += (n - repetitions * 2) * 15;
                    report.Fifteen = (n - repetitions * 2);
                }
                else
                {
                    sum += repetitions * 15;
                    report.Fifteen = repetitions;
                }
            }
            if(n > repetitions * 3)
            {
                if(n <= repetitions * 4)
                {
                    sum += (n - repetitions * 3) * 20;
                    report.twenty = (n - repetitions * 3);
                }
                else
                {
                    sum += repetitions * 20;
                    report.twenty = repetitions;
                }
            }
            if(n > repetitions * 4)
            {
                sum += (n - repetitions * 4) * 25;
                report.TwentFive = (n - repetitions * 4);
            }
            report.ReducedDueToAbsenceWithPermission = sum;
            return report;
        }
        public List<AttendanceDegree> ReadAttendanceDegrees()
        {
            CalculateAttendanceDegrees();
            return db.AttendanceDegrees.Include(ad=> ad.Student).ThenInclude(s=> s.Track).ToList();
        }
    }
}
