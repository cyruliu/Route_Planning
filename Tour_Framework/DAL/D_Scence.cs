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
    public class D_Scence
    {
        #region 查询所有数据
        /// <summary>
        /// 查询所有数据
        /// </summary>
        public static List<M_Scence> D_SAll(int cid)
        {
            string sql = "select  * from T_Scence where C_ID='"+cid+"'";
            List<M_Scence> list = new List<M_Scence>();
            M_Scence d = new M_Scence();
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
        public static int D_SCount()
        {
            int count = 0;
            string sql = "select count(*) from T_Scence";
            SqlParameter[] sp = { null };
            SQLHelper sh = new SQLHelper();
            count = sh.returnCount(sql, sp);
            return count;

        }
        #endregion
        #region 增加，删除，修改
        /// <summary>
        /// 增加，返回值为true则表示添加成功
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="MD"></param>
        public static bool D_SAdd(M_Scence MD)
        {
            bool istrue = false;
            string sql = "select count(*) from T_Scence where S_name=@S_name";
            string sql1 = "insert into T_Scence (S_name, S_like, U_ID, C_ID) values (@S_name, @S_like, @U_ID, @C_ID)";
            SqlParameter[] sp = new SqlParameter[] { new SqlParameter("@S_name", MD.S_name), new SqlParameter("@S_like", MD.S_like), new SqlParameter("@U_ID", MD.U_ID), new SqlParameter("@C_ID", MD.C_ID), new SqlParameter("@S_ID", MD.S_ID) };
            SQLHelper sh = new SQLHelper();
           
            if (sh.returnCount(sql, sp) < 1)
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
        public static void D_SDelete(M_Scence MD)
        {

            string sql = "delete  from T_Scence where S_ID=@S_ID";
            SqlParameter[] sp = new SqlParameter[] { new SqlParameter("@S_name", MD.S_name), new SqlParameter("@S_like", MD.S_like), new SqlParameter("@U_ID", MD.U_ID), new SqlParameter("@C_ID", MD.C_ID), new SqlParameter("@S_ID", MD.S_ID) };
            SQLHelper sh = new SQLHelper();
            sh.databasic(sql, sp);

        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="MD"></param>
        public static void D_SAlter(M_Scence MD)
        {
            string sql1 = "update  T_Scence set S_name=@S_name,S_like=@S_like where S_ID=@S_ID";

            SqlParameter[] sp = new SqlParameter[] { new SqlParameter("@S_name", MD.S_name), new SqlParameter("@S_like", MD.S_like), new SqlParameter("@U_ID", MD.U_ID), new SqlParameter("@C_ID", MD.C_ID), new SqlParameter("@S_ID", MD.S_ID) };
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
        public static MOdel.M_Scence Obj(SqlDataReader dr)
        {
            M_Scence d = new M_Scence();

            d.S_ID = Convert.ToInt32(dr["S_ID"]);
            d.C_ID = Convert.ToInt32(dr["C_ID"]);
            d.S_like = dr["S_like"].ToString();
            d.S_name = dr["S_name"].ToString();
            d.U_ID = Convert.ToInt32( dr["U_ID"].ToString());
            return d;
        }
        #endregion        
    }
}
