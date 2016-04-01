using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Tour_Route.DAL.D_DataSet.DataSetUserTableAdapters;

namespace Tour_Route.admin
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblUserErrorMsg.Visible = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            tb_userTableAdapter adapter = new tb_userTableAdapter();   
            var data = adapter.GetDataByUName(txtUserName.Text);
            if (data.Count <= 0)
            {
                lblUserErrorMsg.Text = "用户不存在";
                lblUserErrorMsg.Visible = true;
                txtUserName.Text = "";
                txtPwd.Text = "";
            }
            else
            {
                var user = data.Single();    //取得一条记录

                //增加错误登录次数验证
                //若最后登录时间和错误次数不为空
                if (!user.IsU_ErrorTimesNull() && !user.IsU_LastErrorTimeNull())
                {
                    //user.U_LastErrorTime？？？？？？？？？？？？
                    double span = (DateTime.Now - user.U_LastErrorTime).TotalMinutes; //与最后一次登录时间间隔分钟数  
                    if (user.U_ErrorTimes > 5 && span < 30)    //错误登录次数超过5次并且间隔小于30分钟则禁止登录
                    {
                        lblUserErrorMsg.Visible = true;
                        lblUserErrorMsg.Text = "请在30分钟后再尝试";
                        return;    //返回
                    }
                }
                if (txtPwd.Text == user.U_Pwd)
                {
                    Session["用户名"] = user.U_Name;
                    Session["权限"] = user.U_Level.ToString();
                    Session["登录时间"] = DateTime.Now.ToString();
                     if (user.U_Level == 3)   //管理员
                    {
                         Session["权限名"]="管理员";
                    }
                    else if (user.U_Level == 2)     //VIP会员
                    {
                       Session["权限名"] = "VIP会员";
                    }
                    else                             //普通会员
                    {
                      Session["权限名"]= "普通用户";
                    }
                    
                    adapter.ResetErrorTimesById((int)user.UID);  //成功登录,错误次数和时间清空
                    if (user.U_Level==3)      //管理员用户，进入后台
                    {
                        Response.Redirect("userManager.aspx");
                    }
                    else                       //普通用户或VIP用户Default.aspx
                    {
                        Response.Redirect("../Default.aspx");
                    }
                   
                }
                else
                {
                    adapter.IncErrorTimes((int)user.UID);   //错误则错误登录次数+1
                    lblUserErrorMsg.Visible = true;
                    lblUserErrorMsg.Text = "密码错误";
                    txtPwd.Text = "";
                }
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            txtUserName.Text = "";
            txtPwd.Text = "";
        }
    }
}