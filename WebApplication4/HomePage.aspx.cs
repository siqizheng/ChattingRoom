using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class HomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Master.MValue = "welcome";
        }
        protected void Page_LoadComplete(object sender, EventArgs e)
        {
           //Label MLable1 = (Label)this.Master.FindControl("lbMaster");
           //this.lbPage.Text = MLable1.Text;
          this.lbPage.Text = ((Label)this.Master.FindControl("lbMaster")).Text.ToString();
        }

        protected void btSubmit_Click(object sender, EventArgs e)
        {
            int count =Convert.ToInt32(Application["count"]);
            Application.Lock();
            if (count == 0 || count > 20)
            {
                count = 0;
                Application["chats"] = Session["tbUsername"].ToString() + "says:" + tbMessage.Text.Trim() + "(" + DateTime.Now.ToString() + ")";
            }
            else
            {
                Application["chats"] = Application["chats"].ToString()+"\r\n"+ Session["tbUsername"].ToString() + "says:" + tbMessage.Text.Trim() + "(" + DateTime.Now.ToString() + ")";
            }
            Application["user"] = Session["tbUsername"].ToString();
            count += 1;
            Application["count"] = count;
            Application.UnLock();
            Response.Redirect("~/ChattingContent.aspx");
        }
    }
}