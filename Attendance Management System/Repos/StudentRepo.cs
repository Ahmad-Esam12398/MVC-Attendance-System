using Attendance_Management_System.Data;
using Attendance_Management_System.Models;
using Microsoft.EntityFrameworkCore;

namespace Attendance_Management_System.Repos
{
    public class StudentRepo : IStudentRepo
    {
        IitiContext db;
        public StudentRepo(IitiContext _db)
        {
            db = _db;
        }

    }
}
