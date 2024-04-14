using Attendance_Management_System.Data;
using Microsoft.EntityFrameworkCore;

namespace Attendance_Management_System.Repos
{
    public class AccountRepo : IAccountRepo
    {
        itiContext db;
        public AccountRepo(itiContext _db)
        {
            db = _db;
        }
    }
}
