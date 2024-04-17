using Attendance_Management_System.Data;
using Attendance_Management_System.Models;
using Microsoft.EntityFrameworkCore;

namespace Attendance_Management_System.Repos
{
    public class EmployeeRepo : IEmployeeRepo
    {
        itiContext db;
        int initialAbsenceDegrees = 500;
        public EmployeeRepo(itiContext _db)
        {
            db = _db;
        }
        public List<Student> ReadAllStudents()
        {
            return db.Students.ToList();
        }
        public List<Track> ReadAllTracks()
        {
            return db.Tracks.Include(t=> t.Program).ToList();
        }
        public List<Student> ReadTodaysStudents()
        {
            var todayDate = DateTime.Now;
            var todaysTracks = db.Schedules.Where(s => s.Date == DateOnly.FromDateTime(todayDate)).Select(s=> s.Track).ToList();
            var todaysStudents = db.Students.Where(s => todaysTracks.Contains(s.Track)).ToList();
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
            var checkIn = db.Attendances.FirstOrDefault(a => a.StudentId == id && a.Date == DateOnly.FromDateTime(dateTime));
            var checkOut = db.Attendances.FirstOrDefault(a => a.StudentId == id && a.Date == DateOnly.FromDateTime(dateTime));
            if (type == "in" && checkIn != null)
                return 2;
            if(type == "out" && checkOut == null)
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
            var students = db.Students.Include(s=> s.AttendanceDegrees).Where(s => s.AttendanceDegrees.Max(ad => ad.UntilDate) != DateOnly.FromDateTime(DateTime.Now)).ToList();
            foreach(var student in students)
            {
                var totalDays = db.Schedules.Where(s => s.Track == student.Track).Select(s=> s.Date).Distinct();
                var totalStudentsdays = db.Attendances.Where(a => a.StudentId == student.Id).Select(a=> a.Date).Distinct();
                int absentDays = totalDays.Except(totalStudentsdays).Count();
                var attendanceDegree = new AttendanceDegree()
                {
                    StudentId = student.Id,
                    AbscenceDays = absentDays,
                    AttendanceDegrees = initialAbsenceDegrees - absentDays * 10,
                    UntilDate = DateOnly.FromDateTime(DateTime.Now)
                };
                db.AttendanceDegrees.Add(attendanceDegree);
                db.SaveChanges();
            }
        }
        public List<AttendanceDegree> ReadAttendanceDegrees()
        {
            CalculateAttendanceDegrees();
            return db.AttendanceDegrees.Include(ad=> ad.Student).ThenInclude(s=> s.Track).ToList();
        }
    }
}
