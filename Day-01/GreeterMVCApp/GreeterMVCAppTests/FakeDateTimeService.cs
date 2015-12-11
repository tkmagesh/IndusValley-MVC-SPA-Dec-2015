using System;
using GreeterMVCApp;

namespace GreeterMVCAppTests
{
    public class FakeDateTimeService : IDateTimeService
    {
        private readonly DateTime _dateTime;

        public FakeDateTimeService(DateTime dateTime)
        {
            _dateTime = dateTime;
        }

        public DateTime GetCurrentTime()
        {
            return _dateTime;
        }
    }
}