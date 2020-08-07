using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class SiteMaster : MasterPage
    {
        string mValue = "";
        public string MValue
        {
            get
            {
                return mValue;
            }
            set
            {
                mValue = value;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
           this.lbMaster.Text = "Today is"+DateTime.Today;
            
        }
    }
}