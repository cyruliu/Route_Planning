using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tour_Route.Model;
using System.Data;
using System.Data.SqlClient;


namespace Tour_Route.DAL
{
    public class D_city
    {
      
        public static IList<M_city> GetCityTopN(int n)
        {
            IList<M_city> list = new List<M_city>();

            string strsql = "select top " + n + " * from tb_city order by C_HotDegree DESC";
            DataTable table = DBHelper.GetDataSet(strsql);
            foreach (DataRow row in table.Rows)
            {
                M_city scene = new M_city();
                scene.CID = (int)row["CID"];
                scene.C_Name = (string)row["C_Name"];
                scene.C_Description = (string)row["C_Description"];
                scene.C_Image = (string)row["C_Image"];
                scene.C_BelongProvince = (string)row["C_BelongProvince"];
                scene.C_HotDegree = (int)row["C_HotDegree"];
                list.Add(scene);
            }
            return list;
        }
       
        //获取排行前n的城市信息
        public static DataTable GetCityTop(int n)
        {
            string strsql = "select top "+n+" CID,C_Name,C_BelongProvince,C_Description,C_Image,C_HotDegree from tb_city order by C_HotDegree DESC";
            DataTable table = DBHelper.GetDataSet(strsql);
            return table;
        }

        //是否存在该城市
        public static bool IsContainCity(string cityname)
        {
            string sql = "select * from tb_city where C_Name=@C_Name";
            SqlDataReader reader = DBHelper.GetReader(sql,new SqlParameter("@C_Name",cityname));
            if (reader.HasRows)     //存在该城市
            {
                return true;
            }
            else
            {
                return false;
            }
        }



    }
}