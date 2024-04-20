using Attendance_Management_System.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Attendance_Management_System.Data
{
    public class DbInitializer
    {
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<IdentityRole<int>> _roleManager;
        itiContext db;

        public DbInitializer(itiContext _db,UserManager<User> userManager, RoleManager<IdentityRole<int>> roleManager)
        {
            db = _db;
            _userManager = userManager;
            _roleManager = roleManager;
        }
        public async Task Initialize()
        {
            //Create Roles
            if (!await _roleManager.RoleExistsAsync(RolesValues.AdminRole))
            {
                await _roleManager.CreateAsync(new IdentityRole<int>(RolesValues.AdminRole));
                await _roleManager.CreateAsync(new IdentityRole<int>(RolesValues.InstructorRole));
                await _roleManager.CreateAsync(new IdentityRole<int>(RolesValues.SuperVisorRole));
                await _roleManager.CreateAsync(new IdentityRole<int>(RolesValues.SecurityRole));
                await _roleManager.CreateAsync(new IdentityRole<int>(RolesValues.StudentsAffairs));
                await _roleManager.CreateAsync(new IdentityRole<int>(RolesValues.Student));
            }
            if (!await _userManager.Users.AnyAsync())
            {
                foreach (var student in SeedingClass.students)
                {
                    var result = await _userManager.CreateAsync(student, "AboEsam@123");

                    var result2 = await _userManager.AddToRoleAsync(student, RolesValues.Student);

                }
            
            }
            if (!await _userManager.IsInRoleAsync(await _userManager.FindByIdAsync("5"), RolesValues.AdminRole))
            {
                var user = await _userManager.FindByIdAsync("5");
                if (user != null)
                {
                    await _userManager.AddToRoleAsync(user, RolesValues.AdminRole);
                }
                user = await _userManager.FindByIdAsync("3");
                if (user != null)
                {
                    await _userManager.AddToRoleAsync(user, RolesValues.InstructorRole);
                }
                user = await _userManager.FindByIdAsync("3");
                if (user != null)
                {
                    await _userManager.AddToRoleAsync(user, RolesValues.SuperVisorRole);
                }
                user = await _userManager.FindByIdAsync("6");
                if (user != null)
                {
                    await _userManager.AddToRoleAsync(user, RolesValues.SecurityRole);
                }
                user = await _userManager.FindByIdAsync("1");
                if (user != null)
                {
                    await _userManager.AddToRoleAsync(user, RolesValues.StudentsAffairs);
                }
            }
            if (!db.Permissions.Any())
            {
                foreach (var permission in SeedingClass.Permissions)
                {
                    db.Permissions.Add(permission);
                }
                db.SaveChanges();
            }
            if (!db.Supervisors.Any())
            {
                // Insert Id 3 in the Instructor Table Using Raw SQL
                db.Database.ExecuteSqlRaw("INsert into Instructors (Id) values (3)");
                // Insert Id 3 and SupTrackId 1 in the Supervisor Table Using Raw SQL
                db.Database.ExecuteSqlRaw("INsert into Supervisors (Id,SupTrackId) values (3,1)");    
            }
        }
    }
}
