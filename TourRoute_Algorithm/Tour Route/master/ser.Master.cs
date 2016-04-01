using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Tour_Route.BLL;
using Tour_Route.Model;

namespace Tour_Route.master
{
    public partial class s : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblWeb.Text = Request.Browser.Type.ToString();
            lblHost.Text = Request.Browser.Platform.ToString();
            lblIP.Text = Request.UserHostAddress.ToString();
            if (Session["用户名"] == null || Session["权限"].ToString()!="3")    //未登录或非管理员禁止进入
            {
                Response.Redirect("../default.aspx");
            }
        }

     
    }
}