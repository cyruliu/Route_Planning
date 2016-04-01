using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tour_Route.DAL;
using Tour_Route.Model;
using System.Data;

namespace Tour_Route.BLL
{
    public class B_common
    {
       //判断指定路径是否存在图片，不存在则返回404.jpg
        public static string IsContainPic(string path)
        {
            try
            {
                if (path!="" && path!=null)
                {
                    return path;
                }
                else
                {
                    string str404="~/images/404.jpg";
                    return str404;
                }
            }
            catch (Exception exp)
            {

                throw new Exception(exp.Message.ToString());
            }
        }
    }
}