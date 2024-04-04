using Attendance_Management_System.Data;
using Attendance_Management_System.Repos;
using Microsoft.AspNetCore.Mvc;
using Attendance_Management_System.Dtos;
using Microsoft.EntityFrameworkCore;
using Attendance_Management_System.Models;
namespace Attendance_Management_System.Controllers
{
    public class InstructorController : Controller
    {
        itiContextSl db = new itiContextSl();
        IInstructorRepo InstructorRepo;
        public InstructorController(IInstructorRepo _InstructorRepo)
        {
            InstructorRepo = _InstructorRepo;
        }
        public IActionResult Permissions()
        {
            // Get the list of permissions from the database
            var Permissions= db.Permissions.Where(p => p.Status == 0).Include(p => p.Student).ToList();
            // Convert the list of permissions to a list of PermissionDto
            List<PermissionDto> PermissionsDtos = new List<PermissionDto>();
            foreach (var permission in Permissions)
            {
                PermissionsDtos.Add(new PermissionDto(permission));
            }
            
            
            return View(PermissionsDtos);
        }



        //[HttpPost("Permissions/Accept")]
        [HttpPost]

        public int Accept(int id)
        {
            try
            {
                // find the permission by id
                var permission = db.Permissions.Find(id);
                // update the status to accepted
                permission.Status = PermissionStatus.Accepted;
                // save the changes
                db.SaveChanges();
                // return fail or success status
                return 1;
            }
            catch (Exception)
            {
                return 0;
            }


        }
        // give special route name
        //[HttpPost("Permissions/Reject")]
        [HttpPost]
        public int Reject(int id)
        {
            try
            {
                // find the permission by id
                var permission = db.Permissions.Find(id);
                // update the status to rejected
                permission.Status = PermissionStatus.Refused;
                // save the changes
                db.SaveChanges();
                // return fail or success status
                return 1;
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}
