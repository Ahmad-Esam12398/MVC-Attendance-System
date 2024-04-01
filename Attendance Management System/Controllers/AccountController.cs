using Attendance_Management_System.Repos;
using Microsoft.AspNetCore.Mvc;

namespace Attendance_Management_System.Controllers
{
    public class AccountController : Controller
    {
        IAccountRepo AccountRepo;
        public AccountController(IAccountRepo _AccountRepo)
        {
            AccountRepo = _AccountRepo;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
