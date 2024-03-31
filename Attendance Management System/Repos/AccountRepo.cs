using Attendance_Management_System.Data;
using Microsoft.EntityFrameworkCore;

namespace Attendance_Management_System.Repos
{
    public class AccountRepo : IAccountRepo
    {
        IitiContext db;
        public AccountRepo(IitiContext _db)
        {
            db = _db;
        }
    }
}
