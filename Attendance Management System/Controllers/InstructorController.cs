using Attendance_Management_System.Dtos;
using Attendance_Management_System.Models;
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
        public IActionResult Permissions()
        {
            // Get the list of permissions from the database
            var Permissions = InstructorRepo.getPendingPermissions();
            // Convert the list of permissions to a list of PermissionDto
            List<PermissionDto> PermissionsDtos = new List<PermissionDto>();
            foreach (var permission in Permissions)
            {
                PermissionsDtos.Add(new PermissionDto(permission));
            }
            return View(PermissionsDtos);
        }
        [HttpPost]
        public int Accept(int id)
        {
            try
            {
                InstructorRepo.AcceptPermission(id);

                return 1;
            }
            catch (Exception)
            {
                return 0;
            }
        }
        [HttpPost]
        public int Reject(int id)
        {
            try
            {
                InstructorRepo.RefusePermission(id);

                return 1;
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}
