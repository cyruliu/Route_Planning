/*
 *作    者:     龙军
 *创作时间：    2013/3/5 20:43
 *修改时间：
 *备    注：
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using MOdel;

namespace DAL
{
    public class D_City
    {
        #region 查询所有数据
        /// <summary>
        /// 查询所有数据
        /// </summary>
        public static List<M_City> DCity(int pid)
        {
            string sql = "select * from T_City where P_ID="+pid;
            List<M_City> list = new List<M_City>();
            M_City d = new M_City();
            SQLHelper sqlhelpers = new SQLHelper();
            SqlConnection conn = new SqlConnection();
            SqlDataReader dr = sqlhelpers.returnReader(sql, conn);
            while (dr.Read())
            {
                d = Obj(dr);
                list.Add(d);
            }

            dr.Close();
            dr.Dispose();
            conn.Close();
            return list;
        }
        #endregion
        #region 查询总条数
        /// <summary>
        /// 查询总条数
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static int D_CCount(int pid)
        {
            int count = 0;
            string sql = "select count(*) from T_City where P_ID = " + pid;
            SqlParameter[] sp={null};
            SQLHelper sh = new SQLHelper();
            count = sh.returnCount(sql,sp);
            return count;

        }
        #endregion
        #region 构造实体
        /// <summary>
        /// 构造实体
        /// </summary>
        /// <param name="dr">表中的数据集</param>
        /// <returns>返回单条记录</returns>
        public static MOdel.M_City Obj(SqlDataReader dr)
        {
            M_City d = new M_City();

            d.P_ID = Convert.ToInt32(dr["P_ID"]);
            d.C_ID = Convert.ToInt32( dr["C_ID"].ToString());
            d.C_name = dr["C_name"].ToString();
            return d;
        }
        #endregion
    }
}
