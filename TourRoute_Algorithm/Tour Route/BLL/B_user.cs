using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tour_Route.Model;
using Tour_Route.DAL;

namespace Tour_Route.BLL
{
    public class B_user
    {
        //由用户名得到用户权限信息
        public static M_user GetUserByName(string username)
        {
            try
            {
                return D_User.GetUserByName(username);
            }
            catch (Exception exp)
            {

                throw new Exception(exp.Message.ToString());
            }

        }
    }
}