using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Moq;
using NPOI.OpenXml4Net.OPC;
using System;
using System.Linq;
using TuikProject.Controllers;
using TuikProject.Data;
using TuikProject.Helper;
using TuikProject.Models;
using Xunit;

namespace TuikProjectXUnitTest
{
    public class UnitTest1
    {

        //public BooksControllerTest()
        //{
        //    InitContext();
        //}

        //private ApplicationDbContext _booksContext;

        //public void InitContext()
        //{
        //    var builder = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase();

        //    var context = new ApplicationDbContext(builder.Options);
        //    var books = Enumerable.Range(1, 10)
        //        .Select(i => new Book { BookId = i, Title = $"Sample{i}", Publisher = "Wrox Press" });
        //    context.Books.AddRange(books);
        //    int changed = context.SaveChanges();

        //}
        [Fact]
        public void DbHelper_GetIssizlikOraniT1()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase(databaseName: "TuikDb3").Options;

            using (var context = new ApplicationDbContext(options))
            {
                var controller = new DbHelper(context);

                var issizlikOraniT1 = Enumerable.Range(1, 10)
                    .Select(i => new ÝþtekiDurumVeEkonomikFaaliyet { Id = i, Column1 = $"Sample{i}", Column2 = "Wrox Press" });
                context.IssizlikOraniT1.AddRange(issizlikOraniT1);
                int changed = context.SaveChanges();

                // Act
                var result = controller.getIssizlikOraniT1();

                // Assert
                Assert.NotNull(result);
            }

        }
        [Fact]
        public void DbHelper_GetIssizlikOraniT2()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase(databaseName: "TuikDb3").Options;

            using (var context = new ApplicationDbContext(options))
            {
                var controller = new DbHelper(context);

                var issizlikOraniT2 = Enumerable.Range(1, 10)
                    .Select(i => new SosyalGüvenlikKuruluþunaKayitlilik { Id = i, Column1 = $"Sample{i}", Column2 = "Wrox Press" });
                context.IssizlikOraniT2.AddRange(issizlikOraniT2);
                int changed = context.SaveChanges();

                // Act
                var result = controller.getIssizlikOraniT2();

                // Assert
                Assert.NotNull(result);
            }

        }

        //[Fact]
        //public async void DbHelper_GetIssizlikOraniT1()
        //{
        //    var dbContext = serviceProvider.GetRequiredService<ApplicationDbContext>();



        //    var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
        //    optionsBuilder.UseInMemoryDatabase();
        //    var _dbContext = new ApplicationDbContext(optionsBuilder.Options);

        //    var controller = new DbHelper(_dbContext);

        //    // Act
        //    var result = controller.getIssizlikOraniT1();

        //    // Assert
        //    Assert.NotNull(result);
        //}

        //[Fact]
        //public void Index_ReturnsViewResultWithNoModel()
        //{
        //    // Arrange
        //    var mockLogger = new Mock<ILogger<HomeController>>();
        //    ApplicationDbContext context = new ApplicationDbContext(m);
        //    var controller = new HomeController(context, mockLogger.Object, mockLogger.Object);

        //    // Act
        //    var result = controller.Index();

        //    // Assert correct non-null View returned with no Model
        //    var viewResult = Assert.IsType<ViewResult>(result);
        //    Assert.NotNull(viewResult);
        //    Assert.Equal(nameof(controller.Index), viewResult.ViewName);
        //    Assert.NotNull(viewResult.ViewData);
        //    Assert.Null(viewResult.ViewData.Model);
        //}

        //[Fact]
        //public void Privacy_ReturnsViewResultWithNoModel()
        //{
        //    // Arrange
        //    var mockLogger = new Mock<ILogger<HomeController>>();
        //    var controller = new HomeController(mockLogger.Object);

        //    // Act
        //    var result = controller.Privacy();

        //    // Assert correct non-null View returned with no Model
        //    var viewResult = Assert.IsType<ViewResult>(result);
        //    Assert.NotNull(viewResult);
        //    Assert.Equal(nameof(controller.Privacy), viewResult.ViewName);
        //    Assert.NotNull(viewResult.ViewData);
        //    Assert.Null(viewResult.ViewData.Model);
        //}
    }
}
