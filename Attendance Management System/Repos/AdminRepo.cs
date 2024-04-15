using Attendance_Management_System.Data;
using Microsoft.EntityFrameworkCore;

namespace Attendance_Management_System.Repos
{
    public class AdminRepo : IAdminRepo
    {
        itiContext db;
        public AdminRepo(itiContext _db)
        {
            db = _db;
        }
    }
}
