using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace WebApplication4
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            //用戶列表
            string user = "";
            Application["user"] = user;
            //聊天記錄
            string chats = "";
            Application["chats"] =chats;
            //當前聊天記錄數
            Application["count"] = 0;

        }
    }
}