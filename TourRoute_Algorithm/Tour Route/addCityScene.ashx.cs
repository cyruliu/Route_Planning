using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Drawing;

namespace Tour_Route
{
    /// <summary>
    /// addCityScene 的摘要说明
    /// 为图片增加文字
    /// </summary>
    public class addCityScene : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "image/jpeg";

            string filename = context.Request["Filename"];   //要获取的图片信息
            string scenename = context.Request["SceneName"];
            string scenebelongcity = context.Request["SceneBelongCity"];
            string fullpath = HttpContext.Current.Server.MapPath(filename);  //全路径
            using (Bitmap map = new Bitmap(fullpath))
            {
                using (Graphics g = Graphics.FromImage(map))
                {
                    //UrlReferrer客户端上次请求的url信息，该信息链接到当前url
                    // //直接访问该网页，urlReferrer为null
                    if (context.Request.UrlReferrer == null)
                    {
                        g.Clear(System.Drawing.Color.Red);
                        System.Drawing.SolidBrush mybrush = new System.Drawing.SolidBrush(System.Drawing.Color.Red);
                        g.DrawString("禁止直接访问该网页", new System.Drawing.Font("宋体", 30), mybrush, new System.Drawing.PointF(0, 0));
                    }

                   // //若非从指定localhost网站访问时
                    // //防盗链
                    //else if (context.Request.UrlReferrer.Host != "localhost")
                    //{
                    //    g.Clear(System.Drawing.Color.Blue);
                    //    System.Drawing.SolidBrush mybrush = new System.Drawing.SolidBrush(System.Drawing.Color.Red);
                    //    g.DrawString("图片仅供内部人员使用", new System.Drawing.Font("宋体", 30), mybrush, new System.Drawing.PointF(0, 0));
                    //}

                    SolidBrush my = new SolidBrush(Color.Black);
                    g.DrawString(scenebelongcity + ":" + scenename, new Font("宋体", 20), my, 0, 0);
                }
                map.Save(context.Response.OutputStream, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
         
                
            



        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}