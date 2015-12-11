﻿using System;
using GreeterMVCApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GreeterMVCAppTests
{
   /* public class FakeDateTimeServiceForMorning : IDateTimeService
    {
        public DateTime GetCurrentTime()
        {
            return new DateTime(2015, 12, 12, 9, 0, 0);
        }
    }

    public class FakeDateTimeServiceForEvening : IDateTimeService
    {
        public DateTime GetCurrentTime()
        {
            return new DateTime(2015, 12, 12, 17, 0, 0);
        }
    }*/

    [TestClass]
    public class GreeterTests
    {
        [TestMethod]
        public void GreetsWithGoodMorningDuringMorning()
        {
            //Arrange
            var fakeDateTimeServiceForMorning = new FakeDateTimeService(new DateTime(2015, 12, 12, 9, 0, 0));
            var greeter = new Greeter(fakeDateTimeServiceForMorning);
            var name = "Magesh";
            var expectedMessage = "Hi Magesh, Good Morning!";

            //Act
            greeter.Name = name;
            greeter.Greet();

            //Assert
            Assert.AreEqual(expectedMessage, greeter.GreetMsg);
        }

        [TestMethod]
        public void GreetsWithGoodEveningDuringEvening()
        {
            //Arrange
            var fakeDateTimeServiceForAfternoon = new FakeDateTimeService(new DateTime(2015, 12, 12, 17, 0, 0));
            var greeter = new Greeter(fakeDateTimeServiceForAfternoon);
            var name = "Magesh";
            var expectedMessage = "Hi Magesh, Good Afternoon!";

            //Act
            greeter.Name = name;
            greeter.Greet();

            //Assert
            Assert.AreEqual(expectedMessage, greeter.GreetMsg);
        }
    }
}
