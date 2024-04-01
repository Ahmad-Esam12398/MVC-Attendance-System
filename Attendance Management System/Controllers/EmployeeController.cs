using Attendance_Management_System.Repos;
using Microsoft.AspNetCore.Mvc;

namespace Attendance_Management_System.Controllers
{
    public class EmployeeController : Controller
    {
        IEmployeeRepo EmployeeRepo;
        public EmployeeController(IEmployeeRepo _EmployeeRepo)
        {
            EmployeeRepo = _EmployeeRepo;
        }
        public IActionResult Index()
        {
            var students = EmployeeRepo.ReadAllStudents();
            return View(students);
        }
    }
}
