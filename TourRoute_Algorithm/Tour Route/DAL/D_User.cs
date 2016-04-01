using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using Tour_Route.Model;

namespace Tour_Route.DAL
{
    public class D_User
    {
        //由用户名取得用户权限信息
        public static M_user GetUserByName(string username)
        {
            M_user user = new M_user();
            string sql = "select UID,U_Name,U_Pwd,U_Level from tb_user where U_Name=@U_Name";
            SqlDataReader reader = DBHelper.GetReader(sql,new SqlParameter("@U_Name",username));
            if (reader.HasRows)
            {
                reader.Read();
                user.UID=(int)reader["UID"];
                user.U_Name=(string)reader["U_Name"];
                user.U_Pwd=(string)reader["U_Pwd"];
                user.U_Level=(int)reader["U_Level"];
                return user;
            }
            else
            {
                return null;
            }

        }
    }
}