using Attendance_Management_System.Data;
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
    }
}
