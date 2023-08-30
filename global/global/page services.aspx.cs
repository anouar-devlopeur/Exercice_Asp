using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace global
{
    public partial class page_services : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            localhost.WebService1 a = new localhost.WebService1();
            
          var  i = a.aff(int.Parse(TextBox1.Text));
            Label2.Text = i.ToString();
        }
    }
}