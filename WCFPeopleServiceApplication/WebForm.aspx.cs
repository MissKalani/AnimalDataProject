using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WCFPeopleServiceApplication
{
    public partial class WebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            AnimalDataServiceReference.AnimalDataServiceClient client = new AnimalDataServiceReference.AnimalDataServiceClient();
             var monkey = client.GetAnimal("Monkey");

            Label1.Text = monkey;
        }


    }
}