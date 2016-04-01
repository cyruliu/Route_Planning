/*
 *作    者:     龙军
 *创作时间：    2013/3/12 20:43
 *修改时间：
 *备    注：
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MOdel;
using BLL;

namespace Web
{
    public partial class Record : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_OK_Click(object sender, EventArgs e)
        {
            M_User user = new M_User();
            user.U_name = txt_user.Text.ToString();
            user.U_Secret = txt_secret.Text.ToString();
            if (B_User.B_URecord(user))
            {
                txt_user.Text = "Alan!!";
            }
        }
    }
}