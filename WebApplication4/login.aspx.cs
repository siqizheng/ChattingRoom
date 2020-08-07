using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void btSubmit_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text == "siqi" && tbPassword.Text == "123")
            {
                Session["tbUsername"] = tbUsername.Text;
                
                Response.Redirect("~/HomePage.aspx");
            }
            else
            {
                lError.Text = "Input is not correct";
               
            }
        }
    }
}