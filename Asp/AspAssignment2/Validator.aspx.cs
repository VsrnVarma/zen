using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspAssignment2
{
    public partial class Validator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void checkbtn_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
                Response.Write("Successfully Registered");
            else
                Response.Write("Failed Validatons");
        }
    }
}
