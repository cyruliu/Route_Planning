using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using Tour_Route.Model;

namespace Tour_Route.DAL
{
    public class D_province
    {
        //取得排名前n项的全部省信息
        public static IList<M_province> GetProTopN(int n)
        {
            IList<M_province> list = new List<M_province>();

            string strsql = "select top " + n + " * from tb_province order by P_HotDegree DESC";
            DataTable table = DBHelper.GetDataSet(strsql);
            foreach (DataRow row in table.Rows)
            {
                M_province province = new M_province();
                province.PID = (int)row["PID"];
                province.P_Name = (string)row["P_Name"];
                province.P_HotDegree= (int)row["P_HotDegree"];
                list.Add(province);
            }
            return list;

        }

        //取得tb_province表中的所有信息
        public static IList<M_province> GetAllPro()
        {
            IList<M_province> list = new List<M_province>();

            string strsql = "select * from tb_province order by P_Name ASC";
            DataTable table = DBHelper.GetDataSet(strsql);
            foreach (DataRow row in table.Rows)
            {
                M_province province = new M_province();
                province.PID = (int)row["PID"];
                province.P_Name = (string)row["P_Name"];
                province.P_HotDegree = (int)row["P_HotDegree"];
                list.Add(province);
            }
            return list;
        }

    }
}