using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class ChattingContent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(Application["count"]);
            Application.Lock();
            string strChats = Application["chats"].ToString();
            tbContent.Text = strChats;
            string struser = Application["user"].ToString();
            lList.Text = struser;
            Session.Timeout = 20;
            Application.UnLock();
        }
    }
}