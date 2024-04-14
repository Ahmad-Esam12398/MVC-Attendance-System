using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Attendance_Management_System.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using Attendance_Management_System.Models;
using Attendance_Management_System.ViewModels;

namespace Attendance_Management_System.Tests.Controllers
    {
        [TestClass]
        public class AccountControllerTests
        {
            [TestMethod]
            public async Task Index_ReturnsNotFound_WhenUserNotFound()
            {
                // Arrange
                var userManagerMock = new Mock<UserManager<User>>(MockBehavior.Strict, null, null, null, null, null, null, null, null);
                userManagerMock.Setup(m => m.FindByEmailAsync(It.IsAny<string>())).ReturnsAsync((User)null);
                var controller = new AccountController(userManagerMock.Object);

                // Act
                var result = await controller.Index();

                // Assert
                Assert.IsInstanceOfType(result, typeof(NotFoundResult));
            }

            [TestMethod]
            public async Task Index_ReturnsViewResult_WithValidModel()
            {
                // Arrange
                var user = new User();
                var userManagerMock = new Mock<UserManager<User>>(MockBehavior.Strict, null, null, null, null, null, null, null, null);
                userManagerMock.Setup(m => m.FindByEmailAsync(It.IsAny<string>())).ReturnsAsync(user);
                var controller = new AccountController(userManagerMock.Object);

                // Act
                var result = await controller.Index();

                // Assert
                Assert.IsInstanceOfType(result, typeof(ViewResult));
                var viewResult = (ViewResult)result;
                Assert.AreEqual(user, viewResult.Model);
            }

            [TestMethod]
            public async Task Update_ReturnsNotFound_WhenUserNotFound()
            {
                // Arrange
                var userManagerMock = new Mock<UserManager<User>>(MockBehavior.Strict, null, null, null, null, null, null, null, null);
                userManagerMock.Setup(m => m.FindByNameAsync(It.IsAny<string>())).ReturnsAsync((User)null);
                var controller = new AccountController(userManagerMock.Object);

                // Act
                var result = await controller.Update(new User());

                // Assert
                Assert.IsInstanceOfType(result, typeof(NotFoundResult));
            }

            [TestMethod]
            public async Task Update_ReturnsRedirectToActionResult_WhenModelIsValid()
            {
                // Arrange
                var user = new User();
                var userManagerMock = new Mock<UserManager<User>>(MockBehavior.Strict, null, null, null, null, null, null, null, null);
                userManagerMock.Setup(m => m.FindByNameAsync(It.IsAny<string>())).ReturnsAsync(user);
                userManagerMock.Setup(m => m.UpdateAsync(user)).ReturnsAsync(IdentityResult.Success);
                var controller = new AccountController(userManagerMock.Object);

                // Act
                var result = await controller.Update(user);

                // Assert
                Assert.IsInstanceOfType(result, typeof(RedirectToActionResult));
                var redirectToActionResult = (RedirectToActionResult)result;
                Assert.AreEqual("Index", redirectToActionResult.ActionName);
            }

            [TestMethod]
            public async Task ResetPassword_ReturnsNotFound_WhenUserNotFound()
            {
                // Arrange
                var userManagerMock = new Mock<UserManager<User>>(MockBehavior.Strict, null, null, null, null, null, null, null, null);
                userManagerMock.Setup(m => m.FindByIdAsync(It.IsAny<string>())).ReturnsAsync((User)null);
                var controller = new AccountController(userManagerMock.Object);

                // Act
                var result = await controller.ResetPassword(1);

                // Assert
                Assert.IsInstanceOfType(result, typeof(NotFoundResult));
            }

            [TestMethod]
            public async Task ResetPassword_ReturnsViewResult_WithValidModel()
            {
                // Arrange
                var user = new User();
                var userManagerMock = new Mock<UserManager<User>>(MockBehavior.Strict, null, null, null, null, null, null, null, null);
                userManagerMock.Setup(m => m.FindByIdAsync(It.IsAny<string>())).ReturnsAsync(user);
                userManagerMock.Setup(m => m.GeneratePasswordResetTokenAsync(user)).ReturnsAsync("token");
                var controller = new AccountController(userManagerMock.Object);

                // Act
                var result = await controller.ResetPassword(1);

                // Assert
                Assert.IsInstanceOfType(result, typeof(ViewResult));
                var viewResult = (ViewResult)result;
                var model = (ResetPasswordViewModel)viewResult.Model;
                Assert.AreEqual(user.Id, model.UserId);
                Assert.AreEqual("token", model.Token);
            }

            [TestMethod]
            public async Task ResetPassword_Post_ReturnsRedirectToActionResult_WhenModelIsValid()
            {
                // Arrange
                var userManagerMock = new Mock<UserManager<User>>(MockBehavior.Strict, null, null, null, null, null, null, null, null);
                userManagerMock.Setup(m => m.FindByIdAsync(It.IsAny<string>())).ReturnsAsync(new User());
                userManagerMock.Setup(m => m.ResetPasswordAsync(It.IsAny<User>(), It.IsAny<string>(), It.IsAny<string>())).ReturnsAsync(IdentityResult.Success);
                var controller = new AccountController(userManagerMock.Object);

                // Act
                var result = await controller.ResetPassword(new ResetPasswordViewModel());

                // Assert
                Assert.IsInstanceOfType(result, typeof(RedirectToActionResult));
                var redirectToActionResult = (RedirectToActionResult)result;
                Assert.AreEqual("Index", redirectToActionResult.ActionName);
            }
        }
    }
