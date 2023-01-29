
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Moq;
using VioRentals.Controllers;
using VioRentals.Data;
using VioRentals.ViewModels;

namespace xUnitTests
{
    public class AdministrationControllerTests
    {
        [Fact]
        public async Task CreateRole_ShouldReturnView_WhenModelIsInvalid() 
        {
            // Arrange
            var model = new CreateRoleViewModel { RoleName = "" };
            var controller = new AdministrationController(null, null);
            controller.ModelState.AddModelError("RoleName", "Role name is required.");

            // Act
            var result = await controller.CreateRole(model) as ViewResult;

            // Assert
            Assert.Equal(model, result.Model);
            Assert.False(result.ViewData.ModelState.IsValid);
        }

        [Fact]
        public async Task CreateRole_ShouldReturnView_WhenRoleNameIsInvalid()
        {
            // Arrange
            var model = new CreateRoleViewModel { RoleName = "Admin" };
            var roleManagerMock = new Mock<RoleManager<IdentityRole>>(new Mock<IRoleStore<IdentityRole>>().Object, null, null, null, null);
            roleManagerMock.Setup(x => x.CreateAsync(It.IsAny<IdentityRole>())).ReturnsAsync(IdentityResult.Failed(new IdentityError { Code = "DuplicateRoleName", Description = "Role name already exists." }));
            var controller = new AdministrationController(roleManagerMock.Object, null);

            // Act
            var result = await controller.CreateRole(model) as ViewResult;

            // Assert
            Assert.Equal(model, result.Model);
            Assert.False(result.ViewData.ModelState.IsValid);
        }

        [Fact]
        public async Task CreateRole_ShouldReturnRedirect_WhenRoleNameIsValid()
        {
            // Arrange
            var model = new CreateRoleViewModel { RoleName = "Admin" };
            var roleManagerMock = new Mock<RoleManager<IdentityRole>>(new Mock<IRoleStore<IdentityRole>>().Object, null, null, null, null);
            roleManagerMock.Setup(x => x.CreateAsync(It.IsAny<IdentityRole>())).ReturnsAsync(IdentityResult.Success);
            var controller = new AdministrationController(roleManagerMock.Object, null);

            // Act
            var result = await controller.CreateRole(model) as RedirectToActionResult;

            // Assert
            Assert.Equal("ListRoles", result.ActionName);
        }
        
        [Fact]
        public async Task CreateRole_ShouldReturnView_WhenModelIsInvalid2()
        {
            // Arrange
            var model = new CreateRoleViewModel { RoleName = "" };
            var controller = new AdministrationController(null, null);
            controller.ModelState.AddModelError("RoleName", "Role name is required.");

            // Act
            var result = await controller.CreateRole(model) as ViewResult;

            // Assert
            Assert.Equal(model, result.Model);
            Assert.False(result.ViewData.ModelState.IsValid);
        }
        
        [Fact]
        public async Task CreateRole_ShouldReturnView_WhenRoleNameIsInvalid3()
        {
            // Arrange
            var model = new CreateRoleViewModel { RoleName = "Admin" };
            var roleManagerMock = new Mock<RoleManager<IdentityRole>>(new Mock<IRoleStore<IdentityRole>>().Object, null, null, null, null);
            roleManagerMock.Setup(x => x.CreateAsync(It.IsAny<IdentityRole>())).ReturnsAsync(IdentityResult.Failed(new IdentityError { Code = "DuplicateRoleName", Description = "Role name already exists." }));
            var controller = new AdministrationController(roleManagerMock.Object, null);

            // Act
            var result = await controller.CreateRole(model) as ViewResult;

            // Assert
            Assert.Equal(model, result.Model);
            Assert.False(result.ViewData.ModelState.IsValid);
        }

        [Fact]
        public async Task CreateRole_ShouldReturnRedirect_WhenRoleNameIsValid4()
        {
            // Arrange
            var model = new CreateRoleViewModel { RoleName = "Admin" };
            var roleManagerMock = new Mock<RoleManager<IdentityRole>>(new Mock<IRoleStore<IdentityRole>>().Object, null, null, null, null);
            roleManagerMock.Setup(x => x.CreateAsync(It.IsAny<IdentityRole>())).ReturnsAsync(IdentityResult.Success);
            var controller = new AdministrationController(roleManagerMock.Object, null);

            // Act
            var result = await controller.CreateRole(model) as RedirectToActionResult;

            // Assert
            Assert.Equal("ListRoles", result.ActionName);
        }

    }
}