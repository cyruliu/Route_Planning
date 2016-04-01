using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tour_Route.Model;
using System.Data;
using System.Data.SqlClient;

namespace Tour_Route.DAL
{
    public class D_scene
    {
        //IList<M_scene>
        public static IList<M_scene> GetScenelist(int n)
        {
            IList<M_scene> list = new List<M_scene>();
            string strsql = "select top " + n + " SID,S_Name,S_BelongCity,S_Description,S_Image,S_Position,S_HotDegree from tb_scene order by S_HotDegree DESC";
            DataTable table = DBHelper.GetDataSet(strsql);
            foreach (DataRow row in table.Rows)
            {
                //scene.S_Description = (string)row["S_Description"];
                //无法将类型为“System.DBNull”的对象强制转换为类型“System.String”
                //ISNULL(SID,0),ISNULL(S_Name,0),ISNULL(S_Description,0),ISNULL(S_Image,0),ISNULL(SID,0),ISNULL(S_BelongCity,0),ISNULL(S_BelongCity,0),ISNULL(S_HotDegree,0)
                //转换处理
                M_scene scene = new M_scene();
                scene.SID = (int)row["SID"];
                scene.S_Name =(string)row["S_Name"];
                scene.S_Description = (string)row["S_Description"];     
                scene.S_Image = (string)row["S_Image"];
                scene.S_BelongCity = (string)row["S_BelongCity"];
                scene.S_Position = (string)row["S_Position"];
                scene.S_HotDegree = (int)row["S_HotDegree"];
                list.Add(scene);
            }
            return list;
        }
       
        //Datable
        public static DataTable GetSceneTopN(int n)
        {
            string strsql = "select top " + n + " SID,S_Name,S_BelongCity,S_Description,S_Image,S_Position,S_HotDegree from tb_scene order by S_HotDegree DESC";
            DataTable table = DBHelper.GetDataSet(strsql);
            return table;
        }

        //由景点名得到景点信息
        public static M_scene GetSceneByName(string scenename)
        {
            M_scene scene = new M_scene();
            string sql = "select * from tb_scene where S_Name=@S_Name";
            SqlDataReader reader = DAL.DBHelper.GetReader(sql,new SqlParameter("@S_Name",scenename));
            if (reader.Read())
            {
                scene.SID=(int)reader["UID"];
                scene.S_Name=(string)reader["S_Name"];
                scene.S_BelongCity=(string)reader["S_BelongCity"];
                scene.S_Description=(string)reader["S_Description"];
                scene.S_Position=(string)reader["S_Position"];
                scene.S_HotDegree=(int)reader["S_HotDegree"];
            }
            return scene;
        }


        //由城市名得到点击量前n项城市所有景点的信息
        public static DataTable GetSceneByCity(string cityname,int n)
        {
            string strsql = "select top "+n+" SID,S_Name,S_BelongCity,S_Description,S_Image,S_Position,S_HotDegree from tb_scene where S_BelongCity=@S_BelongCity order by S_HotDegree DESC";
            DataTable table = DBHelper.GetDataSet(strsql,new SqlParameter("@S_Belongcity",cityname));
            return table;
        }

        //判断是否存在指定城市，若存在，得到该景点top n项景点信息；若不存在，则返回所有景点top n信息
        public static IList<M_scene> GetScenelistTopNByCityName(string name,int n)
        {
            bool b = D_city.IsContainCity(name);
            IList<M_scene> list = new List<M_scene>();
            string strsql;
            DataTable table;
            if (b==true)
            {
                strsql = "select top " + n + " * from tb_scene where S_BelongCity=@S_BelongCity order by S_HotDegree DESC";
                table = DBHelper.GetDataSet(strsql,new SqlParameter("@S_BelongCity",name));
            }
            else
            {
                strsql = "select top " + n + " * from tb_scene order by S_HotDegree DESC";
                table = DBHelper.GetDataSet(strsql);
            }
            foreach (DataRow row in table.Rows)
            {
                M_scene scene = new M_scene();
                scene.SID = (int)row["SID"];
                scene.S_Name = (string)row["S_Name"];
                scene.S_Description = (string)row["S_Description"];
                scene.S_Image = (string)row["S_Image"];
                scene.S_BelongCity = (string)row["S_BelongCity"];
                scene.S_Position = (string)row["S_Position"];
                scene.S_HotDegree = (int)row["S_HotDegree"];
                list.Add(scene);
            }
            return list;
        }

        //指定省的点击率top n景点信息
        public static IList<M_scene> GetScenelistTopNByProvince(string pro,int n)
        {
            IList<M_scene> list = new List<M_scene>();
          string strsql = "select top "+n+" SID,S_Name,S_BelongCity,S_Description,S_Image,S_Position,S_HotDegree,S_BelongProvince from tb_scene where S_BelongProvince=@S_BelongProvince order by S_HotDegree DESC";
          DataTable table = DBHelper.GetDataSet(strsql, new SqlParameter("@S_BelongProvince",pro));
            foreach (DataRow row in table.Rows)
            {
                M_scene scene = new M_scene();
                scene.SID = (int)row["SID"];
                scene.S_Name = (string)row["S_Name"];
                scene.S_Description = (string)row["S_Description"];
                scene.S_Image = (string)row["S_Image"];
                scene.S_BelongCity = (string)row["S_BelongCity"];
                scene.S_Position = (string)row["S_Position"];
                scene.S_HotDegree = (int)row["S_HotDegree"];
                //scene.S_BelongProvince=(string)row["S_BelongProvince"];
                list.Add(scene);
            }
            return list;
        }

        //获取指定省点击率top N的图片路径
        public static DataTable GetSceneTopNPicByPro(string proname,int n)
        {
            string strsql = "select top " + n + "S_Image from tb_scene where S_BelongProvince=@S_BelongProvince order by S_HotDegree DESC";
            DataTable table = DBHelper.GetDataSet(strsql,new SqlParameter("@S_BelongProvince",proname));
            return table;
        }
    }
}