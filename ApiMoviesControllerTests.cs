using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VioRentals.Controllers.Api;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VioRentals.Data;
using VioRentals.Dtos;
using Moq;
using VioRentals.Models;

namespace xUnitTests
{
    public class ApiMoviesControllerTests
    {
        [Fact]
        public async Task GetMovie_ShouldReturnNotFound_WhenCalledWithInvalidId()
        {
            // Arrange
            var mockContext = new Mock<ApplicationDbContext>();
            var mockMapper = new Mock<IMapper>();
            var mockMovie = new Movie { Id = 1, Name = "Movie1" };
            var mockMovieDto = new MovieDto { Id = 1, Name = "Movie1" };
            var mockDbSet = new Mock<DbSet<Movie>>();
            mockDbSet.As<IQueryable<Movie>>().Setup(m => m.Provider).Returns(new List<Movie> { mockMovie }.AsQueryable().Provider);
            mockDbSet.As<IQueryable<Movie>>().Setup(m => m.Expression).Returns(new List<Movie> { mockMovie }.AsQueryable().Expression);
            mockDbSet.As<IQueryable<Movie>>().Setup(m => m.ElementType).Returns(new List<Movie> { mockMovie }.AsQueryable().ElementType);
            mockDbSet.As<IQueryable<Movie>>().Setup(m => m.GetEnumerator()).Returns(new List<Movie> { mockMovie }.AsQueryable().GetEnumerator());
            mockContext.Setup(c => c.Movies).Returns(mockDbSet.Object);
            mockMapper.Setup(m => m.Map<Movie, MovieDto>(mockMovie)).Returns(mockMovieDto);
            var controller = new MoviesController(mockContext.Object, mockMapper.Object);
            // Act
            var result = await controller.GetMovie(2);
            // Assert
            Assert.IsType<NotFoundResult>(result.Result);
        }

        [Fact]
        public async Task CreateMovie_ShouldReturnCreatedAtAction_WhenCalledWithValidMovieDto()
        {
            // Arrange
            var mockContext = new Mock<ApplicationDbContext>();
            var mockMapper = new Mock<IMapper>();
            var mockMovie = new Movie { Id = 1, Name = "Movie1" };
            var mockMovieDto = new MovieDto { Id = 1, Name = "Movie1" };
            var mockDbSet = new Mock<DbSet<Movie>>();
            mockDbSet.As<IQueryable<Movie>>().Setup(m => m.Provider).Returns(new List<Movie> { mockMovie }.AsQueryable().Provider);
            mockDbSet.As<IQueryable<Movie>>().Setup(m => m.Expression).Returns(new List<Movie> { mockMovie }.AsQueryable().Expression);
            mockDbSet.As<IQueryable<Movie>>().Setup(m => m.ElementType).Returns(new List<Movie> { mockMovie }.AsQueryable().ElementType);
            mockDbSet.As<IQueryable<Movie>>().Setup(m => m.GetEnumerator()).Returns(new List<Movie> { mockMovie }.AsQueryable().GetEnumerator());
            mockContext.Setup(c => c.Movies).Returns(mockDbSet.Object);
            mockMapper.Setup(m => m.Map<MovieDto, Movie>(mockMovieDto)).Returns(mockMovie);
            var controller = new MoviesController(mockContext.Object, mockMapper.Object);
            // Act
            var result = await controller.CreateMovie(mockMovieDto);
            // Assert
            Assert.IsType<CreatedAtActionResult>(result.Result);
        }

        
        [Fact]
        public async Task UpdateMovie_ShouldReturnNotFound_WhenCalledWithInvalidId()
        {
            // Arrange
            var mockContext = new Mock<ApplicationDbContext>();
            var mockMapper = new Mock<IMapper>();
            var mockMovie = new Movie { Id = 1, Name = "Movie1" };
            var mockMovieDto = new MovieDto { Id = 1, Name = "Movie1" };
            var mockDbSet = new Mock<DbSet<Movie>>();
            mockDbSet.As<IQueryable<Movie>>().Setup(m => m.Provider).Returns(new List<Movie> { mockMovie }.AsQueryable().Provider);
            mockDbSet.As<IQueryable<Movie>>().Setup(m => m.Expression).Returns(new List<Movie> { mockMovie }.AsQueryable().Expression);
            mockDbSet.As<IQueryable<Movie>>().Setup(m => m.ElementType).Returns(new List<Movie> { mockMovie }.AsQueryable().ElementType);
            mockDbSet.As<IQueryable<Movie>>().Setup(m => m.GetEnumerator()).Returns(new List<Movie> { mockMovie }.AsQueryable().GetEnumerator());
            mockContext.Setup(c => c.Movies).Returns(mockDbSet.Object);
            mockMapper.Setup(m => m.Map<MovieDto, Movie>(mockMovieDto)).Returns(mockMovie);
            var controller = new MoviesController(mockContext.Object, mockMapper.Object);
            // Act
            var result = await controller.UpdateMovie(2, mockMovieDto);
            // Assert
            Assert.IsType<NotFoundResult>(result);
        }


        [Fact]
        public async Task UpdateMovie_ShouldReturnNotFound_WhenCalledWithInvalidI2d()
        {
            // Arrange
            var mockContext = new Mock<ApplicationDbContext>();
            var mockMapper = new Mock<IMapper>();
            var mockMovie = new Movie { Id = 1, Name = "Movie1" };
            var mockMovieDto = new MovieDto { Id = 1, Name = "Movie1" };
            var mockDbSet = new Mock<DbSet<Movie>>();
            mockDbSet.As<IQueryable<Movie>>().Setup(m => m.Provider).Returns(new List<Movie> { mockMovie }.AsQueryable().Provider);
            mockDbSet.As<IQueryable<Movie>>().Setup(m => m.Expression).Returns(new List<Movie> { mockMovie }.AsQueryable().Expression);
            mockDbSet.As<IQueryable<Movie>>().Setup(m => m.ElementType).Returns(new List<Movie> { mockMovie }.AsQueryable().ElementType);
            mockDbSet.As<IQueryable<Movie>>().Setup(m => m.GetEnumerator()).Returns(new List<Movie> { mockMovie }.AsQueryable().GetEnumerator());
            mockContext.Setup(c => c.Movies).Returns(mockDbSet.Object);
            mockMapper.Setup(m => m.Map<MovieDto, Movie>(mockMovieDto)).Returns(mockMovie);
            var controller = new MoviesController(mockContext.Object, mockMapper.Object);
            // Act
            var result = await controller.UpdateMovie(2, mockMovieDto);
            // Assert
            Assert.IsType<NotFoundResult>(result);
        }
    }
}
