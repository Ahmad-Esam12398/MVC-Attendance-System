using Attendance_Management_System.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Attendance_Management_System.Data
{
    public class DbInitializer
    {
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<IdentityRole<int>> _roleManager;

        public DbInitializer(UserManager<User> userManager, RoleManager<IdentityRole<int>> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }
        public async Task Initialize()
        {
            //Create Roles
            if(!await _roleManager.RoleExistsAsync(RolesValues.AdminRole))
            {
                await _roleManager.CreateAsync(new IdentityRole<int>(RolesValues.AdminRole));
                await _roleManager.CreateAsync(new IdentityRole<int>(RolesValues.InstructorRole));
                await _roleManager.CreateAsync(new IdentityRole<int>(RolesValues.SuperVisorRole));
                await _roleManager.CreateAsync(new IdentityRole<int>(RolesValues.SecurityRole));
                await _roleManager.CreateAsync(new IdentityRole<int>(RolesValues.StudentsAffairs));
                await _roleManager.CreateAsync(new IdentityRole<int>(RolesValues.Student));
            }
            if(!await _userManager.Users.AnyAsync())
            {
                foreach(var student in SeedingClass.students)
                {
                    await _userManager.CreateAsync(student, "AboEsam@123");
                    await _userManager.AddToRoleAsync(student, RolesValues.Student);
                }
            }
        }
    }
}
