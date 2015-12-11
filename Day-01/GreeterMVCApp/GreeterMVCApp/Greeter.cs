using System;

namespace GreeterMVCApp
{
    public class Greeter
    {
        private readonly IDateTimeService _dateTimeService;
        public string Name { get; set; }
        public string GreetMsg { get; set; }

        public Greeter(IDateTimeService dateTimeService)
        {
            _dateTimeService = dateTimeService;
        }

        public void Greet()
        {
            var currentHour = DateTime.Now.Hour;
            string greetMsg;
            if (currentHour < 12)
            {
                greetMsg = "Hi " + this.Name + ", Good Morning!";
               
            }
            else
            {
                greetMsg = "Hi " + this.Name + ", Good Afternoon!";
               
            }
            this.GreetMsg = greetMsg;
        }
    }

    public interface IDateTimeService
    {
        DateTime GetCurrentTime();
    }

    public class DateTimeService : IDateTimeService
    {
        public DateTime GetCurrentTime()
        {
            return DateTime.Now;
        }
    }
}