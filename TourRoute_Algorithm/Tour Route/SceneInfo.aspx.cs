using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Tour_Route.Model;
using Tour_Route.BLL;
using System.Data;

namespace Tour_Route
{
    public partial class SceneInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dt = B_scene.GetSceneTopN(5);
            IamgeTop1.ImageUrl = B_common.IsContainPic(dt.Rows[0][4].ToString());
            IamgeTop2.ImageUrl = B_common.IsContainPic(dt.Rows[1][4].ToString());
            IamgeTop3.ImageUrl = B_common.IsContainPic(dt.Rows[2][4].ToString());
            IamgeTop4.ImageUrl = B_common.IsContainPic(dt.Rows[3][4].ToString());
            IamgeTop5.ImageUrl = B_common.IsContainPic(dt.Rows[4][4].ToString());

            lblTopName1.Text = dt.Rows[0][1].ToString();
            lblTopName2.Text = dt.Rows[1][1].ToString();
            lblTopName3.Text = dt.Rows[2][1].ToString();
            lblTopName4.Text = dt.Rows[3][1].ToString();
            lblTopName5.Text = dt.Rows[4][1].ToString();

            lblDescription1.Text = dt.Rows[0][2].ToString();
            lblDescription2.Text = dt.Rows[1][2].ToString();
            lblDescription3.Text = dt.Rows[2][2].ToString();
            lblDescription4.Text = dt.Rows[3][2].ToString();
            lblDescription5.Text = dt.Rows[4][2].ToString();

            //input 写成服务器控件 runat="server"，通过Request.Form[""]获取input内的文本
            string searchtext = Request.Form["searchtext"];

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            //Button1.Attributes.Add("onclick", searchlocal1());
        }
    }
}