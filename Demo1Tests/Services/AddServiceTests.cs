using Demo1BLL.Services;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestPlatform.Common.Exceptions;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1Tests.Services
{
    public class AddServiceTests
    {
        private readonly Mock<ILogger<AddService>> loggerMock;
        public AddServiceTests()
        {
            loggerMock = new Mock<ILogger<AddService>>();
        }
        [Fact]
        public void AddService_Valid_ShouldReturnResult()
        {
            //Arrange
            var service = new AddService(loggerMock.Object);
            int a = 4;
            int b = 5;

            //Act
            var res = service.AddAsync(a, b);

            //Assert
            Assert.Equal(res.Result, 9);
        }
    }
}
