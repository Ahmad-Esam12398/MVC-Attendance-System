using Attendance_Management_System.Data;
using Attendance_Management_System.Models;
using Attendance_Management_System.Repos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Attendance_Management_System.Controllers
{
    [Authorize(Roles = RolesValues.AdminRole)]
    public class AdminController : Controller
    {
        IAdminRepo AdminRepo;
        private readonly UserManager<User> _userManager;
        public AdminController(IAdminRepo _AdminRepo, UserManager<User> userManager)
        {
            AdminRepo = _AdminRepo;
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            return View();
        }
        private async Task<User> GetCurrentUser()
        {
            return await _userManager.GetUserAsync(User);
        }
    }
}
