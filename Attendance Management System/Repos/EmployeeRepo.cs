using Attendance_Management_System.Data;
using Attendance_Management_System.Models;
using Microsoft.EntityFrameworkCore;

namespace Attendance_Management_System.Repos
{
    public class EmployeeRepo : IEmployeeRepo
    {
        IitiContext db;
        public EmployeeRepo(IitiContext _db)
        {
            db = _db;
        }
        public List<Student> ReadAllStudents()
        {
            return db.students.ToList();
        }
        public List<Track> ReadAllTracks()
        {
            return db.Tracks.ToList();
        }
        public List<Student> ReadTodaysStudents()
        {
            var todayDate = DateTime.Now;
            var todaysTracks = db.Schedules.Where(s => s.Date == DateOnly.FromDateTime(todayDate)).Select(s=> s.Track).ToList();
            var todaysStudents = db.students.Where(s => todaysTracks.Contains(s.Track)).ToList();
            return todaysStudents;
        }
        public List<Schedule> ReadSchedules()
        {
            return db.Schedules.ToList();
        }
        public int SetAttendance(String id, DateTime dateTime, string type)
        {
            var student = db.students.FirstOrDefault(s => s.NationalId == id);
            if (student == null)
            {
                return 1;
            }
            var checkIn = db.Attendances.FirstOrDefault(a => a.StudentId == id && a.Date == DateOnly.FromDateTime(dateTime));
            var checkOut = db.Attendances.FirstOrDefault(a => a.StudentId == id && a.Date == DateOnly.FromDateTime(dateTime));
            if (type == "in" && checkIn != null)
                return 2;
            if (type == "out" && checkOut == null)
                return 3;
            if (type == "in")

            {
                Attendance attendance = new Attendance()
                {
                    StudentId = id,
                    Student = student,
                    Date = DateOnly.FromDateTime(dateTime),
                    Time_in = TimeOnly.FromDateTime(dateTime)
                };
                db.Attendances.Add(attendance);
                student.Attendances.Add(attendance);
                //db.SaveChanges();
            }
            else if(type == "out")
            {
                var attendance = db.Attendances.FirstOrDefault(a => a.StudentId == id && a.Date == DateOnly.FromDateTime(dateTime));
                attendance.Time_out = TimeOnly.FromDateTime(dateTime);
                student.Attendances.Single(s => s.Date == DateOnly.FromDateTime(dateTime)).Time_out = TimeOnly.FromDateTime(dateTime);
                //db.SaveChanges();
            }
            return 0;
        }
    }
}
