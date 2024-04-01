using Attendance_Management_System.Data;
using Microsoft.EntityFrameworkCore;

namespace Attendance_Management_System.Repos
{
    public class InstructorRepo : IInstructorRepo
    {
        IitiContext db;
        public InstructorRepo(IitiContext _db)
        {
            db = _db;
        }
    }
}
