using System;
using GreeterMVCApp;
using GreeterMVCApp.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GreeterMVCAppTests
{
    public class FakeGreeter : IGreeter
    {
        public string Name { get; set; }
        public string GreetMsg { get; set; }
        public void Greet()
        {
            GreetMsg = "dummy message";
        }
    }

    [TestClass]
    public class GreetingControllerTests
    {
        [TestMethod]
        public void RendersMorningViewForMorning()
        {
            //Arrange
            var fakeDateTimeServiceForMorning = new FakeDateTimeService(new DateTime(2015, 12, 12, 9, 0, 0));
            var fakeGreeter = new FakeGreeter();
            var greetingController = new GreetingController(fakeDateTimeServiceForMorning, fakeGreeter);


            //Act
            var result = greetingController.Greet("Magesh");

            //Assert
            Assert.AreEqual("Display-Morning", result.ViewName);
           
        }

        [TestMethod]
        public void RendersMorningViewForEvening()
        {
            //Arrange
            var fakeDateTimeServiceForEvening = new FakeDateTimeService(new DateTime(2015, 12, 12, 19, 0, 0));
            var fakeGreeter = new FakeGreeter();
            var greetingController = new GreetingController(fakeDateTimeServiceForEvening, fakeGreeter);


            //Act
            var result = greetingController.Greet("Magesh");

            //Assert
            Assert.AreEqual("Display-Evening", result.ViewName);
        }

        [TestMethod]
        public void RendersTheMessageFromGreeter()
        {
            //Arrange
            var fakeDateTimeServiceForMorning = new FakeDateTimeService(new DateTime(2015, 12, 12, 9, 0, 0));
            var fakeGreeter = new FakeGreeter();
            var greetingController = new GreetingController(fakeDateTimeServiceForMorning, fakeGreeter);


            //Act
            var result = greetingController.Greet("Magesh");

            //Assert
            Assert.AreEqual("dummy message", result.ViewData["message"]);

        }
    }
}
