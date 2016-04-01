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
    public  class D_Province
    {
        #region 查询所有数据
        /// <summary>
        /// 查询所有数据
        /// </summary>
        public static List<M_Province> D_pro()
        {
            string sql = "select  * from T_Province ";
            List<M_Province> list=new List<M_Province>();
            M_Province d = new M_Province();
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
            return list ;
        }
        #endregion
        #region 查询总条数
       /// <summary>
        /// 查询总条数
       /// </summary>
       /// <param name="id"></param>
       /// <returns></returns>
        public static int D_PCount()
        {
            int count = 0;
            string sql = "select count(*) from T_Province";
            SqlParameter[] sp = { null };
            SQLHelper sh=new SQLHelper();
            count= sh.returnCount(sql,sp);
           return count;

        }
        #endregion
        #region 构造实体
        /// <summary>
        /// 构造实体
        /// </summary>
        /// <param name="dr">表中的数据集</param>
        /// <returns>返回单条记录</returns>
        public static MOdel.M_Province Obj(SqlDataReader dr)
        {
            M_Province d = new M_Province();

            d.P_ID = Convert.ToInt32(dr["P_ID"]);
            d.P_name = dr["P_name"].ToString();
            return d;
        }
        #endregion
        
        
    }
    
}
