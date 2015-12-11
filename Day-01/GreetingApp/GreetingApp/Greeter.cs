using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GreetingApp
{
    public class Greeter
    {
        public string Name { get; set; }
        public string GreetMsg { get; set; }

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
}