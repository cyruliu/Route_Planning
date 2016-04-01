/*
 *作    者:     龙军
 *创作时间：    2013/3/13 10:22
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
    public partial class ScenceAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_OK_Click(object sender, EventArgs e)
        {
            string sname = txt_scence.Text.ToString();
            string like = txt_like.Text.ToString();
            string scence = sname + "," + like;
            if (sname == null || like == null)
            {
                Response.Write("请输入景点和喜欢程度！！");
            }
            else
            {
                lst_scence.Items.Add(scence);
            }
        }

        protected void btn_delete_Click(object sender, EventArgs e)
        {
            lst_scence.Items.Remove(lst_scence.SelectedItem);
        }

        protected void btn_Add_Click(object sender, EventArgs e)
        {
            IList<M_Scence> ls =new List<M_Scence>();
            M_Scence ms = new M_Scence();
            ms.


        }
    }
}