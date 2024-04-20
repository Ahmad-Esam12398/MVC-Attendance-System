// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
#nullable disable

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Attendance_Management_System.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Attendance_Management_System.Data;

namespace Attendance_Management_System.Areas.Identity.Pages.Account
{
    public class LoginModel : PageModel
    {
        private readonly SignInManager<User> _signInManager;
        private readonly ILogger<LoginModel> _logger;
        private readonly UserManager<User> _userManager;
        public LoginModel(SignInManager<User> signInManager, ILogger<LoginModel> logger, UserManager<User> userManager)
        {
            _signInManager = signInManager;
            _logger = logger;
            _userManager = userManager;
        }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        [BindProperty]
        public InputModel Input { get; set; }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        public string ReturnUrl { get; set; }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        [TempData]
        public string ErrorMessage { get; set; }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        public class InputModel
        {
            /// <summary>
            ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
            ///     directly from your code. This API may change or be removed in future releases.
            /// </summary>
            [Required]
            public string NationalId { get; set; }

            /// <summary>
            ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
            ///     directly from your code. This API may change or be removed in future releases.
            /// </summary>
            [Required]
            [DataType(DataType.Password)]
            public string Password { get; set; }

            /// <summary>
            ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
            ///     directly from your code. This API may change or be removed in future releases.
            /// </summary>
            [Display(Name = "Remember me?")]
            public bool RememberMe { get; set; }
        }

        public async Task<IActionResult> OnGetAsync(string returnUrl = null)
        {
            if (!string.IsNullOrEmpty(ErrorMessage))
            {
                ModelState.AddModelError(string.Empty, ErrorMessage);
            }

            returnUrl ??= Url.Content("~/");

            // Clear the existing external cookie to ensure a clean login process
            await HttpContext.SignOutAsync(IdentityConstants.ExternalScheme);

            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
            var currentUser = await _userManager.GetUserAsync(User);
            if(currentUser != null)
            {
                returnUrl = await MapUserToPage(currentUser);
                return LocalRedirect(returnUrl);
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        
        {
            returnUrl ??= Url.Content("~/");

            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();

            if (ModelState.IsValid)
            {
                // This doesn't count login failures towards account lockout
                // To enable password failures to trigger account lockout, set lockoutOnFailure: true
                // Add The Account as Dummy User for Testing
                // var Add =await _signInManager.UserManager.CreateAsync(new User { UserName = "Account", NationalId = "1000", Email = "Ahmed@gmail.com" }, "123456aA!");
                //var user = new User { UserName = "Account", NationalId = "1000", Email = "Ahmed@gmail.com" };
                //var Add = await _signInManager.UserManager.CreateAsync(user, "123456aA!");

                //if (!Add.Succeeded)
                //{
                //    foreach (var error in Add.Errors)
                //    {
                //        ModelState.AddModelError(string.Empty, error.Description);
                //    }
                //    return Page();
                //}
                //Save Changes
                //await _signInManager.UserManager.UpdateAsync(new User { UserName = Input.NationalId, NationalId = Input.NationalId, Email = Input.NationalId + "@gmail.com" });

                var user = _userManager.Users.FirstOrDefault(u => u.NationalId == Input.NationalId);

                if(user == null)
                {
                    ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                    return Page();
                }
                var result = await _signInManager.PasswordSignInAsync(user.UserName, Input.Password, Input.RememberMe, lockoutOnFailure: false);

                if (result.Succeeded)
                {
                    _logger.LogInformation("User logged in.");
                    // get Current User
                    returnUrl = await MapUserToPage(user);
                    return LocalRedirect(returnUrl);
                }
                if (result.RequiresTwoFactor)
                {
                    return RedirectToPage("./LoginWith2fa", new { ReturnUrl = returnUrl, RememberMe = Input.RememberMe });
                }
                if (result.IsLockedOut)
                {
                    _logger.LogWarning("User account locked out.");
                    return RedirectToPage("./Lockout");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                    return Page();
                }
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }
        private async Task<string> MapUserToPage(User user)
        {
            string returnUrl;

            //Redirect User According to his Role
            if (await _userManager.IsInRoleAsync(user, RolesValues.AdminRole))
            {
                returnUrl = Url.Action("Index", "Admin");
            }
            // Check if the user is an Instructor
            else if (await _userManager.IsInRoleAsync(user, RolesValues.InstructorRole) || await _userManager.IsInRoleAsync(user, RolesValues.SuperVisorRole))
            {
                // Redirect to the Index action of the InstructorController
                returnUrl = Url.Action("Index", "Instructor");
            }
            //// Check if the user is a Supervisor
            //else if (await _userManager.IsInRoleAsync(user, RolesValues.SuperVisorRole))
            //{
            //    // Redirect to the Index action of the InstructorController
            //    returnUrl = Url.Action("Index", "Instructor");
            //}
            else if (await _userManager.IsInRoleAsync(user, RolesValues.SecurityRole) || await _userManager.IsInRoleAsync(user, RolesValues.StudentsAffairs))
            {
                returnUrl = Url.Action("Index", "Employee");
            }
            else
            {
                returnUrl = Url.Action("Index", "Student");
            }
            return returnUrl;
        }
    }
}
