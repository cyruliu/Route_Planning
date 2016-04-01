using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Tour_Route.Model;
using Tour_Route.BLL;

namespace Tour_Route.master
{
    public partial class c : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblWeb.Text = Request.Browser.Type.ToString();
            lblHost.Text = Request.Browser.Platform.ToString();
            lblIP.Text = Request.UserHostAddress.ToString();

            SessionLogin();
        }

        protected void Login_Click(object sender, EventArgs e)
        {
            LoginByNP(txtUserName.Text,txtUserPwd.Text);
          
        }
        //登录
        private void LoginByNP(string name,string pwd)
        {
            if (btnLogin.Text == "登录")
            {
                string username = name;
                string userpwd = pwd;
                M_user user = B_user.GetUserByName(username);
           
                if (user==null)       //用户不存在
                {
                    txtUserName.Text = "";
                    txtUserPwd.Text = "";
                    lblErrorMsg.Text = "用户不存在！";
                }  
               else if (userpwd == user.U_Pwd)       //密码正确，成功登陆
                {
                    Session["用户名"] = user.U_Name;
                    Session["权限"] = user.U_Level.ToString();
                    txtUserName.Text = user.U_Name;
                    txtUserName.Enabled = false;
                    txtUserPwd.Visible = false;
                    btnLogin.Text = "退出";
                    lblErrorMsg.Text = "登录时间："+DateTime.Now.ToString();
                   Session["登录时间"]=lblErrorMsg.Text;
                    btnRegister.Visible = false;    
                    if (user.U_Level == 3)   //管理员
                    {

                        lblUserPwd.Text = "管理员";
                    }
                    else if (user.U_Level == 2)     //VIP会员
                    {
                        lblUserPwd.Text = "VIP会员";
                    }
                    else                             //普通会员
                    {
                        lblUserPwd.Text = "普通用户";
                    }
                    Session["权限名"] = lblUserPwd.Text;
                }
               
                else               //密码不正确
                {
                    txtUserPwd.Text = "";
                    lblErrorMsg.Text = "密码不正确！";
                }
            }
            else if (btnLogin.Text == "退出")
            {
                txtUserName.Text = "";
                txtUserPwd.Text = "";
                Session["用户名"] = null;
                Session["权限"] = null;
                txtUserName.Enabled = true; ;
                txtUserPwd.Visible = true;
                btnLogin.Text = "登录";
                lblUserPwd.Text = "密码:";
                btnRegister.Visible = true;
                lblErrorMsg.Text = "欢迎登录";
            }
        }

        //注册
        protected void btnRegister_Click(object sender, EventArgs e)
        {
            Response.Redirect("./admin/register.aspx");
        }

        //pageload Session传递
        private void SessionLogin()
        {
            if (Session["用户名"]!=null && Session["权限"]!=null)
            {
                    txtUserName.Text =Session["用户名"].ToString();
                    txtUserName.Enabled = false;
                    txtUserPwd.Visible = false;
                    btnLogin.Text = "退出";
                    lblErrorMsg.Text = Session["登录时间"].ToString();
                    btnRegister.Visible = false;
                    lblUserPwd.Text = Session["权限名"].ToString();
            }
        }
    }
}