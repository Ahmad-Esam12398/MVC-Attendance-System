using Attendance_Management_System.Repos;
using Microsoft.AspNetCore.Mvc;

namespace Attendance_Management_System.Controllers
{
    public class StudentController : Controller
    {
        IStudentRepo StudentRepo;
        public StudentController(IStudentRepo _StudentRepo)
        {
            StudentRepo = _StudentRepo;
        }
        //public IActionResult Index()
        //{
        //    return View();
        //}


    

       


    }
}
