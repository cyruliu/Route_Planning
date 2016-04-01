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
    public partial class UserInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                bindProvinceList(10);   //左上
                // bindSceneList(5);
                //DropDownListProvince
                bindDropDownListProvince();
                bindSelectProScene(15);    //左下
                bindSceneListByCityName(10);
                //加载图片
                SetPic(DropDownListProvince.SelectedItem.Text,6);
            }        
        }

        //旅游城市选择
        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            bindSceneListByCityName(10);
        }

        //tb_scene表中点击率top n 项景点
        private void bindSceneList(int n)
        {
            IList<M_scene> scenelist = B_scene.GetScenelistTopN(n);
            RepeaterScene.DataSource = scenelist;
            RepeaterScene.DataBind();
        }
        //tb_province表中点击率top n项省份
        private void bindProvinceList(int n)
        {
            IList<M_province> prolist = B_province.GetProTopN(n);
            RepeaterProvince.DataSource = prolist;
            RepeaterProvince.DataBind();
        }
        //指定textbox市的景点信息绑定
        private void bindSceneListByCityName(int n)
        {
            IList<M_scene> scenelistByName = B_scene.GetScenelistTopNByCityName(TextBox1.Text,n);
            RepeaterSceneByCity.DataSource = scenelistByName;
            RepeaterSceneByCity.DataBind();
        }

        //省DropDownListProvince数据绑定
        private void bindDropDownListProvince()
        {
            IList<M_province> drpd = B_province.GetAllPro();
            DropDownListProvince.DataSource = drpd;
            DropDownListProvince.DataTextField = "P_Name";
            DropDownListProvince.DataValueField = "PID";
            DropDownListProvince.DataBind();
        }
        //指定省的点击率top n项景点
        private void bindSelectProScene(int n)
        {
            string proName = DropDownListProvince.SelectedItem.Text;
            IList<M_scene> proScene = B_scene.GetScenelistTopNByProvince(proName,n);
            RepeaterScene.DataSource = proScene;
            RepeaterScene.DataBind();
 
        }

        //!IspostBack非首次加载  DropDownList AutoPostBack属性设置为true, SelectedIndexChanged事件
        protected void DropDownListProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            bindSelectProScene(10);
            SetPic(DropDownListProvince.SelectedItem.Text,6);
        }

        //设置图片路径
        private void SetPic(string proname, int n)
        {
            DataTable dt=B_scene.GetSceneTopNPicByPro(proname,n);
            if (dt!=null)
            {
                //ImageProTop1.ImageUrl = B_common.IsContainPic(dt.Rows[0][0].ToString());
                //ImageProTop2.ImageUrl = B_common.IsContainPic(dt.Rows[1][0].ToString());
                //ImageProTop3.ImageUrl = B_common.IsContainPic(dt.Rows[2][0].ToString());
                //ImageProTop4.ImageUrl = B_common.IsContainPic(dt.Rows[3][0].ToString());
                //ImageProTop5.ImageUrl = B_common.IsContainPic(dt.Rows[4][0].ToString());
                //ImageProTop6.ImageUrl = B_common.IsContainPic(dt.Rows[5][0].ToString());
            }
            
        }

      
    }
}