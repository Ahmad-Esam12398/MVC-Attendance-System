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
    }
}
