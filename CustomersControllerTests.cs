using Microsoft.AspNetCore.Mvc;
using VioRentals.Controllers;
using VioRentals.Models;

namespace xUnitTests
{
    public class CustomersControllerTests
    {
        [Fact]
        public void Index_ShouldReturnViewResult_WhenCalled()
        {
            // Arrange
            var controller = new CustomersController();

            // Act
            var result = controller.Index();

            // Assert
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Index_ShouldReturnViewResultWithCustomers_WhenCalled()
        {
            // Arrange
            var controller = new CustomersController();

            // Act
            var result = controller.Index();

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsAssignableFrom<IEnumerable<Customer>>(viewResult.ViewData.Model);
            Assert.Equal(10, model.Count());
        }


        [Fact]
        public void Details_ShouldReturnViewResult_WhenCalled()
        {
            // Arrange
            var controller = new CustomersController();

            // Act
            var result = controller.Details(1);

            // Assert
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Details_ShouldReturnViewResultWithCustomer_WhenCalled()
        {
            // Arrange
            var controller = new CustomersController();

            // Act
            var result = controller.Details(1);

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsAssignableFrom<Customer>(viewResult.ViewData.Model);
            Assert.Equal(1, model.Id);
        }
        

        [Fact]
        public void Create_ShouldReturnViewResult_WhenCalled()
        {
            // Arrange
            var controller = new CustomersController();

            // Act
            var result = controller.New();

            // Assert
            Assert.IsType<ViewResult>(result);
        }
    }
}
