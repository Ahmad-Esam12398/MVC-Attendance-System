using Attendance_Management_System.Data;
using Microsoft.EntityFrameworkCore;

namespace Attendance_Management_System.Repos
{
    public class AdminRepo : IAdminRepo
    {
        IitiContext db;
        public AdminRepo(IitiContext _db)
        {
            db = _db;
        }
    }
}
