using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GreetingApp
{
    public partial class Greet : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnGreet_OnClick(object sender, EventArgs e)
        {
            var greeter = new Greeter();
            greeter.Name = this.TxtName.Text;
            greeter.Greet();
            LblMessage.Text = greeter.GreetMsg;

            var currentHour = DateTime.Now.Hour;

            if (currentHour < 12)
            {

                Body.Attributes["style"] = "background-color : lightblue;";
            }
            else
            {
                Body.Attributes["style"] = "background-color : lightpink;";
            }

        }
    }
}