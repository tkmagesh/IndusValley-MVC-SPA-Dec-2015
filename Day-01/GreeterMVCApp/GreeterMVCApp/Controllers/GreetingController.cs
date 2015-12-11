using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace GreeterMVCApp.Controllers
{
    public class GreetingController : Controller
    {
        private readonly IDateTimeService _dateTimeService;
        private readonly IGreeter _greeter;

        public GreetingController(IDateTimeService dateTimeService, IGreeter greeter)
        {
            _dateTimeService = dateTimeService;
            _greeter = greeter;
        }

        public GreetingController()
        {
            _dateTimeService = new DateTimeService();
            _greeter = new Greeter(_dateTimeService);
        }

        public ViewResult GreetInput()
        {
            return View("GreetInput");
        }

        public ViewResult Greet(string name)
        {
            _greeter.Name = name;
            _greeter.Greet();
            ViewData["message"] = _greeter.GreetMsg;
            if (_dateTimeService.GetCurrentTime().Hour < 12)
            {
                return View("Display-Morning");
            }
            else
            {
                return View("Display-Evening");
            }
        }
    }
}
