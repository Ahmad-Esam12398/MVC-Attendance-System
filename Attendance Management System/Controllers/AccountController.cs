using Microsoft.AspNetCore.Mvc;
using Attendance_Management_System.Models;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Linq;
using Attendance_Management_System.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Attendance_Management_System.Repos;


namespace Attendance_Management_System.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        private readonly UserManager<User> _userManager;
        public AccountController(UserManager<User> userManager)
        {
            _userManager = userManager;
            AccountRepo = accountRepo;
        }

        public async Task<IActionResult> Index()
        {
            // Fetch user information based on the logged-in user's email
            var user = await GetCurrentUser();
            return View(user);
        }

        [HttpPost]
        public async Task<IActionResult> Update(User model)
        {
            if (ModelState.IsValid)
            {
                // Fetch the user from the database based on UserName
                var user = await _userManager.FindByNameAsync(model.UserName);
                if (user == null)
                {
                    return NotFound();
                }

                // Update user information
                user.UserName = model.UserName;
                user.PhoneNumber = model.PhoneNumber;
                user.Gender = model.Gender;

                // Save changes to the database
                var result = await _userManager.UpdateAsync(user);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                }
            }

            // If ModelState is not valid, redisplay the form with validation errors
            return View("Edit", model);
        }
        public async Task<IActionResult> ResetPassword(int id)
        {
            // Find the user by an alternate unique identifier, such as email
            var user = await _userManager.FindByIdAsync(id.ToString());
            if (user == null)
            {
                return NotFound();
            }

            // Generate a password reset token
            var token = await _userManager.GeneratePasswordResetTokenAsync(user);

            // Return the view with necessary data
            return View(new ResetPasswordViewModel { UserId = user.Id, Token = token });
        }

        [HttpPost]
        public async Task<IActionResult> ResetPassword(ResetPasswordViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            // Convert the user ID from int to string
            string userId = model.UserId.ToString();

            // Find the user by id
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
            {
                return NotFound();
            }

            // Reset the password for the user
            var result = await _userManager.ResetPasswordAsync(user, model.Token, model.NewPassword);
            if (result.Succeeded)
            {
                // Redirect to the index page or any other page
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
                return View(model);
            }
        }
        private async Task<User> GetCurrentUser()
        {
            return await _userManager.GetUserAsync(User);
        }
    }
}