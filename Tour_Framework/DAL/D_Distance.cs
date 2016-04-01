/*
 *作    者:     龙军
 *创作时间：    2013/3/12 15:43
 *修改时间：
 *备    注：
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MOdel;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
     public class D_Distance
    {
        #region 查询所有数据
        /// <summary>
        /// 查询所有数据
        /// </summary>
        public static List<M_Distance> D_DAll(string scence1, string scence2)
        {
            string sql = "select  * from T_Distance where D_Scence1 = '" + scence1+"' and D_Scence2 = '" + scence2 + "'";
            List<M_Distance> list = new List<M_Distance>();
            M_Distance d = new M_Distance();
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
        public static int D_DCount()
        {
            int count = 0;
            string sql = "select count(*) from T_Distance";
            SqlParameter[] sp = { null };
            SQLHelper sh = new SQLHelper();
            count = sh.returnCount(sql,sp);
            return count;

        }
        #endregion
        #region 增加，删除，修改
        /// <summary>
        /// 增加，返回值为true则表示添加成功
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="MD"></param>
        public static bool D_DAdd(M_Distance MD)
        {
            bool istrue = false;
            string sql = "select count(*) from T_Distance where D_Scence1=@D_Scence1 and D_Scence2=@D_Scence2";
            string sql1 = "insert into T_Distance (D_Scence1, D_Scence2, D_time) values (@D_Scence1, @D_Scence2, @D_time)";
            SqlParameter[] sp = new SqlParameter[] { new SqlParameter("@D_Scence1", MD.D_Scence1), new SqlParameter("@D_Scence2", MD.D_Scence2), new SqlParameter("@D_time", MD.D_time) };
            SQLHelper sh = new SQLHelper();
         
            if (sh.returnCount(sql,sp) < 1)
            {
                sh.databasic(sql1, sp);
                istrue = true;
            }
            return istrue;
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="MD"></param>
        public static void D_DDelete( M_Distance MD)
        {

            string sql = "delete  from T_Distance where D_ID=@D_ID";
            SqlParameter[] sp = new SqlParameter[] { new SqlParameter("@D_ID", MD.D_ID) };
            SQLHelper sh = new SQLHelper();
            sh.databasic(sql, sp);

        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="MD"></param>
        public static void D_DAlter(M_Distance MD)
        {
            string sql1 = "update  T_Distance set D_time=@D_time,D_Scence1=@D_Scence1 where D_ID=@D_ID";

            SqlParameter[] sp = new SqlParameter[] { new SqlParameter("@D_ID", MD.D_ID), new SqlParameter("@D_Scence1", MD.D_Scence1), new SqlParameter("@D_Scence2", MD.D_Scence2), new SqlParameter("@D_time", MD.D_time) };
            SQLHelper sh = new SQLHelper();
            sh.databasic(sql1, sp);
        }
        #endregion
        #region 构造实体
        /// <summary>
        /// 构造实体
        /// </summary>
        /// <param name="dr">表中的数据集</param>
        /// <returns>返回单条记录</returns>
        public static MOdel.M_Distance Obj(SqlDataReader dr)
        {
            M_Distance d = new M_Distance();

            d.D_ID = Convert.ToInt32(dr["D_ID"]);
            d.D_Scence1 = dr["D_Scence1"].ToString();
            d.D_Scence2 = dr["D_Scence2"].ToString();
            d.D_time = dr["D_time"].ToString();
            return d;
        }
        #endregion        
    }
}
