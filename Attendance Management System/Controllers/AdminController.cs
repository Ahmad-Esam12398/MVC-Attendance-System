using Attendance_Management_System.Repos;
using Microsoft.AspNetCore.Mvc;

namespace Attendance_Management_System.Controllers
{
    public class AdminController : Controller
    {
        IAdminRepo AdminRepo;
        public AdminController(IAdminRepo _AdminRepo)
        {
            AdminRepo = _AdminRepo;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
