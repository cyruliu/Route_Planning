using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using MOdel;
namespace Web
{
    public partial class test : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                bind();
                bind1();
            }
        }
        void bind()
        {
            IList<M_Province> list= B_Province.B_pro();
            DropDownList1.DataSource = list;
            DropDownList1.DataTextField = "P_name";
            DropDownList1.DataValueField = "P_ID";
           
            DropDownList1.DataBind();
            
        }
        void bind1()
        {
            int pid = Convert.ToInt32(DropDownList1.SelectedItem.Value.ToString());
            IList<M_City> list1 = B_City.BCity(pid);
            DropDownList2.DataSource = list1;
            DropDownList2.DataTextField = "C_name";
            DropDownList2.DataValueField = "C_ID";
            DropDownList2.DataBind();
            
        }
        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            bind1();      
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
            M_Scence ms = new M_Scence();
            ms.C_ID = Convert.ToInt32( DropDownList2.SelectedValue.ToString());
            for (int i = 0; i < lst_scence.Items.Count; i++)
            {
                ms.S_name = lst_scence.Items[i].ToString().Split(',')[0];
                ms.S_like = lst_scence.Items[i].ToString().Split(',')[1];
                B_Scence.B_SAdd(ms);
               
            }
        }           
    }
}