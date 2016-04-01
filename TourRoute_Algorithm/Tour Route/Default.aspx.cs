using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Tour_Route.BLL;
using Tour_Route.Model;

namespace Tour_Route
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                loadPic();
            }          
        }

        //加载图片
        private void loadPic()
        {
            //用循环获取控件Id并为其属性赋值
            //for (int i = 0; i <5; i++)
            //{
            //    string cityPic="ImageCity"+(i+1).ToString();
            //  (Image)Page.FindControl(cityPic).ImageUrl=data.Rows[i][4].ToString();
            //}
            //左侧图片区
            DataTable dt = B_city.GetCityTop(5);
            ImageCity1.ImageUrl = B_common.IsContainPic(dt.Rows[0][4].ToString());
            ImageCity2.ImageUrl = B_common.IsContainPic(dt.Rows[1][4].ToString());
            ImageCity3.ImageUrl = B_common.IsContainPic(dt.Rows[2][4].ToString());
            ImageCity4.ImageUrl = B_common.IsContainPic(dt.Rows[3][4].ToString());
            ImageCity5.ImageUrl = B_common.IsContainPic(dt.Rows[4][4].ToString());

            LabelCity1.Text = dt.Rows[0][1].ToString();
            LabelCity2.Text = dt.Rows[1][1].ToString();
            LabelCity3.Text = dt.Rows[2][1].ToString();
            LabelCity4.Text = dt.Rows[3][1].ToString();
            LabelCity5.Text = dt.Rows[4][1].ToString();

            LabelJianjie1.Text = dt.Rows[0][2].ToString();
            LabelJianjie2.Text = dt.Rows[1][2].ToString();
            LabelJianjie3.Text = dt.Rows[2][2].ToString();
            LabelJianjie4.Text = dt.Rows[3][2].ToString();
            LabelJianjie5.Text = dt.Rows[4][2].ToString();

            //上部浮动图片区
            DataTable dtfloat = B_city.GetCityTop(6);   //取得排名前6的城市图片，还可以改为其他的 ？？？
            Imagefloat1.ImageUrl = B_common.IsContainPic(dtfloat.Rows[0][4].ToString());
            Imagefloat2.ImageUrl = B_common.IsContainPic(dtfloat.Rows[1][4].ToString());
            Imagefloat3.ImageUrl = B_common.IsContainPic(dtfloat.Rows[2][4].ToString());
            Imagefloat4.ImageUrl = B_common.IsContainPic(dtfloat.Rows[3][4].ToString());
            Imagefloat5.ImageUrl = B_common.IsContainPic(dtfloat.Rows[4][4].ToString());
            Imagefloat6.ImageUrl = B_common.IsContainPic(dtfloat.Rows[5][4].ToString());

            //主图片区
            DataTable dtmain = B_scene.GetSceneTopN(15);
            //获取文件名，belongcity,scenename传入addCityScene图片处理程序中
            ImageMain1.ImageUrl = B_common.IsContainPic(dtmain.Rows[0][4].ToString());
            ImageMain2.ImageUrl = B_common.IsContainPic(dtmain.Rows[1][4].ToString());
            ImageMain3.ImageUrl = B_common.IsContainPic(dtmain.Rows[2][4].ToString());
            ImageMain4.ImageUrl = B_common.IsContainPic(dtmain.Rows[3][4].ToString());
            ImageMain5.ImageUrl = B_common.IsContainPic(dtmain.Rows[4][4].ToString());
            ImageMain6.ImageUrl = B_common.IsContainPic(dtmain.Rows[5][4].ToString());
            ImageMain7.ImageUrl = B_common.IsContainPic(dtmain.Rows[6][4].ToString());
            ImageMain8.ImageUrl = B_common.IsContainPic(dtmain.Rows[7][4].ToString());
            ImageMain9.ImageUrl = B_common.IsContainPic(dtmain.Rows[8][4].ToString());
            ImageMain10.ImageUrl = B_common.IsContainPic(dtmain.Rows[9][4].ToString());
            ImageMain11.ImageUrl = B_common.IsContainPic(dtmain.Rows[10][4].ToString());
            ImageMain12.ImageUrl = B_common.IsContainPic(dtmain.Rows[11][4].ToString());
            ImageMain13.ImageUrl = B_common.IsContainPic(dtmain.Rows[12][4].ToString());
            ImageMain14.ImageUrl = B_common.IsContainPic(dtmain.Rows[13][4].ToString());
            ImageMain15.ImageUrl = B_common.IsContainPic(dtmain.Rows[14][4].ToString());
 
        }
    }
}