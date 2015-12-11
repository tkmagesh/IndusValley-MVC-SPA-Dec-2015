using System;
using GreeterMVCApp;
using GreeterMVCApp.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GreeterMVCAppTests
{
   /* public class FakeGreeter : IGreeter
    {
        public string Name { get; set; }
        public string GreetMsg { get; set; }
        public void Greet()
        {
            GreetMsg = "dummy message";
        }
    }*/

    [TestClass]
    public class GreetingControllerTests
    {
        [TestMethod]
        public void RendersMorningViewForMorning()
        {
            //Arrange
            var mockDateTimeService = new Moq.Mock<IDateTimeService>();
            mockDateTimeService.Setup(s => s.GetCurrentTime()).Returns(new DateTime(2015, 12, 12, 9, 0, 0));

            var greeterMockery = new Moq.Mock<IGreeter>();
            greeterMockery.Setup(g => g.GreetMsg).Returns("dummy message");
            var fakeGreeter = greeterMockery.Object;
            var greetingController = new GreetingController(mockDateTimeService.Object, fakeGreeter);


            //Act
            var result = greetingController.Greet("Magesh");

            //Assert
            Assert.AreEqual("Display-Morning", result.ViewName);
           
        }

        [TestMethod]
        public void RendersMorningViewForEvening()
        {
            //Arrange
            var mockDateTimeService = new Moq.Mock<IDateTimeService>();
            mockDateTimeService.Setup(s => s.GetCurrentTime()).Returns(new DateTime(2015, 12, 12, 15, 0, 0));

            var greeterMockery = new Moq.Mock<IGreeter>();
            greeterMockery.Setup(g => g.GreetMsg).Returns("dummy message");
            var fakeGreeter = greeterMockery.Object;

            var greetingController = new GreetingController(mockDateTimeService.Object, fakeGreeter);


            //Act
            var result = greetingController.Greet("Magesh");

            //Assert
            Assert.AreEqual("Display-Evening", result.ViewName);
        }

        [TestMethod]
        public void RendersTheMessageFromGreeter()
        {
            var mockDateTimeService = new Moq.Mock<IDateTimeService>();
            mockDateTimeService.Setup(s => s.GetCurrentTime()).Returns(new DateTime(2015, 12, 12, 15, 0, 0));

            var greeterMockery = new Moq.Mock<IGreeter>();
            greeterMockery.Setup(g => g.GreetMsg).Returns("dummy message");
            var fakeGreeter = greeterMockery.Object;
            var greetingController = new GreetingController(mockDateTimeService.Object, fakeGreeter);

            //Act
            var result = greetingController.Greet("Magesh");

            //Assert
            Assert.AreEqual("dummy message", result.ViewData["message"]);

        }
    }
}
