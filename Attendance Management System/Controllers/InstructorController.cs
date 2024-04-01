using Attendance_Management_System.Repos;
using Microsoft.AspNetCore.Mvc;

namespace Attendance_Management_System.Controllers
{
    public class InstructorController : Controller
    {
        IInstructorRepo InstructorRepo;
        public InstructorController(IInstructorRepo _InstructorRepo)
        {
            InstructorRepo = _InstructorRepo;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
